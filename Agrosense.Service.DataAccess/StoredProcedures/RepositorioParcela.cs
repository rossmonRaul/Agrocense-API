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
    public class RepositorioParcela:IRepositorioParcela
    {
        private readonly IContextoBD contextoBD;

        public RepositorioParcela(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<List<DtoParcela>> ObtenerParcelas()
        {
            try
            {

                string query = "SPObtenerParcelas";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoParcela>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CrearParcela(EntityParcela entityParcela)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Parcela", entityParcela.Nombre);
                data.Add("@IdFinca", entityParcela.IdFinca);
                string query = "SPCrearParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ActualizarParcela(EntityParcela entityParcela)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdParcela", entityParcela.IdParcela);
                data.Add("@NuevoNombreParcela", entityParcela.Nombre);
                string query = "SPActualizarParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> CambiarEstadoParcela(EntityParcela entityParcela)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdParcela", entityParcela.IdParcela);
                string query = "SPCambiarEstadoParcela";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
