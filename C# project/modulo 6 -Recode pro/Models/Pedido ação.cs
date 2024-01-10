using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RecodePro2023_Modulo_6.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Required]
        public int PedidoId { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        public int DiariasPedido { get; set; }

        [Required]
        [Column(TypeName = "float(10,2)")]
        public float ValorPedido { get; set; }

        [Required]
        public long ClienteCPF { get; set; }
        [JsonIgnore]
        public Cliente? Cliente { get; set; }

        [Required]
        public int PacoteId { get; set; }
        [JsonIgnore]
        public Pacote? Pacote { get; set; }
    }
}
