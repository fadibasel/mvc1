using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context =new ApplicationDbContext();   
        public ViewResult Index()
        {
            var categories = context.categories.ToList();
            return View("index",categories);
        }
        public ViewResult Details(int id)
        {
            var category = context.categories.Find(id);
            return View("Details",category);
        }
    }
}
