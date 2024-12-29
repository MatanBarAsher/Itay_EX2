using Microsoft.AspNetCore.Mvc;

namespace Itay_EX2.Controllers
{
    using Itay_EX2.Model;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;


        [Route("api/[controller]")]
        [ApiController]
        public class UserController : Controller
        {

            User tempUser = new User();

            // GET: UserController
            [HttpGet]
            public List<User> readUserCon()
            {
                return tempUser.readUser();
            }



            // POST: UserController/Create
            [HttpPost]

            public bool InserUserCon(User newUserCon)
            {
                return newUserCon.InsertUser(newUserCon);
            }



        }
    
}
