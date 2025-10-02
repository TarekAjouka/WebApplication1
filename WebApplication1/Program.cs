using System.Collections;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Dtos;
using WebApplication1.Endpoints;


var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddDbContext<GameStoreContext>(options =>
{
    options.UseSqlServer(connString);
} );




var app = builder.Build();



app.MapGamesEndpoints();




app.Run();
