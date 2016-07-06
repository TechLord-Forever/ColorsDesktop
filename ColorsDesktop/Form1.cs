using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace ColorsDesktop
{
    public partial class MainWindow : Form
    {
        // Instance of LogHandler
        private LogHandler logHandler;

        // Searching succeded ?
        private bool searchSucceeded;

        // Fetching succeeded ?
        private bool fetchWebUrlSucceeded;
        private bool fetchDirectLinksSucceeded;

        private bool fetchSeriesEpisodeSucceeded;

        // List of episodes from search results
        private Episode[] episodeList;

        // List of episodes from search results
        private TvSeries[] tvSeriesList;

        // Currently selected episode in search result
        private Episode currentEpisode;

        // Currently selected TV series in search result
        private TvSeries currentSeries;

        // List of direct links to current episode
        private string[] currentEpisodeLinks;

        // List of episodes from search series results
        private Episode[] episodeSeries;

        internal const int PAGE_SIZE = 10;

        
        //==================================================================
        public MainWindow()
        {
            InitializeComponent();
            logHandler = new LogHandler(this);
            Settings settings = AppSettings.RestoreSettings();
            AppSettings.ApplySettings(settings);

            switch (settings.proxyType)
            {
                case PROXY_TYPE.NONE:
                    radioButtonOptions_ProxyNone.Checked = true;
                    break;

                case PROXY_TYPE.SYSTEM:
                    radioButtonOptions_ProxySystem.Checked = true;
                    break;

                case PROXY_TYPE.CUSTOM:
                    radioButtonOptions_ProxyCustom.Checked = true;
                    textBoxOptions_ProxyAddr.Text = settings.proxyAddr;
                    numericUpDownOptions_ProxyPort.Value = settings.proxyPort;
                    break;
            }
        }


        //==================================================================
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTxt = textBoxSearch.Text.Trim(new char[] { ' ' });

            // Check if search string is empty
            if (searchTxt.Length == 0)
            {
                textBoxSearch.Text = String.Empty;
                return;
            }

            logHandler.AddNewLine("[*] Searching for " + searchTxt);
            toolStripStatusLabel.Text = "Searching...";
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.hourglass;
            buttonSearch.Enabled = false;
            textBoxSearch.Enabled = false;
            currentEpisode = null;
            currentSeries = null;
            backgroundWorkerSearch.RunWorkerAsync(searchTxt);
        }


        //==================================================================
        private void backgroundWorkerSearch_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            searchSucceeded = false;
            string reqUrl = string.Format("http://api.voot.com/ws/adultSearch.json?searchText={0}&pId=1&platform=Cellular", (string)e.Argument);

            logHandler.AddNewLine("[*] GET " + reqUrl);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(reqUrl);
            request.UserAgent = "Dalvik / 1.6.0(Linux; U; Android 4.2.2; sdk Build/ JB_MR1.1)";
            request.Host = "api.voot.com";
            request.KeepAlive = false;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    logHandler.AddNewLine("[!] Search failed: " + response.StatusDescription);
                    response.Close();
                    return;
                }

                if (response.ContentType != "application/json")
                {
                    logHandler.AddNewLine("[!] Invalid response type " + response.ContentType);
                    response.Close();
                    return;
                }

                long contentLength = response.ContentLength;
                if (contentLength <= 0)
                {
                    logHandler.AddNewLine("[!] Invalid Content-Length " + contentLength);
                    response.Close();
                    return;
                }

                // Get the stream associated with the response.
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Read the content.
                string jsonStr = reader.ReadToEnd();
                responseStream.Close();
                response.Close();

                dynamic jsonResponse = JsonConvert.DeserializeObject(jsonStr);

                episodeList = ResponseParser.GetEpisodes(jsonResponse);
                tvSeriesList = ResponseParser.GetTvSeries(jsonResponse);
                searchSucceeded = true;
            }
            catch (Exception ex)
            {
                logHandler.AddNewLine("[!] Search failed: " + ex.Message);
            }
        }


        //==================================================================
        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            listViewSearchResults.Items.Clear();

            // Search was cancelled
            if (backgroundWorkerSearch.CancellationPending)
            {
                toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.exclamation;
                toolStripStatusLabel.Text = "Search cancelled...";
            }
            // Search Failed
            else if (!searchSucceeded)
            {
                toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.cancel;
                toolStripStatusLabel.Text = "Search failed...";
            }
            else
            {
                if (episodeList != null)
                {
                    foreach (var episode in episodeList)
                    {
                        MyListViewItem lvi = new MyListViewItem(episode.id);
                        lvi.detailObject = episode;
                        lvi.SubItems.AddRange(new string[] { episode.type, episode.name });
                        listViewSearchResults.Items.Add(lvi);
                    }
                }

                if (tvSeriesList != null)
                {
                    foreach (var series in tvSeriesList)
                    {
                        MyListViewItem lvi = new MyListViewItem(series.id);
                        lvi.detailObject = series;
                        lvi.SubItems.AddRange(new string[] { series.type, series.name });
                        listViewSearchResults.Items.Add(lvi);
                    }
                }

                toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.accept;
                toolStripStatusLabel.Text = "Ready...";
            }
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;
            buttonSearch.Enabled = true;
            textBoxSearch.Enabled = true;
        }


        //==================================================================
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
            textBoxSearch.SelectAll();
        }


        //==================================================================
        private void listViewSearchResults_DoubleClick(object sender, EventArgs e)
        {
            if (listViewSearchResults.SelectedItems.Count == 1)
            {
                MyListViewItem item = (MyListViewItem)listViewSearchResults.SelectedItems[0];

                if (item.detailObject is Episode)
                {
                    Episode epi = (Episode)item.detailObject;
                    currentEpisode = epi;

                    textBoxEpisode_ID.Text = epi.id;
                    textBoxEpisode_Name.Text = epi.name;
                    textBoxEpisode_Number.Text = epi.episodeNum;
                    textBoxEpisode_MainTitle.Text = epi.mainTitle;
                    textBoxEpisode_Synopsis.Text = epi.synopsis;
                    textBoxEpisode_URL.Text = string.Empty;
                    textBoxEpisode_EntryId.Text = epi.entryId;
                    textBoxEpisode_Predm3u8.Text = string.Format("http://cdnapi.kaltura.com/p/1982551/sp/198255100/playManifest/entryId/{0}/format/applehttp/tags/iphonenew/protocol/http/f/a.m3u8", epi.entryId);
                    listViewEpisode_Links.Items.Clear();

                    tabControlMainTab.SelectTab(tabPageEpisode);
                }
                else if (item.detailObject is TvSeries)
                {
                    TvSeries tvs = (TvSeries)item.detailObject;
                    currentSeries = tvs;

                    textBoxSeries_ID.Text = tvs.id;
                    textBoxSeries_Name.Text = tvs.name;
                    textBoxSeries_Title.Text = tvs.seriesMainTitle;
                    textBoxSeries_TotalEpisodes.Text = Convert.ToString(tvs.totalEpisode);
                    textBoxSeries_Synopsis.Text = tvs.synopsis;
                    listViewSeries_FetchResults.Items.Clear();
                    tabControlMainTab.SelectTab(tabPageSeries);
                }
            }
        }

        //==================================================================
        private void listViewSearchResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) listViewSearchResults_DoubleClick(null, null);
        }


        //==================================================================
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) buttonSearch.PerformClick();
        }


        //==================================================================
        //
        // Fetches the direct video links and web url for the current episode
        //
        //==================================================================
        private void buttonFetch_Click(object sender, EventArgs e)
        {
            if (currentEpisode != null)
            {
                buttonFetch.Enabled = false;
                toolStripStatusLabel.Text = "Fetching...";
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
                toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.hourglass;
                backgroundWorkerFetch.RunWorkerAsync(currentEpisode.id);
            }
        }


        //==================================================================
        //
        // Background worker for fetching video links
        //
        //==================================================================
        private void backgroundWorkerFetch_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            fetchWebUrlSucceeded = false;
            fetchDirectLinksSucceeded = false;

            // First get web url for current episode, executes in same thread
            logHandler.AddNewLine("[*] Fetching web url for current episode");
            backgroundWorkerSearch_DoWork(null, new System.ComponentModel.DoWorkEventArgs(currentEpisode.seriesTitle));

            if (tvSeriesList != null || tvSeriesList.Length > 0)
            {
                foreach (var series in tvSeriesList)
                {
                    if (series.seriesMainTitle == currentEpisode.seriesTitle)
                    {
                        currentEpisode.refSeriesId = series.id;
                        fetchWebUrlSucceeded = true;
                        break;
                    }
                }
            }
            if (!fetchWebUrlSucceeded) logHandler.AddNewLine("[!] Failed fetching web url for current episode");

            // Fetch direct links for current episode
            string payload = PostDataBuilder.ByEpisodeID((string)e.Argument);
            string reqUrl = "http://tvpapi-as.ott.kaltura.com/v3_4/gateways/jsonpostgw.aspx?m=GetMediaInfo";
            logHandler.AddNewLine("[*] POST " + reqUrl);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(reqUrl);
                request.Method = "POST";
                request.UserAgent = "Dalvik / 1.6.0(Linux; U; Android 4.2.2; sdk Build/ JB_MR1.1)";
                request.Host = "tvpapi-as.ott.kaltura.com";
                request.KeepAlive = false;
                request.ContentType = "application/json";
                request.ContentLength = payload.Length;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(payload);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    logHandler.AddNewLine("[!] Fetch failed: " + response.StatusDescription);
                    response.Close();
                    return;
                }

                if (response.ContentType != "application/json; charset=utf-8")
                {
                    logHandler.AddNewLine("[!] Invalid response type " + response.ContentType);
                    response.Close();
                    return;
                }

                long contentLength = response.ContentLength;
                if (contentLength <= 0)
                {
                    logHandler.AddNewLine("[!] Invalid Content-Length " + contentLength);
                    response.Close();
                    return;
                }

                // Get the stream associated with the response
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Read the content
                string jsonStr = reader.ReadToEnd();
                responseStream.Close();

                dynamic jsonResponse = JsonConvert.DeserializeObject(jsonStr);
                currentEpisodeLinks = new string[jsonResponse.Files.Count];

                for (int i = 0; i < jsonResponse.Files.Count; i++) currentEpisodeLinks[i] = jsonResponse.Files[i].URL;
                fetchDirectLinksSucceeded = true;
                response.Close();
            }
            catch (Exception ex)
            {
                logHandler.AddNewLine("[!] Fetch failed: " + ex.Message);
            }
        }


        //==================================================================
        private void backgroundWorkerFetch_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = "Ready...";
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;
            toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.accept;

            if (fetchWebUrlSucceeded)
            {
                string webUrl = 
                string.Format("http://www.voot.com/shows/{0}/0/{1}/{2}/{3}", 
                    currentEpisode.seriesTitle, 
                    currentEpisode.refSeriesId, 
                    currentEpisode.mainTitle.Replace(' ', '-'), 
                    currentEpisode.id);
                textBoxEpisode_URL.Text = webUrl;
            }

            if (fetchDirectLinksSucceeded)
            {
                listViewEpisode_Links.Items.Clear();
                foreach (var url in currentEpisodeLinks)
                {
                    ListViewItem lvi = new ListViewItem(url.Substring(url.LastIndexOf('.') + 1));
                    lvi.SubItems.Add(url);
                    listViewEpisode_Links.Items.Add(lvi);
                }
            }
            buttonFetch.Enabled = true;
        }


        //==================================================================
        private void listViewEpisode_Links_DoubleClick(object sender, EventArgs e)
        {
            if (listViewEpisode_Links.SelectedItems.Count == 1)
                Clipboard.SetText(listViewEpisode_Links.SelectedItems[0].SubItems[1].Text);
        }

        //==================================================================
        private void textBoxEpisode_URL_Click(object sender, EventArgs e)
        {
            textBoxEpisode_URL.SelectAll();
            if (textBoxEpisode_URL.Text.Length > 0)
                Clipboard.SetText(textBoxEpisode_URL.Text);
        }

        //==================================================================
        private void buttonSeries_Clear_Click(object sender, EventArgs e)
        {
            listViewSeries_FetchResults.Items.Clear();
        }

        //==================================================================
        private void buttonSeries_Fetch10_Click(object sender, EventArgs e)
        {
            if (currentSeries == null) return;
            int start = Convert.ToInt32(numericUpDownSeries_Start.Value);
            buttonSeries_Fetch10.Enabled = false;

            toolStripStatusLabel.Text = "Fetching...";
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.hourglass;

            backgroundWorkerSeries.RunWorkerAsync(start);
        }

        //==================================================================
        private void backgroundWorkerSeries_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            fetchSeriesEpisodeSucceeded = false;
            int start = (int) e.Argument;
            string payload = PostDataBuilder.BySeries(currentSeries.seriesMainTitle, currentSeries.season, start);
            string reqUrl = "http://tvpapi-as.ott.kaltura.com/v3_4/gateways/jsonpostgw.aspx?m=SearchMediaByAndOrList";

            logHandler.AddNewLine("[*] POST " + reqUrl);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(reqUrl);
                request.Method = "POST";
                request.UserAgent = "Dalvik / 1.6.0(Linux; U; Android 4.2.2; sdk Build/ JB_MR1.1)";
                request.Host = "tvpapi-as.ott.kaltura.com";
                request.KeepAlive = false;
                request.ContentType = "application/json";
                request.ContentLength = payload.Length;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(payload);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    logHandler.AddNewLine("[!] Fetch failed: " + response.StatusDescription);
                    response.Close();
                    return;
                }

                if (response.ContentType != "application/json; charset=utf-8")
                {
                    logHandler.AddNewLine("[!] Invalid response type " + response.ContentType);
                    response.Close();
                    return;
                }

                long contentLength = response.ContentLength;
                if (contentLength <= 0)
                {
                    logHandler.AddNewLine("[!] Invalid Content-Length " + contentLength);
                    response.Close();
                    return;
                }

                // Get the stream associated with the response
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Read the content
                string jsonStr = reader.ReadToEnd();
                responseStream.Close();

                dynamic jsonResponse = JsonConvert.DeserializeObject(jsonStr);
                episodeSeries = new Episode[jsonResponse.Count];

                for (int i = 0; i < episodeSeries.Length; i++)
                {
                    Episode epi = new Episode();
                    epi.name = jsonResponse[i].MediaName;
                    epi.id = jsonResponse[i].MediaID;
                    epi.entryId = jsonResponse[i].EntryId;

                    foreach (var meta in jsonResponse[i].Metas)
                    {
                        string key = meta.Key;
                        if (string.Equals(key, "RefSeriesTitle", StringComparison.InvariantCultureIgnoreCase))
                            epi.seriesTitle = meta.Value;

                        if (string.Equals(key, "ContentSynopsis", StringComparison.InvariantCultureIgnoreCase))
                            epi.synopsis = meta.Value;

                        if (string.Equals(key, "EpisodeMainTitle", StringComparison.InvariantCultureIgnoreCase))
                            epi.mainTitle = meta.Value;

                        if (string.Equals(key, "EpisodeNo", StringComparison.InvariantCultureIgnoreCase))
                            epi.episodeNum = meta.Value;
                    }

                    epi.refSeriesId = currentSeries.id;
                    episodeSeries[i] = epi;
                }
                
                fetchSeriesEpisodeSucceeded = true;
                response.Close();
            }
            catch (Exception ex)
            {
                logHandler.AddNewLine("[!] Fetch failed: " + ex.Message);
            }
        }

        //==================================================================
        private void backgroundWorkerSeries_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            buttonSeries_Fetch10.Enabled = true;
            toolStripStatusLabel.Text = "Ready...";
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;
            toolStripStatusIcon.Image = ColorsDesktop.Properties.Resources.accept;

            if (fetchSeriesEpisodeSucceeded && episodeSeries != null)
            {
                foreach (var episode in episodeSeries)
                {
                    MyListViewItem lvi = new MyListViewItem(episode.episodeNum);
                    lvi.detailObject = episode;
                    lvi.SubItems.AddRange(new string[] { episode.id, episode.name });
                    listViewSeries_FetchResults.Items.Add(lvi);
                }
            }
        }

        //==================================================================
        private void listViewSeries_FetchResults_DoubleClick(object sender, EventArgs e)
        {
            if (listViewSeries_FetchResults.SelectedItems.Count == 1)
            {
                MyListViewItem item = (MyListViewItem)listViewSeries_FetchResults.SelectedItems[0];

                if (item.detailObject is Episode)
                {
                    Episode epi = (Episode)item.detailObject;
                    currentEpisode = epi;

                    textBoxEpisode_ID.Text = epi.id;
                    textBoxEpisode_Name.Text = epi.name;
                    textBoxEpisode_Number.Text = epi.episodeNum;
                    textBoxEpisode_MainTitle.Text = epi.mainTitle;
                    textBoxEpisode_Synopsis.Text = epi.synopsis;
                    textBoxEpisode_URL.Text = string.Empty;
                    textBoxEpisode_EntryId.Text = epi.entryId;
                    textBoxEpisode_Predm3u8.Text = string.Format("http://cdnapi.kaltura.com/p/1982551/sp/198255100/playManifest/entryId/{0}/format/applehttp/tags/iphonenew/protocol/http/f/a.m3u8", epi.entryId);
                    listViewEpisode_Links.Items.Clear();

                    tabControlMainTab.SelectTab(tabPageEpisode);
                }
            }
        }

        //==================================================================

        private void listViewSeries_FetchResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) listViewSeries_FetchResults_DoubleClick(null, null);
        }

        //==================================================================
        private void numericUpDownSeries_Start_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) buttonSeries_Fetch10.PerformClick();
        }

        
        //==================================================================
        private void radioButtonOptions_ProxyCustom_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOptions_ProxyAddr.Enabled = numericUpDownOptions_ProxyPort.Enabled = radioButtonOptions_ProxyCustom.Checked;
        }


        //==================================================================
        private void buttonOptions_SaveSettings_Click(object sender, EventArgs e)
        {
            Settings settings;

            settings.proxyAddr = string.Empty;
            settings.proxyPort = 80;

            if (radioButtonOptions_ProxyNone.Checked)
                settings.proxyType = PROXY_TYPE.NONE;

            else if (radioButtonOptions_ProxySystem.Checked)
                settings.proxyType = PROXY_TYPE.SYSTEM;

            else
            {
                settings.proxyType = PROXY_TYPE.CUSTOM;

                bool isValid = false;
                string addr = textBoxOptions_ProxyAddr.Text.Trim();

                if (addr.Length != 0)
                {
                    string[] parts = addr.Split(new char[] { '.' });
                    if (parts.Length == 4)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            string part = parts[i];
                            if (part.Length > 3) break;
                            int p;
                            if (int.TryParse(part, out p))
                            {
                                if (p < 0 || p > 255) break;
                                else if (i == 3) isValid = true;
                            }
                        }
                    }
                }

                if (!isValid)
                {
                    MessageBox.Show("Invalid proxy address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                settings.proxyAddr = addr;
                settings.proxyPort = (int)numericUpDownOptions_ProxyPort.Value;
            }

            AppSettings.SaveSettings(settings);
            AppSettings.ApplySettings(settings);
            MessageBox.Show("Settings saved and applied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOptions_ClearSettings_Click(object sender, EventArgs e)
        {
            AppSettings.ClearSettings();
            MessageBox.Show("Settings removed from registry\nRestart to apply changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
