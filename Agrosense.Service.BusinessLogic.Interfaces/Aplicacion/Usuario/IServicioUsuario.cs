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
        Task<List<DtoUsuario>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario);
        Task<List<DtoUsuario>> ObtenerUsuariosPorRol4();
        Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> InsertarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarUsuario(EntityUsuario entityUsuario);
    }
}
