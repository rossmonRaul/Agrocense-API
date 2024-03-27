using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityEficienciaRiego
    {
        public int IdMonitoreoEficienciaRiego { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public decimal VolumenAguaUtilizado { get; set; }
        public int EstadoTuberiasYAccesorios { get; set; }
        public int UniformidadRiego { get; set; }
        public int EstadoAspersores { get; set; }
        public int EstadoCanalesRiego { get; set; }
        public decimal NivelFreatico { get; set; }
        public string? UsuarioCreacionModificacion { get; set; }
    }
}
