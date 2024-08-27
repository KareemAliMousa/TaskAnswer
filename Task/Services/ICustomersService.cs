namespace TaskAnswer.Services
{
    public interface ICustomersService
    {
        Customer? Register(CustomerViewModel model);
        string? Login(CustomerViewModel model);
        void Logout(string token);
        Customer? GetById(int Id);
        Customer? GetAuthorizedCustomer(string Token);
        Task<Customer?> Edit(Customer customer);
    }
}
