using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MerakiApplication.Usuario
{
    public class UsuarioIdentity : IdentityUser
    {
        public int idUsuario { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string Nombre { get; set; }
        public int IdRol { get; set; }
        public int IdEstado { get; set; }
    }
}
