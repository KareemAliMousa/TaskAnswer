namespace TaskAnswer.Controllers
{

    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        [Authorize]
        public IActionResult Index()
        {
            var products = _productsService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetPrice(int id)
        {
            decimal? price = _productsService.GetPrice(id);
            if(price == null)
            {
                return NotFound();
            }
            return Ok(price);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _productsService.create(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productsService.GetById(id);
            if (product is null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var product = await _productsService.Edit(model);
            if (product is null)
                return BadRequest();
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isDeleted = _productsService.Delete(id);

            return isDeleted ? Ok() : BadRequest();
        }
    }
}
