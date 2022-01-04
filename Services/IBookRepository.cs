// Repository- this - Interface created  for the CRUD functions
//which are implemented in BookRepositoryServices Class

using BookStoreApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreApp.Services
{
    public interface IBookRepository
    {
        void AddNewBook(Book book);
        Task<List<Book>> GetAllBooksAsync();
        Book GetBookbyId(int bookId);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);
    }
}