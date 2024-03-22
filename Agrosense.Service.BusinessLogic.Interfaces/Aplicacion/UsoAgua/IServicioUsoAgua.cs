using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.UsoAgua
{
    public interface IServicioUsoAgua
    {
        Task<List<DtoUsoAgua>> ObtenerRegistrosSeguimientoUsoAgua();
        Task<DtoRespuestaSP> CrearRegistroSeguimientoUsoAgua(EntityUsoAgua registro);
        Task<DtoRespuestaSP> ActualizarRegistroSeguimientoUsoAgua(EntityUsoAgua registro);
        Task<DtoRespuestaSP> CambiarEstadoRegistroSeguimientoUsoAgua(EntityUsoAgua registro);
    }
}
