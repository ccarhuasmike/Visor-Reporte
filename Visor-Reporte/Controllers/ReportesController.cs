
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Net;
using System.Security.Principal;
using Visor_Reporte.Common;
using System.Web.SessionState;
using System.Web.UI;
using Microsoft.ReportingServices.Interfaces;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Visor_Reporte.Controllers
{
    public class ReportRequest
    {
        //public Dictionary<string, string> Data { get; set; }
        public string NombreReporte { get; set; }
    }

    [SessionState(SessionStateBehavior.Required)]

    
    public class ReportesController : Controller
    {
        private string NombreReporte { get { return Request["NombreReporte"] != null ? Request["NombreReporte"] : string.Empty; } }
        private string IdCia { get { return Request["IdCia"] != null ? Request["IdCia"] : string.Empty; } }
        private string IdCliente { get { return Request["IdCliente"] != null ? Request["IdCliente"] : string.Empty; } }
        private string IdTipoRegla { get { return Request["IdTipoRegla"] != null ? Request["IdTipoRegla"] : string.Empty; } }
        
        private string IdInmueble { get { return Request["IdInmueble"] != null ? Request["IdInmueble"] : string.Empty; } }
        private string IdEdificio { get { return Request["IdEdificio"] != null ? Request["IdEdificio"] : string.Empty; } }
        private string IdNivel { get { return Request["IdNivel"] != null ? Request["IdNivel"] : string.Empty; } }
        private string DescripcionCentroCosto { get { return Request["DescripcionCentroCosto"] != null ? Request["DescripcionCentroCosto"] : string.Empty; } }
        private string NombreCorto { get { return Request["NombreCorto"] != null ? Request["NombreCorto"] : string.Empty; } }
        private string IdEstadoSolicitud { get { return Request["IdEstadoSolicitud"] != null ? Request["IdEstadoSolicitud"] : string.Empty; } }
        private string CodigoPlan { get { return Request["CodigoPlan"] != null ? Request["CodigoPlan"] : string.Empty; } }
        private string IdFrecuencia { get { return Request["IdFrecuencia"] != null ? Request["IdFrecuencia"] : string.Empty; } }
        private string IdProvincia { get { return Request["IdProvincia"] != null ? Request["IdProvincia"] : string.Empty; } }
        private string IdTipoSolicitud { get { return Request["IdTipoSolicitud"] != null ? Request["IdTipoSolicitud"] : string.Empty; } }
        private string IdZonal { get { return Request["IdZonal"] != null ? Request["IdZonal"] : string.Empty; } }
        private string IdUbigeo { get { return Request["IdUbigeo"] != null ? Request["IdUbigeo"] : string.Empty; } }
        private string NombreCliente { get { return Request["NombreCliente"] != null ? Request["NombreCliente"] : string.Empty; } }
        private string IdDepartamento { get { return Request["IdDepartamento"] != null ? Request["IdDepartamento"] : string.Empty; } }
        private string IdTipoGrupo { get { return Request["IdTipoGrupo"] != null ? Request["IdTipoGrupo"] : string.Empty; } }
        private string IdsInspectores { get { return Request["IdsInspectores"] != null ? Request["IdsInspectores"] : string.Empty; } }
        private string IdProvedor { get { return Request["IdProvedor"] != null ? Request["IdProvedor"] : string.Empty; } }
        private string CodigoSKU { get { return Request["CodigoSKU"] != null ? Request["CodigoSKU"] : string.Empty; } }
        private string CodInmueble { get { return Request["CodInmueble"] != null ? Request["CodInmueble"] : string.Empty; } }
        private string NombreInmueble { get { return Request["NombreInmueble"] != null ? Request["NombreInmueble"] : string.Empty; } }
        private string Direccion { get { return Request["Direccion"] != null ? Request["Direccion"] : string.Empty; } }
        private string IdsMateriales { get { return Request["IdsMateriales"] != null ? Request["IdsMateriales"] : string.Empty; } }
        private string IdsAlmacenes { get { return Request["IdsAlmacenes"] != null ? Request["IdsAlmacenes"] : string.Empty; } }
        private string IdGrupoMantenimiento { get { return Request["IdGrupoMantenimiento"] != null ? Request["IdGrupoMantenimiento"] : string.Empty; } }
        private string IdUnidadMantenimiento { get { return Request["IdUnidadMantenimiento"] != null ? Request["IdUnidadMantenimiento"] : string.Empty; } }
        private string IdInspectorFM { get { return Request["IdInspectorFM"] != null ? Request["IdInspectorFM"] : string.Empty; } }
        private string IdInspectorCliente { get { return Request["IdInspectorCliente"] != null ? Request["IdInspectorCliente"] : string.Empty; } }
        private string NombreUsuarioSolicitante { get { return Request["NombreUsuarioSolicitante"] != null ? Request["NombreUsuarioSolicitante"] : string.Empty; } }
        private string NombreUsuario { get { return Request["NombreUsuario"] != null ? Request["NombreUsuario"] : string.Empty; } }
        private string IdClasificacionProblema { get { return Request["IdClasificacionProblema"] != null ? Request["IdClasificacionProblema"] : string.Empty; } }
        private string IdZonalOT { get { return Request["IdZonalOT"] != null ? Request["IdZonalOT"] : string.Empty; } }
        private string IdTipoGasto { get { return Request["IdTipoGasto"] != null ? Request["IdTipoGasto"] : string.Empty; } }
        private string IdTipoTarifario { get { return Request["IdTipoTarifario"] != null ? Request["IdTipoTarifario"] : string.Empty; } }
        private string IdCondicion { get { return Request["IdCondicion"] != null ? Request["IdCondicion"] : string.Empty; } }
        private string IdUso { get { return Request["IdUso"] != null ? Request["IdUso"] : string.Empty; } }
        private string IdSituacion { get { return Request["IdSituacion"] != null ? Request["IdSituacion"] : string.Empty; } }
        private string IdPais { get { return Request["IdPais"] != null ? Request["Pais"] : string.Empty; } }
        private string FechaInicio { get { return Request["FechaInicio"] != null ? Request["FechaInicio"] : string.Empty; } }
        private string FechaFin { get { return Request["FechaFin"] != null ? Request["FechaFin"] : string.Empty; } }
        private string TipoCambio { get { return Request["TipoCambio"] != null ? Request["TipoCambio"] : string.Empty; } }
        private string TieneAdjunto { get { return Request["TieneAdjunto"] != null ? Request["TieneAdjunto"] : string.Empty; } }
        private string IdTecnicoEjecuta { get { return Request["IdTecnicoEjecuta"] != null ? Request["IdTecnicoEjecuta"] : string.Empty; } }
        private string IdDistrito { get { return Request["IdDistrito"] != null ? Request["IdDistrito"] : string.Empty; } }
        private string IdUsuario { get { return Request["IdUsuario"] != null ? Request["IdUsuario"] : string.Empty; } }
        private string IdArrendatario { get { return Request["IdArrendatario"] != null ? Request["IdArrendatario"] : string.Empty; } }
        private string IdPropietario { get { return Request["IdPropietario"] != null ? Request["IdPropietario"] : string.Empty; } }
        private string IdVehiculo { get { return Request["IdVehiculo"] != null ? Request["IdVehiculo"] : string.Empty; } }
        // GET: Reportes
        public ActionResult Index()
        {
            var parametros = HttpRequestHelper.ConvertRequestToDictionary(Request);
            var rutaReporte = HttpRequestHelper.ObtenerRutaReporteYElimnarDelDictionary(parametros, "NombreReporte");


            // Determinar si usar modo local o remoto
            string nombreReporte = Path.GetFileNameWithoutExtension(rutaReporte);
            bool usarModoLocal = ConfigurationManager.AppSettings["IsModeDeveloper"] == "SI" ||
                                _reportConfigs.ContainsKey(nombreReporte);

            if (usarModoLocal)
            {
                ViewBag.ReportViewer = ConfigurarReportLocal(rutaReporte, parametros);
            }
            else
            {
                ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            }



            //ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            
            return View();
        }         
        public ReportViewer ConfigurarReportServer(string urlReporte, Dictionary<string, string> parametros)
        {
            try
            {
                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Remote;
                viewer.SizeToReportContent = true;
                // Habilitar la caché de informes
                viewer.LocalReport.EnableExternalImages = true;
                viewer.LocalReport.EnableHyperlinks = true;
                viewer.ZoomMode = ZoomMode.FullPage;
                //viewer.Width = Unit.Percentage(100);
                //viewer.Height = Unit.Percentage(100);
                bool IsModeDeveloper = ConfigurationManager.AppSettings["IsModeDeveloper"] == "SI";
                if (IsModeDeveloper)
                    viewer.ServerReport.ReportServerCredentials = new ReportServerCredentials(ConfigurationManager.AppSettings["ReportUser"], ConfigurationManager.AppSettings["ReportPassword"], "");
                viewer.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["SSRSReportUrls"]);
                viewer.ServerReport.ReportPath = urlReporte;
                viewer.ServerReport.Timeout = 600000;
                foreach (KeyValuePair<string, string> valor in parametros)
                {
                    viewer.ServerReport.SetParameters(new ReportParameter(valor.Key, valor.Value, false));
                }
                //var usuarioSession = Session["Usuario"] as UsuarioSesionDto;
                //viewer.ServerReport.SetParameters(new ReportParameter("NombreCIA", "usuarioSession.NombreCompania", false));
                //viewer.ServerReport.SetParameters(new ReportParameter("IdCia", "1", false));
                //viewer.ServerReport.SetParameters(new ReportParameter("IdPerfil", "1", false));
                //viewer.ServerReport.SetParameters(new ReportParameter("IdUsuario", "1", false));
                viewer.ServerReport.Refresh();
                return viewer;
            }
            catch (Exception e)
            {
                //Log.Error(e.Message, e);

                throw;
            }

        }



        // Diccionario para mapear reportes con sus stored procedures y parámetros
        private readonly Dictionary<string, ReportConfig> _reportConfigs = new Dictionary<string, ReportConfig>
        {
            {
                "ReporteConsultasReclamosV2",
                new ReportConfig
                {
                    StoredProcedure = "REP.USP_REPORTE_CONSULTAS_RECLAMOS",
                    DataSetName = "dataSetConsultasReclamos",
                    Parameters = new List<string>
                    {
                        "IdCliente", "FechaDesde", "FechaHasta", "IdTipoTicket", "IdCategoriaTicket",
                        "IdZonal", "IdInmueble", "IdEdificio", "IdNivel", "IdGrupoMantenimiento",
                        "IdUnidadMantenimiento", "IdResponsable", "ListaSolicitante", "ListaZonalOT",
                        "ListaEstadoTicket", "CodigoSolicitud"
                    }
                }
            }
            // Aquí puedes agregar más configuraciones para otros reportes
            // "OtroReporte", new ReportConfig { ... }
        };
        public ReportViewer ConfigurarReportLocal(string rutaReporte, Dictionary<string, string> parametros)
        {
            try
            {
                var viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.SizeToReportContent = true;
                viewer.LocalReport.EnableExternalImages = true;
                viewer.LocalReport.EnableHyperlinks = true;
                viewer.ZoomMode = ZoomMode.FullPage;

                // Obtener nombre del reporte
                string nombreReporte = ObtenerNombreReporte(rutaReporte);

                // Verificar si existe configuración para este reporte
                if (!_reportConfigs.ContainsKey(nombreReporte))
                {
                    throw new Exception($"No existe configuración para el reporte: {nombreReporte}");
                }

                var config = _reportConfigs[nombreReporte];

                // Ruta física del archivo .rdl
                string rutaFisica = ObtenerRutaFisicaReporte(nombreReporte);
                if (!System.IO.File.Exists(rutaFisica))
                {
                    throw new FileNotFoundException($"Archivo .rdl no encontrado: {rutaFisica}");
                }

                viewer.LocalReport.ReportPath = rutaFisica;

                // Obtener datos del stored procedure
                var datos = EjecutarStoredProcedure(config.StoredProcedure, config.Parameters, parametros);

                // Configurar parámetros del reporte
                ConfigurarParametrosReporte(viewer, parametros);

                // Asignar el DataSource
                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(new ReportDataSource(config.DataSetName, datos));

                viewer.LocalReport.Refresh();
                return viewer;
            }
            catch (Exception e)
            {
                throw new Exception($"Error configurando reporte local '{rutaReporte}': {e.Message}", e);
            }
        }


        /// <summary>
        /// Configura los parámetros del reporte
        /// </summary>
        private void ConfigurarParametrosReporte(ReportViewer viewer, Dictionary<string, string> parametros)
        {
            var reportParams = new List<ReportParameter>();

            foreach (var param in parametros)
            {
                //if (!string.IsNullOrEmpty(param.Value))
                //{
                    reportParams.Add(new ReportParameter(param.Key, param.Value));
                //}
            }

            // Agregar parámetros por defecto si no están presentes
            if (!parametros.ContainsKey("IdUsuario"))
            {
                reportParams.Add(new ReportParameter("IdUsuario", "43"));
            }
            if (!parametros.ContainsKey("Usuario"))
            {
                reportParams.Add(new ReportParameter("Usuario", "USER"));
            }

            viewer.LocalReport.SetParameters(reportParams.ToArray());
        }

        /// <summary>
        /// Obtiene el nombre del reporte desde la ruta
        /// </summary>
        private string ObtenerNombreReporte(string rutaReporte)
        {
            if (string.IsNullOrEmpty(rutaReporte))
                return string.Empty;

            // Si es una ruta completa, obtener solo el nombre del archivo
            if (rutaReporte.Contains("/") || rutaReporte.Contains("\\"))
            {
                return Path.GetFileNameWithoutExtension(rutaReporte.Split('/').Last());
            }

            // Si ya es solo el nombre
            return rutaReporte.Replace(".rdl", "");
        }

        /// <summary>
        /// Obtiene la ruta física del archivo .rdl
        /// </summary>
        private string ObtenerRutaFisicaReporte(string nombreReporte)
        {
            // Primero buscar en la carpeta Reportes
            string rutaPrincipal = Server.MapPath($"~/Reportes/{nombreReporte}.rdl");
            if (System.IO.File.Exists(rutaPrincipal))
                return rutaPrincipal;

            // Buscar en subcarpetas comunes
            string[] subcarpetas = { "Nuevos", "KPI", "Solicitudes" };
            foreach (string subcarpeta in subcarpetas)
            {
                string rutaSubcarpeta = Server.MapPath($"~/Reportes/{subcarpeta}/{nombreReporte}.rdl");
                if (System.IO.File.Exists(rutaSubcarpeta))
                    return rutaSubcarpeta;
            }

            // Si no se encuentra, devolver la ruta principal para que lance excepción
            return rutaPrincipal;
        }
        private DataTable EjecutarStoredProcedure(string storedProcedure, List<string> parametrosRequeridos, Dictionary<string, string> parametrosRecibidos)
        {
            var dt = new DataTable();
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["EDIContext"];
            if (connectionStringSettings == null)
            {
                throw new Exception("No se encontró la cadena de conexión 'EDIContext' en el Web.config");
            }
            string connectionString = connectionStringSettings.ConnectionString;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(storedProcedure, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 300; // 5 minutos

                // Agregar parámetros dinámicamente
                foreach (string parametro in parametrosRequeridos)
                {
                    object valor = ObtenerValorParametro(parametrosRecibidos, parametro);
                    cmd.Parameters.AddWithValue($"@{parametro}", valor);
                }

                conn.Open();
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        /// <summary>
        /// Obtiene el valor de un parámetro con manejo de tipos
        /// </summary>
        private object ObtenerValorParametro(Dictionary<string, string> parametros, string nombreParametro)
        {
            if (parametros.ContainsKey(nombreParametro) && !string.IsNullOrEmpty(parametros[nombreParametro]))
            {
                string valor = parametros[nombreParametro];

                // Manejo especial según el nombre del parámetro
                if (nombreParametro.Contains("Fecha"))
                {
                    return DateTime.TryParse(valor, out DateTime fecha) ? (object)fecha : DBNull.Value;
                }
                else if (nombreParametro.StartsWith("Id") && nombreParametro != "IdUsuario")
                {
                    return int.TryParse(valor, out int id) ? (object)id : DBNull.Value;
                }
                else
                {
                    return valor;
                }
            }
            return DBNull.Value;
        }

    }
    public class ReportConfig
    {
        public string StoredProcedure { get; set; }
        public string DataSetName { get; set; }
        public List<string> Parameters { get; set; }
    }
}