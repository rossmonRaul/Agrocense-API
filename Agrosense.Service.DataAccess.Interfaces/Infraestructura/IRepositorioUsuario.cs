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
        Task<List<DtoUsuario>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario);
        Task<List<DtoUsuario>> ObtenerUsuariosPorRol4();
        Task<DtoRespuestaSP> InsertarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> ActualizarUsuario(EntityUsuario entityUsuario);
        Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario);
        Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario);
    }
}
