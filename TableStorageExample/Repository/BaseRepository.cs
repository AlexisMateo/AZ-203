using System;
using Microsoft.Azure.Cosmos.Table;

namespace TableStorageExample.Repository
{
    public class BaseRepository
    {
        protected readonly CloudTableClient cloudTableClient;

        public BaseRepository()
        {
            cloudTableClient = this.GetCloudTableClient();
        }

        private  CloudStorageAccount GetStorageAccountConnection()
        {
            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            return storageAccount;
        }

        private CloudTableClient GetCloudTableClient()
        {
            CloudStorageAccount storageAccount = this.GetStorageAccountConnection();
            CloudTableClient cloudTableClient = storageAccount.CreateCloudTableClient();
            return cloudTableClient;
        }
    }
}