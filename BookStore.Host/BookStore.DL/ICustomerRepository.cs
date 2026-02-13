using BookStore.Models;
namespace BookStore.DL;
public interface ICustomerRepository
{
    Task<Customer?> GetById(string id);
    Task Update(Customer customer);
}
