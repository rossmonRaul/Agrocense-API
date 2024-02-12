using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Usuario;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Entity;
//using Agrosense.Service.BusinessLogic.Interface

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioUsuario: IServicioUsuario
    {
        private readonly IRepositorioUsuario repositorioUsuario;

        public ServicioUsuario(IRepositorioUsuario repositorioUsuario)
        {
            this.repositorioUsuario = repositorioUsuario;
        }

        public async Task<List<DtoUsuario>> ObtenerUsuarios()
        {
            return await this.repositorioUsuario.ObtenerUsuarios();
        }

        public async Task<DtoRespuestaSP> InsertarUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.InsertarUsuario(entityUsuario);
        }
        public async Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ValidarUsuario(entityUsuario);
        }
    }
}
