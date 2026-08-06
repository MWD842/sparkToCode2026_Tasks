using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAPIProject.Models
{
    public class Product
    {
        [Key]
        [JsonIgnore]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        //Relationship
        [ForeignKey("_category")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category _category { get; set; }

    }
}
