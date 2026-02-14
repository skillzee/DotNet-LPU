using System;

namespace Exceptions
{
    public class InventoryException : Exception
    {
        public InventoryException(string message) : base(message) { }
    }
}
