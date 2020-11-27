using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finanzas.Models
{
    public class Linea_de_Credito
    {
        [Key]
        public Guid Id { set; get; }
        public string NombrePaquete { set; get; }
        public decimal Interes { set; get; }
        public short Tasa { set; get; }
        public short Periodo { set; get; }
        public short Capitalizacion { set; get; }
        public int Credito { set; get; }
        public short Year { set; get; }
        public string Creador { set; get; }

    }
}
