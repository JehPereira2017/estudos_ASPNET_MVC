using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCNPJ.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Estabelecimento = new HashSet<Estabelecimento>();
            Municipio = new HashSet<Municipio>();
        }

        [Key]
        public int IdEstado { get; set; }
        [StringLength(2)]
        public string Sigla { get; set; }
        [StringLength(50)]
        public string Descricao { get; set; }

        [InverseProperty("IdEstadoNavigation")]
        public ICollection<Estabelecimento> Estabelecimento { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<Municipio> Municipio { get; set; }
    }
}
