using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCNPJ.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Estabelecimento = new HashSet<Estabelecimento>();
        }

        [Key]
        public int IdMunicipio { get; set; }
        [StringLength(7)]
        public string CodigoIbge { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        public int? IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("Municipio")]
        public Estado IdEstadoNavigation { get; set; }
        [InverseProperty("IdCidadeNavigation")]
        public ICollection<Estabelecimento> Estabelecimento { get; set; }
    }
}
