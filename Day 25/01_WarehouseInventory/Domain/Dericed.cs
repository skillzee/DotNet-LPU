namespace Domain
{
    public class Electronics : Product
    {
        public Electronics(int id, string sku, string name, int stock, int priority)
            : base(id, sku, name, stock, priority) { }
    }

    public class Perishable : Product
    {
        public Perishable(int id, string sku, string name, int stock, int priority)
            : base(id, sku, name, stock, priority) { }
    }

    public class FragileItem : Product
    {
        public FragileItem(int id, string sku, string name, int stock, int priority)
            : base(id, sku, name, stock, priority) { }
    }
}
