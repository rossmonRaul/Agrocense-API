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

        public async Task<List<DtoUsuario>> ObtenerUsuarios()
        {
            try
            {
                //string query = "SPPrueba";
                string query = "SPObtenerUsuarioTablaPrueba";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsuario>(query);
                /*
                DtoUsuario a = new DtoUsuario();
                a.Id = 1;a.Nombre = "Prueba1";

                DtoUsuario b = new DtoUsuario();
                b.Id = 2; b.Nombre = "Prueba2";

                List<DtoUsuario> result = new List<DtoUsuario>()
                {

                    a,
                    b
                };
                */
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
                data.Add("@Usuario", entityUsuario.Usuario);
                data.Add("@Correo", entityUsuario.Correo);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                data.Add("@idEmpresa", entityUsuario.idEmpresa);
                data.Add("@idFinca", entityUsuario.idFinca);
                data.Add("@idParcela", entityUsuario.idParcela);
                string query = "SPGuardarUsuario";

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
                data.Add("@Usuario", entityUsuario.Usuario);
                data.Add("@Contrasena", entityUsuario.Contrasena);
                
                string query = "SPObtenerUsuarioPoruUsuarioYContrasena";

                return await this.contextoBD.ObtenerDato<DtoUsuarioLogueado>(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

