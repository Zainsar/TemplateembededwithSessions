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

        public IActionResult IconMenu()
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

        public IActionResult SidebarStyle2()
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

        public IActionResult DataTables()
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

        public IActionResult Tables()
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

        public IActionResult GoogleMaps()
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

        public IActionResult JsVectorMap()
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

        public IActionResult Forms()
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

        public IActionResult Avatars()
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

        public IActionResult Buttons()
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

        public IActionResult FontAwesomeIcons()
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

        public IActionResult GridSystem()
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

        public IActionResult Notifications()
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

        public IActionResult Panels()
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

        public IActionResult SimpleLineIcons()
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

        public IActionResult SweetAlert()
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

        public IActionResult Charts()
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

        public IActionResult Sparkline()
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
            if (email == "admin@gmail.com" && pass == "123" && username == "Admin")
            {
                HttpContext.Session.SetString("adminEmail", email);
                HttpContext.Session.SetString("adminUsername" , username);
                HttpContext.Session.SetString("role", "admin");
                return RedirectToAction("Index");
            }
            else if (email == "huda@gmail.com" && pass == "123" && username == "Huda")
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
