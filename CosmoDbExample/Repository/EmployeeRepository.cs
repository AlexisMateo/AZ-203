using TableStorageExample.Models;
using Microsoft.Azure.Cosmos;
using System.Net;
using System.Threading.Tasks;
using System;
using CosmoDbExample.Models;

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

    }
    
}