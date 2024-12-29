using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Http;

namespace Itay_EX2.Controllers
{
    using Itay_EX2.Model;
    using Microsoft.AspNetCore.Mvc;


        [Route("api/[controller]")]
        [ApiController]
        public class GamesController : Controller
        {


            Game tempGame = new Game();
            // GET: GamesController
            [HttpGet]
            public List<Game> ReadGames()
            {
                return tempGame.Read();
            }


            // POST: GamesController/Create
            [HttpPost]

            public bool InsertGameCON(Game NewGame)
            {
                return NewGame.InsertGame(NewGame);
            }


            [HttpGet("ReadGamesByPrice")]
            public List<Game> ReadGamesByPrice([FromQuery] float minPrice)
            {
                return tempGame.GetByPrice(minPrice);
            }

            [HttpGet("ReadGamesByRank/{Rank}")]

            public List<Game> ReadGamesByRank(int Rank)
            {
                return tempGame.GetByPrice(Rank);
            }

        

        }
    
}
