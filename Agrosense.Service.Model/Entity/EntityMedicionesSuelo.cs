using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityMedicionesSuelo
    {
        public int IdMedicionesSuelo { get; set; }
        public string? MedicionesCalidadSuelo { get; set; }
        public decimal RespiracionSuelo { get; set; }
        public decimal Infiltracion { get; set; }
        public decimal DensidadAparente { get; set; }
        public decimal ConductividadElectrica { get; set; }
        public decimal pH { get; set; }
        public decimal NitratosSuelo { get; set; }
        public decimal EstabilidadAgregados { get; set; }
        public decimal Desleimiento { get; set; }
        public int Lombrices { get; set; }
        public string? Observaciones { get; set; }
        public decimal CalidadAgua { get; set; }
        public string? IdentificacionUsuario { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
    }
}
