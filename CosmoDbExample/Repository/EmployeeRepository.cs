using TableStorageExample.Models;
using Microsoft.Azure.Cosmos;
using System.Net;
using System.Threading.Tasks;
using System;
using CosmoDbExample.Models;
using System.Linq;
using System.Collections.Generic;

namespace TableStorageExample.Repository
{
    public class YoutubeRepository
    {
        public int AddYoutubeStat(YoutubeStatModel youtubeStat)
        {
            using (var context = new MetricsDbContext())
            {

                context.Add(youtubeStat);

                try
                {
                  int response =context.SaveChanges();
                  return response;
                }
                catch (Exception ex)
                {
                    return ex.HResult;
                }
            }
        } 

        public List<YoutubeStatModel> GetYoutubeStat()
        {
            using (var context = new MetricsDbContext())
            {
                try
                {
                  List<YoutubeStatModel> youtubeStats =context.YoutubeStats.ToList();
                  return youtubeStats;
                }
                catch (Exception ex)
                {
                    return new List<YoutubeStatModel>();
                }
            }
        } 

    }
    
}