using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Parcela
{
    public interface IServicioParcela
    {
        Task<List<DtoParcela>> ObtenerParcelas();
        Task<DtoRespuestaSP> CrearParcela(EntityParcela entityParcela);
        Task<DtoRespuestaSP> ActualizarParcela(EntityParcela entityParcela);
        Task<DtoRespuestaSP> CambiarEstadoParcela(EntityParcela entityParcela);
    }
}
