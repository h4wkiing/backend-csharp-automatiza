using System.ComponentModel.DataAnnotations;

namespace automatizasistemas.Models;

public class MarcaItem
{
    public long Id { get; set; }
    [StringLength(100, MinimumLength =  3, ErrorMessage = "A descrição deve ter entre  3 e  100 caracteres.")]
    public string? Descricao { get; set; }
    public string? Status { get; set; }
}