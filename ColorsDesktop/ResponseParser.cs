namespace ColorsDesktop
{
    class ResponseParser
    {
        /// <summary>
        /// Returns a list of Episodes by parsing a json response
        /// </summary>
        /// <param name="jsonData">The parsed json data</param>
        /// <returns>Array of episodes or null</returns>
        public static Episode[] GetEpisodes(dynamic jsonData)
        {
            // Check number of assets types

            if (jsonData.total_items == 0) return null;
            if (jsonData.assets.episode.assets == null) return null;
            try
            {
                int totalEpisodes = jsonData.assets.episode.assets.Count;
                if (totalEpisodes > 0)
                {
                    Episode[] epiArr = new Episode[totalEpisodes];

                    for (int i = 0; i < totalEpisodes; i++)
                    {
                        var episode = jsonData.assets.episode.assets[i];
                        Episode epi = new Episode();
                        epi.id = episode.id;
                        epi.name = episode.name;
                        epi.synopsis = episode.metas.ContentSynopsis;
                        epi.mainTitle = episode.metas.EpisodeMainTitle;
                        epi.episodeNum = episode.metas.EpisodeNo;
                        epi.seriesTitle = episode.metas.RefSeriesTitle;
                        epi.entryId = episode.extra_params.entry_id;
                        epiArr[i] = epi;
                    }
                    return epiArr;
                }
            }
            catch
            {
                return null;
            }
            return null;
        }


        public static TvSeries[] GetTvSeries(dynamic jsonData)
        {
            // Check number of assets types
            if (jsonData.total_items == 0) return null;
            if (jsonData.assets.tvSeries.assets == null) return null;

            try
            {
                int totalSeries = jsonData.assets.tvSeries.assets.Count;
                if (totalSeries > 0)
                {
                    TvSeries[] tvsArr = new TvSeries[totalSeries];

                    for (int i = 0; i < totalSeries; i++)
                    {
                        var series = jsonData.assets.tvSeries.assets[i];
                        TvSeries tvs = new TvSeries();
                        tvs.id = series.id;
                        tvs.name = series.name;
                        tvs.totalEpisode = series.totalEpisode;
                        tvs.seriesMainTitle = series.metas.SeriesMainTitle;
                        tvs.synopsis = series.metas.SeriesSynopsis;
                        tvs.season = series.metas.Season;
                        tvsArr[i] = tvs;
                    }
                    return tvsArr;
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}
