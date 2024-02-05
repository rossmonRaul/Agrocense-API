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
        Task<List<DtoUsuario>> ObtenerUsuarios();
        Task<DtoRespuestaSP> InsertarUsuario(EntityUsuario entityUsuario);
    }
}
