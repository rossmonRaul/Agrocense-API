using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoUsuarioAsignado
    {
        public string Identificacion { get; set; }
        public string? Correo { get; set; }
        public int idRol { get; set; }
        public int idEmpresa { get; set; }
        public int idFinca { get; set; }
        public int idParcela { get; set; }
        public string? Empresa { get; set; }
        public int Estado { get; set; }
        public string? NombreFinca { get; set; }
        public string? NombreParcela { get; set; }
    }
}
