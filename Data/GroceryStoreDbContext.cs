using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
namespace grocery_store.Data; 

public class GroceryStoreDbContext : DbContext
{
	public GroceryStoreDbContext(DbContextOptions options) 
		: base(options)
	{
		
	}

	public DbSet<Product> Products { get; set; }

	public DbSet<Feature> Features { get; set; }

	public DbSet<Category> Categories { get; set; }
}
