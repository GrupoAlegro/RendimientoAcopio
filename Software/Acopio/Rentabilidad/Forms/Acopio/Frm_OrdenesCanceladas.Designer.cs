namespace Acopio.Forms.Acopio
{
    partial class Frm_OrdenesCanceladas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdenesCanceladas));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtFin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.RPT_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(679, 103);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnConsultar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dtFin);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dtInicio);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(663, 87);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Parametros - Fecha de Corte";
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(173, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 22);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Hasta";
            // 
            // dtFin
            // 
            this.dtFin.EditValue = new System.DateTime(2018, 3, 12, 10, 20, 50, 0);
            this.dtFin.Location = new System.Drawing.Point(64, 56);
            this.dtFin.Name = "dtFin";
            this.dtFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Size = new System.Drawing.Size(100, 20);
            this.dtFin.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Desde";
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = new System.DateTime(2018, 3, 12, 10, 20, 45, 0);
            this.dtInicio.Location = new System.Drawing.Point(64, 30);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(100, 20);
            this.dtInicio.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.RPT_Viewer);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 103);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(679, 290);
            this.panelControl2.TabIndex = 2;
            // 
            // RPT_Viewer
            // 
            this.RPT_Viewer.ActiveViewIndex = -1;
            this.RPT_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RPT_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RPT_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPT_Viewer.Location = new System.Drawing.Point(8, 8);
            this.RPT_Viewer.Name = "RPT_Viewer";
            this.RPT_Viewer.ShowCloseButton = false;
            this.RPT_Viewer.ShowCopyButton = false;
            this.RPT_Viewer.ShowGroupTreeButton = false;
            this.RPT_Viewer.ShowLogo = false;
            this.RPT_Viewer.ShowParameterPanelButton = false;
            this.RPT_Viewer.ShowTextSearchButton = false;
            this.RPT_Viewer.Size = new System.Drawing.Size(663, 274);
            this.RPT_Viewer.TabIndex = 0;
            this.RPT_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_OrdenesCanceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 393);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_OrdenesCanceladas";
            this.Text = "Ordenes Canceladas";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtFin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RPT_Viewer;
    }
}