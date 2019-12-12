using System;
using CosmoDbExample.Models;
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

          
        public static void AddYoutubeStat()
        {
            YoutubeStatModel youtubeStatModel = new YoutubeStatModel
            {
                Id = "4891",
                Clicks="165",
                Criteria="Doctor",
                Impressions="798",
                PartitionKey="Doctor"
            };

            YoutubeRepository youtubeRepository = new YoutubeRepository();
            youtubeRepository.AddYoutubeStat(youtubeStatModel);
        }
 
    }
}
