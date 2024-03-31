

namespace Library.Helper.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException() { }
        public CapacityLimitException(string message) : base(message) { }
        public CapacityLimitException(string message, Exception ex ):base(message, ex) { }
    }
}
