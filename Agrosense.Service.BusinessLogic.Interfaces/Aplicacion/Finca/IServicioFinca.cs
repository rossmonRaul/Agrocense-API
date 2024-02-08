using Agrosense.Service.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Finca
{
    public interface IServicioFinca
    {
        Task<List<DtoFinca>> ObtenerFincas();
    }
}
