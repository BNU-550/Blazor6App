using System.ComponentModel.DataAnnotations;

namespace Blazor6App.Models
{
    public class Customer
    {
        public int Id { get; set; } = 1;

        [StringLength(20), Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(20), Required]
        public string Address { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
