using System;
using dotenv.net;
using TableStorageExample.Models;
using TableStorageExample.Repository;

namespace CosmoDbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Config();
            AddYoutubeStat();
        }

          
        public static async void AddYoutubeStat()
        {
            YoutubeStatModel youtubeStatModel = new YoutubeStatModel();
            youtubeStatModel.Id="111";
            youtubeStatModel.Clicks= "256";
            youtubeStatModel.Criteria = "Automobiles";
            youtubeStatModel.Impressions = "1024";

            YoutubeRepository youtubeRepository = new YoutubeRepository();
            await youtubeRepository.AddYoutubeStat(youtubeStatModel);
        }
    }
}
