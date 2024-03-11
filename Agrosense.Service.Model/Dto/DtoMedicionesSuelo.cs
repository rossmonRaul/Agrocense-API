using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoMedicionesSuelo
    {
        public int IdMedicionesSuelo { get; set; }
        public string MedicionesCalidadSuelo { get; set; }
        public decimal RespiracionSuelo { get; set; }
        public decimal Infiltracion { get; set; }
        public decimal DensidadAparente { get; set; }
        public decimal ConductividadElectrica { get; set; }
        public decimal pH { get; set; }
        public decimal NitratosSuelo { get; set; }
        public decimal EstabilidadAgregados { get; set; }
        public decimal Desleimiento { get; set; }
        public int Lombrices { get; set; }
        public string Observaciones { get; set; }
        public decimal CalidadAgua { get; set; }
        public string Usuario { get; set; }
        public string Finca { get; set; }
        public string Parcela { get; set; }
        public int Estado { get; set; }
    }
}
