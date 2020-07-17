using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCNPJ.Models
{
    public partial class Status
    {
        public Status()
        {
            Estabelecimento = new HashSet<Estabelecimento>();
        }

        [Key]
        [Column("id_status")]
        public int IdStatus { get; set; }
        [Column("descricao_status")]
        [StringLength(10)]
        public string DescricaoStatus { get; set; }

        [InverseProperty("StatusEstabelecimentoNavigation")]
        public ICollection<Estabelecimento> Estabelecimento { get; set; }
    }
}
