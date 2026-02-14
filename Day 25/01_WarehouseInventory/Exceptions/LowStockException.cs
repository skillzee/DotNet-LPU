namespace Exceptions
{
    public class LowStockException : InventoryException
    {
        public LowStockException(string message) : base(message) { }
    }
}
