using Microsoft.EntityFrameworkCore;
using TableStorageExample.Models;

namespace CosmoDbExample.Models
{
    public class MetricsDbContext:DbContext
    {
        public DbSet<YoutubeStatModel> YoutubeStats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseCosmos(
            "https://aloecosmodb.documents.azure.com:443",
            "8Fc0Mcw9t7Xed9Dzg3U0veCkdw2rD6IxEVoKuHxOgK9BSBNiRHRQOb6iYjfDHI5TlTHt9IQuzEaNZbjoFPABEQ==",
            databaseName: "metricsdb");
        }
    }
}