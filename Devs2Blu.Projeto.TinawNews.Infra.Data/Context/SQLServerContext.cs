using Devs2Blu.Projeto.TinawNews.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.TinawNews.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            modelBuilder.Entity<Category>()
                .HasData(
                new { Id = 1, Name = "Destaque" },
                new { Id = 2, Name = "Programação" },
                new { Id = 3, Name = "Economia" },
                new { Id = 4, Name = "Brasil" },
                new { Id = 5, Name = "Mundo" },
                new { Id = 6, Name = "Jogos" }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets

        public DbSet<Category> Category { get; set; }
        public DbSet<News> News { get; set; }

        #endregion

    }
}
