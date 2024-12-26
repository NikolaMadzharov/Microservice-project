using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        public BooksController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboudConnection()
        {
            Console.WriteLine(" --> Inbound POST from Command Service");

            return Ok("Inbound tesr of from Book Controller");
        }
    }
}
