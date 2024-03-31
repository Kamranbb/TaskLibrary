﻿

namespace Library.Helper.Exceptions
{
    internal class AlreadyExistsException:Exception
    {
        public AlreadyExistsException() { }
        public AlreadyExistsException(string message) : base(message) { }
        public AlreadyExistsException(string message,Exception ex ) : base(message,ex) { }  
    }
}
