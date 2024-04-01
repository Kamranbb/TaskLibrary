

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
       
        public int Id { get ; set ; }
        static int StaticId;

        
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            StaticId++;
            Id = StaticId;
        }
        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, AuthorName:{AuthorName}, PageCount:{PageCount}";
        }
       

    }
}

