using System.ComponentModel.DataAnnotations;
namespace Blazor6App.Models
{
	public class ShoppingItem
	{
		public int Id { get; set; }
		
		[Required, StringLength(15, ErrorMessage ="Name should be less than 15 characters!")]
		public string Name { get; set; } = String.Empty;

		[Required, Range(0.01, 100)]
		public decimal Price { get; set; }

		[Required, Range(1, 10)]
		public int Quantity { get; set; } = 1;
	}
}
