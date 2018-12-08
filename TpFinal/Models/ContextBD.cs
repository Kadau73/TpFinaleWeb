using Microsoft.EntityFrameworkCore;
using TpFinal.Models;

namespace TpFinal.Models
{
    public partial class ContextBD : DbContext
    {
        public ContextBD()
        {
        }

        public ContextBD(DbContextOptions<ContextBD> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Organisateur> Organisateurs { get; set; }
        public virtual DbSet<MembreArticle> MembreArticles { get; set; }
        public virtual DbSet<Membre> Membres { get; set; }
        public virtual DbSet<Paiement> Paiements { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Spécialité> Spécialités { get; set; }
        public virtual DbSet<VersionArticle> VersionArticles { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MembreArticle>(entity =>
        //    {
        //        // https://docs.microsoft.com/en-us/ef/core/modeling/keys
        //        entity.HasKey(c => new { c.IdArticle, c.IdMembre });

        //        // https://docs.microsoft.com/en-us/ef/core/saving/cascade-delete
        //        entity.HasOne(d => d.IdArticleNavigation)
        //              .WithMany(p => p.MembreArticle)
        //              .HasForeignKey(d => d.IdArticle)
        //              .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(d => d.IdMembreNavigation)
        //              .WithMany(p => p.MembreArticle)
        //              .HasForeignKey(d => d.IdMembre)
        //              .OnDelete(DeleteBehavior.Restrict);
        //    });

        //    modelBuilder.Entity<Session>(entity =>
        //    {
        //        entity.HasKey(c => new { c.IdArticle, c.IdMembre });

        //        entity.HasOne(d => d.IdArticleNavigation)
        //              .WithMany(p => p.Session)
        //              .HasForeignKey(d => d.IdArticle)
        //              .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(d => d.IdMembreNavigation)
        //              .WithMany(p => p.Session)
        //              .HasForeignKey(d => d.IdMembre)
        //              .OnDelete(DeleteBehavior.Restrict);
        //    });
        //}
    }
}
// https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application
