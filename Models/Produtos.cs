using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatasLuxos.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Column("Id")]
        [Display(Name = "Id do Estabelecimento")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome:")]
        public string Nome { get; set; } = string.Empty;

        [Column("Descricao")]
        [Display(Name = "Descrição:")]
        public string Descricao { get; set; } = string.Empty;

        [Column("Preco")]
        [Display(Name = "Preço")]
        public string Preco { get; set; } = string.Empty;
    }
}
