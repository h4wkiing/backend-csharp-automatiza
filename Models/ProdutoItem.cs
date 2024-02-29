using System.ComponentModel.DataAnnotations;

namespace automatizasistemas.Models;

public class ProdutoItem 
{
  public long Id {get; set;}
  [StringLength(100, MinimumLength =  3, ErrorMessage = "A descrição deve ter entre  3 e  100 caracteres.")]
  public string? Descricao { get; set; }
  [Range(0, double.MaxValue, ErrorMessage = "O preço de venda deve ser maior ou igual a zero.")]

  public float? PrecoVenda {get; set;}
  [Range(0, long.MaxValue, ErrorMessage = "O estoque deve ser maior ou igual a zero.")]
  public long Estoque {get; set;}
  public long MarcaId { get; set; }
  public string? Status { get; set; }
}