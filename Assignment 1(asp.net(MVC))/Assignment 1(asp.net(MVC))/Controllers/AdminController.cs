using Assignment_1_asp.net_MVC__.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment_1_asp.net_MVC__.Controllers
{
    public class AdminController : Controller
    {
        private readonly HttpClient _httpClient;

        public AdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("InsecureClient");
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Error()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Blank()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Widgets()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Table()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Button()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Chart()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Element()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Form()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Typography()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string pass, string username)
        {
            if (email == "superadmin@gmail.com" && pass == "123456" && username == "Zain")
            {
                HttpContext.Session.SetString("adminEmail", email);
                HttpContext.Session.SetString("adminUsername" , username);
                HttpContext.Session.SetString("role", "admin");
                return RedirectToAction("Index");
            }
            else if (email == "zainsarfraz82@gmail.com" && pass == "123456" && username == "Zain")
            {
                HttpContext.Session.SetString("adminUsername" , username);
                HttpContext.Session.SetString("userEmail", email);
                HttpContext.Session.SetString("role", "user");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.msg = "Invalid Credentials";
                return View();
            }
        }

        public IActionResult LogoutAdmin()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("adminEmail");
            HttpContext.Session.Remove("adminUsername");

            return RedirectToAction("Login");
        }

        // Example action to use HttpClient
        public async Task<IActionResult> GetData()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                ViewBag.username = HttpContext.Session.GetString("adminUsername");
                var response = await _httpClient.GetAsync("https://localhost:5001/api/data");
                var data = await response.Content.ReadAsStringAsync();
                ViewData["Data"] = data;
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
