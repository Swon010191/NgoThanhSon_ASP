using System.ComponentModel.DataAnnotations;

namespace NgoThanhSon_Ngay6.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        //Nav
        public List<Genre> Genres { get; set; }

    }
}
