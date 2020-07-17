using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCNPJ.Models
{
    public partial class Estabelecimento
    {
        [Key]
        [Column("id_estabelecimento")]
        public Guid IdEstabelecimento { get; set; }
        [Required(ErrorMessage = "Razão social obrigatório")]
        [Column("razaosocial")]
        [Display(Name ="Razão Social")]
        [StringLength(200)]
        public string Razaosocial { get; set; }
        [Column("nome_fantasia")]
        [StringLength(200)]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "CNPJ obrigatório")]
        [Column("cnpj")]
        [StringLength(20)]
        [Display(Name = "CNPJ")]
        [Remote("ValidarCnpj", "Estabelecimento",ErrorMessage ="CNPJ inválido")]
        public string Cnpj { get; set; }
        [Column("email")]
        [StringLength(100)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Column("data_cadastro", TypeName = "datetime")]
        [Display(Name = "Data cadastro")]
        public DateTime DataCadastro { get; set; }
        [Column("logradouro")]
        [StringLength(100)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }
        [Column("numero")]
        [StringLength(20)]
        [Display(Name = "Número")]
        public string Numero { get; set; }
        [Column("telefone")]
        [StringLength(20)]
        [Display(Name = "Telefone")]
        [Remote("ValidarTelefone", "Estabelecimento", ErrorMessage = "Telefone obrigatório para categoria 'Supermercado'", AdditionalFields =nameof(IdCategoria))]
        public string Telefone { get; set; }
        [Display(Name ="Estado")]
        [Column("id_estado")]
        public int? IdEstado { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> Estados { get; set; }
        [Column("id_cidade")]
        [Display(Name = "Cidade")]
        public int? IdCidade { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> Cidades { get; set; }
        [Column("agencia")]
        [StringLength(20)]
        [Display(Name = "Agência")]
        public string Agencia { get; set; }
        [Column("conta")]
        [StringLength(20)]
        [Display(Name = "Conta")]
        public string Conta { get; set; }
        [Column("id_categoria")]
        [Display(Name = "Categoria")]
        public int? IdCategoria { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> Categorias { get; set; }
        [Column("status_estabelecimento")]
        [Display(Name = "Status")]
        public int StatusEstabelecimento { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> Status { get; set; }

        [ForeignKey("IdCategoria")]
        [InverseProperty("Estabelecimento")]
        public Categoria IdCategoriaNavigation { get; set; }
        [ForeignKey("IdCidade")]
        [InverseProperty("Estabelecimento")]
        public Municipio IdCidadeNavigation { get; set; }
        [ForeignKey("IdEstado")]
        [InverseProperty("Estabelecimento")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("StatusEstabelecimento")]
        [InverseProperty("Estabelecimento")]
        public virtual Status StatusEstabelecimentoNavigation { get; set; }
    }
}
