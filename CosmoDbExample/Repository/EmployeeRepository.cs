using TableStorageExample.Models;
using Microsoft.Azure.Cosmos;
using System.Net;
using System.Threading.Tasks;
using System;

namespace TableStorageExample.Repository
{
    public class YoutubeRepository: BaseRepository
    {

        private readonly Database dataBase; 
        private readonly Container container; 
        public YoutubeRepository()
        {
            dataBase=this.cosmoClient.GetDatabase("metricsdb");
            container=this.cosmoClient.GetContainer("metricsdb","youtube_stat");
        }

        public async Task<HttpStatusCode> AddYoutubeStat(YoutubeStatModel youtubeStat)
        {
            var partionKey = new PartitionKey(youtubeStat.Criteria);
            ItemResponse<YoutubeStatModel> youtubeStatReponse = await this.container.ReadItemAsync<YoutubeStatModel>(youtubeStat.Id, partionKey);

            Console.WriteLine(youtubeStat);
            
            return youtubeStatReponse.StatusCode;
        } 

    }
    
}