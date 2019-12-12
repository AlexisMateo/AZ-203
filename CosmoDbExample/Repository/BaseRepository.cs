using System;
using Microsoft.Azure.Cosmos;

namespace TableStorageExample.Repository
{
    public class BaseRepository
    {
        protected readonly CosmosClient cosmoClient;

        public BaseRepository()
        {
            cosmoClient = this.GetCosmoDBClient();
        }

        private CosmosClient GetCosmoDBClient()
        {
            string EndpointUri = Environment.GetEnvironmentVariable("ENDPOINT_KEY");
            string PrimaryKey = Environment.GetEnvironmentVariable("PRIMARY_KEY");

            CosmosClient cosmoClient = new CosmosClient(EndpointUri, PrimaryKey);
            return cosmoClient;
        }
    }
}