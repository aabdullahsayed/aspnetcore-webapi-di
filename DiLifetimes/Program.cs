var builder = WebApplication.CreateBuilder(args); // gives tool box to configure the app


var app = builder.Build(); // Takes Those configurations and constructs the app


app.Run(); // Turns on the server so it can start accepting web traffic 

