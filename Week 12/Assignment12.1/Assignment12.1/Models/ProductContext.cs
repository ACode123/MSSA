using Microsoft.EntityFrameworkCore;
namespace Assignment12._1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : 
            base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Vintage Coogi Sweater",
                    Description = "Rare vintage coogi sweater. Dress like Biggie",
                    Price = 200.00M,
                    ImageName = "3.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "2018 Jordan 11 Concord",
                    Description = "Only one shoe. You don't get the pair.",
                    Price = 150.00M,
                    ImageName = "One Shoe.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Some Dove Dish Soap",
                    Description = "Most of it is still left!",
                    Price = 5.00M,
                    ImageName = "Used Soap.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Chief Keef Finally Rich Vinyl",
                    Description = "Vinyl me Please exclusive. Silver. First time on vinyl, full of bangers.",
                    Price = 75.00M,
                    ImageName = "FR Vinyl.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Kanye West Jesus is King Cassette",
                    Description = "Blue cassette. Great gospel album from the best artist of the millenium.",
                    Price = 40.00M,
                    ImageName = "JIK Cassette.jpg"
                });
        }
    }
}
