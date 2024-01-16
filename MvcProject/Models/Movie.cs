using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [Display(Name = "Название фильма")]
    [Required(ErrorMessage = "Название фильма отсутствует")]
    [StringLength(60, MinimumLength = 2)]
    
    public string Title { get; set; }

    [Display(Name = "Дата просмотра")]
    [Required(ErrorMessage = "Дата введена неверно или отсутствует")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Жанр")]
    [StringLength(30)]
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "Цена")]
    [Required(ErrorMessage = "Цена введена неверно или отсутствует")]
    public decimal Price { get; set; }

    [Display(Name = "Ваше впечатление о фильме")]
    public string? Rating { get; set; }
}