using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryBookTracker.BLL
{
    public class BookService
    {
     public BookRepo _repo = new BookRepo();
       
        public IEnumerable<Book> GetBooks()
        {
            return _repo.GetAllBooks();
        }
     
        public Book GetBook(int id)
        {
            return _repo.GetBookById(id);
        }
        public void AddBook(Book book) => _repo.AddBook(book);
     
        public void UpdateBook(Book book)=>_repo.UpdateBook(book);

    

        public void RemoveBook(int id) => _repo.DeleteBook(id);

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }


        public List<Book> SearchBooksByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return new List<Book>(); 
            }

            return _repo.GetBooksByTitle(title); 
        }

        public object GetBooksByTitle(string title)
        {
            throw new NotImplementedException();
        }


    }
}

