using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiCasino.Entidades;

namespace WebApiCasino
{
    public class ApplicationDbContext : DbContext
        // : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ParticipanteRifaCarta>()
                .HasKey(al => new { al.idParticipante, al.idRifa, al.idCarta});
        }

        public DbSet <Carta> Cartas { get; set; }
        public DbSet <Participante> Participantes { get; set; }
        public DbSet<ParticipanteRifaCarta> ParticipanteRifaCarta { get; set; }
        public DbSet<Premio> Premios { get; set; }
        public DbSet<Rifa> Rifas { get; set; }
        public DbSet<TarjetaGanador> TarjetaGanadors { get; set; }
    }
}
