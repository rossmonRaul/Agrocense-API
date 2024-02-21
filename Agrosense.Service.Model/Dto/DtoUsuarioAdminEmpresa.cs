using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoUsuarioAdminEmpresa
    {
        public string Identificacion { get; set; }
        public string? Correo { get; set; }
        public string Contrasena { get; set; }
        public int idEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public int Estado { get; set; }
    }
}
