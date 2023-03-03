using System.ComponentModel.DataAnnotations;

namespace grocery_store.Models;

public class Feature
{
	[Key]
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;

	public string Description { get; set; } = string.Empty;
}
