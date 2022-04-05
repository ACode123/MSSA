using System.Collections.Generic;
namespace Assignment12._1.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(int? id)
        {
            var prd = Products.Find(x => x.Id == id);
            Products.Remove(prd);
        }

        public Product GetProduct(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return Products.Find(x => x.Id == id);
            }
        }


        public IEnumerable<Product> InitializeProducts()
        {
            return Products;
        }

        public ProductRepository()
        { 
            Products= new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Vintage Coogi Sweater",
                    Description = "Rare vintage coogi sweater. Dress like Biggie",
                    Price = 200.00M,
                    ImageName = "3.jpg"
                },
                new Product()
                {
                    Id = 2,
                    Name = "2018 Jordan 11 Concord",
                    Description = "Only one shoe. You don't get the pair.",
                    Price = 150.00M,
                    ImageName = "One Shoe.jpg"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Some Dove Dish Soap",
                    Description = "Most of it is still left!",
                    Price = 5.00M,
                    ImageName = "Used Soap.jpg"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Chief Keef Finally Rich Vinyl",
                    Description = "Vinyl me Please exclusive. Silver. First time on vinyl, full of bangers.",
                    Price = 75.00M,
                    ImageName = "FR Vinyl.jpg"
                },
                new Product()
                {
                    Id = 5,
                    Name = "Kanye West Jesus is King Cassette",
                    Description = "Blue cassette. Great gospel album from the best artist of the millenium.",
                    Price = 40.00M,
                    ImageName = "JIK Cassette.jpg"
                }
            };
            
        }

        public void UpdateProduct(Product product)
        {
            var prod=GetProduct(product.Id);
            if(prod!=null)
            {
                prod.Id = product.Id;
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.Price = product.Price;
                prod.ImageName = product.ImageName;
                
            }
        }
    }
}
