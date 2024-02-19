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

        public async Task<List<DtoUsuario>> ObtenerUsuariosPorRol2()
        {
            try
            {
                
                string query = "ObtenerUsuariosPorRol2";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<DtoUsuario>> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                string query = "ObtenerUsuariosPorRol3";

                return await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
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
                string query = "SPActualizarUsuario";

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
                data.Add("@Correo", entityUsuario.Correo);
                string query = "SPActualizarUsuarioAdministrador";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> EliminarUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                string query = "SPEliminarUsuario";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Identificacion", entityUsuario.Identificacion);
                data.Add("@Correo", entityUsuario.Correo);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                data.Add("@IdEmpresa", entityUsuario.idEmpresa);
                data.Add("@IdFinca", entityUsuario.idFinca);
                data.Add("@IdParcela", entityUsuario.idParcela);
                string query = "SPGuardarUsuarioPorSuperUsuario";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

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

