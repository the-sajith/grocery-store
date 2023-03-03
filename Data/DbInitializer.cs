using grocery_store.Models;
using System.Text.Json;

namespace grocery_store.Data;

public static class DbInitializer
{
	public static void Initialize(GroceryStoreDbContext context)
	{ 
	
		context.Database.EnsureCreated();

		if (context.Products.Any())
		{
			return;
		}

		var products = new List<Product>()
		{
		  new Product
		  {
			Name= "Fresh Orange",
			 NoOfStars = 4,
			  Price = 50
		  },
		  new Product
		  {
			Name= "Fresh Orange",
			 NoOfStars = 4,
			  Price = 50
		  },
		  new Product
		   {
			Name= "Fresh Orange",
			 NoOfStars = 4,
			  Price = 50
		  },
		  };


		context.Products.AddRange(products);
		

		var categories = new List<Category>()
		{
			new Category{
				 Id = 1,
				 Type = "Vegetables",
				  Discount = "Upto 50% off",
			},
			new Category{
				 Id = 2,
				 Type = "Fresh Fruits",
				  Discount = "Upto 25% off",
			},
			new Category{
				 Id = 3,
				 Type = "Dairy Products",
				  Discount = "Upto 30 % off",
			},
			
		};

		context.Categories.AddRange(categories);

		var features = new List<Feature>()
		{
		   new Feature
		   {
			   Id  = 1,
				Description = "Lorem Ipsum Dolor Sit Amet Consectetur, Adipisicing Elit, Quis!",
				 Name = "Fresh And Organic",

		   },
		   new Feature
		   {
			   Id  = 2,
				Description = "Lorem Ipsum Dolor Sit Amet Consectetur, Adipisicing Elit, Quis!",
				 Name = "Free Delivery",

		   },
		   new Feature
		   {
			   Id  = 3,
			   Description = "Lorem Ipsum Dolor Sit Amet Consectetur, Adipisicing Elit, Quis!",
			   Name = "Easy Payment",

		   }

		};

		context.Features.AddRange(features);	
		context.SaveChanges();
	}
}
