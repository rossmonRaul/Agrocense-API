using Agrosense.Service.Model.Dto;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioEmpresa: IServicioEmpresa
    {
        private readonly IRepositorioEmpresa repositorioEmpresa;

        public ServicioEmpresa(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa = repositorioEmpresa;
        }

        public async Task<List<DtoEmpresa>> ObtenerEmpresas()
        {
            return await this.repositorioEmpresa.ObtenerEmpresas();
        }
        public async Task<DtoRespuestaSP> InsertarEmpresa(EntityEmpresa entityEmpresa)
        {
            return await this.repositorioEmpresa.InsertarEmpresa(entityEmpresa);
        }
        public async Task<DtoRespuestaSP> ActualizarEmpresa(EntityEmpresa entityEmpresa)
        {
            return await this.repositorioEmpresa.ActualizarEmpresa(entityEmpresa);
        }
    }
}
