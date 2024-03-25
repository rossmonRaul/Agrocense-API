using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoRotacionCultivos
    {
        public int? IdRotacionCultivoSegunEstacionalidad { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public string? Cultivo { get; set; }
        public string? EpocaSiembra { get; set; }
        public string? TiempoCosecha { get; set; }
        public string? CultivoSiguiente { get; set; }
        public string? EpocaSiembraCultivoSiguiente { get; set; }
        public int Estado { get; set; }
        public string? Finca { get; set; }
        public string? Parcela { get; set; }
    }
}
