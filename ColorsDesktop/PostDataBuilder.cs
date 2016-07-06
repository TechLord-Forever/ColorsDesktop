using Newtonsoft.Json;

namespace ColorsDesktop
{
    class PostDataBuilder
    {
        public static string ByEpisodeID(string mediaId)
        {
            const string jsonData = @"{'MediaID':'382334','initObj':{'ApiPass':'11111','ApiUser':'tvpapi_225','Locale':{'LocaleCountry':'null','LocaleDevice':'null','LocaleLanguage':'null','LocaleUserState':'Unknown'},'Platform':'Cellular','SiteGuid':'2557906','UDID':'4b94efaa4d6d355a','DomainID':2557906},'picSize':'full','pageIndex':0,'pageSize':0,'page_index':0,'page_size':0,'mediaType':391,'iMediaID':0,'exact':false,'days':0,'withDynamic':false}";
            dynamic json = JsonConvert.DeserializeObject(jsonData);
            json.MediaID = mediaId;
            return JsonConvert.SerializeObject(json);
        }

        public static string BySeries(string seriesTitle, string season, int epiStart)
        {
            const string jsonData = @"{'andList':[{'m_sKey':'RefSeriesTitle','m_sValue':'___'},{'m_sKey':'RefSeriesSeason','m_sValue':'___'},{'m_sKey':'ContentType','m_sValue':'Full Episode'}],'initObj':{'ApiPass':'11111','ApiUser':'tvpapi_225','Locale':{'LocaleCountry':'null','LocaleDevice':'null','LocaleLanguage':'null','LocaleUserState':'Unknown'},'Platform':'Cellular','SiteGuid':'2557906','UDID':'4b94efaa4d6d355a','DomainID':2557906},'orderBy':'META','orderDir':'ASC','orderMeta':'EpisodeNo','pageIndex':0,'pageSize':5,'page_index':0,'page_size':0,'mediaType':391,'iMediaID':0,'exact':true,'days':0,'withDynamic':false}";
            dynamic json = JsonConvert.DeserializeObject(jsonData);
            json.andList[0].m_sValue = seriesTitle;
            json.andList[1].m_sValue = season;
            json.pageSize = MainWindow.PAGE_SIZE;
            json.pageIndex = epiStart / 10;
            return JsonConvert.SerializeObject(json);
        }
    }
}
