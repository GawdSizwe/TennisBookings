using BrandedProducts.Api.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var products = new List<ProductOutputModel>
{
	new ProductOutputModel
	{
		Name = "ProTech Racket",
		Description = "The best racket on the market today! Never miss a shot.",
		Price = 3750.00
	},

	new ProductOutputModel
	{
		Name = "Yellow Spheres",
		Description = "Performance tennis balls with fantastic durability.",
		Price = 395.00
	},

	new ProductOutputModel
	{
		Name = "Go-faster Shorts",
		Description = "Never be late to the ball again with our patented go-faster fabric technology.",
		Price = 1150.00
	}
};

//app.Use(async (context, next) =>
//{
//	// This is not a secure way to do this - demoware only!
//	if (context.Request.Headers["ApiKey"] != "SUPERSECRETKEY")
//	{
//		context.Response.StatusCode = StatusCodes.Status401Unauthorized;
//		return;
//	}

//	await next.Invoke();
//});

app.MapGet("/api/products", () =>
{
	return new ProductsResultOutputModel
	{
		Products = products
	};
});

app.Run();
