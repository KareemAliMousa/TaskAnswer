
namespace TaskAnswer.Models
{
    public class PurchaseInvoice
    {
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public IEnumerable<PurchaseInvoiceProduct> Details { get; set; } = new List<PurchaseInvoiceProduct>();
    }
    public class PurchaseInvoiceProduct
    {
        public int Id { get; set; }
        [ForeignKey("PurchaseInvoiceId")]
        public int PurchaseInvoiceId { get; set; }
        public PurchaseInvoice PurchaseInvoice { get; set; } = default!;
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
    }
}
