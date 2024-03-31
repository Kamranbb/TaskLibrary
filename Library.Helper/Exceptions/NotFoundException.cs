
namespace Library.Helper.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException() { }  
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string meesage,Exception ex ): base(meesage,ex) { }
    }
}
