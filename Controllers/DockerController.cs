using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TreinaToo1_Docker_AllanHermoso.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DockerController : ControllerBase
    {
        private readonly ILogger<string> _logger;

        public DockerController(ILogger<string> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("HealthCheck")]
        public string HealthCheck()
        {
            return "OK";
        }

        [HttpGet]
        [Route("Musicas")]
        public List<string> Musicas()
        {
            List<string> musicas = new List<string>();
            musicas.Add("PeladosEmSantos.mp3");
            musicas.Add("Macarena.mp3");
            musicas.Add("WhiskyAGoGo.mp3");
            return musicas;
        }

        [HttpGet]
        [Route("Livros")]
        public List<string> Livros()
        {
            List<string> livros = new List<string>();
            livros.Add("O Piloto de Hitler");
            livros.Add("Hollywood nua e crua");
            livros.Add("Na Raça");
            return livros;
        }

        [HttpGet]
        [Route("Filmes")]
        public List<string> Filmes()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Beleza Americana");
            filmes.Add("Senhor dos Anéis");
            filmes.Add("O Hobbit");
            return filmes;
        }
    }
}
