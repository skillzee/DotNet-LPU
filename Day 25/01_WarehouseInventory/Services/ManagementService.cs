using System.Collections.Generic;
using System.Linq;
using Domain;
using Exceptions;

namespace Services
{
    public class ManagementService
    {
        private SortedDictionary<int, List<Product>> _data
            = new SortedDictionary<int, List<Product>>();

        private HashSet<string> _skuSet = new HashSet<string>();

        public void AddEntity(Product product)
        {
            if (_skuSet.Contains(product.SKU))
                throw new DuplicateSKUException("SKU already exists.");

            if (!_data.ContainsKey(product.Priority))
                _data[product.Priority] = new List<Product>();

            _data[product.Priority].Add(product);
            _skuSet.Add(product.SKU);
        }

        public void RemoveEntity(int id)
        {
            foreach (var key in _data.Keys.ToList())
            {
                var product = _data[key].FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    _data[key].Remove(product);
                    _skuSet.Remove(product.SKU);
                    break;
                }
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _data.SelectMany(x => x.Value);
        }

        public IEnumerable<Product> GetHighestPriorityProducts()
        {
            if (_data.Count == 0)
                return new List<Product>();

            int highestPriority = _data.Keys.First(); // Because SortedDictionary auto sorts
            return _data[highestPriority];
        }
    }
}
