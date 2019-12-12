using Newtonsoft.Json;

namespace TableStorageExample.Models
{
    public class YoutubeStatModel
    {
        public string Id { get; set; }
        public string Criteria { get; set; }
        public string Impressions { get; set; }
        public string Clicks { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}