using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Dto
{
    public class DtoManejoResiduos
    {
        public int IdManejoResiduos { get; set; }
        public string? Residuo { get; set; }
        public string? Usuario { get; set; }
        public string? FechaGeneracion { get; set; }
        public string? FechaManejo { get; set; }
        public float Cantidad { get; set; }
        public string? AccionManejo { get; set; }
        public string? DestinoFinal { get; set; }
        public int IdFinca { get; set; }
        public int IdParcela { get; set; }
        public string? IdentificacionUsuario { get; set; }
        public string? Finca { get; set; }
        public string? Parcela { get; set; }
        public int Estado { get; set; }
    }
}
