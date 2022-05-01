using TMC.ACATTA.DSACATTATableAdapters;
using TMC.ACATTA;
namespace TMC.ACATTA.Codificadores
{
    partial class FrmHornos
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
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.dSDatos = new DSACATTA();
            this.t_HornoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_HornoTableAdapter = new T_HornoTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.t_TipoFundicionTableAdapter = new T_TipoFundicionTableAdapter();
            this.t_TipoHornoTableAdapter = new T_TipoHornoTableAdapter();
            this.t_HornoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamehorno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipohorno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoHornoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipohorno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipofundicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoFundicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipoFundicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfundidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempMaxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEficiencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPowerRating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.t_TipoHornoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipohorno1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.t_TipoFundicionGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipoFundicion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_HornoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_HornoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoHornoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoFundicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoHornoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoFundicionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 386);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.ucPieFormulario1.Size = new System.Drawing.Size(533, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cerrar";
            this.ucPieFormulario1.TabIndex = 0;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_HornoBindingSource
            // 
            this.t_HornoBindingSource.DataMember = "T_Horno";
            this.t_HornoBindingSource.DataSource = this.dSDatos;
            // 
            // t_HornoTableAdapter
            // 
            this.t_HornoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_HornoTableAdapter = this.t_HornoTableAdapter;
            this.tableAdapterManager.T_MaterialTableAdapter = null;
            this.tableAdapterManager.T_MedioEnfriamientoTableAdapter = null;
            this.tableAdapterManager.T_NormaTableAdapter = null;
            this.tableAdapterManager.T_RegimenCalentamientoTableAdapter = null;
            this.tableAdapterManager.T_SeparacionPiezaTableAdapter = null;
            this.tableAdapterManager.T_TemperaturaTableAdapter = null;
            this.tableAdapterManager.T_TipoCurvaTableAdapter = null;
            this.tableAdapterManager.T_TipoFundicionTableAdapter = this.t_TipoFundicionTableAdapter;
            this.tableAdapterManager.T_TipoHornoTableAdapter = this.t_TipoHornoTableAdapter;
            this.tableAdapterManager.T_TipoMaterialTableAdapter = null;
            this.tableAdapterManager.T_TipoPiezaGeometriaTableAdapter = null;
            this.tableAdapterManager.T_TipoPiezaTableAdapter = null;
            this.tableAdapterManager.T_TipoPropiedadSolTableAdapter = null;
            this.tableAdapterManager.T_TipoTratamientoTableAdapter = null;
            this.tableAdapterManager.T_TratamientoDeslozeTableAdapter = null;
            this.tableAdapterManager.T_TratamientoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_TipoFundicionTableAdapter
            // 
            this.t_TipoFundicionTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoHornoTableAdapter
            // 
            this.t_TipoHornoTableAdapter.ClearBeforeFill = true;
            // 
            // t_HornoGridControl
            // 
            this.t_HornoGridControl.DataSource = this.t_HornoBindingSource;
            this.t_HornoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_HornoGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_HornoGridControl.MainView = this.gridView1;
            this.t_HornoGridControl.Name = "t_HornoGridControl";
            this.t_HornoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.t_HornoGridControl.Size = new System.Drawing.Size(527, 358);
            this.t_HornoGridControl.TabIndex = 2;
            this.t_HornoGridControl.UseEmbeddedNavigator = true;
            this.t_HornoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamehorno,
            this.colidtipohorno,
            this.colidtipofundicion,
            this.colProfundidad,
            this.colLargo,
            this.colAltura,
            this.colTempMaxima,
            this.colEficiencia,
            this.colProductMax,
            this.colPowerRating});
            this.gridView1.GridControl = this.t_HornoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnamehorno
            // 
            this.colnamehorno.Caption = "Horno";
            this.colnamehorno.FieldName = "namehorno";
            this.colnamehorno.Name = "colnamehorno";
            this.colnamehorno.Visible = true;
            this.colnamehorno.VisibleIndex = 0;
            // 
            // colidtipohorno
            // 
            this.colidtipohorno.Caption = "Tipo de Horno";
            this.colidtipohorno.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidtipohorno.FieldName = "idtipohorno";
            this.colidtipohorno.Name = "colidtipohorno";
            this.colidtipohorno.Visible = true;
            this.colidtipohorno.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tTipoHornoBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "nametipohorno";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idtipohorno";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tTipoHornoBindingSource
            // 
            this.tTipoHornoBindingSource.DataMember = "T_TipoHorno";
            this.tTipoHornoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipohorno});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipohorno
            // 
            this.colnametipohorno.Caption = "Tipo de Horno";
            this.colnametipohorno.FieldName = "nametipohorno";
            this.colnametipohorno.Name = "colnametipohorno";
            this.colnametipohorno.Visible = true;
            this.colnametipohorno.VisibleIndex = 0;
            // 
            // colidtipofundicion
            // 
            this.colidtipofundicion.Caption = "Tipo de Fundicion";
            this.colidtipofundicion.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidtipofundicion.FieldName = "idtipofundicion";
            this.colidtipofundicion.Name = "colidtipofundicion";
            this.colidtipofundicion.Visible = true;
            this.colidtipofundicion.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tTipoFundicionBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nametipoFundicion";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idTipoFundicion";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemGridLookUpEdit1_ButtonClick);
            // 
            // tTipoFundicionBindingSource
            // 
            this.tTipoFundicionBindingSource.DataMember = "T_TipoFundicion";
            this.tTipoFundicionBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipoFundicion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipoFundicion
            // 
            this.colnametipoFundicion.Caption = "Tipo de Fundicion";
            this.colnametipoFundicion.FieldName = "nametipoFundicion";
            this.colnametipoFundicion.Name = "colnametipoFundicion";
            this.colnametipoFundicion.Visible = true;
            this.colnametipoFundicion.VisibleIndex = 0;
            // 
            // colProfundidad
            // 
            this.colProfundidad.Caption = "Ancho o Diametro";
            this.colProfundidad.FieldName = "Ancho_Diametro";
            this.colProfundidad.Name = "colProfundidad";
            this.colProfundidad.Visible = true;
            this.colProfundidad.VisibleIndex = 3;
            // 
            // colLargo
            // 
            this.colLargo.Caption = "Largo";
            this.colLargo.FieldName = "Largo";
            this.colLargo.Name = "colLargo";
            this.colLargo.Visible = true;
            this.colLargo.VisibleIndex = 4;
            // 
            // colAltura
            // 
            this.colAltura.Caption = "Altura";
            this.colAltura.FieldName = "Altura";
            this.colAltura.Name = "colAltura";
            this.colAltura.Visible = true;
            this.colAltura.VisibleIndex = 5;
            // 
            // colTempMaxima
            // 
            this.colTempMaxima.Caption = "Temp Maxima";
            this.colTempMaxima.FieldName = "TempMaxima";
            this.colTempMaxima.Name = "colTempMaxima";
            this.colTempMaxima.Visible = true;
            this.colTempMaxima.VisibleIndex = 6;
            // 
            // colEficiencia
            // 
            this.colEficiencia.Caption = "Eficiencia";
            this.colEficiencia.FieldName = "Eficiencia";
            this.colEficiencia.Name = "colEficiencia";
            this.colEficiencia.Visible = true;
            this.colEficiencia.VisibleIndex = 7;
            // 
            // colProductMax
            // 
            this.colProductMax.Caption = "Max. Producto";
            this.colProductMax.FieldName = "ProductMax";
            this.colProductMax.Name = "colProductMax";
            this.colProductMax.Visible = true;
            this.colProductMax.VisibleIndex = 8;
            // 
            // colPowerRating
            // 
            this.colPowerRating.Caption = "PowerRating";
            this.colPowerRating.FieldName = "PowerRating";
            this.colPowerRating.Name = "colPowerRating";
            this.colPowerRating.Visible = true;
            this.colPowerRating.VisibleIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(533, 386);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.t_HornoGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(527, 358);
            this.xtraTabPage1.Text = "Hornos";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.t_TipoHornoGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(527, 358);
            this.xtraTabPage2.Text = "Tipos de Hornos";
            // 
            // t_TipoHornoGridControl
            // 
            this.t_TipoHornoGridControl.DataSource = this.tTipoHornoBindingSource;
            this.t_TipoHornoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TipoHornoGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoHornoGridControl.MainView = this.gridView2;
            this.t_TipoHornoGridControl.Name = "t_TipoHornoGridControl";
            this.t_TipoHornoGridControl.Size = new System.Drawing.Size(527, 358);
            this.t_TipoHornoGridControl.TabIndex = 0;
            this.t_TipoHornoGridControl.UseEmbeddedNavigator = true;
            this.t_TipoHornoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipohorno1});
            this.gridView2.GridControl = this.t_TipoHornoGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colnametipohorno1
            // 
            this.colnametipohorno1.Caption = "Tipo";
            this.colnametipohorno1.FieldName = "nametipohorno";
            this.colnametipohorno1.Name = "colnametipohorno1";
            this.colnametipohorno1.Visible = true;
            this.colnametipohorno1.VisibleIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.t_TipoFundicionGridControl);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(527, 358);
            this.xtraTabPage3.Text = "Tipo de Fundición";
            // 
            // t_TipoFundicionGridControl
            // 
            this.t_TipoFundicionGridControl.DataSource = this.tTipoFundicionBindingSource;
            this.t_TipoFundicionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TipoFundicionGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoFundicionGridControl.MainView = this.gridView3;
            this.t_TipoFundicionGridControl.Name = "t_TipoFundicionGridControl";
            this.t_TipoFundicionGridControl.Size = new System.Drawing.Size(527, 358);
            this.t_TipoFundicionGridControl.TabIndex = 0;
            this.t_TipoFundicionGridControl.UseEmbeddedNavigator = true;
            this.t_TipoFundicionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipoFundicion1});
            this.gridView3.GridControl = this.t_TipoFundicionGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.EnableMasterViewMode = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView3_RowClick);
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            // 
            // colnametipoFundicion1
            // 
            this.colnametipoFundicion1.Caption = "Fundición";
            this.colnametipoFundicion1.FieldName = "nametipoFundicion";
            this.colnametipoFundicion1.Name = "colnametipoFundicion1";
            this.colnametipoFundicion1.Visible = true;
            this.colnametipoFundicion1.VisibleIndex = 0;
            // 
            // FrmHornos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 416);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHornos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hornos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHornos_FormClosed);
            this.Load += new System.EventHandler(this.FrmHornos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_HornoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_HornoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoHornoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoFundicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoHornoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoFundicionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource t_HornoBindingSource;
        private T_HornoTableAdapter t_HornoTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private T_TipoFundicionTableAdapter t_TipoFundicionTableAdapter;
        private DevExpress.XtraGrid.GridControl t_HornoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tTipoFundicionBindingSource;
        private T_TipoHornoTableAdapter t_TipoHornoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipoFundicion;
        private System.Windows.Forms.BindingSource tTipoHornoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipohorno;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl t_TipoHornoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipohorno1;
        private DevExpress.XtraGrid.GridControl t_TipoFundicionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipoFundicion1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamehorno;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipohorno;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipofundicion;
        private DevExpress.XtraGrid.Columns.GridColumn colProfundidad;
        private DevExpress.XtraGrid.Columns.GridColumn colLargo;
        private DevExpress.XtraGrid.Columns.GridColumn colAltura;
        private DevExpress.XtraGrid.Columns.GridColumn colTempMaxima;
        private DevExpress.XtraGrid.Columns.GridColumn colEficiencia;
        private DevExpress.XtraGrid.Columns.GridColumn colProductMax;
        private DevExpress.XtraGrid.Columns.GridColumn colPowerRating;
    }
}