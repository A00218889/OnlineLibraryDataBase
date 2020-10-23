using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _dbContext.Customer.ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            return await _dbContext.Customer.FirstOrDefaultAsync(customer => customer.CustomerId == customerId);
        }

        public async Task<bool> RemoveCustomerAsync(int customerId)
        {
            var Customer = await _dbContext.Customer.FirstOrDefaultAsync(customer => customer.CustomerId == customerId);
            _dbContext.Customer.Remove(Customer);
            await _dbContext.SaveChangesAsync();

            return true;
        }

         

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            _dbContext.Customer.Update(customer);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            await _dbContext.Customer.AddAsync(customer);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}