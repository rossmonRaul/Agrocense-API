using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.StoredProcedures
{
    public class RepositorioUsuario:IRepositorioUsuario
    {
        private readonly IContextoBD contextoBD;

        public RepositorioUsuario(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }
        //Obtener usuarios administradores de las empresas
        public async Task<List<DtoUsuarioAdminEmpresa>> ObtenerUsuariosPorRol2()
        {
            try
            {
                
                string query = "SPObtenerUsuariosPorRol2";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsuarioAdminEmpresa>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Obtener usuarios que ya estan asignados a empresa
        public async Task<List<DtoUsuarioAsignado>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                string query = "SPObtenerUsuariosPorRol3";

                return await this.contextoBD.ObtenerListaDeDatos<DtoUsuarioAsignado>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        //Obtener los usuarios sin asignar
        public async Task<List<DtoUsuario>> ObtenerUsuariosPorRol4()
        {
            try
            {
                
                string query = "SPObtenerUsuariosPorRol4";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query);
                
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Se obtiene los usuarios con el id de la empresa que devuelve solo la indetificacion de los usuarios
        public async Task<List<DtoUsuario>> ObtenerUsuariosPorIdEmpresa(EntityUsuario entityUsuario)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                string query = "SPObtenerUsuariosPorIdEmpresa";

                return await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Agregar un usuario
        public async Task<DtoRespuestaSP> GuardarUsuario(EntityUsuario entityUsuario)
        {
            try
            {
               

                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@Correo", entityUsuario.Correo);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                string query = "SPGuardarUsuario";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        /*Cambia el estado de usuario finca y parcela*/
        public async Task<DtoRespuestaSP> CambiarEstadoUsuarioFincaParcela(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@UsuarioIdentificacion", entityUsuario.Identificacion);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                string query = "SPCambiarEstadoUsuarioFincaParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Cambia el estado del usuario
        public async Task<DtoRespuestaSP> CambiarEstadoUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                string query = "SPCambiarEstadoUsuario";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        //Se usa para asignar las diferentes fincas y parcelas que puede tener el usuario
        public async Task<DtoRespuestaSP> AsignarFincaParcela(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdUsuarioFincaParcela", entityUsuario.idUsuario);
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                string query = "SPAsignarFincaParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ActualizarContrasenaUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@NuevaContrasena", entityUsuario.Contrasena);
                string query = "SPActualizarContrasenaUsuario";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task<DtoRespuestaSP> ActualizarUsuarioAdministrador(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                data.Add("@NuevaContrasena", entityUsuario.Contrasena);
                string query = "SPActualizarUsuarioAdministrador";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> AsignarNuevaFincaParcela (EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                string query = "SPAsignarNuevaFincaParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Se usa para poder asiganar tanto las empresa como las fincas y parcelas
        public async Task<DtoRespuestaSP> AsignarEmpresaFincaYParcela(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                string query = "SPAsignarEmpresaFincaYParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        //Guardar o insertar Usuario Aministrador de Empresa
        public async Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@Correo", entityUsuario.Correo);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                string query = "SPGuardarUsuarioPorSuperUsuario";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Validar el login por medio de usuario o correo con contraseña
        public async Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Usuario", entityUsuario.Identificacion);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                
                string query = "SPValidarUsuario";

                return await this.contextoBD.ObtenerDato<DtoUsuarioLogueado>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

