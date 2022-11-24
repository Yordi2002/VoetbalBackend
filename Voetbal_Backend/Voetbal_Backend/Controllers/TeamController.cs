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
    public class TeamController : Controller
    {
        private TeamContainer pc;
        private readonly IConfiguration configuration;

        public TeamController(IConfiguration ic)
        {
            configuration = ic;
            pc = new(new TeamContext(configuration["db:ConnectionString"]));
        }

        [HttpGet]
        [Route("api/[controller]")]
        public string JsonConverter()
        {

            List<Team> teams = pc.GetAllTeams();

            var json = JsonSerializer.Serialize(teams);
            return json;
        }
    }
}