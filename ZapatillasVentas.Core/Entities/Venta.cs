using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapatillasVentas.Core.Entities
{
    public class Venta
    {
        public int Id { get; set; }  
        public int ClienteId { get; set; } 
        public int ZapatillaId { get; set; }
        public DateTime FechaVenta { get; set; } 
        public decimal Total { get; set; } 
    }
}
