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
    public class RepositorioMedicionesSuelo: IRepositorioMedicionesSuelo
    {
        private readonly IContextoBD contextoBD;

        public RepositorioMedicionesSuelo(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        //Obtener los registro de las Mediciones de Suelo
        public async Task<List<DtoMedicionesSuelo>> ObtenerDatosMedicionesSuelo()
        {
            try
            {
                string query = "SPObtenerDatosMedicionesSuelo";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoMedicionesSuelo>(query);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> InsertarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>
                {
                { "@MedicionesCalidadSuelo", entityMedicionesSuelo.MedicionesCalidadSuelo },
                { "@RespiracionSuelo", entityMedicionesSuelo.RespiracionSuelo },
                { "@Infiltracion", entityMedicionesSuelo.Infiltracion },
                { "@DensidadAparente", entityMedicionesSuelo.DensidadAparente },
                { "@ConductividadElectrica", entityMedicionesSuelo.ConductividadElectrica },
                { "@pH", entityMedicionesSuelo.pH },
                { "@NitratosSuelo", entityMedicionesSuelo.NitratosSuelo },
                { "@EstabilidadAgregados", entityMedicionesSuelo.EstabilidadAgregados },
                { "@Desleimiento", entityMedicionesSuelo.Desleimiento },
                { "@Lombrices", entityMedicionesSuelo.Lombrices },
                { "@Observaciones", entityMedicionesSuelo.Observaciones },
                { "@CalidadAgua", entityMedicionesSuelo.CalidadAgua },
                { "@IdentificacionUsuario", entityMedicionesSuelo.IdentificacionUsuario },
                { "@IdFinca", entityMedicionesSuelo.IdFinca },
                { "@IdParcela", entityMedicionesSuelo.IdParcela }
                };

                string query = "SPInsertarMedicionesSuelo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> ModificarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>
                {
                { "@IdMedicionesSuelo", entityMedicionesSuelo.IdMedicionesSuelo },
                { "@MedicionesCalidadSuelo", entityMedicionesSuelo.MedicionesCalidadSuelo },
                { "@RespiracionSuelo", entityMedicionesSuelo.RespiracionSuelo },
                { "@Infiltracion", entityMedicionesSuelo.Infiltracion },
                { "@DensidadAparente", entityMedicionesSuelo.DensidadAparente },
                { "@ConductividadElectrica", entityMedicionesSuelo.ConductividadElectrica },
                { "@pH", entityMedicionesSuelo.pH },
                { "@NitratosSuelo", entityMedicionesSuelo.NitratosSuelo },
                { "@EstabilidadAgregados", entityMedicionesSuelo.EstabilidadAgregados },
                { "@Desleimiento", entityMedicionesSuelo.Desleimiento },
                { "@Lombrices", entityMedicionesSuelo.Lombrices },
                { "@Observaciones", entityMedicionesSuelo.Observaciones },
                { "@CalidadAgua", entityMedicionesSuelo.CalidadAgua },
                { "@IdFinca", entityMedicionesSuelo.IdFinca },
                { "@IdParcela", entityMedicionesSuelo.IdParcela }
                };

                string query = "SPModificarMedicionesSuelo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdMedicionesSuelo", entityMedicionesSuelo.IdMedicionesSuelo);
                string query = "SPCambiarEstadoMedicionesSuelo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
