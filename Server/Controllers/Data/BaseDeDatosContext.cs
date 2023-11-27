using ApiWeb3C.Shared.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cyber.Server.Data
{
    public class BasedeDatosContext : DbContext
    {
        public BasedeDatosContext(DbContextOptions<BasedeDatosContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
    }
}