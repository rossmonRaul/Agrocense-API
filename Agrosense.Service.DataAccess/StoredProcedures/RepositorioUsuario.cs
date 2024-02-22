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
                
                string query = "ObtenerUsuariosPorRol2";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsuarioAdminEmpresa>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Obtener usuarios que ya estan asignados a empresa, finca y parcela
        public async Task<List<DtoUsuarioAsignado>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                string query = "ObtenerUsuariosPorRol3";

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
                
                string query = "ObtenerUsuariosPorRol4";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query);
                
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<DtoUsuario>> ObtenerUsuariosPorIdEmpresa(EntityUsuario entityUsuario)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                string query = "ObtenerUsuariosPorIdEmpresa";

                return await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Agregar un usuario
        public async Task<DtoRespuestaSP> InsertarUsuario(EntityUsuario entityUsuario)
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
        //Se actualiza los datos necesarios del usuario
        public async Task<DtoRespuestaSP> ActualizarUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                data.Add("@IdRol", entityUsuario.idRol);
                data.Add("@Estado", entityUsuario.Estado);
                data.Add("@NuevaContrasena", entityUsuario.Contrasena);
                string query = "SPActualizarUsuario";

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
        //Se actualiza los datos de administrador
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
        //Cambio del estado del usuario
        public async Task<DtoRespuestaSP> CambioEstadoUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                string query = "SPCambiarEstadoUsuario";

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
        //Validar el login por medio de usuarrio o correo con contraseña
        public async Task<DtoUsuarioLogueado> ValidarUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Usuario", entityUsuario.Identificacion);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                
                string query = "SPObtenerUsuarioPorUsuarioYContrasena";

                return await this.contextoBD.ObtenerDato<DtoUsuarioLogueado>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

