var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapGet("/", () =>
{
    return "hello get api";
});

var product = new List<Product> {
    new Product ("samsung s20 ultra", 1055),
    new Product ("samsung ultra", 1055),
    new Product ("samsung", 1500)
};
app.MapGet("/get-product", () =>
{
   
    return Results.Ok(product);
});
app.MapPost("/post", () =>
{
    return "hello post api";
});
app.MapDelete("/post-delete", () =>
{
    return "hello  delete api";
});
app.UseHttpsRedirection();
app.Run();


public record Product(string name, decimal price);
