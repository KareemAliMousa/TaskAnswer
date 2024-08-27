[Authorize]
public class PurchaseInvoiceController : Controller
{
    private readonly IProductsService _productService;
    private readonly IPurchaseInvoicesService _purchaseInvoiceService;
    public PurchaseInvoiceController(IProductsService productService, IPurchaseInvoicesService purchaseInvoiceService)
    {
        _productService = productService;
        _purchaseInvoiceService = purchaseInvoiceService;
    }

    // GET: PurchaseInvoice/Index
    public IActionResult Index()
    {
        string Token = Request.Cookies["BearerToken"]!;

        var invoices = _purchaseInvoiceService.GetAll(Token);
        return View(invoices);
    }

    public IActionResult Details(int id)
    {
        string Token = Request.Cookies["BearerToken"]!;

        var invoice = _purchaseInvoiceService.GetById(id, Token);
        if (invoice == null)
        {
            return NotFound();
        }

        return View(invoice);
    }

    public IActionResult Print(int id)
    {
        string Token = Request.Cookies["BearerToken"]!;

        var invoice = _purchaseInvoiceService.PrintPurchase(id, Token);
        if (invoice is null)
            return BadRequest();

        return PhysicalFile(invoice.filePath, "application/pdf", invoice.fileName);
    }
    // GET: PurchaseInvoice/Create
    public IActionResult Create()
    {
        var model = new PurchaseInvoiceViewModel
        {
            ProductOptions = _productService.GetSelectList()
        };
        return View(model);
    }

    // POST: PurchaseInvoice/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(PurchaseInvoiceViewModel model)
    {
        string Token = Request.Cookies["BearerToken"]!;

        if (ModelState.IsValid)
        {
            var invoiceId = _purchaseInvoiceService.create(model , Token);
            if (invoiceId == null)
                return BadRequest();
            return RedirectToAction("Index"); 
        }
        return View(model);
    }

    // GET: PurchaseInvoice/Edit/5
    public IActionResult Edit(int id)
    {
        string Token = Request.Cookies["BearerToken"]!;

        var invoice = _purchaseInvoiceService.GetById(id, Token);
        if (invoice == null)
        {
            return NotFound();
        }

        return View(invoice);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(PurchaseInvoiceViewModel model)
    {
        string Token = Request.Cookies["BearerToken"]!;

        if (ModelState.IsValid)
        {
            _purchaseInvoiceService.Edit(model , Token);

            return RedirectToAction("Index");
        }

        model.ProductOptions = _productService.GetSelectList();
        return View(model);
    }


    [HttpDelete]
    public IActionResult Delete(int id)
    {
        string Token = Request.Cookies["BearerToken"]!;

        var isDeleted = _purchaseInvoiceService.Delete(id , Token);
        return isDeleted ? Ok() : BadRequest();
    }
}
