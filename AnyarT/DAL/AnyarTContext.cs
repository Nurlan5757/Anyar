using AnyarT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AnyarT.DAL
{
    public class AnyarTContext : DbContext
    {
        public AnyarTContext(DbContextOptions options) : base(options)
        {            
        }
         
        public DbSet<Slider>sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-8ABCEA9\\SQLEXPRESS;Database=AnyarT;Trusted_Connection=true;TrustServerCertificate=True");
            base.OnConfiguring(options);
        }
    }
}
