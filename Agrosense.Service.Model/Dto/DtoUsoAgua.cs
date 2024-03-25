using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{

    //este es quien devuelve los datos desde la base de datos a la api
    public class DtoUsoAgua
    {
        public int? IdRegistroSeguimientoUsoAgua { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public string? Fecha { get; set; }
        public string? Actividad { get; set; }
        public string? UsuarioCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public float Caudal { get; set; }
        public float ConsumoAgua { get; set; }
        public string? Observaciones { get; set; }
        public int Estado { get; set; }

    }
}
