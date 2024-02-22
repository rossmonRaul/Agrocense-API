using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioUsuario
    {
        
        Task<List<DtoUsuarioAdminEmpresa>> ObtenerUsuariosPorRol2();
        Task<List<DtoUsuarioAsignado>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario);
        Task<List<DtoUsuario>> ObtenerUsuariosPorRol4();
        Task<List<DtoUsuario>> ObtenerUsuariosPorIdEmpresa(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> InsertarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarUsuarioAdministrador(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarContrasenaUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> CambioEstadoUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario);
        Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario);
    }
}
