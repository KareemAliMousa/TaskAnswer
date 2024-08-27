namespace TaskAnswer.ViewModels
{
    public class PurchaseInvoiceViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public IEnumerable<SelectListItem> ProductOptions { get; set; } = new List<SelectListItem>();
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
