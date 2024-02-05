using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agrosense.Service.Model.Dto;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IContextoBD
    {
        Task<DtoRespuestaSP> EjecutarSP(string query, Dictionary<string, object>? data = null);
        Task<T> ObtenerDato<T>(string sqlQuery, Dictionary<string, object>? data = null);
        Task<List<T>> ObtenerListaDeDatos<T>(string sqlQuery, Dictionary<string, object>? data = null);
    }
}
