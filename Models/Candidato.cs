using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aec_mvc_entity_framework.Models
{
    [Table("candidatos")]
    public class Candidato
    {
        [Key]
        [Column("id", Order = 1)]
        public int Id { get; set; }

        [Display(Name = "CPF:")]
        [Column("cpf", Order = 2)]
        [MaxLength(14)]
        [Required]
        public string Cpf { get; set; }

        [Display(Name = "Nome completo:")]
        [Column("nome", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Data de nascimento:")]
        [Column("nascimento", TypeName = "nvarchar")]
        [MaxLength(10)]
        [Required]
        public string Nascimento { get; set; }

        [Display(Name = "E-mail:")]
        [Column("email", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [Column("telefone", TypeName = "nvarchar")]
        [MaxLength(14)]
        [Required]
        public string Telefone { get; set; }

        [Display(Name = "Selecione uma vaga:")]
        [Column("profissaoId")]
        [ForeignKey("ProfissaoId")]
        [Required]
        public int ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }

        [Display(Name = "Logradouro:")]
        [Column("logradouro", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Logradouro { get; set; }

        [Display(Name = "Complemento:")]
        [Column("complemento", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Complemento { get; set; }

        [Display(Name = "Número:")]
        [Column("numero", TypeName = "nvarchar")]
        [MaxLength(5)]
        [Required]
        public string Numero { get; set; }

        [Display(Name = "Bairro:")]
        [Column("bairro", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Bairro { get; set; }

        [Display(Name = "Cidade:")]
        [Column("cidade", TypeName = "nvarchar")]
        [MaxLength(60)]
        [Required]
        public string Cidade { get; set; }

        [Display(Name = "CEP:")]
        [Column("cep", TypeName = "nvarchar")]
        [MaxLength(9)]
        [Required]
        public string Cep { get; set; }

        [Display(Name = "Estado:")]
        [Column("estado", TypeName = "nchar")]
        [MaxLength(2)]
        [Required]
        public string Estado { get; set; }

    }
}