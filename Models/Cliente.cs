using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatasLuxos.Models
{
    [Table("Cliente")]
    public class Cliente
    {
       
            [Column("Id")]
            [Display(Name = "Código")]
            public int Id { get; set; }

            [Column("Nome")]
            [Display(Name = "Nome")]
            public string Nome { get; set; } = string.Empty;

            [Column("Cpf")]
            [Display(Name = "Cpf")]
            public string Cpf { get; set; } = string.Empty;

            [Column("DataNascimento")]
            [Display(Name = "Data de Nascimento")]
            public string DataNascimento { get; set; } = string.Empty;

            [Column("Email")]
            [Display(Name = "Email")]
            public string Email { get; set; } = string.Empty;

            [Column("Numero de Contato")]
            [Display(Name = "Numero de Contato")]
            public string NumeroContato { get; set; } = string.Empty;

            [Column("Tipo dE Usuario")]
            [Display(Name = "Tipo e Usuario")]
            public bool TipoUsuario { get; set; }

            [Column("Senha")]
            [Display(Name = "Senha")]
            public bool Senha { get; set; }
    }
}
