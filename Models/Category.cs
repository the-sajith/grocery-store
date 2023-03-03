using System.ComponentModel.DataAnnotations;

namespace grocery_store.Models;

public sealed class Category
{
	[Key]
	public int Id { get; set; }

	public string Type { get; set; } = string.Empty;

	public string Discount { get; set; } = string.Empty;
}
