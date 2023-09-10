using Content.BookContext;
using Microsoft.EntityFrameworkCore;

public class BookRepository
{
  private readonly DbContext _context;

  public BookRepository(BookContext context)
  {
    _context = context;
  }

  // Para realizar a consulta, adicionamos um método
  // que realiza essa consulta em BookRepository
  // public List<Book?> GetBookList()
  // {
  //   var query = _context.Books.ToList();

  //   return query;
  // }
}
