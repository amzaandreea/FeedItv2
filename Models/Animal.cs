using System.Text.Json;

namespace FeedItv2.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string imageSmall { get; set; }
        public string imageMedium { get; set; }
        public string imageLarge { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Animal>(this);

    }
}
