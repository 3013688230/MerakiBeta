using MerakiApplication.Usuario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerakiApplication.Entities
{
    public class MerakiContext : DbContext
    {
        public MerakiContext()
        {
        }

        public MerakiContext(DbContextOptions<MerakiContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioIdentity> UsuariosIdentity { get; set; }
    }
}
