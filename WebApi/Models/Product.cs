using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		[MinLength(3)]
		public string? Name { get; set; }

		[Required]
		[Range(10, 10000, ErrorMessage = "Price should be between 10 and 10000")]
		public decimal Price { get; set; }
	}
}
