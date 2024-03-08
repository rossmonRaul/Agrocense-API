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
    public class RepositorioManejoFertilizantes: IRepositorioManejoFertilizantes
    {
        private readonly IContextoBD contextoBD;

        public RepositorioManejoFertilizantes(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        //Obtener los registro de Manejo de Fertilizantes
        public async Task<List<DtoManejoFertilizantes>> ObtenerManejoFertilizantes()
        {
            try
            {
                string query = "SPObtenerManejoFertilizantes";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoManejoFertilizantes>(query);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> InsertarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityManejoFertilizantes.IdFinca);
                data.Add("@IdParcela", entityManejoFertilizantes.IdParcela);
                data.Add("@Fecha", entityManejoFertilizantes.FechaCreacion);
                data.Add("@Aplicacion", entityManejoFertilizantes.Aplicacion);
                data.Add("@Fertilizante", entityManejoFertilizantes.Fertilizante);
                data.Add("@Dosis", entityManejoFertilizantes.Dosis);
                data.Add("@CultivoTratado", entityManejoFertilizantes.CultivoTratado);
                data.Add("@Observaciones", entityManejoFertilizantes.Observaciones);
                data.Add("@AccionesAdicionales ", entityManejoFertilizantes.AccionesAdicionales);
                data.Add("@CondicionesAmbientales ", entityManejoFertilizantes.CondicionesAmbientales);
                string query = "SPInsertarManejoFertilizantes";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> ActualizarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            try
            {

                Dictionary<string, object> data = new Dictionary<string, object>();

                data.Add("@IdManejoFertilizantes", entityManejoFertilizantes.IdManejoFertilizantes);
                data.Add("@Fecha", entityManejoFertilizantes.FechaCreacion);
                data.Add("@Fertilizante", entityManejoFertilizantes.Fertilizante);
                data.Add("@Aplicacion", entityManejoFertilizantes.Aplicacion);
                data.Add("@Dosis", entityManejoFertilizantes.Dosis);
                data.Add("@CultivoTratado", entityManejoFertilizantes.CultivoTratado);
                data.Add("@Observaciones", entityManejoFertilizantes.Observaciones);
                data.Add("@AccionesAdicionales ", entityManejoFertilizantes.AccionesAdicionales);
                data.Add("@CondicionesAmbientales ", entityManejoFertilizantes.CondicionesAmbientales);

                string query = "SPModificarManejoFertilizantes";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdManejoFertilizantes", entityManejoFertilizantes.IdManejoFertilizantes);
                string query = "SPCambiarManejoFertlizante";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
