using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment12._1.Models
{
    public class Product
    {
        //step 1 create product model class
        [Display(Name = "Product ID")]
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Product Name")]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string ImageName { get; set; }
    }
}
