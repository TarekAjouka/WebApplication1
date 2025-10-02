namespace WebApplication1.Dtos;
using System.ComponentModel.DataAnnotations;


public record class UpdateGameDto(
        [Required][StringLength(100)][MinLength(1)] string? Name,
        [Required] int GenreId,
        [Required][Range(1, 100)] decimal Price,
        DateOnly ReleaseDate
    );

