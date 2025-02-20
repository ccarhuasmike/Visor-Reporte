
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
            ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //Dictionary<string, string> parametros = new Dictionary<string, string>();

            //if (NombreReporte == "ejemplo")
            //{
            //    parametros = ObtenerParametrosReporteEECC();
            //    ViewBag.ReportViewer = ConfigurarReportServer(NombreReporte, parametros);
            //}
            //if (NombreReporte == "REPORTESOLICITUDESTRABAJODEMANDA")
            //{
            //    string rutaReporte = "/EDI/Reportes/Reportes/Nuevos/ReporteSolicitudesTrabajoDemandaV2";
            //    parametros = ObtenerParametrosREPORTESOLICITUDESTRABAJODEMANDA();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "REPORTEATENCIONESADJUNTOS")
            //{
            //    string rutaReporte = "/EDI/Reportes/Reportes/Nuevos/ReporteAtencionesAdjuntosV2";
            //    parametros = ObtenerParametrosREPORTEATENCIONESADJUNTOS();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "REPORTESOLICITUDESTRABAJODEMANDACLIENTE")
            //{
            //    string rutaReporte = "/EDI/Reportes/Reportes/Nuevos/ReporteSolicitudesTrabajoDemandaClienteV2";
            //    parametros = ObtenerParametrosREPORTESOLICITUDESTRABAJODEMANDACLIENTE();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "REPORTEVALORACIONSERVICIO")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/KPI/ReporteValoracionServicioV2";
            //    parametros = ObtenerParametrosREPORTEVALORACIONSERVICIO();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteSKU")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/ReporteSKUV2";
            //    parametros = ObtenerParametrosReporteSKU();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteMaterialesSolicitudes")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/ReporteMaterialesSolicitudesV2";
            //    parametros = ObtenerParametrosReporteMaterialesSolicitudes();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteServiciosSolicitudes")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/ReporteServiciosSolicitudesV2";
            //    parametros = ObtenerParametrosReporteServiciosSolicitudes();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteListadoInmuebles")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/NUEVOS/ReporteListadoInmueblesV2";
            //    parametros = ObtenerParametrosReporteListadoInmuebles();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}            
            //if (NombreReporte == "OrdenPagoMiBanco")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/CONTROL PATRIMONIAL/ALQUILERES/OrdenPagoMiBancoV2";
            //    parametros = ObtenerParametrosReporteOrdenPagoMiBanco();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteSolicitudesTrabajoPlanificado")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/NUEVOS/ReporteSolicitudesTrabajoPlanificadoV2";
            //    parametros = ObtenerParametrosReporteSolicitudesTrabajoPlanificado();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteSolicitudesTrabajoPlanificado2")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/NUEVOS/ReporteSolicitudesTrabajoPlanificado2_V2";
            //    parametros = ObtenerParametrosReporteSolicitudesTrabajoPlanificado2();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteFacturacionGasto")
            //{
            //    string rutaReporte = "/EDI/Reportes/Reportes/ReporteFacturacionGastoV2";
            //    parametros = ObtenerParametrosReporteFacturacionGasto();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "ReporteInventarioVehicular")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/FLOTA VEHICULAR/REPORTEVEHICULAR";
            //    parametros = ObtenerParametrosReporteInventarioVehiculo();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "REPORTEREGLAASIGNACIONSUBREPORTE")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/REPORTEREGLAASIGNACIONSUBREPORTE";
            //    parametros = ObtenerParametrosREPORTEREGLAASIGNACIONSUBREPORTE();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "REPORTELOGACCIONSOLICITUD")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/SOLICITUDES/REPORTELOGACCIONSOLICITUD";
            //    parametros = ObtenerParametrosREPORTELOGACCIONSOLICITUD();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            //if (NombreReporte == "REPORTELOGACCIONSOLICITUD")
            //{
            //    string rutaReporte = "/EDI/REPORTES/REPORTES/SOLICITUDES/REPORTELOGACCIONSOLICITUD";
            //    parametros = ObtenerParametrosREPORTELOGACCIONSOLICITUD();
            //    ViewBag.ReportViewer = ConfigurarReportServer(rutaReporte, parametros);
            //}
            return View();
        }     
        private Dictionary<string, string> ObtenerParametrosREPORTELOGACCIONSOLICITUD()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},
                {"TipoST", IdTipoSolicitud},               
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin},                
            };
        }
        private Dictionary<string, string> ObtenerParametrosREPORTEREGLAASIGNACIONSUBREPORTE()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"IdsCliente", IdCliente},
                {"IdsTipoRegla", IdTipoRegla}                
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteEECC()
        {
            return new Dictionary<string, string>
            {
                {"IdCia", IdCia}
            };
        }
        private Dictionary<string, string> ObtenerParametrosREPORTESOLICITUDESTRABAJODEMANDA()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},
                {"Inmueble", IdInmueble},
                {"CentroCost", DescripcionCentroCosto},
                {"EstadoSol", IdEstadoSolicitud},
                {"TipoST", IdTipoSolicitud},
                {"TipoGrupo", IdTipoGrupo},
                {"Proveedor", IdProvedor},
                {"GrupoMant", IdGrupoMantenimiento},
                {"UnidadMant", IdUnidadMantenimiento},
                {"InspectorFM", IdInspectorFM},
                {"InspectorCli", IdInspectorCliente},
                {"UsuarioSoli", NombreUsuarioSolicitante},
                {"ClasifProbl", IdClasificacionProblema},
                {"ZonalOT", IdZonalOT},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin},
                {"TecnicoEjec", IdTecnicoEjecuta},
            };
        }
        private Dictionary<string, string> ObtenerParametrosREPORTEVALORACIONSERVICIO()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},
                {"Inmueble", IdInmueble},
                {"Proveedor", IdProvedor},
                {"ListaInspectores", IdsInspectores},
                {"NombreCliente", NombreCliente},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin}
            };
        }
        private Dictionary<string, string> ObtenerParametrosREPORTESOLICITUDESTRABAJODEMANDACLIENTE()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},
                {"Proveedor", IdProvedor},
                {"TipoST", IdTipoSolicitud},
                {"Departamento", IdDepartamento},
                {"EstadoSol", IdEstadoSolicitud},
                {"Provincia", IdProvincia},
                {"TecnicoEjec", IdTecnicoEjecuta},
                {"Distrito", IdDistrito},
                {"Inmueble", IdInmueble},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin},                
                //{"CentroCost", DescripcionCentroCosto},                                
                //{"TipoGrupo", IdTipoGrupo},                
                //{"GrupoMant", IdGrupoMantenimiento},
                //{"UnidadMant", IdUnidadMantenimiento},
                //{"InspectorFM", IdInspectorFM},
                //{"InspectorCli", IdInspectorCliente},
                //{"UsuarioSoli", NombreUsuarioSolicitante},
                //{"ClasifProbl", IdClasificacionProblema},
                //{"ZonalOT", IdZonalOT},                
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteOrdenPagoMiBanco()
        {
            return new Dictionary<string, string>
            {
                {"fechaIni", FechaInicio},
                {"fechaFin", FechaFin},
                {"tipocambio", TipoCambio}
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteSolicitudesTrabajoPlanificado()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},                
                {"INMUEBLE", NombreInmueble},
                {"EstadoSol", IdEstadoSolicitud},
                {"CodigoPlan", CodigoPlan},
                {"Frecuencia", IdFrecuencia},
                {"GrupoMant", IdGrupoMantenimiento},
                {"UnidadMant", IdUnidadMantenimiento},
                {"InspectorFM", IdInspectorFM},
                {"InspectorCli", IdInspectorCliente},
                {"Proveedor", IdProvedor},
                {"TecnicoEjec", IdTecnicoEjecuta},
                {"ZonalOT", IdZonalOT},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin}
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteInventarioVehiculo()
        {
            return new Dictionary<string, string>
            {
                {"IdVehiculo", IdVehiculo},
                {"Url",""},
                //{"FechaFinActual", FechaFin},
                //{"IdTipoSolicitud", IdTipoSolicitud},
                //{"IdZonal", IdZonal},
                //{"ListaGrupoMantenimiento", IdGrupoMantenimiento},
                //{"ListaUnidadMantenimiento", IdUnidadMantenimiento},
                //{"ListaProveedor", IdProvedor},
                //{"ListaInspectores", IdInspectorCliente},
                //{"CentroCosto", DescripcionCentroCosto},
                //{"ListaClasificacionProblema", IdClasificacionProblema},
                //{"IdZonalOT", IdZonalOT},
                //{"IdTipoGasto", IdTipoGasto},
                //{"IdTipoTarifario", IdTipoTarifario}
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteFacturacionGasto()
        {
            return new Dictionary<string, string>
            {
                {"IdCliente", IdCliente},
                {"FechaInicioActual", FechaInicio},
                {"FechaFinActual", FechaFin},
                {"IdTipoSolicitud", IdTipoSolicitud},
                {"IdZonal", IdZonal},                
                {"ListaGrupoMantenimiento", IdGrupoMantenimiento},
                {"ListaUnidadMantenimiento", IdUnidadMantenimiento},
                {"ListaProveedor", IdProvedor},
                {"ListaInspectores", IdInspectorCliente},
                {"CentroCosto", DescripcionCentroCosto},
                {"ListaClasificacionProblema", IdClasificacionProblema},
                {"IdZonalOT", IdZonalOT},
                {"IdTipoGasto", IdTipoGasto},
                {"IdTipoTarifario", IdTipoTarifario}
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteSolicitudesTrabajoPlanificado2()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},
                //{"CodInmueble", CodInmueble},
                {"INMUEBLE", NombreInmueble},
                {"EstadoSol", IdEstadoSolicitud},
                {"CodigoPlan", CodigoPlan},
                {"Frecuencia", IdFrecuencia},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin}
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteListadoInmuebles()
        {
            return new Dictionary<string, string>
            {
                {"IdUsuario", IdUsuario},
                {"Usuario", NombreUsuario},
                {"Cliente", IdCliente},
                {"CodInmueble", CodInmueble},
                {"INMUEBLE", NombreInmueble},
                {"Direccion", Direccion},
                {"Zonal", IdZonal},
                {"ZonalOT", IdZonalOT},
                {"Condicion", IdCondicion},
                {"Uso", IdUso},
                {"Situ", IdSituacion},
                {"Pais", IdPais},
                {"Departamento", IdDepartamento},
                {"Provincia", IdProvincia},
                {"Distrito", IdDistrito},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin},
                {"Arrendatario", IdArrendatario},
                {"Propietario", IdPropietario}
            };
        }
        private Dictionary<string, string> ObtenerParametrosReporteServiciosSolicitudes()
        {

            return new Dictionary<string, string>
            {
                {"IdCliente", IdCliente},
                {"FechaInicioActual", FechaInicio},
                {"FechaFinActual", FechaFin},
                {"IdTipoSolicitud", IdTipoSolicitud},
                {"IdZonal", IdZonal},
                {"ListaUbigeo", IdUbigeo},
                {"ListaInmueble", IdInmueble},
                {"ListaEdificio", IdEdificio},
                {"ListaNivel", IdNivel},
                {"ListaGrupoMantenimiento", IdGrupoMantenimiento},
                {"ListaUnidadMantenimiento", IdUnidadMantenimiento},
                {"ListaProveedor", IdProvedor},
                {"ListaInspectores", IdsInspectores},
                {"CentroCosto", DescripcionCentroCosto},
                {"NombreSolicitanteReporte", NombreUsuarioSolicitante},
//                {"IdEstado", IdEstadoSolicitud},
            };

            //return new Dictionary<string, string>
            //{
            //    {"IdCliente", IdCliente},
            //    {"FechaInicioActual", FechaInicio},
            //    {"FechaFinActual", FechaFin},
            //    {"IdTipoSolicitud", IdTipoSolicitud},
            //    {"IdZonal", IdZonal},
            //    {"ListaUbigeo", IdUbigeo},
            //    {"ListaInmueble", IdInmueble},
            //    {"ListaEdificio", IdEdificio},
            //    {"ListaNivel", IdNivel},
            //    {"ListaGrupoMantenimiento", IdGrupoMantenimiento},
            //    {"ListaUnidadMantenimiento", IdUnidadMantenimiento},
            //    {"ListaProveedor", IdProvedor},
            //    {"ListaInspectores", IdsInspectores},
            //    {"CentroCosto", DescripcionCentroCosto},
            //    {"ListaMateriales", IdsMateriales},
            //    {"ListaAlmacenes", IdsAlmacenes},
            //    {"NombreSolicitanteReporte", NombreUsuarioSolicitante},
            //    {"IdEstado", IdEstadoSolicitud}
            //};           
        }
        private Dictionary<string, string> ObtenerParametrosReporteMaterialesSolicitudes()
        {
            return new Dictionary<string, string>
            {
                {"IdCliente", IdCliente},
                {"FechaInicioActual", FechaInicio},
                {"FechaFinActual", FechaFin},
                {"IdTipoSolicitud", IdTipoSolicitud},
                {"IdZonal", IdZonal},
                {"ListaUbigeo", IdUbigeo},
                {"ListaInmueble", IdInmueble},
                {"ListaEdificio", IdEdificio},
                {"ListaNivel", IdNivel},
                {"ListaGrupoMantenimiento", IdGrupoMantenimiento},
                {"ListaUnidadMantenimiento", IdUnidadMantenimiento},
                {"ListaProveedor", IdProvedor},
                {"ListaInspectores", IdsInspectores},
                {"ListaMateriales", IdsMateriales},
                {"ListaAlmacenes", IdsAlmacenes},
                {"CentroCosto", DescripcionCentroCosto},
                {"NombreSolicitanteReporte", NombreUsuarioSolicitante},
                {"IdEstado", IdEstadoSolicitud},
            };




        }
        private Dictionary<string, string> ObtenerParametrosReporteSKU()
        {
            return new Dictionary<string, string>
            {
                {"idCliente", IdCliente},
                {"fechaInicio", FechaInicio},
                {"fechaFin", FechaFin},
                {"CodigoSKU", CodigoSKU},
                {"CentroCosto", DescripcionCentroCosto},
                {"NombreCorto", NombreCorto},
                {"IdUnidadMantenimiento", IdUnidadMantenimiento},
                {"TipoSolicitud", IdTipoSolicitud},
                {"NombreSolicitanteReporte", NombreUsuario}
            };
        }
        private Dictionary<string, string> ObtenerParametrosREPORTEATENCIONESADJUNTOS()
        {
            return new Dictionary<string, string>
            {
                {"Usuario", NombreUsuario},
                {"IdUsuario", IdUsuario},
                {"Cliente", IdCliente},
                {"Inmueble", IdInmueble},
                {"EstadoSol", IdEstadoSolicitud},
                {"Proveedor", IdProvedor},
                {"FechaIni", FechaInicio},
                {"FechaFin", FechaFin},
                {"TieneAdjunto", TieneAdjunto}
                //{"CentroCost", DescripcionCentroCosto},                
                //{"TipoST", IdTipoSolicitud},
                //{"TipoGrupo", IdTipoGrupo},                
                //{"GrupoMant", IdGrupoMantenimiento},
                //{"UnidadMant", IdUnidadMantenimiento},
                //{"InspectorFM", IdInspectorFM},
                //{"InspectorCli", IdInspectorCliente},
                //{"UsuarioSoli", NombreUsuarioSolicitante},
                //{"ClasifProbl", IdClasificacionProblema},
                //{"ZonalOT", IdZonalOT},
                
                
            };
        }
        public ReportViewer ConfigurarReportServerDinamico(string urlReporte, Dictionary<string, string> parametros)
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
    }
}