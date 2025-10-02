using System.ComponentModel.DataAnnotations;
using WebApplication1.Entities;

namespace WebApplication1.Dtos;

public record class CreatGameDto(
    [Required][StringLength(100)][MinLength(1)] string? Name,
    [Required] int GenreId,
    [Required] [Range(1,100)] decimal Price,
    DateOnly ReleaseDate);
