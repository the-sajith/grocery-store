using grocery_store.Data;
using grocery_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace grocery_store.Controllers;

[Route("[controller]")]
[ApiController]
public class GroceryStoreController : ControllerBase
{
	private readonly GroceryStoreDbContext _dbContext;
	public GroceryStoreController(GroceryStoreDbContext dbContext)
	{
		_dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
	}

	[Route("/products")]
	[HttpGet]
	public IEnumerable<Product> GetProducts()
	{
		return _dbContext.Products.ToList();
	}

	[Route("/features")]
	[HttpGet]
	public IEnumerable<Feature> GetFeatures() 
	{ 
	   return _dbContext.Features.ToList();
	}

	[Route("/categories")]
	[HttpGet]
	public IEnumerable<Category> GetCategories() 
	{ 
	   return _dbContext.Categories.ToList();	
	}
}
