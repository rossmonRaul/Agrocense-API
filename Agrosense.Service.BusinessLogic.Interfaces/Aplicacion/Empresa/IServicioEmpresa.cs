using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa
{
    public interface  IServicioEmpresa
    {
        Task<List<DtoEmpresa>> ObtenerEmpresas();
        Task<DtoRespuestaSP> CrearEmpresa(EntityEmpresa entityEmpresa);
        Task<DtoRespuestaSP> ActualizarEmpresa(EntityEmpresa entityEmpresa);
    }
}
