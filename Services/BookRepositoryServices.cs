///***********************************************************
//This the Service Class 
//This class is implementaion of IBookRepository Interface.
// this class allow to Access the List<Book> in whole app.  
///***********************************************************

using BookStoreApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Services
{
    public class BookRepositoryServices :IBookRepository
    {
        // Declaration of List of model class Book
        private readonly List<Book> _bookList;
        /// <summary>
        /// In the Constructor Inrtializing the list with Book Object book1 and book2
        /// /// </summary>
        public BookRepositoryServices()
        {
            _bookList = new List<Book>();
            //intialize the bookId by increasing Id

            Book book1 = new Book
            {
                BookName = "Software Engineering",
                BookAuthor = "Ian Sommerville",
                Quantity = 1,
                Rating = 3.5,
                LibraryClassification="000.005"
            };
            Book book2 = new Book
            {          
                BookName = "The C Programming Language",
                BookAuthor = "Brian Kernighan , Dennis Ritchie",
                Quantity = 10,
                Rating = 4.4,
                LibraryClassification = "000.005"

            };
            _bookList = new List<Book> { book1, book2 };
        }
        /// <summary>
        ///this method call in Onintialized method of components to get initial data
        /// </summary>
        /// <returns> List of Book class</returns>
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return _bookList;
        }

        /// <summary>
        /// THis method Execute for Edit and Delete function
        /// to get the requested Book 
        /// </summary>
        /// <param name="bookId">get from Component class</param>
        /// <returns>requested book data using SingleOrDefault method </returns>
        public Book GetBookbyId(int bookId)
        {
            return _bookList.SingleOrDefault(i => i.BookId == bookId);
        }

        /// <summary>
        /// Execute the Create Function
        /// Add the Book data in the List as per the user request
        /// if Book is new then it add in List 
        /// id its not then it update the existing data
        /// </summary>
        /// <param name="book">getting from AddBook Component</param>
        /// <returns></returns>
        public void AddNewBook(Book newbook)
        {
            //intialize the bookId by increasing Id
            
            Book getNewBook= _bookList.SingleOrDefault(i => i.BookName == newbook.BookName && i.BookAuthor==newbook.BookAuthor);
            if (getNewBook == null)
            {
                
                _bookList.Add(newbook);
            }
            else
            {
                getNewBook.BookAuthor = newbook.BookAuthor;
                getNewBook.Rating = newbook.Rating;
                getNewBook.LibraryClassification = newbook.LibraryClassification;
                getNewBook.Quantity = getNewBook.Quantity + newbook.Quantity;

            }

        }
        /// <summary>
        /// Delete the selected book from the table 
        /// </summary>
        /// <param name="id">get from Books Component</param>
        public void DeleteBook(int id)
        {
            //removeBook : store the requested book and use it to remove from list
            Book removeBook = GetBookbyId(id);
            _bookList.Remove(removeBook);
        }
        /// <summary>
        /// This method replaced the old data with new data in same record
        /// /// </summary>
        /// <param name="editedBookData"> getting from UpdateBook Component</param>
        public void UpdateBook(Book editedBookData)
        {
            Book oldbook = GetBookbyId(editedBookData.BookId);
            if (oldbook.BookId == editedBookData.BookId)
            {
                oldbook.BookName = editedBookData.BookName;
                oldbook.BookAuthor = editedBookData.BookAuthor;
                oldbook.Rating = editedBookData.Rating;
                oldbook.LibraryClassification = editedBookData.LibraryClassification;
            }
        }  
    }
}

