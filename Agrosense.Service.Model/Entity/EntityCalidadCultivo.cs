using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityCalidadCultivo
    {
        public int? IdManejoCalidadCultivo { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public string? UsuarioCreacionModificacion { get; set; }
        public string? FechaCreacion { get; set; }
        public string? Cultivo { get; set; }
        public string? Hora { get; set; }
        public int Lote { get; set; }
        public int Calidad { get; set; }
        public decimal PesoTotal { get; set; }
        public decimal PesoPromedio { get; set; }
        public string? Observaciones { get; set; }
    }
}
