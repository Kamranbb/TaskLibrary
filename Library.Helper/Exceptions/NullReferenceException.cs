
namespace Library.Helper.Exceptions
{
    public class NullReferenceException:Exception
    {
        public NullReferenceException() { } 
        public NullReferenceException(string message):base (message) { }   
        public NullReferenceException (string message, Exception ex ) :base (message,ex ){ }    
    }
}
