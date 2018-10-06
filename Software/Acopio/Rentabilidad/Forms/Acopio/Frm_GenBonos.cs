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
using DevExpress.XtraGrid;
using DevExpress.Data;
using CapaDeDatos;

namespace Acopio
{
    public partial class Frm_GenBonos : DevExpress.XtraEditors.XtraForm
    {
        GridColumnSummaryItem siAverage = new GridColumnSummaryItem();

        private static Frm_GenBonos m_FormDefInstance;
        public static Frm_GenBonos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_GenBonos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public string FechaInicio { get; private set; }
        public string FechaFin { get; private set; }
        public string Acopiador { get; private set; }
        public decimal valPenalizacionVolumen { get; private set; }
        public decimal valPenalizacionCalidad { get; private set; }
        public decimal valPenalizacionCalibres { get; private set; }
        public string c_codigo_eta { get; private set; }
        public string v_descripcion_etapa { get; private set; }
        public decimal CamionCMP { get; private set; }
        public decimal CamionMI { get; private set; }
        public decimal valPenalizacionCat1 { get; private set; }
        public decimal valPenalizacionCat2 { get; private set; }
        public decimal valPenalizacionNal { get; private set; }
        public decimal vn_porcentajeCat1 { get; private set; }
        public decimal vn_porcentajeCat2 { get; private set; }
        public decimal vn_porcentajeNal { get; private set; }
        public decimal vn_porcentajeCat { get; private set; }
        public decimal valPenalizacion32 { get; private set; }
        public decimal valPenalizacion36 { get; private set; }
        public decimal valPenalizacion40 { get; private set; }
        public decimal valPenalizacion48 { get; private set; }
        public decimal valPenalizacion60 { get; private set; }
        public decimal valPenalizacion70 { get; private set; }
        public decimal valPenalizacion84 { get; private set; }
        public decimal valPenalizacion96 { get; private set; }
        public decimal vn_porcentajeCal { get; private set; }
        public decimal vn_porcentajeVolumen { get; private set; }
        public decimal vn_porcentaje32 { get; private set; }
        public decimal vn_porcentaje36 { get; private set; }
        public decimal vn_porcentaje40 { get; private set; }
        public decimal vn_porcentaje48 { get; private set; }
        public decimal vn_porcentaje60 { get; private set; }
        public decimal vn_porcentaje70 { get; private set; }
        public decimal vn_porcentaje84 { get; private set; }
        public decimal vn_porcentaje96 { get; private set; }

        public string DosCeros1(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        private void MakeTablaVolumen()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();
            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column0";
            column.AutoIncrement = false;
            column.Caption = "Nombre Huerta";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Column1";
            column.AutoIncrement = false;
            column.Caption = "Est.";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "Column2";
            column.AutoIncrement = false;
            column.Caption = "Rec.";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column3";
            column.AutoIncrement = false;
            column.Caption = "% Obtenido";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column4";
            column.AutoIncrement = false;
            column.Caption = "$ Bono";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column5";
            column.AutoIncrement = false;
            column.Caption = "$ Obtenido";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column6";
            column.AutoIncrement = false;
            column.Caption = "Orden Corte";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgVolumen.DataSource = table;

        }
        private void MakeTablaCalidad()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();
            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column0";
            column.AutoIncrement = false;
            column.Caption = "Nombre Huerta";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column1";
            column.AutoIncrement = false;
            column.Caption = "Cat1";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column2";
            column.AutoIncrement = false;
            column.Caption = "Cat2";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column3";
            column.AutoIncrement = false;
            column.Caption = "Nal";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column4";
            column.AutoIncrement = false;
            column.Caption = "Cat1";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column5";
            column.AutoIncrement = false;
            column.Caption = "Cat2";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column6";
            column.AutoIncrement = false;
            column.Caption = "Nal";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column7";
            column.AutoIncrement = false;
            column.Caption = "% Obtenido";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column14";
            column.AutoIncrement = false;
            column.Caption = "$ Bono";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column8";
            column.AutoIncrement = false;
            column.Caption = "300";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column9";
            column.AutoIncrement = false;
            column.Caption = "360";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column10";
            column.AutoIncrement = false;
            column.Caption = "380";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column11";
            column.AutoIncrement = false;
            column.Caption = "500";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column12";
            column.AutoIncrement = false;
            column.Caption = "Total";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column13";
            column.AutoIncrement = false;
            column.Caption = "Orden Corte";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgCalidad.DataSource = table;

        }
        private void MakeTablaCalibres()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();
            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column0";
            column.AutoIncrement = false;
            column.Caption = "Nombre Huerta";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column1";
            column.AutoIncrement = false;
            column.Caption = "32";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column2";
            column.AutoIncrement = false;
            column.Caption = "36";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column3";
            column.AutoIncrement = false;
            column.Caption = "40";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column4";
            column.AutoIncrement = false;
            column.Caption = "48";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column5";
            column.AutoIncrement = false;
            column.Caption = "60";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column6";
            column.AutoIncrement = false;
            column.Caption = "70";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column7";
            column.AutoIncrement = false;
            column.Caption = "84";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column8";
            column.AutoIncrement = false;
            column.Caption = "96";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column9";
            column.AutoIncrement = false;
            column.Caption = "32";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column10";
            column.AutoIncrement = false;
            column.Caption = "36";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column11";
            column.AutoIncrement = false;
            column.Caption = "40";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column12";
            column.AutoIncrement = false;
            column.Caption = "48";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column13";
            column.AutoIncrement = false;
            column.Caption = "60";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column14";
            column.AutoIncrement = false;
            column.Caption = "70";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column15";
            column.AutoIncrement = false;
            column.Caption = "84";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column16";
            column.AutoIncrement = false;
            column.Caption = "96";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column17";
            column.AutoIncrement = false;
            column.Caption = "% Bono";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column24";
            column.AutoIncrement = false;
            column.Caption = "$ Bono";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column18";
            column.AutoIncrement = false;
            column.Caption = "300";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column19";
            column.AutoIncrement = false;
            column.Caption = "360";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column20";
            column.AutoIncrement = false;
            column.Caption = "380";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column21";
            column.AutoIncrement = false;
            column.Caption = "500";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Column22";
            column.AutoIncrement = false;
            column.Caption = "Total";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column23";
            column.AutoIncrement = false;
            column.Caption = "Orden Corte";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgCalibres.DataSource = table;

        }


        public Frm_GenBonos()
        {
            InitializeComponent();
        }

        private void btnCriterios_Click(object sender, EventArgs e)
        {
            Frm_Criterios frmb = new Frm_Criterios();
            frmb.IsModal = true;
            frmb.Show();
        }

        private void btnPenalizacion_Click(object sender, EventArgs e)
        {
            Frm_PenalizacionAcopio frmb = new Frm_PenalizacionAcopio();
            frmb.IsModal = true;
            frmb.Show();
        }

        private void Frm_GenBonos_Shown(object sender, EventArgs e)
        {
            dtInicio.EditValue = DateTime.Now;
            dtFin.EditValue = DateTime.Now;
            BuscarEtapaActiva();
            FormatoGrids();
            MakeTablaVolumen();
            MakeTablaCalidad();
            MakeTablaCalibres();
            CargarAcopiadores(null);
            lkUpAcopiador.Focus();
            ProgressB.Position = 0;
        }

        private void FormatoGrids()
        {
            /*Formato Grid Volumen*/
            dtgValVolumen.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            dtgValVolumen.OptionsBehavior.Editable = false;
            dtgValVolumen.OptionsCustomization.AllowColumnMoving = false;
            dtgValVolumen.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValVolumen.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValVolumen.OptionsSelection.MultiSelect = true;
            dtgValVolumen.OptionsView.ShowGroupPanel = false;
            gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn8.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn7.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn6.DisplayFormat.FormatString = "#0.00 %";

            /*Formato Grid Calidad*/
            dtgValCalidad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            dtgValCalidad.OptionsBehavior.Editable = false;
            dtgValCalidad.OptionsCustomization.AllowColumnMoving = false;
            dtgValCalidad.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValCalidad.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValCalidad.OptionsSelection.MultiSelect = true;
            dtgValCalidad.OptionsView.ShowGroupPanel = false;
            gridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn17.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn18.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn19.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn20.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn21.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn16.DisplayFormat.FormatString = "#0.00 %";
            bandedGridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            bandedGridColumn4.DisplayFormat.FormatString = "$ ###,###0.00";
            
            /*Formato Grid Calibres*/
            dtgValCalibres.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            dtgValCalibres.OptionsBehavior.Editable = false;
            dtgValCalibres.OptionsCustomization.AllowColumnMoving = false;
            dtgValCalibres.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValCalibres.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValCalibres.OptionsSelection.MultiSelect = true;
            dtgValCalibres.OptionsView.ShowGroupPanel = false;
            gridColumn40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn40.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn41.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn41.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn42.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn42.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn43.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn43.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn44.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn44.DisplayFormat.FormatString = "$ ###,###0.00";
            gridColumn39.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn39.DisplayFormat.FormatString = "#0.00 %";
            bandedGridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            bandedGridColumn5.DisplayFormat.FormatString = "$ ###,###0.00";
        }

        private void CargarAcopiadores(int? Valor)
        {
            CLS_Acopio bAcpopiadores = new CLS_Acopio();
            bAcpopiadores.MtdSeleccionarAcopiadores();
            if (bAcpopiadores.Exito)
            {
                CargarCombo(bAcpopiadores.Datos, Valor);
            }
        }
        private void CargarCombo(DataTable Datos, int? Valor)
        {
            lkUpAcopiador.Properties.DisplayMember = "c_acopiador_Cal";
            lkUpAcopiador.Properties.ValueMember = "c_codigo_zon";
            lkUpAcopiador.EditValue = Valor;
            lkUpAcopiador.Properties.DataSource = Datos;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LimpiarGrids();
            txtCamiones_CMP.Text = string.Empty;
            txtCamionesMI.Text = string.Empty;
            if (lkUpAcopiador.EditValue != null)
            {
                if (ConsultaNoCaturados())
                {
                    DialogResult = XtraMessageBox.Show("¿Existe cortes no Capturados Deseas seguir generando el bono?", "Capturas por completar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult == DialogResult.Yes)
                    {
                        CalcularBonos();
                    }
                }
                else
                {
                    CalcularBonos();
                }
            }
            else
            {
                XtraMessageBox.Show("Falta Seleccionar un Acopiador");
            }
        }

        private void LimpiarGrids()
        {
            dtgVolumen.DataSource = null;
            MakeTablaVolumen();
            dtgCalidad.DataSource = null;
            MakeTablaCalidad();
            dtgCalibres.DataSource = null;
            MakeTablaCalibres();
        }

        private void CalcularBonos()
        {
            CamionesCancelados();
            llenarGris();
        }

        private void llenarGris()
        {
            CLS_Acopio cortesel = new CLS_Acopio();
            if (lkUpAcopiador.EditValue == null)
            {
                Acopiador = string.Empty;
            }
            else
            {
                Acopiador = lkUpAcopiador.Text;
            }
            FechaInicio = dtInicio.DateTime.Year + DosCeros1(dtInicio.DateTime.Month.ToString()) + DosCeros1(dtInicio.DateTime.Day.ToString());
            FechaFin = dtFin.DateTime.Year + DosCeros1(dtFin.DateTime.Month.ToString()) + DosCeros1(dtFin.DateTime.Day.ToString());
            cortesel.Acopiador = Acopiador;
            cortesel.FechaInicio = FechaInicio;
            cortesel.FechaFin = FechaFin;
            cortesel.MtdSeleccionarCortesAcopiadores();
            if (cortesel.Exito)
            {
                if (cortesel.Datos.Rows.Count > 0)
                {
                    ProgressB.Position = 0;
                    Application.DoEvents();
                    InsertarBonificacionVolumen(cortesel.Datos);
                    ProgressB.Position = 30;
                    Application.DoEvents();
                    InsertarBonificacionCalidad(cortesel.Datos);
                    ProgressB.Position = 60;
                    Application.DoEvents();
                    InsertarBonificacionCalibre(cortesel.Datos);
                    ProgressB.Position = 100;
                    Application.DoEvents();
                }
                else
                {
                    XtraMessageBox.Show("No existen datos para mostrar");
                }
            }
        }

        private void InsertarBonificacionCalibre(DataTable datos)
        {
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                string vOrdenCorte = datos.Rows[i]["c_codigo_oct"].ToString();
                string vHuerta = datos.Rows[i]["Huerta"].ToString();
                string vnEst32 = datos.Rows[i]["Est32"].ToString();
                string vnEst36 = datos.Rows[i]["Est36"].ToString();
                string vnEst40 = datos.Rows[i]["Est40"].ToString();
                string vnEst48 = datos.Rows[i]["Est48"].ToString();
                string vnEst60 = datos.Rows[i]["Est60"].ToString();
                string vnEst70 = datos.Rows[i]["Est70"].ToString();
                string vnEst84 = datos.Rows[i]["Est84"].ToString();
                string vnEst96 = datos.Rows[i]["Est96"].ToString();
                string vnPro32 = datos.Rows[i]["Pro32"].ToString();
                string vnPro36 = datos.Rows[i]["Pro36"].ToString();
                string vnPro40 = datos.Rows[i]["Pro40"].ToString();
                string vnPro48 = datos.Rows[i]["Pro48"].ToString();
                string vnPro60 = datos.Rows[i]["Pro60"].ToString();
                string vnPro70 = datos.Rows[i]["Pro70"].ToString();
                string vnPro84 = datos.Rows[i]["Pro84"].ToString();
                string vnPro96 = datos.Rows[i]["Pro96"].ToString();
                string vEstimado = datos.Rows[i]["n_cajas_pcd"].ToString();
                decimal vn_porcentajeGrupo = PorcentajeGrupo("03");
                decimal vn_bono_completo = MontoCompletoCamion(Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString()));
                string vTotalObtenido = "0";
                decimal ProcRecibido = 0;
                string vPorcObtenido = string.Empty;
                ConsultaParametrosPenalizacionCal(c_codigo_eta);

                if (Convert.ToDecimal(datos.Rows[i]["Est32"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro32"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est32"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est32"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje32 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro32"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est32"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est32"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje32 = 0;
                    }
                }
                else
                {
                    vn_porcentaje32 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est36"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro36"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est36"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est36"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje36 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro36"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est36"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est36"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje36 = 0;
                    }
                }
                else
                {
                    vn_porcentaje36 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est40"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro40"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est40"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est40"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje40 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro40"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est40"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est40"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje40 = 0;
                    }
                }
                else
                {
                    vn_porcentaje40 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est48"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro48"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est48"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est48"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje48 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro48"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est48"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est48"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje48 = 0;
                    }
                }
                else
                {
                    vn_porcentaje48 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est60"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro60"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est60"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est60"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje60 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro60"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est60"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est60"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje60 = 0;
                    }
                }
                else
                {
                    vn_porcentaje60 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est70"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro70"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est70"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est70"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje70 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro70"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est70"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est70"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje70 = 0;
                    }
                }
                else
                {
                    vn_porcentaje70 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est84"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro84"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est84"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est84"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje84 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro84"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est84"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est84"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje84 = 0;
                    }
                }
                else
                {
                    vn_porcentaje84 = 0;
                }

                if (Convert.ToDecimal(datos.Rows[i]["Est96"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["Pro96"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est96"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est96"].ToString()) / 100) > 0)
                    {
                        vn_porcentaje96 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["Pro96"].ToString()) / Convert.ToDecimal(datos.Rows[i]["Est96"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["Est96"].ToString()) / 100);
                    }
                    else
                    {
                        vn_porcentaje96 = 0;
                    }
                }
                else
                {
                    vn_porcentaje96 = 0;
                }

                vn_porcentajeCal = vn_porcentaje32 + vn_porcentaje36 + vn_porcentaje40 + vn_porcentaje48 + vn_porcentaje60 + vn_porcentaje70 + vn_porcentaje84 + vn_porcentaje96;

                vPorcObtenido = Convert.ToString(1 - (vn_porcentajeCal/100));
                string vTotalBono = Convert.ToString(vn_bono_completo * vn_porcentajeGrupo * (100 - (0 )) / 100);
                string v300 = string.Empty;
                string v360 = string.Empty;
                string v380 = string.Empty;
                string v500 = string.Empty;
                if(vn_porcentajeCal>20)
                {
                    vn_porcentajeCal = 20;
                }
                switch (datos.Rows[i]["n_cajas_pcd"].ToString())
                {
                    case "300":

                        v300 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCal )) / 100);
                        v360 = "0";
                        v380 = "0";
                        v500 = "0";

                        break;
                    case "360":
                        v300 = "0";
                        v360 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCal )) / 100);
                        v380 = "0";
                        v500 = "0";
                        break;
                    case "380":
                        v300 = "0";
                        v360 = "0";
                        v380 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCal )) / 100);
                        v500 = "0";
                        break;
                    case "500":
                        v300 = "0";
                        v360 = "0";
                        v380 = "0";
                        v500 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCal )) / 100);
                        break;
                }
                /*
                 Validar si obtuvo el bono por volumne
                 Validar si obtuvo el bono por Calidad
                 Validar si paso las penalizaciones por calibres
                 Validad si alcanzo el porcentaje minimo por calibres
                 Validar si alcanzo la sumatoria del grupo por calibres
                 */

                CreatNewRowCalibres(vOrdenCorte, vHuerta, vnEst32, vnEst36, vnEst40, vnEst48, vnEst60, vnEst70, vnEst84, vnEst96,
                                                      vnPro32, vnPro36, vnPro40, vnPro48, vnPro60, vnPro70, vnPro84, vnPro96,
                                                      vPorcObtenido, vTotalBono, v300, v360, v380, v500, vTotalObtenido);
            }
        }

        private void CreatNewRowCalibres(string OrdenCorte, string Huerta, string Est32, string Est36, string Est40, string Est48, string Est60, string Est70, string Est84, string Est96,
                                        string Pro32, string Pro36, string Pro40, string Pro48, string Pro60, string Pro70, string Pro84, string Pro96, 
                                        object PorcObtenido, object TotalBono, object C300, object C360, object C380, object C500, string TotalObtenido)
        {
            dtgValCalibres.AddNewRow();

            int rowHandle = dtgValCalibres.GetRowHandle(dtgValCalibres.DataRowCount);
            if (dtgValCalibres.IsNewItemRow(rowHandle))
            {
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column23"], OrdenCorte);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column0"], Huerta);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column1"], Est32);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column2"], Est36);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column3"], Est40);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column4"], Est48);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column5"], Est60);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column6"], Est70);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column7"], Est84);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column8"], Est96);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column9"], Pro32);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column10"], Pro36);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column11"], Pro40);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column12"], Pro48);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column13"], Pro60);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column14"], Pro70);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column15"], Pro84);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column16"], Pro96);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column17"], PorcObtenido);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column18"], C300);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column19"], C360);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column20"], C380);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column21"], C500);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column22"], TotalObtenido);
                dtgValCalibres.SetRowCellValue(rowHandle, dtgValCalibres.Columns["Column24"], TotalBono);
            }
        }

        private void ConsultaParametrosPenalizacionCal(string c_codigo_eta)
        {
            CLS_Acopio selCamion = new CLS_Acopio();
            selCamion.c_codigo_eta = c_codigo_eta;
            selCamion.MtdSeleccionarPenalizacionCalibres();
            if (selCamion.Exito)
            {
                for (int i = 0; i < selCamion.Datos.Rows.Count; i++)
                {
                    switch (selCamion.Datos.Rows[i]["v_penalizacion_pcali"].ToString())
                    {
                        case "32":
                            valPenalizacion32 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "36":
                            valPenalizacion36 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "40":
                            valPenalizacion40 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "48":
                            valPenalizacion48 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "60":
                            valPenalizacion60 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "70":
                            valPenalizacion70 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "84":
                            valPenalizacion84 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "96":
                            valPenalizacion96 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                    }
                }
            }
        }
        private void InsertarBonificacionCalidad(DataTable datos)
        {
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                vn_porcentajeCat1 = 0;
                vn_porcentajeCat2 = 0;
                vn_porcentajeNal = 0;
                vn_porcentajeCat = 0;
                string vOrdenCorte = datos.Rows[i]["c_codigo_oct"].ToString();
                string vHuerta = datos.Rows[i]["Huerta"].ToString();
                string vEstCat1 = datos.Rows[i]["EstCat1"].ToString();
                string vEstCat2 = datos.Rows[i]["EstCat2"].ToString();
                string vEstNal = datos.Rows[i]["EstNal"].ToString();
                string vProdCat1 = datos.Rows[i]["ProCat1"].ToString();
                string vProdCat2 = datos.Rows[i]["ProCat2"].ToString();
                string vProdNal = datos.Rows[i]["ProNal"].ToString();
                string vEstimado = datos.Rows[i]["n_cajas_pcd"].ToString();
                decimal vn_porcentajeGrupo = PorcentajeGrupo("02");
                decimal vn_bono_completo = MontoCompletoCamion(Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString()));
                string vTotalObtenido = string.Empty;
                decimal ProcRecibido = 0;
                ConsultaParametrosPenalizacionCat(c_codigo_eta);
                if (Convert.ToDecimal(datos.Rows[i]["EstCat1"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["ProCat1"].ToString()) / Convert.ToDecimal(datos.Rows[i]["EstCat1"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["EstCat1"].ToString()) / 100) > 0)
                    {
                        vn_porcentajeCat1 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["ProCat1"].ToString()) / Convert.ToDecimal(datos.Rows[i]["EstCat1"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["EstCat1"].ToString()) / 100)/100;
                    }
                    else
                    {
                        vn_porcentajeCat1 = 0;
                    }
                }
                else
                {
                    vn_porcentajeCat1 = 0;
                }
                if (Convert.ToDecimal(datos.Rows[i]["EstCat2"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["ProCat2"].ToString()) / Convert.ToDecimal(datos.Rows[i]["EstCat2"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["EstCat2"].ToString()) / 100) > 0)
                    {
                        vn_porcentajeCat2 = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["ProCat2"].ToString()) / Convert.ToDecimal(datos.Rows[i]["EstCat2"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["EstCat2"].ToString()) / 100)/100;
                    }
                    else
                    {
                        vn_porcentajeCat2 = 0;
                    }
                }
                else
                {
                    vn_porcentajeCat2 = 0;
                }
                if (Convert.ToDecimal(datos.Rows[i]["EstNal"].ToString()) > 0)
                {
                    if ((100 - (((Convert.ToDecimal(datos.Rows[i]["ProNal"].ToString()) / Convert.ToDecimal(datos.Rows[i]["EstNal"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["EstNal"].ToString()) / 100) > 0)
                    {
                        vn_porcentajeNal = Math.Abs(100 - (((Convert.ToDecimal(datos.Rows[i]["ProNal"].ToString()) / Convert.ToDecimal(datos.Rows[i]["EstNal"].ToString())) * 100))) * (Convert.ToDecimal(datos.Rows[i]["EstNal"].ToString()) / 100)/100;
                    }
                    else
                    {
                        vn_porcentajeNal = 0;
                    }
                }
                else
                {
                    vn_porcentajeNal = 0;
                }

                vn_porcentajeCat = CalculaPorcentaje();

                if (Convert.ToDecimal(datos.Rows[i]["ProCat1"].ToString()) / 100 > valPenalizacionCat1 || Convert.ToDecimal(datos.Rows[i]["ProCat2"].ToString()) / 100 > valPenalizacionCat2 || Convert.ToDecimal(datos.Rows[i]["ProNal"].ToString()) / 100 > valPenalizacionNal)
                {
                    vTotalObtenido = "0";
                }
                else
                {
                    if ((Convert.ToDecimal(datos.Rows[i]["EstCajas"].ToString())) / Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString()) > 1)
                    {
                        ProcRecibido = 1;
                    }
                    else
                    {
                        ProcRecibido = (Convert.ToDecimal(datos.Rows[i]["EstCajas"].ToString())) / Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString());
                    }

                    if (ProcRecibido < (valPenalizacionVolumen) || Convert.ToDecimal(txtCamiones_CMP.Text) > CamionCMP || Convert.ToDecimal(txtCamionesMI.Text) > CamionMI)
                    {
                        vTotalObtenido = "0";
                    }
                    else
                    {
                        if ((1 - vn_porcentajeCat) <= valPenalizacionCalidad)
                        {
                            vTotalObtenido = "0";
                        }
                        else
                        {
                            vTotalObtenido = Convert.ToString(((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCat * 5)) / 100));
                        }
                    }
                }
                string vPorcObtenido = string.Empty;
                string vTotalBono = Convert.ToString(vn_bono_completo * vn_porcentajeGrupo * (100 - (0 * 5)) / 100);
                string v300 = string.Empty;
                string v360 = string.Empty;
                string v380 = string.Empty;
                string v500 = string.Empty;
                switch (datos.Rows[i]["n_cajas_pcd"].ToString())
                {
                    case "300":
                        v300 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCat * 5)) / 100);
                        v360 = "0";
                        v380 = "0";
                        v500 = "0";

                        break;
                    case "360":
                        v300 = "0";
                        v360 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCat * 5)) / 100);
                        v380 = "0";
                        v500 = "0";
                        break;
                    case "380":
                        v300 = "0";
                        v360 = "0";
                        v380 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCat * 5)) / 100);
                        v500 = "0";
                        break;
                    case "500":
                        v300 = "0";
                        v360 = "0";
                        v380 = "0";
                        v500 = Convert.ToString((vn_bono_completo * vn_porcentajeGrupo) * (100 - (vn_porcentajeCat * 5)) / 100);
                        break;
                }
                vPorcObtenido = Convert.ToString(1-vn_porcentajeCat);
                CreatNewRowCalidad(vOrdenCorte, vHuerta, vEstCat1, vEstCat2, vEstNal, vProdCat1, vProdCat2, vProdNal, vPorcObtenido, vTotalBono, v300, v360, v380, v500, vTotalObtenido);
            }
        }
        private decimal CalculaPorcentaje()
        {
            decimal VPorcentaje = 0;
            CLS_Criterios calcri = new CLS_Criterios();
            calcri.MtdSeleccionarCriterioCalculos();
            if (calcri.Exito)
            {
                for (int i = 0; i < calcri.Datos.Rows.Count; i++)
                {
                    if (calcri.Datos.Rows[i][1].ToString() == "Cat1")
                    {
                        if (Convert.ToBoolean(calcri.Datos.Rows[i][2].ToString()) == true)
                        {
                            VPorcentaje += vn_porcentajeCat1;
                        }
                    }
                    if (calcri.Datos.Rows[i][1].ToString() == "Cat2")
                    {
                        if (Convert.ToBoolean(calcri.Datos.Rows[i][2].ToString()) == true)
                        {
                            VPorcentaje += vn_porcentajeCat2;
                        }
                    }
                    if (calcri.Datos.Rows[i][1].ToString() == "Nal")
                    {

                        if (Convert.ToBoolean(calcri.Datos.Rows[i][2].ToString()) == true)
                        {
                            VPorcentaje += vn_porcentajeNal;
                        }
                    }
                }
            }
            return VPorcentaje;
        }
        private void ConsultaParametrosPenalizacionCat(string c_codigo_eta)
        {
            CLS_Acopio selCamion = new CLS_Acopio();
            selCamion.c_codigo_eta = c_codigo_eta;
            selCamion.MtdSeleccionarPenalizacionCalidad();
            if (selCamion.Exito)
            {
                for (int i = 0; i < selCamion.Datos.Rows.Count; i++)
                {
                    switch (selCamion.Datos.Rows[i]["v_penalizacion_pcal"].ToString())
                    {
                        case "Cat1":
                            valPenalizacionCat1 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "Cat2":
                            valPenalizacionCat2 = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "Nacional":
                            valPenalizacionNal = Convert.ToDecimal(selCamion.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                    }
                }
            }
        }
        private void InsertarBonificacionVolumen(DataTable datos)
        {
            CargarPenalizacionVolumen(c_codigo_eta);
            CargarPenalizacionCamiones();
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                string vOrdenCorte = datos.Rows[i]["c_codigo_oct"].ToString();
                string vHuerta = datos.Rows[i]["Huerta"].ToString();
                string vEstimado = datos.Rows[i]["n_cajas_pcd"].ToString();
                string vRecibido =Convert.ToInt32(datos.Rows[i]["EstCajas"]).ToString();
                decimal ProcRecibido = 0;
                if ((Convert.ToDecimal(datos.Rows[i]["EstCajas"].ToString())) / Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString()) > 1)
                {
                    ProcRecibido = 1;
                }
                else
                {
                    ProcRecibido = (Convert.ToDecimal(datos.Rows[i]["EstCajas"].ToString())) / Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString());
                }
                string vPorcRecibido = ProcRecibido.ToString();
                string vTotalBono = (MontoCompletoCamion(Convert.ToDecimal(datos.Rows[i]["n_cajas_pcd"].ToString())) * PorcentajeGrupo("01")).ToString();
                string vTotalObtenido;
                if (Convert.ToDecimal(vPorcRecibido) < (valPenalizacionVolumen) || Convert.ToDecimal(txtCamiones_CMP.Text)> CamionCMP || Convert.ToDecimal(txtCamionesMI.Text) > CamionMI)
                {
                    vTotalObtenido = "0";
                }
                else
                {
                    vTotalObtenido = (ProcRecibido * Convert.ToDecimal(vTotalBono)).ToString();
                }
                CreatNewRowVolumen(vOrdenCorte, vHuerta, vEstimado, vRecibido, vPorcRecibido, vTotalBono, vTotalObtenido);
            }
        }
        private void BuscarEtapaActiva()
        {
            CLS_EtapasCosechas cbocost = new CLS_EtapasCosechas();
            cbocost.MtdSeleccionarEtapasCosechasActiva();
            if (cbocost.Exito)
            {
                if (cbocost.Datos.Rows.Count > 0)
                {
                    c_codigo_eta = cbocost.Datos.Rows[0][0].ToString();
                    v_descripcion_etapa = cbocost.Datos.Rows[0][1].ToString();
                    txtEtapaActiva.Text = v_descripcion_etapa;
                }
            }
        }
        private void CargarPenalizacionVolumen(string c_codigo_eta)
        {
            CLS_Acopio selGrupo = new CLS_Acopio();
            selGrupo.c_codigo_eta = c_codigo_eta;
            selGrupo.MtdSeleccionarPenalizacionEvaluacionGrupo();
            if (selGrupo.Exito)
            {
                for (int i = 0; i < selGrupo.Datos.Rows.Count; i++)
                {
                    switch (selGrupo.Datos.Rows[i]["v_penalizacion_egru"].ToString())
                    {
                        case "Volumen":
                            valPenalizacionVolumen = Convert.ToDecimal(selGrupo.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "Calidad":
                            valPenalizacionCalidad = Convert.ToDecimal(selGrupo.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                        case "Calibres":
                            valPenalizacionCalibres = Convert.ToDecimal(selGrupo.Datos.Rows[i]["n_porcentaje"].ToString());
                            break;
                    }
                }
                valPenalizacionVolumen = Convert.ToDecimal(selGrupo.Datos.Rows[0][2].ToString());
            }
        }
        private void CargarPenalizacionCamiones()
        {
            CLS_Acopio selGrupo = new CLS_Acopio();
            selGrupo.c_codigo_camion = "01";
            selGrupo.MtdSeleccionarPenalizacionCamiones();
            if (selGrupo.Exito)
            {
                if (selGrupo.Datos.Rows.Count > 0)
                {
                    CamionCMP =Convert.ToDecimal(selGrupo.Datos.Rows[0][1].ToString());
                    CamionMI = Convert.ToDecimal(selGrupo.Datos.Rows[0][2].ToString());
                }
            }
        }
        private decimal PorcentajeGrupo(string v)
        {
            decimal Valor = 0;
            CLS_Acopio selGrupo = new CLS_Acopio();
            selGrupo.c_codigo_gru = v.ToString();
            selGrupo.MtdSeleccionarGrupoPagoBono();
            if (selGrupo.Exito)
            {
                if (selGrupo.Datos.Rows.Count > 0)
                {
                    Valor = Convert.ToDecimal(selGrupo.Datos.Rows[0]["n_porcentaje"].ToString());
                }
                else
                {
                    XtraMessageBox.Show("No se encontraron Registro para este Grupo");
                }
            }
            else
            {
                XtraMessageBox.Show(selGrupo.Mensaje);
            }
            return Valor;
        }
        private decimal MontoCompletoCamion(decimal v)
        {
            decimal Valor = 0;
            CLS_Acopio selMCompleto = new CLS_Acopio();
            selMCompleto.v_tipo_camion = v.ToString();
            selMCompleto.MtdSeleccionarPagoCamionBono();
            if (selMCompleto.Exito)
            {
                if (selMCompleto.Datos.Rows.Count > 0)
                {
                    Valor = Convert.ToDecimal(selMCompleto.Datos.Rows[0]["n_monto_pago"].ToString());
                }
                else
                {
                    Valor = 0;
                }
            }
            else
            {
                XtraMessageBox.Show(selMCompleto.Mensaje);
            }
            return Valor;
        }
        private void CreatNewRowVolumen(string OrdenCorte, string Huerta, string Estimado, string Recibido, string PorcRecibido, string TotalBono, string TotalObtenido)
        {
            dtgValVolumen.AddNewRow();

            int rowHandle = dtgValVolumen.GetRowHandle(dtgValVolumen.DataRowCount);
            if (dtgValVolumen.IsNewItemRow(rowHandle))
            {
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column6"], OrdenCorte);
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column0"], Huerta);
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column1"],Estimado);
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column2"],Recibido);
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column3"], PorcRecibido);
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column4"], TotalBono);
                dtgValVolumen.SetRowCellValue(rowHandle, dtgValVolumen.Columns["Column5"], TotalObtenido);
            }
        }
        private void CreatNewRowCalidad(string OrdenCorte, string Huerta, string EstCat1, string EstCat2, string EstNal, string ProdCat1, string ProdCat2, string ProdNal, 
                                        string PorcObtenido, string TotalBono, string C300, string C360, string C380, string C500, string TotalObtenido)
        {
            dtgValCalidad.AddNewRow();

            int rowHandle = dtgValCalidad.GetRowHandle(dtgValCalidad.DataRowCount);
            if (dtgValCalidad.IsNewItemRow(rowHandle))
            {
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column13"], OrdenCorte);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column0"], Huerta);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column1"], EstCat1);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column2"], EstCat2);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column3"], EstNal);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column4"], ProdCat1);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column5"], ProdCat2);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column6"], ProdNal);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column7"], PorcObtenido);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column8"], C300);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column9"], C360);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column10"], C380);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column11"], C500);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column12"], TotalObtenido);
                dtgValCalidad.SetRowCellValue(rowHandle, dtgValCalidad.Columns["Column14"], TotalBono);
            }
        }

        private void CamionesCancelados()
        {
            CLS_Acopio corteseln = new CLS_Acopio();
            FechaInicio = dtInicio.DateTime.Year + DosCeros1(dtInicio.DateTime.Month.ToString()) + DosCeros1(dtInicio.DateTime.Day.ToString());
            FechaFin = dtFin.DateTime.Year + DosCeros1(dtFin.DateTime.Month.ToString()) + DosCeros1(dtFin.DateTime.Day.ToString());
            corteseln.FechaInicio = FechaInicio;
            corteseln.FechaFin = FechaFin;
            corteseln.c_codigo_zon = lkUpAcopiador.EditValue.ToString();
            corteseln.MtdSeleccionarCancelMixtos();
            if (corteseln.Exito)
            {
                if(corteseln.Datos.Rows.Count>0)
                {
                    txtCamiones_CMP.Text= corteseln.Datos.Rows[0][0].ToString();
                    txtCamionesMI.Text= corteseln.Datos.Rows[0][1].ToString();
                }
                else
                {
                    txtCamiones_CMP.Text = "0";
                    txtCamionesMI.Text = "0";
                }
            }
        }

        private Boolean ConsultaNoCaturados()
        {
            Boolean Valor = false;
            CLS_Acopio corteseln = new CLS_Acopio();
            FechaInicio = dtInicio.DateTime.Year + DosCeros1(dtInicio.DateTime.Month.ToString()) + DosCeros1(dtInicio.DateTime.Day.ToString());
            FechaFin = dtFin.DateTime.Year + DosCeros1(dtFin.DateTime.Month.ToString()) + DosCeros1(dtFin.DateTime.Day.ToString());
            corteseln.FechaInicio = FechaInicio;
            corteseln.FechaFin = FechaFin;
            corteseln.MtdSeleccionarCapturasPendientes();
            if (corteseln.Exito)
            {
                if (corteseln.Datos.Rows.Count > 0)
                {
                    Valor = true;
                }
            }
            return Valor;
        }

        private void btnBonos_Click(object sender, EventArgs e)
        {
            Frm_BonosAcopio frmb = new Frm_BonosAcopio();
            frmb.IsModal = true;
            frmb.Show();
        }
    }
}