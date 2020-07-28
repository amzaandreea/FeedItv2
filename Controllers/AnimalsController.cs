using System.Collections.Generic;
using FeedItv2.Models;
using FeedItv2.Services;
using Microsoft.AspNetCore.Mvc;

namespace FeedItv2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public AnimalsController (JsonFileAnimalService animalService)
        {
            this.AnimalService = animalService;
        }

        public JsonFileAnimalService AnimalService { get; }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return AnimalService.GetAnimals();
        }

        [Route("Weight")]
        [HttpGet] 
        public ActionResult Get(
            [FromQuery]int animalId)
        {
            AnimalService.AddWeight(animalId);
            return Ok();
        }
    }
}