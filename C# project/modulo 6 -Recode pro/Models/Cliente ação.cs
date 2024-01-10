using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecodePro2023_Modulo_6.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new Collection<Pedido>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CPF { get; set; }

        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DataNasc { get; set; }

        [Required]
        [StringLength(100)]
        public string? Email { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
