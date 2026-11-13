using System.ComponentModel.DataAnnotations;

namespace Bai3_Ngothanhson.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; } = string.Empty;
        //tham chieu toi product
        public List<Product> Products { get; set; }
    }
}
