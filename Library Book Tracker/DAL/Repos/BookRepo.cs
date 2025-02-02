using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class BookRepo
    {
       public LibraryContext _context=new LibraryContext();

      
        public IEnumerable<Book> GetAllBooks()
        {
            using (var context = new LibraryContext())
            {
                return context.Books.ToList();
            }
        }

        public Book GetBookById(int id)
        {
            using (var context = new LibraryContext())
            {
                return context.Books.Find(id);
            }
        }

        public void AddBook(Book book)
        {
            using (var context = new LibraryContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
        public void UpdateBook(Book updatedBook)
        {
            using (var context = new LibraryContext())
            {
                var existingBook = context.Books.Find(updatedBook.Id);
                if (existingBook != null)
                {
                    existingBook.Title = updatedBook.Title;
                    existingBook.Author = updatedBook.Author;
                    existingBook.Genre = updatedBook.Genre;

                    context.SaveChanges();
                }
            }
        }


        public void DeleteBook(int id)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.Find(id);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }

        public List<Book> GetBooksByTitle(string title)
        {
            return _context.Books
                .Where(b => b.Title.ToLower().Contains(title.ToLower())) 
                .ToList();
        }


    }
}
