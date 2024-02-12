using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoUsuarioLogueado
    {
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public int idEmpresa { get; set; }
        public int idFinca { get; set; }
        public int idParcela { get; set; }
        public string Mensaje { get; set; }
    }
}
