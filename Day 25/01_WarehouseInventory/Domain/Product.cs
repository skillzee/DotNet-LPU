using Exceptions;

namespace Domain
{
    public abstract class Product : BaseEntity
    {
        public string SKU { get; private set; }
        public string Name { get; private set; }
        public int Stock { get; private set; }
        public int Priority { get; private set; }

        protected Product(int id, string sku, string name, int stock, int priority)
        {
            Id = id;
            SKU = sku;
            Name = name;
            Stock = stock;
            Priority = priority;

            Validate();
        }

        public void UpdateStock(int newStock)
        {
            if (newStock < 0)
                throw new InvalidProductException("Stock cannot be negative.");

            Stock = newStock;
        }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(SKU))
                throw new InvalidProductException("SKU cannot be empty.");

            if (Priority < 1 || Priority > 10)
                throw new InvalidProductException("Priority must be between 1 and 10.");

            if (Stock < 5)
                throw new LowStockException($"Stock too low for product {Name}.");
        }

        public override string ToString()
        {
            return $"{Name} | SKU: {SKU} | Stock: {Stock} | Priority: {Priority}";
        }
    }
}
