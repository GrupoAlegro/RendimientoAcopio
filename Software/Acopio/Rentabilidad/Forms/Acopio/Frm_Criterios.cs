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

namespace Acopio
{
    public partial class Frm_Criterios : DevExpress.XtraEditors.XtraForm
    {
        public string EtapaCosechaActiva { get; set; }
        public string c_codigo_eta { get; set; }
        public string v_descripcion_etapa { get; set; }
        public int xRow { get; private set; }
        public int vb_criterio { get; private set; }
        public string vc_codigo_ccali { get; private set; }

        public Frm_Criterios()
        {
            InitializeComponent();
        }
        private void MakeFirstTable()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();
            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column0";
            column.AutoIncrement = false;
            column.Caption = "Codigo";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Column1";
            column.AutoIncrement = false;
            column.Caption = "Calibre";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(Boolean);
            column.ColumnName = "Column2";
            column.AutoIncrement = false;
            column.Caption = "Agrupar";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgCriterios.DataSource = table;

        }
        private void Frm_Criterios_Shown(object sender, EventArgs e)
        {
            BuscarEtapaActiva();
            CargarEtapasCosecha(c_codigo_eta);
            CargarCriteriosCalculos();
            LlenarListaCalibres(c_codigo_eta);
            LlenarPorcentajeCalibres(c_codigo_eta);
        }

        private void CargarCriteriosCalculos()
        {
            CLS_Criterios calcri = new CLS_Criterios();
            calcri.MtdSeleccionarCriterioCalculos();
            if(calcri.Exito)
            {
                for (int i = 0; i < calcri.Datos.Rows.Count; i++)
                {
                    if (calcri.Datos.Rows[i][1].ToString() == "Cat1")
                    {
                        if (Convert.ToBoolean(calcri.Datos.Rows[i][2].ToString()) == true)
                        {
                            chkCat1.Checked = true;
                        }

                        else
                        {
                            chkCat1.Checked = false;
                        }
                    }
                    if (calcri.Datos.Rows[i][1].ToString() == "Cat2")
                    {
                        if (Convert.ToBoolean(calcri.Datos.Rows[i][2].ToString()) == true)
                        {
                            chkCat2.Checked = true;
                        }

                        else
                        {
                            chkCat2.Checked = false;
                        }
                    }
                    if (calcri.Datos.Rows[i][1].ToString() == "Nal")
                    {

                        if (Convert.ToBoolean(calcri.Datos.Rows[i][2].ToString()) == true)
                        {
                            chkNal.Checked = true;
                        }

                        else
                        {
                            chkNal.Checked = false;
                        }
                    }
                }
            }

        }

        private void LlenarListaCalibres(string vc_codigo_eta)
        {
            dtgCriterios.DataSource = null;
            MakeFirstTable();
            CLS_Criterios gst = new CLS_Criterios();
            gst.c_codigo_eta = vc_codigo_eta;
            gst.MtdSeleccionarCriterio();
            if (gst.Exito)
            {
                string vCodigo = string.Empty;
                Boolean VAgrupar = false;
                string vCalibres = string.Empty;
                

                for (int x = 0; x < gst.Datos.Rows.Count; x++)
                {
                    vCodigo = gst.Datos.Rows[x][0].ToString();
                    vCalibres = gst.Datos.Rows[x][1].ToString();
                    VAgrupar =Convert.ToBoolean(gst.Datos.Rows[x][2].ToString());

                    CreatNewRow(vCodigo, vCalibres, VAgrupar);
                }
            }
        }
        private void LlenarPorcentajeCalibres(string vc_codigo_eta)
        {
            CLS_Criterios gst = new CLS_Criterios();
            gst.c_codigo_eta = vc_codigo_eta;
            gst.MtdSeleccionarPorcentajeCriterio();
            if (gst.Exito)
            {
                txtPorcentaje.Text = gst.Datos.Rows[0][0].ToString();
                groupControl2.Text = "Agrupación Calibres " + gst.Datos.Rows[0][2].ToString();
            }
        }
        private void CreatNewRow(string vCodigo, string vCalibres, Boolean VAgrupar)
        {
            dtgValCriterios.AddNewRow();

            int rowHandle = dtgValCriterios.GetRowHandle(dtgValCriterios.DataRowCount);
            if (dtgValCriterios.IsNewItemRow(rowHandle))
            {
                dtgValCriterios.SetRowCellValue(rowHandle, dtgValCriterios.Columns[0], vCodigo);
                dtgValCriterios.SetRowCellValue(rowHandle, dtgValCriterios.Columns[1], vCalibres);
                dtgValCriterios.SetRowCellValue(rowHandle, dtgValCriterios.Columns[2], VAgrupar);
                dtgValCriterios.Columns[0].OptionsColumn.AllowEdit = false;
                dtgValCriterios.Columns[1].OptionsColumn.AllowEdit = false;
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
                   
                    groupControl2.Text = "Agrupación Calibres " + v_descripcion_etapa;
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

        private void cboEtapasCosechas_EditValueChanged(object sender, EventArgs e)
        {
            dtgCriterios.DataSource = null;
            MakeFirstTable();
            LlenarListaCalibres(cboEtapasCosechas.EditValue.ToString());
            LlenarPorcentajeCalibres(cboEtapasCosechas.EditValue.ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgCriterios.FocusedView.CloseEditor();
            GuardarCriterios();
            ActualizarPorcentaje(cboEtapasCosechas.EditValue.ToString(),Convert.ToDecimal(txtPorcentaje.Text));
            ActualizarCriterioVolumen();
            XtraMessageBox.Show("Se guardaron los datos con exito");
        }

        private void ActualizarCriterioVolumen()
        {
            ActualizarVolumen("Cat1", Convert.ToInt32(chkCat1.Checked));
            ActualizarVolumen("Cat2", Convert.ToInt32(chkCat2.Checked));
            ActualizarVolumen("Nal", Convert.ToInt32(chkNal.Checked));
        }

        private void GuardarCriterios()
        {
            for (int i = 0; i < dtgValCriterios.RowCount; i++)
            {
                xRow = dtgValCriterios.GetVisibleRowHandle(i);
                if (Convert.ToBoolean(dtgValCriterios.GetRowCellValue(xRow, "Column2")))
                {
                    vb_criterio = 1;
                }
                else
                {
                    vb_criterio = 0;
                }
                vc_codigo_ccali = dtgValCriterios.GetRowCellValue(xRow, "Column0").ToString();
                ActualizarCriterio(vc_codigo_ccali, vb_criterio);
            }
        }
      
        private void ActualizarCriterio(string vc_codigo_ccali, int vb_criterio)
        {
            CLS_Criterios udp = new CLS_Criterios();
            udp.c_codigo_ccali = vc_codigo_ccali;
            udp.b_criterio = vb_criterio;
            udp.MtdActualizarCriterio();
            if(!udp.Exito)
            {
                XtraMessageBox.Show(udp.Mensaje);
            }
        }
        private void ActualizarPorcentaje(string vc_codigo_eta, decimal vn_criterio_porcentaje)
        {
            CLS_Criterios udp = new CLS_Criterios();
            udp.c_codigo_eta = vc_codigo_eta;
            udp.n_criterio_porcentaje = vn_criterio_porcentaje;
            udp.MtdActualizarPorcentajeAgrupado();
            if (!udp.Exito)
            {
                XtraMessageBox.Show(udp.Mensaje);
            }
        }
        private void ActualizarVolumen(string vv_criteriocalculo, int vb_calculo)
        {
            CLS_Criterios udp = new CLS_Criterios();
            udp.v_criteriocalculo = vv_criteriocalculo;
            udp.b_calculo = vb_calculo;
            udp.MtdActualizarCriterioVolumen();
            if (!udp.Exito)
            {
                XtraMessageBox.Show(udp.Mensaje);
            }
        }
    }
}