using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Acopio.Forms.Acopio
{
    public partial class Frm_OrdenesNoCapturadas : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_OrdenesNoCapturadas m_FormDefInstance;
        public static Frm_OrdenesNoCapturadas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_OrdenesNoCapturadas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        ConnectionInfo oConexInfo = new ConnectionInfo();
        const string NombreProyecto = "Agro_IntelliTrace";
       
        public string c_codigo_usu { get; set; }
        public string Acopiador { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public Frm_OrdenesNoCapturadas()
        {
            InitializeComponent();
        }
        public string DosCeros1(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Parametros_basededatos();
            Reports.rpt_Bonificacion_NoCapturados RCatalogoP = new Reports.rpt_Bonificacion_NoCapturados();
            Tables RPTTablas = RCatalogoP.Database.Tables;

            foreach (Table oTabla in RPTTablas)
            {
                TableLogOnInfo oTablaConexInfo = oTabla.LogOnInfo;
                oTablaConexInfo.ConnectionInfo = oConexInfo;
                oTabla.ApplyLogOnInfo(oTablaConexInfo);
            }
            RCatalogoP.Refresh();
            FechaInicio = string.Format("{0}/{1}/{2}", DosCeros1(dtInicio.DateTime.Day.ToString()), DosCeros1(dtInicio.DateTime.Month.ToString()), dtInicio.DateTime.Year);
            FechaFin = string.Format("{0}/{1}/{2}", DosCeros1(dtFin.DateTime.Day.ToString()), DosCeros1(dtFin.DateTime.Month.ToString()), dtFin.DateTime.Year);
            RCatalogoP.DataDefinition.FormulaFields["Fecha_Inicio"].Text = string.Format("'{0}'", FechaInicio);
            RCatalogoP.DataDefinition.FormulaFields["Fecha_Fin"].Text = string.Format("'{0}'", FechaFin);
            RPT_Viewer.ReportSource = RCatalogoP;
        }
        private void Parametros_basededatos()
        {
            MSRegistro RegOut = new MSRegistro();
            Crypto DesencriptarTexto = new Crypto();
            string ValServer = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "Server"));
            string ValDB = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "DBase"));
            string ValLogin = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "User"));
            string ValPass = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "Password"));

            oConexInfo.ServerName = ValServer;
            oConexInfo.DatabaseName = ValDB;
            oConexInfo.UserID = ValLogin;
            oConexInfo.Password = ValPass;
        }
    }
}