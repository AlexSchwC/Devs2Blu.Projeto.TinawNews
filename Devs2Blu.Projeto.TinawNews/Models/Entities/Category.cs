using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.Projeto.TinawNews.Models.Entities
{
	public class Category
	{
		public int Id { get; set; }

		[Required]
		public string? Name { get; set; }
	}
}
