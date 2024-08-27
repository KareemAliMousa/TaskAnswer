using DevExpress.XtraPrinting;
using TaskAnswer.DevExpressReports;

namespace TaskAnswer.Services
{
    public class PurchaseInvoicesService : IPurchaseInvoicesService 
    {
        private readonly AppDbContext _context;
        private readonly IProductsService _productService;
        public PurchaseInvoicesService(AppDbContext context, IProductsService productService)
        {
            _context = context;
            _productService = productService;
        }

        IEnumerable<PurchaseInvoiceViewModel?> IPurchaseInvoicesService.GetAll(string token)
        {
            var userId = GetUserId(token);

            List<PurchaseInvoice> purchaseInvoices = _context.PurchaseInvoices.Include(c=>c.Customer).Include(p => p.Details)
                                                    .AsNoTracking().Where(i => i.CustomerId == userId).ToList();
            List<PurchaseInvoiceViewModel> purchaseInvoiceViewModels = new List<PurchaseInvoiceViewModel>();
            foreach (var purchaseInvoice in purchaseInvoices)
            {
                purchaseInvoiceViewModels.Add(MapPurchaseInvoiceViewModel(purchaseInvoice));
            }
            return purchaseInvoiceViewModels;
        }

        PurchaseInvoiceViewModel? IPurchaseInvoicesService.GetById(int id, string token)
        {
            var userId = GetUserId(token);
            PurchaseInvoice purchaseInvoice = _context.PurchaseInvoices
                                              .Include(c=>c.Customer)
                                              .Include(p => p.Details)
                                              .AsNoTracking()
                                              .FirstOrDefault(p => p.Id == id && p.CustomerId == userId)!;
            if(purchaseInvoice is null)
            {
                return null;
            }
            return (MapPurchaseInvoiceViewModel(purchaseInvoice));
        }

        public int? create(PurchaseInvoiceViewModel model, string token)
        {
            var userId = GetUserId(token);
            if (userId is null)
                return null;
            PurchaseInvoice invoice = new()
            {
                CustomerId = userId.Value,
            };
            _context.PurchaseInvoices.Add(invoice);
            _context.SaveChanges();

            ChangePurchaseInvoiceDetails(model, invoice.Id);
            return invoice.Id;
        }

        public void Edit(PurchaseInvoiceViewModel model, string token)
        {
            var userId = GetUserId(token);
            var existingInvoice = _context.PurchaseInvoices
                .Include(i => i.Details)
                .FirstOrDefault(i => i.Id == model.Id && i.CustomerId == userId);

            if (existingInvoice == null)
            {
                throw new Exception("Invoice not found.");
            }

            _context.PurchaseInvoiceProducts.RemoveRange(existingInvoice.Details);
            _context.SaveChanges();
            ChangePurchaseInvoiceDetails(model, existingInvoice.Id);
        }



        public bool Delete(int id, string token)
        {
            var isDeleted = false;
            var PurchaseInvoice = _context.PurchaseInvoices.Include(p=>p.Details).FirstOrDefault(p => p.Id==id);
            if (PurchaseInvoice is null)
                return isDeleted;
            _context.PurchaseInvoiceProducts.RemoveRange(PurchaseInvoice.Details);
            _context.PurchaseInvoices.Remove(PurchaseInvoice);
            var effectedRows = _context.SaveChanges();
            if (effectedRows > 0)
            {
                isDeleted = true;
                return isDeleted;
            }
            return isDeleted;
        }

        public PurchaseInvoicePrintModel? PrintPurchase(int id, string token)
        {
            var invoice = _context.PurchaseInvoices
                                    .Include(p => p.Details)
                                    .ThenInclude(p => p.Product)
                                    .Include(p => p.Customer)
                                    .AsNoTracking()
                                    .FirstOrDefault(p => p.Id == id);

            if (invoice == null)
            {
                return null;
            }

            PurchaseInvoiceReport report = new PurchaseInvoiceReport(invoice);

            // Generate the report as a PDF file.
            using MemoryStream stream = new MemoryStream();

            PdfExportOptions options = new PdfExportOptions();
            report.ExportToPdf(stream, options);
            string fileName = "PurchaseInvoice.pdf";

            // Save the PDF file to a specific location on the server.
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "uploads", "DevExpressReport");
            string filePath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Save the file to the server.
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fileStream);
            }
            PurchaseInvoicePrintModel purchaseInvoicePrintModel = new PurchaseInvoicePrintModel
            {
                fileName = fileName,
                filePath = filePath,
            };
            return purchaseInvoicePrintModel;
        }

        private int? GetUserId (string token)
        {
            var user = _context.Customers.FirstOrDefault(c => c.Token == token);
            if (user is null)
                return null;
            else
                return user.Id;
        }
        private PurchaseInvoiceViewModel MapPurchaseInvoiceViewModel(PurchaseInvoice purchaseInvoice)
        {
            PurchaseInvoiceViewModel purchaseInvoiceViewModel = new PurchaseInvoiceViewModel();
            purchaseInvoiceViewModel.Id = purchaseInvoice.Id;
            purchaseInvoiceViewModel.CustomerName = purchaseInvoice.Customer.Name;
            purchaseInvoiceViewModel.CustomerId = purchaseInvoice.CustomerId;
            if(purchaseInvoice.Details.Count() <= 0)
            {
                purchaseInvoiceViewModel.Products = new List<Product>();
            }
            else
            {
                List<int> ProductIds = purchaseInvoice.Details.Select(p => p.ProductId).ToList();
                purchaseInvoiceViewModel.Products = _context.Products.Where(p => ProductIds.Contains(p.Id)).ToList();
            }
            purchaseInvoiceViewModel.ProductOptions = _productService.GetSelectList();
            return purchaseInvoiceViewModel;
        }

        private void ChangePurchaseInvoiceDetails (PurchaseInvoiceViewModel purchaseInvoice , int invoiceId)
        {
            List<PurchaseInvoiceProduct> Products = new List<PurchaseInvoiceProduct>();
            foreach (var item in purchaseInvoice.Products)
            {
                PurchaseInvoiceProduct products = new()
                {
                    ProductId = item.Id,
                    PurchaseInvoiceId = invoiceId
                };
                Products.Add(products);
            }
            _context.PurchaseInvoiceProducts.AddRange(Products);
            _context.SaveChanges();
        }
    }
}
