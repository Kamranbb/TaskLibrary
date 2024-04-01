

using Library.Helper.Exceptions;
using System.Net.Http.Headers;
using TaskLibrary.Interfaces;
using NullReferenceException = Library.Helper.Exceptions.NullReferenceException;

namespace TaskLibrary.Entities
{
    internal class Library : IEntity
    {
        public int Id { get; set; } 
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(string name, string authorName, int pageCount)
        {
            if (Books.Any(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && !b.IsDeleted)) 
                throw new AlreadyExistsException($"{name} adli kitab var");
            if (Books is null) throw new AlreadyExistsException("Null ola bilmez");
            Book books = new(name, authorName, pageCount); Books.Add(books);

        }
        public List<Book> GetBook() => Books.FindAll(b => !b.IsDeleted); 
        
        public void GetBookById ( int ? id )
        {
            if (id is null) throw new NullReferenceException("Id null ola bilmez ");
            if (Books.Any(b => b.Id == id && !b.IsDeleted)) throw new AlreadyExistsException($"{id}idli kitab movcud deyil");
            var existBook = Books.Find(b => b.Id == id && !b.IsDeleted);
           }

    }
}
