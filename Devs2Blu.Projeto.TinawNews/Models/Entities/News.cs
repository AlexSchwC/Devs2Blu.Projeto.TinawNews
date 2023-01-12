using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.Projeto.TinawNews.Models.Entities
{
	public class News
	{
		public int Id { get; set; }

		[Required]
		public string? Title { get; set; }

		[Column(TypeName = "TEXT")]
		public string? Description { get; set; }

		[Required]
		public int? CategoryId { get; set; }

		public virtual Category? Category { get; set; }
	}
}
