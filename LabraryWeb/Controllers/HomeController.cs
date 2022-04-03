using LabraryWeb.Models;
using LibraryBLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LabraryWeb.Controllers
{
    public class HomeController : Controller
    {
        private IAuthorService _authorService;

        public HomeController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {

            var authors = _authorService.GetAllAuthors();
            return View(authors);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
