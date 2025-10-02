using Microsoft.EntityFrameworkCore;
using WebApplication1.Dtos;
using WebApplication1.Entities;

namespace WebApplication1.Mapping;

public static class GameMapping
{

    public static Game ToEntity(this CreatGameDto game)
    {
        return new Game()
        {
            Name = game.Name!,
            
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate

        };


    }


    public static GameDto ToDto(this Game game)
    {
        return new GameDto(
            game.Id,
            game.Name,
            game.Genre!.Name,
            game.Price,
            game.ReleaseDate
        );
    }


    public static GameDetailsDto ToDetailsDto(this Game game)
    {
        return new GameDetailsDto(
            game.Id,
            game.Name,
            game.GenreId,
            game.Price,
            game.ReleaseDate
        );
    }





}