using DevExpress.XtraReports.UI;

namespace TaskAnswer.DevExpressReports
{
    public partial class PurchaseInvoiceReport : XtraReport
    {
        public PurchaseInvoiceReport(PurchaseInvoice purchaseInvoice)
        {
            InitializeComponent();
            ModifyPurchaseInoice(purchaseInvoice);
        }

        private void ModifyPurchaseInoice(PurchaseInvoice purchaseInvoice)
        {
            Id.Text = purchaseInvoice.Customer.Id.ToString();
            Code.Text = purchaseInvoice.Customer.Code.ToString();
            DateOfRegistration.Text = (new DateOnly(purchaseInvoice.Customer.DateOfRegistration.Year, purchaseInvoice.Customer.DateOfRegistration.Month, purchaseInvoice.Customer.DateOfRegistration.Day)).ToString(); 
            CustomerName.Text = purchaseInvoice.Customer.Name;

            this.DataSource = purchaseInvoice.Details.ToList();
            Product.DataBindings.Add("Text", this.DataSource, "Product.Name");
            Price.DataBindings.Add("Text", this.DataSource, "Product.Price");
        }
    }
}
