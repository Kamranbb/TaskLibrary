

using System.Xml.Linq;
using TaskLibrary.Interfaces;

namespace TaskLibrary.Entities
{
    internal class Book:IEntity
    {
      
        public  string Name   { get; set; }
        public string AuthorName { get; set; }   
        public int PageCount { get; set; }  
        public bool IsDeleted { get; set; }
        public Guid Id { get ; set ; }
        List<Book> Books { get; set;  }
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Books = new List<Book>();
        }
        public override string ToString()
        {
            return $"Name:{Name}, AuthorName:{AuthorName}, PageCount:{PageCount}";
        }
         public void  AddBook (string name ,string authorName, int pageCount)
        {
            if (Books.FindAll(b => b.Name == name && !b.IsDeleted))
            {
                throw new AlreadyException($"{name} adli kitab var ");
            }
        }

    }
}

