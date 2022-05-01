using TMC.ACATTA.DSACATTATableAdapters;
using TMC.ACATTA;
namespace TMC.ACATTA.Codificadores
{
    partial class FrmTipoPieza
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.t_TipoPiezaGeometriaGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_TipoPiezaGeometriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new DSACATTA();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopiezageo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.t_TipoPropiedadSolGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_TipoPropiedadSolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.t_TipoPiezaGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_TipoPiezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.t_ColocacionPiezaGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_ColocacionPiezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamecolocacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.t_SeparacionPiezaGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_SeparacionPiezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameseparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.t_TipoPiezaGeometriaTableAdapter = new T_TipoPiezaGeometriaTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.t_TipoPropiedadSolTableAdapter = new T_TipoPropiedadSolTableAdapter();
            this.t_TipoPiezaTableAdapter = new T_TipoPiezaTableAdapter();
            this.t_ColocacionPiezaTableAdapter = new T_ColocacionPiezaTableAdapter();
            this.t_SeparacionPiezaTableAdapter = new T_SeparacionPiezaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaGeometriaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaGeometriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPropiedadSolGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPropiedadSolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_ColocacionPiezaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ColocacionPiezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_SeparacionPiezaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SeparacionPiezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(470, 381);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.t_TipoPiezaGeometriaGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(464, 353);
            this.xtraTabPage1.Text = "Geometría";
            // 
            // t_TipoPiezaGeometriaGridControl
            // 
            this.t_TipoPiezaGeometriaGridControl.DataSource = this.t_TipoPiezaGeometriaBindingSource;
            this.t_TipoPiezaGeometriaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TipoPiezaGeometriaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoPiezaGeometriaGridControl.MainView = this.gridView1;
            this.t_TipoPiezaGeometriaGridControl.Name = "t_TipoPiezaGeometriaGridControl";
            this.t_TipoPiezaGeometriaGridControl.Size = new System.Drawing.Size(464, 353);
            this.t_TipoPiezaGeometriaGridControl.TabIndex = 0;
            this.t_TipoPiezaGeometriaGridControl.UseEmbeddedNavigator = true;
            this.t_TipoPiezaGeometriaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // t_TipoPiezaGeometriaBindingSource
            // 
            this.t_TipoPiezaGeometriaBindingSource.DataMember = "T_TipoPiezaGeometria";
            this.t_TipoPiezaGeometriaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopiezageo});
            this.gridView1.GridControl = this.t_TipoPiezaGeometriaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnametipopiezageo
            // 
            this.colnametipopiezageo.Caption = "Tipo de Figura";
            this.colnametipopiezageo.FieldName = "nametipopiezageo";
            this.colnametipopiezageo.Name = "colnametipopiezageo";
            this.colnametipopiezageo.Visible = true;
            this.colnametipopiezageo.VisibleIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.t_TipoPropiedadSolGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(464, 353);
            this.xtraTabPage2.Text = "Solicitada";
            // 
            // t_TipoPropiedadSolGridControl
            // 
            this.t_TipoPropiedadSolGridControl.DataSource = this.t_TipoPropiedadSolBindingSource;
            this.t_TipoPropiedadSolGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TipoPropiedadSolGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoPropiedadSolGridControl.MainView = this.gridView2;
            this.t_TipoPropiedadSolGridControl.Name = "t_TipoPropiedadSolGridControl";
            this.t_TipoPropiedadSolGridControl.Size = new System.Drawing.Size(464, 353);
            this.t_TipoPropiedadSolGridControl.TabIndex = 0;
            this.t_TipoPropiedadSolGridControl.UseEmbeddedNavigator = true;
            this.t_TipoPropiedadSolGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // t_TipoPropiedadSolBindingSource
            // 
            this.t_TipoPropiedadSolBindingSource.DataMember = "T_TipoPropiedadSol";
            this.t_TipoPropiedadSolBindingSource.DataSource = this.dSDatos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopropiedad});
            this.gridView2.GridControl = this.t_TipoPropiedadSolGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colnametipopropiedad
            // 
            this.colnametipopropiedad.Caption = "Tipo de Propiedad";
            this.colnametipopropiedad.FieldName = "nametipopropiedad";
            this.colnametipopropiedad.Name = "colnametipopropiedad";
            this.colnametipopropiedad.Visible = true;
            this.colnametipopropiedad.VisibleIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.t_TipoPiezaGridControl);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(464, 353);
            this.xtraTabPage3.Text = "Tipo";
            // 
            // t_TipoPiezaGridControl
            // 
            this.t_TipoPiezaGridControl.DataSource = this.t_TipoPiezaBindingSource;
            this.t_TipoPiezaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TipoPiezaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoPiezaGridControl.MainView = this.gridView3;
            this.t_TipoPiezaGridControl.Name = "t_TipoPiezaGridControl";
            this.t_TipoPiezaGridControl.Size = new System.Drawing.Size(464, 353);
            this.t_TipoPiezaGridControl.TabIndex = 0;
            this.t_TipoPiezaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // t_TipoPiezaBindingSource
            // 
            this.t_TipoPiezaBindingSource.DataMember = "T_TipoPieza";
            this.t_TipoPiezaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopieza});
            this.gridView3.GridControl = this.t_TipoPiezaGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.EnableMasterViewMode = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            // 
            // colnametipopieza
            // 
            this.colnametipopieza.Caption = "Nombre";
            this.colnametipopieza.FieldName = "nametipopieza";
            this.colnametipopieza.Name = "colnametipopieza";
            this.colnametipopieza.Visible = true;
            this.colnametipopieza.VisibleIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.AutoScroll = true;
            this.xtraTabPage4.Controls.Add(this.t_ColocacionPiezaGridControl);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(464, 353);
            this.xtraTabPage4.Text = "Colocación";
            // 
            // t_ColocacionPiezaGridControl
            // 
            this.t_ColocacionPiezaGridControl.DataSource = this.t_ColocacionPiezaBindingSource;
            this.t_ColocacionPiezaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_ColocacionPiezaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_ColocacionPiezaGridControl.MainView = this.gridView4;
            this.t_ColocacionPiezaGridControl.Name = "t_ColocacionPiezaGridControl";
            this.t_ColocacionPiezaGridControl.Size = new System.Drawing.Size(464, 353);
            this.t_ColocacionPiezaGridControl.TabIndex = 0;
            this.t_ColocacionPiezaGridControl.UseEmbeddedNavigator = true;
            this.t_ColocacionPiezaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // t_ColocacionPiezaBindingSource
            // 
            this.t_ColocacionPiezaBindingSource.DataMember = "T_ColocacionPieza";
            this.t_ColocacionPiezaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamecolocacion});
            this.gridView4.GridControl = this.t_ColocacionPiezaGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsDetail.EnableMasterViewMode = false;
            this.gridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView4.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView4_RowUpdated);
            // 
            // colnamecolocacion
            // 
            this.colnamecolocacion.Caption = "Colocación";
            this.colnamecolocacion.FieldName = "namecolocacion";
            this.colnamecolocacion.Name = "colnamecolocacion";
            this.colnamecolocacion.Visible = true;
            this.colnamecolocacion.VisibleIndex = 0;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.t_SeparacionPiezaGridControl);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(464, 353);
            this.xtraTabPage5.Text = "Separación";
            // 
            // t_SeparacionPiezaGridControl
            // 
            this.t_SeparacionPiezaGridControl.DataSource = this.t_SeparacionPiezaBindingSource;
            this.t_SeparacionPiezaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_SeparacionPiezaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_SeparacionPiezaGridControl.MainView = this.gridView5;
            this.t_SeparacionPiezaGridControl.Name = "t_SeparacionPiezaGridControl";
            this.t_SeparacionPiezaGridControl.Size = new System.Drawing.Size(464, 353);
            this.t_SeparacionPiezaGridControl.TabIndex = 0;
            this.t_SeparacionPiezaGridControl.UseEmbeddedNavigator = true;
            this.t_SeparacionPiezaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // t_SeparacionPiezaBindingSource
            // 
            this.t_SeparacionPiezaBindingSource.DataMember = "T_SeparacionPieza";
            this.t_SeparacionPiezaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameseparacion});
            this.gridView5.GridControl = this.t_SeparacionPiezaGridControl;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsDetail.EnableMasterViewMode = false;
            this.gridView5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView5.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView5_RowUpdated);
            // 
            // colnameseparacion
            // 
            this.colnameseparacion.Caption = "Separación";
            this.colnameseparacion.FieldName = "nameseparacion";
            this.colnameseparacion.Name = "colnameseparacion";
            this.colnameseparacion.Visible = true;
            this.colnameseparacion.VisibleIndex = 0;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 381);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.ucPieFormulario1.Size = new System.Drawing.Size(470, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cerrar";
            this.ucPieFormulario1.TabIndex = 1;
            // 
            // t_TipoPiezaGeometriaTableAdapter
            // 
            this.t_TipoPiezaGeometriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_AceroElementoTableAdapter = null;
            this.tableAdapterManager.T_AceroNormaTableAdapter = null;
            this.tableAdapterManager.T_AceroPuntoFormulaTableAdapter = null;
            this.tableAdapterManager.T_AceroPuntoTableAdapter = null;
            this.tableAdapterManager.T_AceroTableAdapter = null;
            this.tableAdapterManager.T_AceroTipoPuntoTableAdapter = null;
            this.tableAdapterManager.T_CapacidadCalorificaTableAdapter = null;
            this.tableAdapterManager.T_CapacidadDeslozeTableAdapter = null;
            this.tableAdapterManager.T_ColocacionPiezaTableAdapter = null;
            this.tableAdapterManager.T_ConstanteTableAdapter = null;
            this.tableAdapterManager.T_CurvaTableAdapter = null;
            this.tableAdapterManager.T_ElementoTableAdapter = null;
            this.tableAdapterManager.T_FormulaTableAdapter = null;
            this.tableAdapterManager.T_HornoTableAdapter = null;
            this.tableAdapterManager.T_MaterialTableAdapter = null;
            this.tableAdapterManager.T_MedioEnfriamientoTableAdapter = null;
            this.tableAdapterManager.T_NormaTableAdapter = null;
            this.tableAdapterManager.T_RegimenCalentamientoTableAdapter = null;
            this.tableAdapterManager.T_SeparacionPiezaTableAdapter = null;
            this.tableAdapterManager.T_TemperaturaTableAdapter = null;
            this.tableAdapterManager.T_TipoCurvaTableAdapter = null;
            this.tableAdapterManager.T_TipoFundicionTableAdapter = null;
            this.tableAdapterManager.T_TipoHornoTableAdapter = null;
            this.tableAdapterManager.T_TipoMaterialTableAdapter = null;
            this.tableAdapterManager.T_TipoPiezaGeometriaTableAdapter = this.t_TipoPiezaGeometriaTableAdapter;
            this.tableAdapterManager.T_TipoPiezaTableAdapter = null;
            this.tableAdapterManager.T_TipoPropiedadSolTableAdapter = this.t_TipoPropiedadSolTableAdapter;
            this.tableAdapterManager.T_TipoTratamientoTableAdapter = null;
            this.tableAdapterManager.T_TratamientoDeslozeTableAdapter = null;
            this.tableAdapterManager.T_TratamientoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_TipoPropiedadSolTableAdapter
            // 
            this.t_TipoPropiedadSolTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoPiezaTableAdapter
            // 
            this.t_TipoPiezaTableAdapter.ClearBeforeFill = true;
            // 
            // t_ColocacionPiezaTableAdapter
            // 
            this.t_ColocacionPiezaTableAdapter.ClearBeforeFill = true;
            // 
            // t_SeparacionPiezaTableAdapter
            // 
            this.t_SeparacionPiezaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTipoPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 411);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoPieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Codificador de Piezas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTipoPieza_FormClosed);
            this.Load += new System.EventHandler(this.FrmTipoPieza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaGeometriaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaGeometriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPropiedadSolGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPropiedadSolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoPiezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_ColocacionPiezaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ColocacionPiezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_SeparacionPiezaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SeparacionPiezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource t_TipoPiezaGeometriaBindingSource;
        private T_TipoPiezaGeometriaTableAdapter t_TipoPiezaGeometriaTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_TipoPiezaGeometriaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopiezageo;
        private T_TipoPropiedadSolTableAdapter t_TipoPropiedadSolTableAdapter;
        private System.Windows.Forms.BindingSource t_TipoPropiedadSolBindingSource;
        private DevExpress.XtraGrid.GridControl t_TipoPropiedadSolGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopropiedad;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.BindingSource t_TipoPiezaBindingSource;
        private T_TipoPiezaTableAdapter t_TipoPiezaTableAdapter;
        private DevExpress.XtraGrid.GridControl t_TipoPiezaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopieza;
        private System.Windows.Forms.BindingSource t_ColocacionPiezaBindingSource;
        private T_ColocacionPiezaTableAdapter t_ColocacionPiezaTableAdapter;
        private DevExpress.XtraGrid.GridControl t_ColocacionPiezaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colnamecolocacion;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private System.Windows.Forms.BindingSource t_SeparacionPiezaBindingSource;
        private T_SeparacionPiezaTableAdapter t_SeparacionPiezaTableAdapter;
        private DevExpress.XtraGrid.GridControl t_SeparacionPiezaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colnameseparacion;
    }
}