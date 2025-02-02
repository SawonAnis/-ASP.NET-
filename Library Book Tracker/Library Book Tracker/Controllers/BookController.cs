using LibraryBookTracker.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Models;

namespace LibraryBookTracker.Controllers
{




    public class BookController : ApiController
        {
       public BookService _service = new BookService();

        [HttpGet]
            [Route("api/books")]
        public HttpResponseMessage GetAllBooks()
        {
            var books = _service.GetBooks();
            return Request.CreateResponse(HttpStatusCode.OK, books);
        }

       
        [HttpGet]
            [Route("api/books/{id}")]
         
        public HttpResponseMessage GetBook(int id)
        {
            var book = _service.GetBook(id);
            return book == null
                ? Request.CreateResponse(HttpStatusCode.NotFound, "Book not found")
                : Request.CreateResponse(HttpStatusCode.OK, book);
        }
   
        [HttpPost]
            [Route("api/books")]
         
        public HttpResponseMessage AddBook([FromBody] Book book)
        {
            _service.AddBook(book);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
     
        [HttpPut]
            [Route("api/books/{id}")]

        public IHttpActionResult UpdateBook(int id, [FromBody] Book book)
        {
            if (book == null || book.Id != id)
            {
                return BadRequest("Book ID mismatch.");
            }

            var existingBook = _service.GetBook(id);
            if (existingBook == null)
            {
                return NotFound(); 
            }

            _service.UpdateBook(book);
            return Ok(book);
        }

  
        [HttpDelete]
            [Route("api/books/{id}")]
          
        public HttpResponseMessage DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

  

        [HttpGet]
        [Route("api/books/search/title/{title}")]
        
        public IHttpActionResult SearchBookByTitle(string title)
        {
            var books = _service.SearchBooksByTitle(title);
            return books == null || books.Count == 0 ? (IHttpActionResult)NotFound() : Ok(books);
        }


    }
}




