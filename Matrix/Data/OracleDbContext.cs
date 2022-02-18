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


            modelBuilder.Entity<Matrixx>().HasData(
                new { MatrixId = 1, MatrixName = "Coal Capex Matrix" },
                new { MatrixId = 1, MatrixName = "Steel Capex Matrix" });

            modelBuilder.Entity<Process>().HasData(
                new { ProcessId = 1, MatrixId = 1, ProcessName = "Annual Capex" },
                new { ProcessId = 2, MatrixId = 1, ProcessName = "Approval of projects, approval of additional funds when overrun of approved project cost is 10% or 2.0 M$" },
                new { ProcessId = 3, MatrixId = 1, ProcessName = "Budget redistribution between projects" },
                new { ProcessId = 4, MatrixId = 1, ProcessName = "Approval of additional funds in the approved projects within total approved cost +10%, when the change cost is" },
                new { ProcessId = 5, MatrixId = 1, ProcessName = "Decisions of Investment Committee" });

            modelBuilder.Entity<SubProcess>().HasData(
                new { SubProcessId = 1, ProcessId = 1, MatrixName = "Business Plan" },

                new { SubProcessId = 2, ProcessId = 2, MatrixName = ">$150M" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = ">$40M & <=$150M" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = "Coal Capex Matrix" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = "Coal Capex Matrix" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = "Coal Capex Matrix" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = "Coal Capex Matrix" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = "Coal Capex Matrix" },
                new { SubProcessId = 2, ProcessId = 2, MatrixName = "Coal Capex Matrix" },

                new { SubProcessId = 2, ProcessId = 3, MatrixName = "Redistributions within allocate budget (normative capex)" },
                new { SubProcessId = 2, ProcessId = 3, MatrixName = "Redistributions within allocate budget (strategic capex)" },
                new { SubProcessId = 2, ProcessId = 3, MatrixName = "Additional fund due to KZT overruns in foreign currency contracts" },
                new { SubProcessId = 2, ProcessId = 3, MatrixName = "Additional fund due to USD savings in KZT contracts" },


                new { SubProcessId = 2, ProcessId = 4, MatrixName = "Additional fund due to USD savings in KZT contracts" },
                new { SubProcessId = 2, ProcessId = 4, MatrixName = "Additional fund due to USD savings in KZT contracts" },
                new { SubProcessId = 2, ProcessId = 4, MatrixName = "Additional fund due to USD savings in KZT contracts" },
                new { SubProcessId = 2, ProcessId = 4, MatrixName = "Additional fund due to USD savings in KZT contracts" },

                new { SubProcessId = 2, ProcessId = 5, MatrixName = "Additional fund due to USD savings in KZT contracts" });
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
