using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        public ViewResult GetAll()
        {
            List<string> hobbies = new List<string> { "Reading", "Traveling", "Cooking" };
            return View("index" ,hobbies);
        }
    }
}
