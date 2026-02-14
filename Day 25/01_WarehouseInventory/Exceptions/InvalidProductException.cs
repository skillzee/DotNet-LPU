namespace Exceptions
{
    public class InvalidProductException : InventoryException
    {
        public InvalidProductException(string message) : base(message) { }
    }
}
