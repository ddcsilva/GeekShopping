using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProdutoAPI.Model.Base;

public abstract class BaseEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
}
