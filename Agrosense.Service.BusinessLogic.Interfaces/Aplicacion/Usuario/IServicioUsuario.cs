using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
//using Agrosense.Service.Model.entity;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Usuario
{
    public interface IServicioUsuario
    {
        Task<List<DtoUsuarioAdminEmpresa>> ObtenerUsuariosPorRol2();
        Task<List<DtoUsuarioAsignado>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario);
        Task<List<DtoUsuario>> ObtenerUsuariosPorIdEmpresa(EntityUsuario entityUsuario);
        Task<List<DtoUsuarioAsignado>> ObtenerUsuariosAsignadosPorIdentificacion(EntityUsuario entityUsuario);
        Task<List<DtoUsuario>> ObtenerUsuariosPorRol4();
        Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> GuardarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarDatosUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarUsuarioAdministrador(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> AsignarNuevaFincaParcela(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> AsignarFincaParcela(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> AsignarEmpresaFincaYParcela(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> CambiarEstadoUsuarioFincaParcela(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> CambiarEstadoUsuario(EntityUsuario entityUsuario);
        
    }
}
