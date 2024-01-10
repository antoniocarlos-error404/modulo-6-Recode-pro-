using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecodePro2023_Modulo_6.Models
{
    [Table("Pacotes")]
    public class Pacote
    {
        public Pacote()
        {
            Pedidos = new Collection<Pedido>();
        }

        [Key]
        public int PacoteId { get; set; }

        [Required]
        public string? Destino { get; set; }

        [Required]
        [Column(TypeName = "float(10,2)")]
        public float ValorDiaria { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
