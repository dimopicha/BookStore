using BookStore.Models;
namespace BookStore.DL;
public interface IBookRepository
{
    Task<Book?> GetById(string id);
    Task Update(Book book);
}
