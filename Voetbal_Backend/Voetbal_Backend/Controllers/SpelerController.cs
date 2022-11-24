using DAL.Context;
using Logic.Classes;
using Logic.Container;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Text.Json;

namespace VoetbalWeb.Controllers
{
    [ApiController]
    [EnableCors]
    public class SpelerController : Controller
    {
        private SpelerContainer pc;
        private readonly IConfiguration configuration;

        public SpelerController(IConfiguration ic)
        {
            configuration = ic;
            pc = new(new SpelerContext(configuration["db:ConnectionString"]));
        }

        [HttpGet]
        [Route("api/[controller]")]
        public string JsonConverter()
        {   
            List<Speler> spelers = pc.GetAllSpelers();
            var json = JsonSerializer.Serialize(spelers);
            return json;
        }


    }
}
