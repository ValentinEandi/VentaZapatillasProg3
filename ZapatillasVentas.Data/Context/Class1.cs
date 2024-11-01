using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZapatillasVentas.Core.Entities;

namespace ZapatillasVentas.Data.Context
{
    public class ZapatillasVentasContext : DbContext
    {
        public DbSet<Zapatilla> Zapatillas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public ZapatillasVentasContext(DbContextOptions<ZapatillasVentasContext> options) : base(options) { }
    }
}
