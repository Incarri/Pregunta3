using Microsoft.EntityFrameworkCore;
using T2_DelCastillo_JoseMiguel.Models;
using System.Threading.Tasks;
using System.Linq;

namespace T2_DelCastillo_JoseMiguel.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}
