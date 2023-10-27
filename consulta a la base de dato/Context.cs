using consulta_a_la_base_de_dato;
using Microsoft.EntityFrameworkCore;

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