using TMC.MCC.DSMCCTableAdapters;
using TMC.MCC;
namespace TMC.MCC.Tareas
{
    partial class FrmCreate
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.codigo = new DevExpress.XtraEditors.TextEdit();
            this.largo = new DevExpress.XtraEditors.TextEdit();
            this.idpalanquilla = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fKTPalanquillaTMaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.MCC.DSMCC();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltipopalanquilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colareapalanquilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idmaquina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmodelomaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarcamaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idacero = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.t_MarcaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_AceroTableAdapter();
            this.t_MaquinaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_MaquinaTableAdapter();
            this.t_PalanquillaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_PalanquillaTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.t_MaquinaParametroTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_ParametroValorTableAdapter();
            this.t_ParametrosTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_ParametrosTableAdapter();
            this.t_TecnologiaTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_TecnologiaTableAdapter();
            this.t_Circulacion_AMTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_Circulacion_AMTableAdapter();
            this.t_AceroNormaTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_AceroNormaTableAdapter();
            this.t_ParametroValorTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_ParametroValorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idpalanquilla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTPalanquillaTMaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idmaquina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idacero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.codigo);
            this.layoutControl1.Controls.Add(this.largo);
            this.layoutControl1.Controls.Add(this.idpalanquilla);
            this.layoutControl1.Controls.Add(this.idmaquina);
            this.layoutControl1.Controls.Add(this.idacero);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(453, 144);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(70, 108);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(371, 20);
            this.codigo.StyleController = this.layoutControl1;
            this.codigo.TabIndex = 8;
            // 
            // largo
            // 
            this.largo.Location = new System.Drawing.Point(70, 84);
            this.largo.Name = "largo";
            this.largo.Size = new System.Drawing.Size(371, 20);
            this.largo.StyleController = this.layoutControl1;
            this.largo.TabIndex = 7;
            // 
            // idpalanquilla
            // 
            this.idpalanquilla.Location = new System.Drawing.Point(70, 60);
            this.idpalanquilla.Name = "idpalanquilla";
            this.idpalanquilla.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idpalanquilla.Properties.DataSource = this.fKTPalanquillaTMaquinaBindingSource;
            this.idpalanquilla.Properties.DisplayMember = "tipopalanquilla";
            this.idpalanquilla.Properties.ValueMember = "idpalanquilla";
            this.idpalanquilla.Properties.View = this.gridLookUpEdit3View;
            this.idpalanquilla.Size = new System.Drawing.Size(371, 20);
            this.idpalanquilla.StyleController = this.layoutControl1;
            this.idpalanquilla.TabIndex = 6;
            // 
            // fKTPalanquillaTMaquinaBindingSource
            // 
            this.fKTPalanquillaTMaquinaBindingSource.DataMember = "FK_T_Palanquilla_T_Maquina";
            this.fKTPalanquillaTMaquinaBindingSource.DataSource = this.tMaquinaBindingSource;
            // 
            // tMaquinaBindingSource
            // 
            this.tMaquinaBindingSource.DataMember = "T_Maquina";
            this.tMaquinaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltipopalanquilla,
            this.colareapalanquilla});
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // coltipopalanquilla
            // 
            this.coltipopalanquilla.Caption = "Tipo";
            this.coltipopalanquilla.FieldName = "tipopalanquilla";
            this.coltipopalanquilla.Name = "coltipopalanquilla";
            this.coltipopalanquilla.Visible = true;
            this.coltipopalanquilla.VisibleIndex = 0;
            // 
            // colareapalanquilla
            // 
            this.colareapalanquilla.Caption = "Area";
            this.colareapalanquilla.FieldName = "areapalanquilla";
            this.colareapalanquilla.Name = "colareapalanquilla";
            this.colareapalanquilla.Visible = true;
            this.colareapalanquilla.VisibleIndex = 1;
            // 
            // idmaquina
            // 
            this.idmaquina.Location = new System.Drawing.Point(70, 36);
            this.idmaquina.Name = "idmaquina";
            this.idmaquina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idmaquina.Properties.DataSource = this.tMaquinaBindingSource;
            this.idmaquina.Properties.DisplayMember = "modelomaquina";
            this.idmaquina.Properties.ValueMember = "idmaquina";
            this.idmaquina.Properties.View = this.gridLookUpEdit2View;
            this.idmaquina.Size = new System.Drawing.Size(371, 20);
            this.idmaquina.StyleController = this.layoutControl1;
            this.idmaquina.TabIndex = 5;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmodelomaquina,
            this.colmarcamaquina});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colmodelomaquina
            // 
            this.colmodelomaquina.Caption = "Modelo";
            this.colmodelomaquina.FieldName = "modelomaquina";
            this.colmodelomaquina.Name = "colmodelomaquina";
            this.colmodelomaquina.Visible = true;
            this.colmodelomaquina.VisibleIndex = 0;
            // 
            // colmarcamaquina
            // 
            this.colmarcamaquina.Caption = "Marca";
            this.colmarcamaquina.FieldName = "marcamaquina";
            this.colmarcamaquina.Name = "colmarcamaquina";
            this.colmarcamaquina.Visible = true;
            this.colmarcamaquina.VisibleIndex = 1;
            // 
            // idacero
            // 
            this.idacero.Location = new System.Drawing.Point(70, 12);
            this.idacero.Name = "idacero";
            this.idacero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idacero.Properties.DataSource = this.tMarcaBindingSource;
            this.idacero.Properties.DisplayMember = "nameacero";
            this.idacero.Properties.ValueMember = "idacero";
            this.idacero.Properties.View = this.gridLookUpEdit1View;
            this.idacero.Size = new System.Drawing.Size(371, 20);
            this.idacero.StyleController = this.layoutControl1;
            this.idacero.TabIndex = 4;
            // 
            // tMarcaBindingSource
            // 
            this.tMarcaBindingSource.DataMember = "T_Acero";
            this.tMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemarca});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemarca
            // 
            this.colnamemarca.Caption = "Acero";
            this.colnamemarca.FieldName = "nameacero";
            this.colnamemarca.Name = "colnamemarca";
            this.colnamemarca.Visible = true;
            this.colnamemarca.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(453, 144);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.idacero;
            this.layoutControlItem1.CustomizationFormText = "Acero:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem1.Text = "Acero:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.idmaquina;
            this.layoutControlItem2.CustomizationFormText = "Máquina:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem2.Text = "Máquina:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.idpalanquilla;
            this.layoutControlItem3.CustomizationFormText = "Palanquilla:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem3.Text = "Palanquilla:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.largo;
            this.layoutControlItem4.CustomizationFormText = "Largo:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem4.Text = "Largo:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.codigo;
            this.layoutControlItem5.CustomizationFormText = "Código:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(433, 28);
            this.layoutControlItem5.Text = "Código:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 144);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(453, 30);
            this.ucPieFormulario1.StringAceptar = "Calcular";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 1;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // t_MarcaTableAdapter
            // 
            this.t_MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // t_MaquinaTableAdapter
            // 
            this.t_MaquinaTableAdapter.ClearBeforeFill = true;
            // 
            // t_PalanquillaTableAdapter
            // 
            this.t_PalanquillaTableAdapter.ClearBeforeFill = true;
            // 
            // t_MaquinaParametroTableAdapter1
            // 
            this.t_MaquinaParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ParametrosTableAdapter1
            // 
            this.t_ParametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TecnologiaTableAdapter1
            // 
            this.t_TecnologiaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_Circulacion_AMTableAdapter1
            // 
            this.t_Circulacion_AMTableAdapter1.ClearBeforeFill = true;
            // 
            // t_AceroNormaTableAdapter1
            // 
            this.t_AceroNormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ParametroValorTableAdapter1
            // 
            this.t_ParametroValorTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 174);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear nueva técnologia";
            this.Load += new System.EventHandler(this.FrmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idpalanquilla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTPalanquillaTMaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idmaquina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idacero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit idacero;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DSMCC dSDatos;
        private System.Windows.Forms.BindingSource tMarcaBindingSource;
        private T_AceroTableAdapter t_MarcaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca;
        private DevExpress.XtraEditors.GridLookUpEdit idpalanquilla;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.GridLookUpEdit idmaquina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource tMaquinaBindingSource;
        private T_MaquinaTableAdapter t_MaquinaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelomaquina;
        private DevExpress.XtraGrid.Columns.GridColumn colmarcamaquina;
        private System.Windows.Forms.BindingSource fKTPalanquillaTMaquinaBindingSource;
        private T_PalanquillaTableAdapter t_PalanquillaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coltipopalanquilla;
        private DevExpress.XtraGrid.Columns.GridColumn colareapalanquilla;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit largo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private T_ParametroValorTableAdapter t_MaquinaParametroTableAdapter1;
        private T_ParametrosTableAdapter t_ParametrosTableAdapter1;
        private DevExpress.XtraEditors.TextEdit codigo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private T_TecnologiaTableAdapter t_TecnologiaTableAdapter1;
        private T_Circulacion_AMTableAdapter t_Circulacion_AMTableAdapter1;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private T_ParametroValorTableAdapter t_ParametroValorTableAdapter1;
    }
}