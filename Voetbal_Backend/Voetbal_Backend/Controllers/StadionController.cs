using DAL.Context;
using Logic.Classes;
using Logic.Container;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace VoetbalWeb.Controllers
{
    [ApiController]
    [EnableCors]
    public class StadionController : Controller
    {
        private StadionContainer pc;
        private readonly IConfiguration configuration;

        public StadionController(IConfiguration ic)
        {
            configuration = ic;
            pc = new(new StadionContext(configuration["db:ConnectionString"]));
        }

        [HttpGet]
        [Route("api/[controller]")]
        public string JsonConverter()
        {
            List<Stadion> stadions = pc.GetAllStadions();
            var json = JsonSerializer.Serialize(stadions);
            return json;
        }
    }
}
