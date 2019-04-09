using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Finalizer.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Finalizer.Controllers
{
    public class HomeController : Controller
    {
        private string _myApiKey;
        private ILogger<HomeController> _logger;

        public HomeController(IConfiguration configuration, ILogger<HomeController> logger)
        {
            _myApiKey = configuration.GetValue<string>("myApiKey");
            _logger = logger;
        }
        public IActionResult Index()
        {

            return View();
        }
        public async Task <IActionResult> Genre()
        {
            string endpoint = "https://binaryjazz.us/wp-json/genrenator/v1/story/5";
            try
            {
                System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
                string response = await httpClient.GetStringAsync(endpoint);
                GenreViewModel typedResponse = new GenreViewModel
                {
                    response = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(response)
                };
                return View(typedResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Content("No genres to display at this time.");
            }

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Author()
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
