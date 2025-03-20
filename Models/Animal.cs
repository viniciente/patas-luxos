using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatasLuxos.Models
{
    public class Animal
    {
        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [Column("TipoAnimal")]
        [Display(Name = "TipoAnimal")]
        public string TipoAnimal { get; set; } = string.Empty;


        [Column("NomeAnimal")]
        [Display(Name = "NomeAnimal")]
        public string NomeAnimal { get; set; } = string.Empty;

    }
}
