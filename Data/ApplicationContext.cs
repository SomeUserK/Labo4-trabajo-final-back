using Microsoft.EntityFrameworkCore;
using Generador_ideas.Models;
using Generador_ideas.Models.User;
using Generador_ideas.Models.Idea;
using Generador_ideas.Models.InputParameter;
using Generador_ideas.Models.Favorite;
using Generador_ideas.Models.IdeaHistory;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Idea> Ideas { get; set; }
    public DbSet<InputParameter> InputParameters { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<IdeaHistory> IdeaHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=borwbhqkyfdrx6u0ybij-mysql.services.clever-cloud.com;Database=borwbhqkyfdrx6u0ybij;User=ul8vngh5lew2hmof;Password=Se4AJkr0zttWEZ35heWf;Port=3306;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración de la clave primaria compuesta para la entidad Favorite
        modelBuilder.Entity<Favorite>()
            .HasKey(f => new { f.UserId, f.IdeaId });

        // Configuración de relaciones
        modelBuilder.Entity<Idea>()
            .HasOne(i => i.User) // Relación con User
            .WithMany(u => u.Ideas) // Un User puede tener muchas Ideas
            .HasForeignKey(i => i.UserId);

        modelBuilder.Entity<InputParameter>()
            .HasOne(ip => ip.User) // Relación con User
            .WithMany(u => u.InputParameters) // Un User puede tener muchos InputParameters
            .HasForeignKey(ip => ip.UserId);

        modelBuilder.Entity<InputParameter>()
            .HasOne(ip => ip.Idea) // Relación con Idea
            .WithMany(i => i.InputParameters) // Una Idea puede tener muchos InputParameters
            .HasForeignKey(ip => ip.IdeaId);

        modelBuilder.Entity<IdeaHistory>()
            .HasOne(ih => ih.User) // Relación con User
            .WithMany(u => u.IdeaHistories) // Un User puede tener muchas IdeaHistories
            .HasForeignKey(ih => ih.UserId)
            .OnDelete(DeleteBehavior.Cascade); // Eliminar IdeaHistory si se elimina el User

        modelBuilder.Entity<IdeaHistory>()
            .HasOne(ih => ih.Idea) // Relación con Idea
            .WithMany(i => i.IdeaHistories) // Una Idea puede tener muchas IdeaHistories
            .HasForeignKey(ih => ih.IdeaId);

        modelBuilder.Entity<IdeaHistory>()
            .HasOne(ih => ih.InputParameter) // Relación con InputParameter
            .WithMany() // Un InputParameter puede tener muchas IdeaHistories
            .HasForeignKey(ih => ih.ParameterId);
    }

}
