using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoManejoFertilizantes
    {
        public int IdManejoFertilizantes{ get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public string? FechaCreacion { get; set; }
        public string? Fertilizante { get; set; }
        public string? Aplicacion { get; set; }
        public float Dosis { get; set; }
        public string? CultivoTratado { get; set; }
        public string? AccionesAdicionales { get; set; }
        public string? CondicionesAmbientales { get; set; }
        public string? Observaciones { get; set; }
        public int Estado { get; set; }

    }
}
