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

        public async Task<List<DtoUsuarioAdminEmpresa>> ObtenerUsuariosPorRol2()
        {
            return await this.repositorioUsuario.ObtenerUsuariosPorRol2();
        }
        public async Task<List<DtoUsuarioAsignado>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ObtenerUsuariosPorRol3(entityUsuario);
        }
        public async Task<List<DtoUsuario>> ObtenerUsuariosPorIdEmpresa(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ObtenerUsuariosPorIdEmpresa(entityUsuario);
        }
        public async Task<List<DtoUsuario>> ObtenerUsuariosAsignadosEmpresa(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ObtenerUsuariosAsignadosEmpresa(entityUsuario);
        }
        public async Task<List<DtoUsuario>> ObtenerUsuariosPorRol4()
        {
            return await this.repositorioUsuario.ObtenerUsuariosPorRol4();
        }

        public async Task<DtoRespuestaSP> GuardarUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.GuardarUsuario(entityUsuario);
        }
        //public async Task<DtoRespuestaSP> ActualizarUsuarioNOENUSO(EntityUsuario entityUsuario)
        //{
        //    return await this.repositorioUsuario.ActualizarUsuarioNOENUSO(entityUsuario);
        //}public async Task<DtoRespuestaSP> ActualizarUsuarioSinEmpresa(EntityUsuario entityUsuario)
        //{
        //    return await this.repositorioUsuario.ActualizarUsuarioSinEmpresa(entityUsuario);
        //}
        public async Task<DtoRespuestaSP> ActualizarContrasenaUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ActualizarContrasenaUsuario(entityUsuario);
        }
        public async Task<DtoRespuestaSP> ActualizarUsuarioAdministrador(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ActualizarUsuarioAdministrador(entityUsuario);
        } 
        public async Task<DtoRespuestaSP> AsignarFincaParcela(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.AsignarFincaParcela(entityUsuario);
        }
        public async Task<DtoRespuestaSP> AsignarEmpresaFincaYParcela(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.AsignarEmpresaFincaYParcela(entityUsuario);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoUsuarioFincaParcela(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.CambiarEstadoUsuarioFincaParcela(entityUsuario);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.CambiarEstadoUsuarioFincaParcela(entityUsuario);
        }
        public async Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.GuardarUsuarioPorSuperUsuario(entityUsuario);
        }
        public async Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario)
        {
            return await this.repositorioUsuario.ValidarUsuario(entityUsuario);
        }
    }
}
