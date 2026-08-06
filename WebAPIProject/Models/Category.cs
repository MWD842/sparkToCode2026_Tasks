using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAPIProject.Models
{
    public class Category
    {
        [Key]
        [JsonIgnore]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        // Relationship
        [JsonIgnore]
        public List<Product> Products { get; set; }
    }
}
