

using Library.Helper.Exceptions;
using System.Net.Http.Headers;
using TaskLibrary.Interfaces;

namespace TaskLibrary.Entities
{
    internal class Library:IEntity
    {
        public Guid Id { get ; set; }
        public List<Book> Books { get; set; }
        public Library() 
        { 
            Books = new List<Book>();
        }
        public void AddBook(string name, string authorName, int pageCount)
        {
           if ( Books.Any(b => b.Name == name && !b.IsDeleted)) throw new AlreadyExistsException($"{name} adli kitab var");
            if (Books is null) throw new AlreadyExistsException("Null ola bilmez");
            Book books= new Book(name, authorName, pageCount);Books.Add(books);

        }
            public  List<Book> GetBook() => Books.FindAll(b => !b.IsDeleted);
    }
}
