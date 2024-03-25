using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoProductividadCultivo
    {
        public int? IdManejoProductividadCultivo { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public int Estado { get; set; }
        public string? Finca { get; set; }
        public string? Parcela { get; set; }
        public string? Cultivo { get; set; }
        public string? Temporada { get; set; }
        public decimal Area { get; set; }
        public decimal Produccion { get; set; }
        public decimal Productividad { get; set; }
        public string? NombreUsuario { get; set; }
    }
}
