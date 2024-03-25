using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityManejoResiduos
    {
        public int IdManejoResiduos { get; set; }
        public string? Residuo { get; set; }
        public string? FechaGeneracion { get; set; }
        public string? FechaManejo { get; set; }
        public float Cantidad { get; set; }
        public string? AccionManejo { get; set; }
        public string? DestinoFinal { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public string? UsuarioCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string? IdentificacionUsuario { get; set; }

    }
}
