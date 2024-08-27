namespace TaskAnswer.Services
{
    public interface IPurchaseInvoicesService
    {
        IEnumerable<PurchaseInvoiceViewModel?> GetAll(string token);
        PurchaseInvoiceViewModel? GetById(int id , string token);
        int? create(PurchaseInvoiceViewModel model , string token);
        void Edit(PurchaseInvoiceViewModel model, string token);
        bool Delete(int id, string token);
        PurchaseInvoicePrintModel? PrintPurchase(int id, string token);
    }
}
