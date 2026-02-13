using BookStore.Models;
using BookStore.DL;
namespace BookStore.BL;
public class BuyBookService
{
    private readonly IBookRepository _bookRepo;
    private readonly ICustomerRepository _customerRepo;

    public BuyBookService(IBookRepository bookRepo, ICustomerRepository customerRepo)
    {
        _bookRepo = bookRepo;
        _customerRepo = customerRepo;
    }

    public async Task<bool> Buy(string bookId, string customerId)
    {
        var book = await _bookRepo.GetById(bookId);
        var customer = await _customerRepo.GetById(customerId);

        if (book == null || customer == null) return false;
        if (book.Stock <= 0) return false;
        if (customer.Balance < book.Price) return false;

        book.Stock--;
        customer.Balance -= book.Price;

        await _bookRepo.Update(book);
        await _customerRepo.Update(customer);

        return True();
    }

    private bool True() => true;
}
