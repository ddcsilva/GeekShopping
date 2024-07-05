﻿using GeekShopping.ProdutoAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProdutoAPI.Model;

[Table("produto")]
public class Produto : BaseEntity
{
    [Column("nome")]
    [Required]
    [StringLength(150)]
    public string Nome { get; set; } = string.Empty;

    [Column("preco")]
    [Required]
    [Range(1, 10000)]
    public decimal Preco { get; set; }

    [Column("descricao")]
    [StringLength(500)]
    public string? Descricao { get; set; }

    [Column("nome_categoria")]
    [StringLength(50)]
    public string? NomeCategoria { get; set; }

    [Column("url_imagem")]
    [StringLength(300)]
    public string? UrlImagem { get; set; }
}
