using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService()
        {
            productRepository = new ProductRepository();
        }
        public void DeleteProduct(Product product)
        {
            productRepository.DeleteProduct(product);
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public void SaveProduct(Product product)
        {
            productRepository.SaveProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}
