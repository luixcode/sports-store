using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View();
    }
}
