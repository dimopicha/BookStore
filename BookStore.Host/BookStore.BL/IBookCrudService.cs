using BookStore.Models;
namespace BookStore.BL;
public interface IBookCrudService
{
    Task Add(Book book);
    Task<List<Book>> GetAll();
    Task<Book?> GetById(string id);
}
