using consulta_a_la_base_de_dato;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Context : DbContext
{

    public DbSet<EstudianteUNAB> Estudiante{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I6DQEF5\\SQLEXPRESS;Database=Program2;Trusted_Connection=True;");
        }
    }
}
