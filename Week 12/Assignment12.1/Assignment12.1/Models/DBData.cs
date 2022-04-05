using System.Collections.Generic;
namespace Assignment12._1.Models
{
    public class DBData : IProductRepository
    {
        public List<Product> Products { get; set; }
        private ProductContext _productContext;
        public DBData(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void AddProduct(Product product)
        {
            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public void DeleteProduct(int? id)
        {
            var prd = _productContext.Products.Find(id);
            _productContext.Products.Remove(prd);
            _productContext.SaveChanges();
        }

        public Product GetProduct(int? id)
        {
            return _productContext.Products.Find(id);
        }

        public IEnumerable<Product> InitializeProducts()
        {
            return _productContext.Products;
        }

        public void UpdateProduct(Product product)
        {
           Product prod=_productContext.Products.Find(product.Id);
            if (prod != null)
            {
                prod.Id = product.Id;
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.Price = product.Price;
                prod.ImageName= product.ImageName;
                _productContext.SaveChanges();
            }
        }
    }
}
