using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Host.Controllers;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    [HttpGet]
    public List<Book> Get() => new();
}
