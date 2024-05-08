using Microsoft.AspNetCore.Mvc;
using TaskMVC.DAL;
using TaskMVC.Models;
using TaskMVC.ViewModels;

namespace TaskMVC.Controllers
{
    public class PagesController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public PagesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetail()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult Team()
        {
            PagesVM vm = new()
            {
                Farmers = _appDbContext.Farmers.ToList()
            };
            return View(vm);
        }
        public IActionResult Testomonial()
        {
            return View();
        }
    }
}
