using grocery_store.Data;
using Microsoft.EntityFrameworkCore;

namespace grocery_store;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
	
		// Add services to the container.

		builder.Services.AddControllers();

		builder.Services.AddEndpointsApiExplorer();

		builder.Services.AddDbContext<GroceryStoreDbContext>(options =>
		options.UseInMemoryDatabase("GroceryDatabase"));

		builder.Services.AddCors(options =>
		{
			options.AddPolicy("Cors Policy", builder =>
			{
				builder.AllowAnyOrigin();
				builder.AllowAnyMethod();
				builder.AllowAnyHeader();

			});

		});

		builder.Services.AddSwaggerGen();

		var app = builder.Build();

		CreateDbIfnotExists(app);

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();
		app.UseRouting();

		app.UseCors("Cors Policy");

		app.UseSwagger();

		app.UseSwaggerUI(options =>
		{
			options.DocumentTitle = "Grocery Document";
			options.SwaggerEndpoint("/swagger/v1/swagger.json", "Store API");
		});

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapControllers();
		});

		app.MapFallbackToFile("index.html");

		app.Run();


	}

	private static void CreateDbIfnotExists(WebApplication app)
	{
		using var scope = app.Services.CreateScope();

		var services = scope.ServiceProvider;

		try
		{
			var context = services.GetRequiredService<GroceryStoreDbContext>();

			DbInitializer.Initialize(context);
		}
		catch (Exception ex)
		{ 
		
		}

	}
}
