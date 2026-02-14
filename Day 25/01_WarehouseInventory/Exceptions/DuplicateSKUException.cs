namespace Exceptions
{
    public class DuplicateSKUException : InventoryException
    {
        public DuplicateSKUException(string message) : base(message) { }
    }
}
