using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityUsuario
    {
        public int idUsuario { get; set; }
        public  string? Identificacion { get; set; }
        public string? Correo { get; set; }
        public string? Contrasena { get; set; }
        public int idRol { get; set; }
        public int idEmpresa { get; set; }
        public int idFinca { get; set; }
        public int idParcela { get; set; }
        public int Estado { get; set; }
    }
}
