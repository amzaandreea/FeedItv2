using FeedItv2.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace FeedItv2.Services
{
    public class JsonFileAnimalService
    {
        public JsonFileAnimalService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "animals.json"); }
        }

        public IEnumerable<Animal> GetAnimals()
        {
            using StreamReader jsonFileReader = File.OpenText(JsonFileName);

            return JsonSerializer.Deserialize<Animal[]>(jsonFileReader.ReadToEnd());
        }

        public void AddWeight(int animalId)
        {
            var animals = GetAnimals();

            var query = animals.First(x => x.Id == animalId);

            if(query.Fat <= 1)
            query.Fat += 1;

            using (FileStream outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Animal>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    animals
                );
            }
        }
    }
}
