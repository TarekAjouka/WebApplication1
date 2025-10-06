
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Dtos;
using WebApplication1.Entities;
using WebApplication1.Mapping;

namespace WebApplication1.Endpoints;

public static class GamesEndpoints
{
    
    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("games");
        //GET /games
        group.MapGet("/", (GameStoreContext dbContext) => dbContext.Games.Include(game=>game.Genre).Select(game => game.ToDto()).AsNoTracking());

        //GET /games/{id}
        group.MapGet("/{id}", (int id,GameStoreContext dbContext) =>
        {

            var game = dbContext.Games.Find(id);
            
            return game is null ? Results.NotFound() : Results.Ok(game.ToDetailsDto());


        }).WithName("GetGame");

        //POST /games
        group.MapPost("/", (CreatGameDto newGame,GameStoreContext dbContext) => {

           
            if (dbContext.Games.Any(game => string.Equals(game.Name, newGame.Name)))
            {
                return Results.BadRequest($"Game with name '{newGame.Name}' already exists.");
            }

            Game game = newGame.ToEntity();
            
            game.Genre = dbContext.Genres.Find(newGame.GenreId);

            dbContext.Games.Add(game);
            dbContext.SaveChanges();

            

            return Results.CreatedAtRoute("GetGame", new { id = game.Id }, game.ToDto());
        }).WithParameterValidation();


        //PUT /games/{id}

        group.MapPut("/{id}", (int id, CreatGameDto updatedGame,GameStoreContext dbContext) =>
        {
            var game = dbContext.Games.Find(id);

            if (game == null) return Results.NotFound();

            if (dbContext.Games.Any(g => g.Name == updatedGame.Name && g.Id != id))
                return Results.BadRequest($"Game with name '{updatedGame.Name}' already exists.");

            dbContext.Entry(game).CurrentValues.SetValues(updatedGame.ToEntity());

            dbContext.SaveChanges();
            return Results.NoContent();


        }).WithParameterValidation();

        //DELETE /games/{id}

        group.MapDelete("/{id}", (int id,GameStoreContext dbContext) =>
        {
            dbContext.Games.Where(game => game.Id == id).ExecuteDelete();
            dbContext.SaveChanges();
            return Results.NoContent();
        });

        return group;
    }
}

