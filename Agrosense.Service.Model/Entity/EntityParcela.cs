using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.Model.Entity
{
    public class EntityParcela
    {
        public int IdParcela { get; set; }
        public string? Nombre { get; set; }

        public int IdFinca { get; set; }
    }
}
