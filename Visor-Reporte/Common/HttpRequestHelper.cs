using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visor_Reporte.Common
{
    public static  class HttpRequestHelper
    {
        public static string ObtenerRutaReporteYElimnarDelDictionary(Dictionary<string, string> diccionario,string claveBuscada) {

            string rutaReporte = string.Empty;
            if (diccionario.ContainsKey(claveBuscada))
            {
                // Obtener el valor asociado a la clave
                rutaReporte = diccionario[claveBuscada];

                // Eliminar el par clave-valor del diccionario
                diccionario.Remove(claveBuscada);                
            }
            return rutaReporte;
        }
        public static Dictionary<string, string> ConvertRequestToDictionary(HttpRequestBase request)
        {
            var requestDictionary = new Dictionary<string, string>();

            // Add QueryString parameters
            foreach (var key in request.QueryString.AllKeys)
            {
                if (key != null)
                    requestDictionary[key] = request.QueryString[key];
            }

            //// Add Form parameters (for POST requests)
            //foreach (var key in request.Form.AllKeys)
            //{
            //    if (key != null)
            //        requestDictionary[key] = request.Form[key];
            //}

            //// Add Headers
            //foreach (var key in request.Headers.AllKeys)
            //{
            //    if (key != null)
            //        requestDictionary[$"Header_{key}"] = request.Headers[key];
            //}

            //// Add Cookies (optional)
            //foreach (string key in request.Cookies)
            //{
            //    if (key != null)
            //        requestDictionary[$"Cookie_{key}"] = request.Cookies[key]?.Value;
            //}

            // Add other properties if needed (e.g., HTTP method)
            //requestDictionary["HttpMethod"] = request.HttpMethod;

            return requestDictionary;
        }
    }
}