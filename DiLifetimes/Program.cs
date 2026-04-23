var builder = WebApplication.CreateBuilder(args); // gives tool box to configure the app

builder.Services.AddSingleton(x => new SingletonDate());


var app = builder.Build(); // Takes Those configurations and constructs the app


app.MapGet("/", () =>
{

});

app.Run(); // Turns on the server so it can start accepting web traffic 


public class SingletonDate
{
    public DateTime Date { get; set; } = DateTime.Now;
}

public class TransientDate
{
    public DateTime Date { get; set; } = DateTime.Now;
}

public class ScopedDate
{
    public DateTime Date { get; set; } = DateTime.Now;
}