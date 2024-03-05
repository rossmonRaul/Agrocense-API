using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioFinca
    {
        Task<List<DtoFinca>> ObtenerFincas();
        Task<DtoRespuestaSP> CrearFinca(EntityFinca entityFinca);
        Task<DtoRespuestaSP> ActualizarFinca(EntityFinca entityFinca);
        Task<DtoRespuestaSP> CambiarEstadoFinca(EntityFinca entityFinca);
    }
}

