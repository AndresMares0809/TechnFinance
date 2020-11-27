using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finanzas.Models
{
    public class Movimiento
    {
        [Key]
        public Guid Id { set; get; }
        public short Type { set; get; }
        public decimal Monto { set; get; }
        public DateTime Fecha { set; get; }
        public Guid ClienteId { set; get; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { set; get; }
        public string Creador { set; get; }

    }
}
