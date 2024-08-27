namespace TaskAnswer.Controllers
{

    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ICustomersService _customersService;

        public CustomerController(ICustomersService customersService)
        {
            _customersService = customersService;
        }
        [HttpGet]
        public IActionResult Customer()
        {
            string Token = Request.Cookies["BearerToken"]!;
            var customer = _customersService.GetAuthorizedCustomer(Token);
            return View(customer);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = _customersService.GetById(id);
            if (customer is null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            var updatedCustomer = await _customersService.Edit(customer);
            if (updatedCustomer is null)
                return View(customer);
            return RedirectToAction(nameof(Customer));
        }

    }
}
