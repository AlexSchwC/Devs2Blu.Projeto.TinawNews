using Devs2Blu.Projeto.TinawNews.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.Projeto.TinawNews.Models
{
	public class NewsDbContext : DbContext
	{
		public NewsDbContext(DbContextOptions<NewsDbContext> options) 
			: base (options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
				.HasData
				(
					new { Id = 1, Name = "Brasil" },
					new { Id = 2, Name = "Mundo" },
					new { Id = 3, Name = "Economia" },
					new { Id = 4, Name = "Esportes" },
					new { Id = 5, Name = "Cultura" },
					new { Id = 6, Name = "Blumenau" }
				);

			base.OnModelCreating(modelBuilder);
		}

		#region DbSets

		public DbSet<News> News { get; set; }
		public DbSet<Category> Category { get; set; }

		#endregion
	}
}
