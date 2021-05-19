using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChamarCepApi.Models;
using ChamarCepApi.Controllers;
using System.Net;
using System.Net.Http;
using ChamarCepApi.Models;

namespace ChamarCepApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /*[HttpPost]
        [ActionName("alias_for_action")]
        public HttpResponseMessage PostProduct([FromBody] Cidade item)
        {

            //your code here

            var response = new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Your Result")
            };

            return response;
        }*/
        [HttpGet]
        public IEnumerable<Cidade> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Cidade
            {
                Cep = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}
