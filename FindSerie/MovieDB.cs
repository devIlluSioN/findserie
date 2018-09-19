using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using TMDbLib;
using TMDbLib.Objects;
using TMDbLib.Utilities;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.TvShows;
using TMDbLib.Objects.Search;
using System.Threading.Tasks;

namespace FindSerie
{
    class MovieDB
    {
        static string api = "e9b7597c5703d825bcbd7504ffee209a";

        static TMDbClient client = new TMDbClient(api);

        public static int getFinalNumberEpispdeTV(string SerieName, int seasonNumber)
        {
            try
            {
                TvSeason MySeason = client.GetTvSeasonAsync(getIDofSerie(SerieName), seasonNumber, language: "fr-FR").Result;
                return MySeason.Episodes.Count(x => x != null);
            }
            catch
            {

                return -1;
            }
        }

        public static void getMoviebyTitle(string Title) //Marche pas a voir
        {
            //Movie MyMovie
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(Title).Result;
            foreach (SearchMovie result in results.Results)
                Console.WriteLine(result.Title);
        }

        public static string getNameOfTvEpisode(int idSerie, int SeasonNumber, int EpisodeNumber)
        {
//            TvEpisode MyEpisode = client.GetTvEpisodeAsync(getIDofSerie(SerieName), SeasonNumber, EpisodeNumber, language: "fr_FR").Result;
            TvEpisode MyEpisode = client.GetTvEpisodeAsync(idSerie, SeasonNumber, EpisodeNumber, language: "fr_FR").Result;

            return MyEpisode.Name;

        }

        public static SearchContainer<SearchTv> getSearchTv(string SerieName)
        {
            return client.SearchTvShowAsync(SerieName).Result;
        }

        public static int getIDofSerie(string SerieName)
        {
            SearchContainer<SearchTv> results = client.SearchTvShowAsync(SerieName).Result;
            if (results.Results.Count != 0)
            {
                return results.Results[0].Id;
            }
            else
                return -1;
        }

        public static int getNBSeason(int idSerie)
        {
            return client.GetTvShowAsync(idSerie, language: "fr-FR").Result.NumberOfSeasons;
        }

        public static TvShow getTvShow(int idSerie)
        {
            return client.GetTvShowAsync(idSerie, language: "fr-FR").Result;
        }
    }
}
