using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexibleinventory
{
    /// <summary>
    /// TODO: Implement custom exception for inventory-specific errors
    /// </summary>
    public class InventoryException : Exception
    {
        // TODO: Add these constructors:
        // - Default constructor
        // - Constructor with message
        // - Constructor with message and inner exception
        // - Constructor with message and error code

        // TODO: Add ErrorCode property
        public int ErrorCode { get; set; }

        // TODO: Override Message property to include error code
        public InventoryException() :base() { }
        public InventoryException(string msg) :base(msg) { }
        public InventoryException(string msg, Exception Errocode) :base(msg, Errocode) { }
        public InventoryException(string msg, int Errorcode) :base($"{msg} with error code {Errorcode}") { }



    }

}
