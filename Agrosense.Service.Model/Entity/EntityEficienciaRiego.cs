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
        public bool EstadoTuberiasYAccesorios { get; set; }
        public bool UniformidadRiego { get; set; }
        public bool EstadoAspersores { get; set; }
        public bool EstadoCanalesRiego { get; set; }
        public decimal NivelFreatico { get; set; }
        public string? UsuarioCreacionModificacion { get; set; }
    }
}
