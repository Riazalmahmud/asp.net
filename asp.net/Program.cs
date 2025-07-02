var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.UseHttpsRedirection();
app.MapGet("/", () =>
{
    return "hello";
});

app.MapPost("/post", () =>
{
    return "hello post";
});
app.MapPut("/put", () =>
{
    return "hello put";
});

app.MapPut("/delete", () =>
{
    return "hello delete";
});

app.Run();
