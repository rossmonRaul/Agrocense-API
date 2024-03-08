using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
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
        Task<DtoRespuestaSP> CrearFinca(EntityFinca entityFinca);
        Task<DtoRespuestaSP> ActualizarFinca(EntityFinca entityFinca);
        Task<DtoRespuestaSP> CambiarEstadoFinca(EntityFinca entityFinca);
    }
}
