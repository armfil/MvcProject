using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;
using System.Collections.Generic;
namespace MvcProject.Models;
public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; } //список фильмов
    public SelectList? Genres { get; set; } //объект со списком жанров
    public string? MovieGenre { get; set; } //объект, содержащий выбранный жанр
    public string? SearchString { get; set; } //содержит текст, который пользователи вводят в поле поиска
}


