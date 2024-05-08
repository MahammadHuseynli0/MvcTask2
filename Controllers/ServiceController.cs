﻿using Microsoft.AspNetCore.Mvc;
using TaskMVC.DAL;

namespace TaskMVC.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ServiceController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
