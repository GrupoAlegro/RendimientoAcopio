namespace Acopio
{
    partial class Frm_PenalizacionAcopio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PenalizacionAcopio));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEstablecerEtapa = new DevExpress.XtraEditors.SimpleButton();
            this.cboEtapasCosechas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCamionesMI = new DevExpress.XtraEditors.TextEdit();
            this.txtCamiones_CMP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dtgPenalizacionCalibres = new DevExpress.XtraGrid.GridControl();
            this.dtgValPenalizacionCalibres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCalibresPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtgPenalizacionCalidad = new DevExpress.XtraGrid.GridControl();
            this.dtgValPenalizacionCalidad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCalidadPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeVolumen = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEtapasCosechas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamionesMI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamiones_CMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPenalizacionCalibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValPenalizacionCalibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPenalizacionCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValPenalizacionCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeVolumen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtPorcentajeVolumen);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnEstablecerEtapa);
            this.panelControl1.Controls.Add(this.cboEtapasCosechas);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtCamionesMI);
            this.panelControl1.Controls.Add(this.txtCamiones_CMP);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnGuardar);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(841, 412);
            this.panelControl1.TabIndex = 0;
            // 
            // btnEstablecerEtapa
            // 
            this.btnEstablecerEtapa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEstablecerEtapa.ImageOptions.Image")));
            this.btnEstablecerEtapa.Location = new System.Drawing.Point(665, 293);
            this.btnEstablecerEtapa.Name = "btnEstablecerEtapa";
            this.btnEstablecerEtapa.Size = new System.Drawing.Size(120, 29);
            this.btnEstablecerEtapa.TabIndex = 10;
            this.btnEstablecerEtapa.Text = "Establecer Etapa \r\nActiva";
            this.btnEstablecerEtapa.Click += new System.EventHandler(this.btnEstablecerEtapa_Click);
            // 
            // cboEtapasCosechas
            // 
            this.cboEtapasCosechas.EditValue = "Seleecion una Etapa de";
            this.cboEtapasCosechas.Location = new System.Drawing.Point(454, 297);
            this.cboEtapasCosechas.Name = "cboEtapasCosechas";
            this.cboEtapasCosechas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEtapasCosechas.Properties.NullText = "Seleecion una Etapa de Cosecha";
            this.cboEtapasCosechas.Properties.View = this.gridLookUpEdit1View;
            this.cboEtapasCosechas.Size = new System.Drawing.Size(195, 20);
            this.cboEtapasCosechas.TabIndex = 9;
            this.cboEtapasCosechas.EditValueChanged += new System.EventHandler(this.cboEtapasCosechas_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(150, 363);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 26);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Camiones\r\nMixtos Incompletos";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(150, 328);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 26);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Camiones Cancelados\r\nMaximos Permitidos";
            // 
            // txtCamionesMI
            // 
            this.txtCamionesMI.Location = new System.Drawing.Point(267, 366);
            this.txtCamionesMI.Name = "txtCamionesMI";
            this.txtCamionesMI.Size = new System.Drawing.Size(100, 20);
            this.txtCamionesMI.TabIndex = 6;
            this.txtCamionesMI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCamionesMI_KeyDown);
            // 
            // txtCamiones_CMP
            // 
            this.txtCamiones_CMP.Location = new System.Drawing.Point(267, 331);
            this.txtCamiones_CMP.Name = "txtCamiones_CMP";
            this.txtCamiones_CMP.Size = new System.Drawing.Size(100, 20);
            this.txtCamiones_CMP.TabIndex = 5;
            this.txtCamiones_CMP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCamiones_CMP_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(454, 334);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(355, 43);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nota: Los porcentajes que se  encuentren \r\ncapturados Seran los maximos permitido" +
    "s";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(22, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 47);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl3);
            this.groupControl2.Location = new System.Drawing.Point(444, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(6);
            this.groupControl2.Size = new System.Drawing.Size(383, 271);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Penalizacion Calibres";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dtgPenalizacionCalibres);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(8, 26);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(367, 237);
            this.panelControl3.TabIndex = 1;
            // 
            // dtgPenalizacionCalibres
            // 
            this.dtgPenalizacionCalibres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPenalizacionCalibres.Location = new System.Drawing.Point(2, 2);
            this.dtgPenalizacionCalibres.MainView = this.dtgValPenalizacionCalibres;
            this.dtgPenalizacionCalibres.Name = "dtgPenalizacionCalibres";
            this.dtgPenalizacionCalibres.Size = new System.Drawing.Size(363, 233);
            this.dtgPenalizacionCalibres.TabIndex = 1;
            this.dtgPenalizacionCalibres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValPenalizacionCalibres});
            // 
            // dtgValPenalizacionCalibres
            // 
            this.dtgValPenalizacionCalibres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.ColCalibresPorcentaje});
            this.dtgValPenalizacionCalibres.GridControl = this.dtgPenalizacionCalibres;
            this.dtgValPenalizacionCalibres.Name = "dtgValPenalizacionCalibres";
            this.dtgValPenalizacionCalibres.OptionsView.ShowFooter = true;
            this.dtgValPenalizacionCalibres.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Codigo";
            this.gridColumn5.FieldName = "c_codigo_pcali";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Calibre";
            this.gridColumn6.FieldName = "v_penalizacion_pcali";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // ColCalibresPorcentaje
            // 
            this.ColCalibresPorcentaje.Caption = "Porcentaje Mayor a";
            this.ColCalibresPorcentaje.FieldName = "n_porcentaje";
            this.ColCalibresPorcentaje.Name = "ColCalibresPorcentaje";
            this.ColCalibresPorcentaje.Visible = true;
            this.ColCalibresPorcentaje.VisibleIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(6);
            this.groupControl1.Size = new System.Drawing.Size(426, 271);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Penalizacion Calidad";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtgPenalizacionCalidad);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(8, 26);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(410, 237);
            this.panelControl2.TabIndex = 0;
            // 
            // dtgPenalizacionCalidad
            // 
            this.dtgPenalizacionCalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPenalizacionCalidad.Location = new System.Drawing.Point(2, 2);
            this.dtgPenalizacionCalidad.MainView = this.dtgValPenalizacionCalidad;
            this.dtgPenalizacionCalidad.Name = "dtgPenalizacionCalidad";
            this.dtgPenalizacionCalidad.Size = new System.Drawing.Size(406, 233);
            this.dtgPenalizacionCalidad.TabIndex = 2;
            this.dtgPenalizacionCalidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValPenalizacionCalidad});
            // 
            // dtgValPenalizacionCalidad
            // 
            this.dtgValPenalizacionCalidad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.ColCalidadPorcentaje});
            this.dtgValPenalizacionCalidad.GridControl = this.dtgPenalizacionCalidad;
            this.dtgValPenalizacionCalidad.Name = "dtgValPenalizacionCalidad";
            this.dtgValPenalizacionCalidad.OptionsView.ShowFooter = true;
            this.dtgValPenalizacionCalidad.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "c_codigo_pcal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Calidad";
            this.gridColumn2.FieldName = "v_penalizacion_pcal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // ColCalidadPorcentaje
            // 
            this.ColCalidadPorcentaje.Caption = "Porcentaje Mayor a";
            this.ColCalidadPorcentaje.FieldName = "n_porcentaje";
            this.ColCalidadPorcentaje.Name = "ColCalidadPorcentaje";
            this.ColCalidadPorcentaje.Visible = true;
            this.ColCalidadPorcentaje.VisibleIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(150, 293);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 26);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Porcentaje Minimo \r\nVolumen x Camion";
            // 
            // txtPorcentajeVolumen
            // 
            this.txtPorcentajeVolumen.Location = new System.Drawing.Point(267, 296);
            this.txtPorcentajeVolumen.Name = "txtPorcentajeVolumen";
            this.txtPorcentajeVolumen.Properties.Mask.EditMask = "P";
            this.txtPorcentajeVolumen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcentajeVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeVolumen.TabIndex = 13;
            // 
            // Frm_PenalizacionAcopio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 412);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PenalizacionAcopio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penalizacion Acopio";
            this.Shown += new System.EventHandler(this.Frm_BonosAcopio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEtapasCosechas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamionesMI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCamiones_CMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPenalizacionCalibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValPenalizacionCalibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPenalizacionCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValPenalizacionCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeVolumen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl dtgPenalizacionCalibres;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValPenalizacionCalibres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn ColCalibresPorcentaje;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgPenalizacionCalidad;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValPenalizacionCalidad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ColCalidadPorcentaje;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCamionesMI;
        private DevExpress.XtraEditors.TextEdit txtCamiones_CMP;
        private DevExpress.XtraEditors.GridLookUpEdit cboEtapasCosechas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnEstablecerEtapa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPorcentajeVolumen;
    }
}