using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finanzas.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { set; get; }
        [StringLength(8)]
        public string DNI { set; get; }
        public string Direccion { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        [ForeignKey("CreditoId")]
        public Linea_de_Credito Credito { set; get; }
        public string Creador { set; get; }

        public Guid CreditoId { set; get; }
        public List<Movimiento> Movimientos { set; get; }
    }
}
