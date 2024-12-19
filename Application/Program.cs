using Application;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Concert> concerts = new List<Concert>();
app.MapPost("/add-concert", async (HttpContext context) =>
{
    var form = await context.Request.ReadFormAsync();
    var name = form["name"];
    var venue = form["venue"];
    var date = form["date"];
    var concert = new Concert(name, venue, DateTime.Parse(date));
    concerts.Add(concert);
    return Results.Ok("/concert added");
}); app.MapGet("/", () => "Hello World!");

app.Run();
