using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FeedItv2.Models
{
    public class Animal
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }


        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("weight")]
        public double[] Weight { get; set; }

        [JsonPropertyName("imageSmall")]
        public string ImageSmall { get; set; }

        [JsonPropertyName("imageMedium")]
        public string ImageMedium { get; set; }

        [JsonPropertyName("imageLarge")]
        public string ImageLarge { get; set; }

        [JsonPropertyName("fat")]
        public int Fat { get; set; }

        public override string ToString() => System.Text.Json.JsonSerializer.Serialize<Animal>(this);

    }
}
