using Assignment_1_asp.net_MVC__.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment_1_asp.net_MVC__.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("InsecureClient");
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        public IActionResult Error()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        public IActionResult Contact()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        public IActionResult Courses()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        public IActionResult Team()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        public IActionResult Testimonial()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        public IActionResult LogoutUser()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("userEmail");

            return RedirectToAction("Login", "Admin");
        }

        // Example action to use HttpClient
        public async Task<IActionResult> GetData()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.email = HttpContext.Session.GetString("userEmail");
                var response = await _httpClient.GetAsync("https://localhost:5001/api/data");
                var data = await response.Content.ReadAsStringAsync();
                ViewData["Data"] = data;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
    }
}
