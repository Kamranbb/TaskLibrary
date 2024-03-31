

namespace Library.Helper.Exceptions
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException() { }
        public CapacityLimitException(string message) : base(message) { }
        public CapacityLimitException(string message, Exception ex ):base(message, ex) { }
    }
}
