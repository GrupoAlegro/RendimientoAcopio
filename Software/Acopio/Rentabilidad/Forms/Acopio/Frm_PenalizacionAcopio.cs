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
using CapaDeDatos;
using DevExpress.XtraGrid.Views.Grid;

namespace Acopio
{
    public partial class Frm_PenalizacionAcopio : DevExpress.XtraEditors.XtraForm
    {
        public bool PrimeraEdicion { get; private set; }
        public string EtapaCosechaActiva { get; set; }
        public string c_codigo_eta { get; set; }
        public string v_descripcion_etapa { get; set; }
        public Frm_PenalizacionAcopio()
        {
            InitializeComponent();
        }

        private void Frm_BonosAcopio_Shown(object sender, EventArgs e)
        {
            PrimeraEdicion = false;
            ColCalidadPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ColCalidadPorcentaje.DisplayFormat.FormatString = "###0.00 %";
            ColCalibresPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ColCalibresPorcentaje.DisplayFormat.FormatString = "###0.00 %";
            CargarPenalizacionCalidad();
            CargarPenalizacionCalibres();
            CargarPenalizacionCamiones();
            BuscarEtapaActiva();
            CargarEtapasCosecha(c_codigo_eta);
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
                    groupControl1.Text = "Penalizacion Calidad " + v_descripcion_etapa;
                    groupControl2.Text = "Penalizacion Calibres " + v_descripcion_etapa;
                }
            }
        }
        private void CargarPenalizacionCalibres()
        {
            CLS_Acopio selGrupo = new CLS_Acopio();
            selGrupo.MtdSeleccionarPenalizacionCalibres();
            if (selGrupo.Exito)
            {
                dtgPenalizacionCalibres.DataSource = selGrupo.Datos;
            }
        }
        private void CargarPenalizacionCalidad()
        {
            CLS_Acopio selCamion = new CLS_Acopio();
            selCamion.MtdSeleccionarPenalizacionCalidad();
            if (selCamion.Exito)
            {
                dtgPenalizacionCalidad.DataSource = selCamion.Datos;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgPenalizacionCalidad.FocusedView.CloseEditor();
                dtgPenalizacionCalibres.FocusedView.CloseEditor();
                ActualizarDatosPenalizacionCalidad();
                ActualizarDatosPenalizacionCalibres();
                ActualizarDatosPenalizacionCamiones();
                XtraMessageBox.Show("Datos Guardados con Exito");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
           
        }

        private void ActualizarDatosPenalizacionCamiones()
        {
            CLS_Acopio artprecio = new CLS_Acopio();
            artprecio.c_codigo_camion = "01";
            artprecio.n_camiones_CMP = Convert.ToInt32(txtCamiones_CMP.Text);
            artprecio.n_camiones_MI = Convert.ToInt32(txtCamionesMI.Text);
            artprecio.MtdActualizarPenalizacionCamiones();
            if (!artprecio.Exito)
            {
                XtraMessageBox.Show(artprecio.Mensaje);
            }
        }

        private void ActualizarDatosPenalizacionCalidad()
        {
            for (int i = 0; i < dtgValPenalizacionCalidad.RowCount; i++)
            {
                CLS_Acopio artprecio = new CLS_Acopio();
                artprecio.c_codigo_pcal = dtgValPenalizacionCalidad.GetRowCellValue(i, dtgValPenalizacionCalidad.Columns["c_codigo_pcal"]).ToString();
                artprecio.v_penalizacion_pcal = dtgValPenalizacionCalidad.GetRowCellValue(i, dtgValPenalizacionCalidad.Columns["v_penalizacion_pcal"]).ToString();
                artprecio.n_porcentaje = Convert.ToDecimal(dtgValPenalizacionCalidad.GetRowCellValue(i, dtgValPenalizacionCalidad.Columns["n_porcentaje"]).ToString());
                artprecio.MtdActualizarPenalizacionCalidad();
                if (!artprecio.Exito)
                {
                    XtraMessageBox.Show(artprecio.Mensaje);
                }
            }

        }
        private void ActualizarDatosPenalizacionCalibres()
        {
            int x = 1;
            for (int i = 0; i < dtgValPenalizacionCalibres.RowCount; i++)
            {
                CLS_Acopio artprecio = new CLS_Acopio();
                artprecio.c_codigo_pcali = dtgValPenalizacionCalibres.GetRowCellValue(i, dtgValPenalizacionCalibres.Columns["c_codigo_pcali"]).ToString();
                artprecio.v_penalizacion_pcali = dtgValPenalizacionCalibres.GetRowCellValue(i, dtgValPenalizacionCalibres.Columns["v_penalizacion_pcali"]).ToString();
                artprecio.n_porcentaje = Convert.ToDecimal(dtgValPenalizacionCalibres.GetRowCellValue(i, dtgValPenalizacionCalibres.Columns["n_porcentaje"]).ToString());
                artprecio.MtdActualizarPenalizacionCalibres();
                if (!artprecio.Exito)
                {
                    XtraMessageBox.Show(artprecio.Mensaje);
                }
            }
        }
        
        private void CargarEtapasCosecha(string Valor)
        {
            CLS_EtapasCosechas cbocost = new CLS_EtapasCosechas();
            cbocost.MtdSeleccionarEtapasCosechas();
            if (cbocost.Exito)
            {
                CargarComboUnidadMedida(cbocost.Datos, Valor);
            }
             
        }
        private void CargarComboUnidadMedida(DataTable Datos, string Valor)
        {
            cboEtapasCosechas.Properties.DisplayMember = "Etapa";
            cboEtapasCosechas.Properties.ValueMember = "Codigo";
            cboEtapasCosechas.EditValue = Valor;
            cboEtapasCosechas.Properties.DataSource = Datos;
        }

        private void btnEstablecerEtapa_Click(object sender, EventArgs e)
        {
            CLS_EtapasCosechas cbocost = new CLS_EtapasCosechas();
            cbocost.c_codigo_eta = cboEtapasCosechas.EditValue.ToString();
            cbocost.MtdEstablecerEtapa();
            if (cbocost.Exito)
            {
                CargarPenalizacionCalidad();
                CargarPenalizacionCalibres();
                BuscarEtapaActiva();
                CargarEtapasCosecha(cboEtapasCosechas.EditValue.ToString());
                XtraMessageBox.Show("Se ha establecido la Etapa de Cosecha con Exito");
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
                    txtCamiones_CMP.Text = selGrupo.Datos.Rows[0][1].ToString();
                    txtCamionesMI.Text = selGrupo.Datos.Rows[0][2].ToString();
                }
            }
        }

        private void txtCamiones_CMP_KeyDown(object sender, KeyEventArgs e)
        {
            Validar_Campos val = new Validar_Campos();
            val.Solo_Numeros(sender,  e, txtCamiones_CMP.Text);
        }

        private void txtCamionesMI_KeyDown(object sender, KeyEventArgs e)
        {
            Validar_Campos val = new Validar_Campos();
            val.Solo_Numeros(sender, e, txtCamionesMI.Text);
        }
    }
}