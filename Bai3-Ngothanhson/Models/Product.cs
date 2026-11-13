using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai3_Ngothanhson.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Phai co ten")]
        [StringLength(100)]
        public string Name { get; set; }
        [Range(1,100000,ErrorMessage ="Gia ca phai thuc te va hop ly")]
        public int Price { get; set; }
        public string Description {  get; set; }
        //khoa ngoai
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        //doi tuong tham chieu
        public Category? Category { get; set; } 
    }
}
