using Matrix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Data
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ActorCommentary>()
            .HasKey(t => new { t.ActorId, t.CommentaryId });

            modelBuilder.Entity<ActorCommentary>()
                .HasOne(sc => sc.Actor)
                .WithMany(s => s.ActorCommentaries)
                .HasForeignKey(sc => sc.ActorId);

            modelBuilder.Entity<ActorCommentary>()
                .HasOne(sc => sc.Commentary)
                .WithMany(c => c.ActorCommentaries)
                .HasForeignKey(sc => sc.CommentaryId);


            modelBuilder.Entity<ActorCommentary>()
            .HasKey(t => new { t.ActorId, t.CommentaryId });

            modelBuilder.Entity<ActorCommentary>()
                .HasOne(sc => sc.Actor)
                .WithMany(s => s.ActorCommentaries)
                .HasForeignKey(sc => sc.ActorId);

            modelBuilder.Entity<ActorCommentary>()
                .HasOne(sc => sc.Commentary)
                .WithMany(c => c.ActorCommentaries)
                .HasForeignKey(sc => sc.CommentaryId);
        }

        public DbSet<Matrixx> Matrices { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<SubProcess> SubProcesses { get; set; }
        public DbSet<GroupManagement> GroupManagements { get; set; }
        public DbSet<UnitManagement> UnitManagements { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<ActorCommentary> ActorCommentaries { get; set; }
    }
}
