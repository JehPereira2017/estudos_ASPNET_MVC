using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCNPJ.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Estabelecimento = new HashSet<Estabelecimento>();
        }

        [Key]
        [Column("id_categoria")]
        public int IdCategoria { get; set; }
        [Column("descricao_categoria")]
        [StringLength(20)]
        public string DescricaoCategoria { get; set; }

        [InverseProperty("IdCategoriaNavigation")]
        public ICollection<Estabelecimento> Estabelecimento { get; set; }
    }
}
