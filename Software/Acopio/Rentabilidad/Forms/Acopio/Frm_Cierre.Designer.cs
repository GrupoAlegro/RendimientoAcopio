namespace Acopio
{
    partial class Frm_Cierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cierre));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lkUpAcopiador = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ProgressB = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtFin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.orbTipoReporte = new DevExpress.XtraEditors.RadioGroup();
            this.chkTodos = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpAcopiador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orbTipoReporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(806, 170);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.hyperlinkLabelControl1);
            this.groupControl1.Controls.Add(this.lkUpAcopiador);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.ProgressB);
            this.groupControl1.Controls.Add(this.btnConsultar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dtFin);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dtInicio);
            this.groupControl1.Controls.Add(this.orbTipoReporte);
            this.groupControl1.Controls.Add(this.chkTodos);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(790, 154);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Parametros - Fecha de Corte";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.hyperlinkLabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.LineColor = System.Drawing.Color.Maroon;
            this.hyperlinkLabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.hyperlinkLabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.hyperlinkLabelControl1.LineVisible = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(446, 100);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(231, 16);
            this.hyperlinkLabelControl1.TabIndex = 14;
            this.hyperlinkLabelControl1.Text = "Capturas Pendientes \r\nConsultar Click Aqui";
            this.hyperlinkLabelControl1.UseMnemonic = false;
            this.hyperlinkLabelControl1.Visible = false;
            // 
            // lkUpAcopiador
            // 
            this.lkUpAcopiador.EditValue = "Selecciones Acopiador";
            this.lkUpAcopiador.Location = new System.Drawing.Point(121, 41);
            this.lkUpAcopiador.Name = "lkUpAcopiador";
            this.lkUpAcopiador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpAcopiador.Properties.NullText = "Seleccione Acopiador";
            this.lkUpAcopiador.Properties.View = this.gridLookUpEdit1View;
            this.lkUpAcopiador.Size = new System.Drawing.Size(211, 20);
            this.lkUpAcopiador.TabIndex = 11;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Progreso";
            // 
            // ProgressB
            // 
            this.ProgressB.EditValue = 30;
            this.ProgressB.Location = new System.Drawing.Point(121, 135);
            this.ProgressB.Name = "ProgressB";
            this.ProgressB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.ProgressB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ProgressB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ProgressB.Properties.ShowTitle = true;
            this.ProgressB.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.ProgressB.Size = new System.Drawing.Size(325, 18);
            this.ProgressB.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(446, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 22);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(72, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Hasta";
            // 
            // dtFin
            // 
            this.dtFin.EditValue = new System.DateTime(2018, 3, 12, 10, 20, 50, 0);
            this.dtFin.Location = new System.Drawing.Point(121, 100);
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
            this.labelControl2.Location = new System.Drawing.Point(72, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Desde";
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = new System.DateTime(2018, 3, 12, 10, 20, 45, 0);
            this.dtInicio.Location = new System.Drawing.Point(121, 74);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(100, 20);
            this.dtInicio.TabIndex = 4;
            // 
            // orbTipoReporte
            // 
            this.orbTipoReporte.Location = new System.Drawing.Point(227, 72);
            this.orbTipoReporte.Name = "orbTipoReporte";
            this.orbTipoReporte.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.orbTipoReporte.Properties.Appearance.Options.UseBackColor = true;
            this.orbTipoReporte.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.orbTipoReporte.Properties.Columns = 1;
            this.orbTipoReporte.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.orbTipoReporte.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Concetrado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Detallado")});
            this.orbTipoReporte.Size = new System.Drawing.Size(105, 56);
            this.orbTipoReporte.TabIndex = 3;
            // 
            // chkTodos
            // 
            this.chkTodos.Location = new System.Drawing.Point(350, 42);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Properties.Caption = "Todos";
            this.chkTodos.Size = new System.Drawing.Size(75, 19);
            this.chkTodos.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Acopiadores";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Codigo";
            this.gridColumn3.FieldName = "c_codigo_zon";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Acopiador";
            this.gridColumn4.FieldName = "c_acopiador_Cal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // Frm_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 434);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_Cierre";
            this.Text = "Frm_Cierre";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpAcopiador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orbTipoReporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit lkUpAcopiador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ProgressBarControl ProgressB;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtFin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.RadioGroup orbTipoReporte;
        private DevExpress.XtraEditors.CheckEdit chkTodos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}