namespace TaskAnswer.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly AppDbContext _context;
        private readonly IJwtTokenManager _jwtTokenManager;
        public CustomersService(AppDbContext context, IJwtTokenManager jwtTokenManager)
        {
            _context = context;
            _jwtTokenManager = jwtTokenManager;
        }

        public string? Login(CustomerViewModel model)
        {
            var existUser = ExistUser(model);
            if (existUser is null)
            {
                return null;
            }
            else
            {
                existUser.Token = _jwtTokenManager.AuthenticateUser(existUser.Name, existUser.Password);
                var effectedRows = _context.SaveChanges();
                if (effectedRows > 0)
                {
                    return existUser.Token;
                }
                else
                {
                    return null;
                }

            }
        }

        public Customer? Register(CustomerViewModel model)
        {
            if (_context.Customers.Any(u => u.Name == model.Name))
            {
                return null;
            }
            var existUser = ExistUser(model);
            if (existUser is null)
            {
                var customer = new Customer
                {
                    Name = model.Name,
                    Password = model.Password,
                    Code = (_context.Customers.Select(c => c.Id).ToList().DefaultIfEmpty(0).Max() + 1).ToString(),
                    DateOfRegistration = DateTime.UtcNow,
                };
                _context.Add(customer);
                _context.SaveChanges();
                return customer;
            }
            else
            {
                return null;
            }
        }

        public Customer? GetById(int Id)
        {
            return _context.Customers.Find(Id);
        }

        public Customer? GetAuthorizedCustomer(string Token)
        {
            return _context.Customers.FirstOrDefault(c=>c.Token == Token);
        }

        private Customer? ExistUser(CustomerViewModel model)
        {
            return _context.Customers.SingleOrDefault(u => u.Name == model.Name && u.Password == model.Password);

        }
        public async Task<Customer?> Edit(Customer customer)
        {
            var existCustomer = await _context.Customers.FindAsync(customer.Id);
            if (existCustomer is null)
            {
                return null;
            }
            if (existCustomer.Name == customer.Name)
            {
                return null;
            }
            existCustomer.Name = customer.Name;
            _context.SaveChanges();
            return existCustomer;

        }

        public void Logout(string token)
        {
            var user = _context.Customers.FirstOrDefault(c => c.Token == token);
            if (user != null)
                user.Token = null;
            _context?.SaveChanges();
        }
    }
}
