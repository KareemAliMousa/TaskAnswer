

namespace TaskAnswer.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Products
                   .Select(p => new SelectListItem
                   {
                       Value = p.Id.ToString(),
                       Text = p.Name,
                   })
                   .OrderBy(p => p.Text)
                   .AsNoTracking()
                   .ToList();
        }

        public Product? GetById(int id)
        {
            return _context.Products.Find(id);
        }
        public IEnumerable<Product?> GetAll()
        {
            return _context.Products.ToList();
        }

        public async Task create(Product model)
        {
            Product product = new()
            {
                Name = model.Name,
                Price = model.Price,
            };
            _context.Add(product);
            await _context.SaveChangesAsync();
        }


        public decimal? GetPrice(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return null;
            }
            return product.Price;
        }
        public async Task<Product?> Edit(Product model)
        {
            var product = await _context.Products.FindAsync(model.Id);
            if (product is null)
                return null;
            if (product.Name == model.Name && product.Price == model.Price)
            {
                return null;
            }
            if(product.Name == model.Name && product.Price == model.Price)
            {
                return product;
            }
            product.Name = model.Name;
            product.Price = model.Price;
            _context.SaveChanges();
            return product;
        }
        public bool Delete(int id)
        {
            var isDeleted = false;
            var product = _context.Products.Find(id);
            if (product is null)
                return isDeleted;

            if (_context.PurchaseInvoiceProducts.Any(p => p.ProductId == id))
                return isDeleted;
            _context.Remove(product);
            var effectedRows = _context.SaveChanges();
            if(effectedRows > 0)
            {
                isDeleted = true;
                return isDeleted;
            }
            return isDeleted;
        }

    }
}
