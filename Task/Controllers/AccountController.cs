namespace TaskAnswer.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICustomersService _customersService;

        public AccountController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = _customersService.Register(model)!;
                if (customer is null)
                {
                    TempData["ErrorMessage"] = "Invalid User!";
                    return View(model);
                }

                TempData["SuccessMessage"] = "Registration successful!";
                return RedirectToAction("Login");
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                string userToken = _customersService.Login(model)!;
                if (userToken is null)
                {
                    return NotFound();
                }
                HttpContext.Response.Cookies.Append("BearerToken", userToken, new CookieOptions { HttpOnly = true, Secure = true });
                return RedirectToAction("Customer", "Customer");
            }
            ModelState.AddModelError(string.Empty, "Invalid Login");
            return View();
        }

        public IActionResult LogOut()
        {
            var token = Request.Cookies["BearerToken"];
            if (token != null)
            {
                _customersService.Logout(token);
                Response.Cookies.Delete("BearerToken");
            }
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}
