using DataValidator.Data.Interfaces.Repositories;
using DataValidator.Data.Models;

namespace DataValidator.Data.Repository.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
    }
}
