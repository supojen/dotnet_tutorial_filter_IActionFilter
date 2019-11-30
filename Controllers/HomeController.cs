using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilterTutorial.Filters;
using Microsoft.Extensions.Logging;
using FilterTutorial.Model;

namespace FilterTutorial.Controllers
{
    [Route("home")]
    [ServiceFilter(typeof(ControllerActionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMovieService _movies;
        public HomeController(ILogger<HomeController> logger, IMovieService movies)
        {
            this._logger = logger;
            this._movies = movies;
        }

        [HttpGet]
        [Route("")]
        [ServiceFilter(typeof(ActionFilterEx1),Order=2)]
        [ServiceFilter(typeof(ActionFilterEx2),Order=1)]
        public IActionResult Index()
        {
            _logger.LogWarning("In Index action method!");
            return Ok("This is the default page!");
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("test page");
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {  
            return View();
        }


        [HttpPost]
        [ServiceFilter(typeof(ValidateActionFilter))]
        public IActionResult CreatePost(Movie movie)
        {
            var entity = _movies.Add(movie);

            return RedirectToAction("all");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Detail(int id)
        {
            var movie = _movies.GetById(id);
            return View(movie);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            var movies = _movies.GetAll();
            return View(movies);
        }
        
    }
}