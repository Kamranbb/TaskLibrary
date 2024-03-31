

using Library.Helper.Exceptions;
using System.Xml.Linq;
using TaskLibrary.Interfaces;
using NullReferenceException = Library.Helper.Exceptions.NullReferenceException;

namespace TaskLibrary.Entities
{
    internal class Book:IEntity
    {
      
        public  string Name   { get; set; }
        public string AuthorName { get; set; }   
        public int PageCount { get; set; }  
        public bool IsDeleted { get; set; }
        public Guid Id { get ; set ; }
        
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
           
        }
        public override string ToString()
        {
            return $"Name:{Name}, AuthorName:{AuthorName}, PageCount:{PageCount}";
        }
       

    }
}

