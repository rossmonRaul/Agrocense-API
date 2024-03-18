using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityPreparacionTerreno
    {
        public int IdPreparacionTerreno { get; set; }
        public string? UsuarioCreacionModificacion { get; set; }
        public string? Fecha { get; set; }
        public string? Actividad { get; set; }
        public string? Maquinaria { get; set; }
        public string? Observaciones { get; set; }
        public int? IdFinca { get; set; }
        public int? IdParcela { get; set; }
    }
}
