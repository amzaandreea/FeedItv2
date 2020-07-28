using System.Collections.Generic;
using FeedItv2.Models;
using FeedItv2.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FeedItv2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileAnimalService AnimalService;
        public IEnumerable<Animal> Animals { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileAnimalService animalService)
        {
            _logger = logger;
            AnimalService = animalService;
        }

        public void OnGet()
        {
            Animals = AnimalService.GetAnimals();
        }
    }
}
