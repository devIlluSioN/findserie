using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using TMDbLib;
using TMDbLib.Objects;
using TMDbLib.Utilities;
using TMDbLib.Helpers;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.TvShows;
using TMDbLib.Objects.Search;
using System.Threading.Tasks;

namespace MovieDB
{
    class Program
    {
        static string api = "e9b7597c5703d825bcbd7504ffee209a";

        static TMDbClient client = new TMDbClient(api);

        static void Main(string[] args)
        {
            Console.WriteLine(getFinalNumberEpispdeTV("The 100", 2));

            Console.ReadKey();
        }


        public static int getFinalNumberEpispdeTV(string SerieName, int seasonNumber)
        {
            TvSeason MySeason = client.GetTvSeasonAsync(getIDofSerie(SerieName), seasonNumber, language:"fr-FR").Result;
            return MySeason.Episodes.Count();
        }



        public static void getMoviebyTitle(string Title) //Marche pas a voir
        {
            //Movie MyMovie
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(Title).Result;
            foreach (SearchMovie result in results.Results)
                Console.WriteLine(result.Title);
        }

        public static string getNameOfTvEpisode(string SerieName, int SeasonNumber, int EpisodeNumber)
        {
            TvEpisode MyEpisode = client.GetTvEpisodeAsync(getIDofSerie(SerieName), SeasonNumber, EpisodeNumber, language: "fr_FR").Result;

            return MyEpisode.Name;

        }

        public static int getIDofSerie(string SerieName)
        {
            SearchContainer<SearchTv> results = client.SearchTvShowAsync(SerieName).Result;
            return results.Results[0].Id;
        }

    }
}
