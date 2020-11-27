using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finanzas.Models;

namespace Finanzas.Models
{
    public class AppDbContext: IdentityDbContext<Bodeguero>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { set; get; }
        public DbSet<Linea_de_Credito> LineasDeCredito { set; get; }
        public DbSet<Finanzas.Models.Movimiento> Movimiento { get; set; }
    }
}
