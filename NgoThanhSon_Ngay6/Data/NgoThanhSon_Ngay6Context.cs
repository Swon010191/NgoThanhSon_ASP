using Microsoft.EntityFrameworkCore;

public class NgoThanhSon_Ngay6Context(DbContextOptions<NgoThanhSon_Ngay6Context> options) : DbContext(options)
{
    public DbSet<NgoThanhSon_Ngay6.Models.Genre> Genre { get; set; } = default!;
    public DbSet<NgoThanhSon_Ngay6.Models.Movie> Movie { get; set; } = default!;
}
