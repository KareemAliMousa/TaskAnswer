namespace TaskAnswer.Services
{
    public interface IProductsService
    {
        IEnumerable<Product?> GetAll();
        IEnumerable<SelectListItem> GetSelectList();
        Product? GetById(int id);
        decimal? GetPrice(int id);
        Task create(Product product);

        Task<Product?> Edit(Product model);
        bool Delete(int id);
    }
}
