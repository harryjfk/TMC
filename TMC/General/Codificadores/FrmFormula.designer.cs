using TMC.ACATTA.DSACATTATableAdapters;
using TMC.ACATTA;
namespace TMC.General.Codificadores
{
    partial class FrmFormula
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidformula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.t_FormulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new DSACATTA();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.t_AceroTipoPuntoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_FormulaTableAdapter = new T_FormulaTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.t_FormulaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.tConstanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameconstante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorconst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_AceroPuntoFormulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_AceroPuntoFormulaTableAdapter = new T_AceroPuntoFormulaTableAdapter();
            this.t_AceroTipoPuntoTableAdapter = new T_AceroTipoPuntoTableAdapter();
            this.t_ConstanteTableAdapter = new T_ConstanteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroTipoPuntoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormulaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConstanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroPuntoFormulaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidformula});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.ViewCaption = "Formulas";
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            // 
            // colidformula
            // 
            this.colidformula.Caption = "Formula";
            this.colidformula.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidformula.FieldName = "idformula";
            this.colidformula.Name = "colidformula";
            this.colidformula.Visible = true;
            this.colidformula.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.t_FormulaBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "mi";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idformula";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // t_FormulaBindingSource
            // 
            this.t_FormulaBindingSource.DataMember = "T_Formula";
            this.t_FormulaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmi1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colmi1
            // 
            this.colmi1.Caption = "Formula";
            this.colmi1.FieldName = "mi";
            this.colmi1.Name = "colmi1";
            this.colmi1.Visible = true;
            this.colmi1.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.t_AceroTipoPuntoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode1.RelationName = "FK_T_AceroPuntoFormula_T_AceroPunto";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(555, 361);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3});
            // 
            // t_AceroTipoPuntoBindingSource
            // 
            this.t_AceroTipoPuntoBindingSource.DataMember = "T_AceroTipoPunto";
            this.t_AceroTipoPuntoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopunto});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.AllowExpandEmptyDetails = true;
            // 
            // colnametipopunto
            // 
            this.colnametipopunto.Caption = "Tipo de Punto";
            this.colnametipopunto.FieldName = "nametipopunto";
            this.colnametipopunto.Name = "colnametipopunto";
            this.colnametipopunto.OptionsColumn.AllowEdit = false;
            this.colnametipopunto.OptionsColumn.ReadOnly = true;
            this.colnametipopunto.Visible = true;
            this.colnametipopunto.VisibleIndex = 0;
            // 
            // t_FormulaTableAdapter
            // 
            this.t_FormulaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_FormulaTableAdapter = this.t_FormulaTableAdapter;
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
            this.tableAdapterManager.T_TipoPiezaGeometriaTableAdapter = null;
            this.tableAdapterManager.T_TipoPiezaTableAdapter = null;
            this.tableAdapterManager.T_TipoPropiedadSolTableAdapter = null;
            this.tableAdapterManager.T_TipoTratamientoTableAdapter = null;
            this.tableAdapterManager.T_TratamientoDeslozeTableAdapter = null;
            this.tableAdapterManager.T_TratamientoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_FormulaGridControl
            // 
            this.t_FormulaGridControl.DataSource = this.t_FormulaBindingSource;
            this.t_FormulaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_FormulaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_FormulaGridControl.MainView = this.gridView1;
            this.t_FormulaGridControl.Name = "t_FormulaGridControl";
            this.t_FormulaGridControl.Size = new System.Drawing.Size(555, 361);
            this.t_FormulaGridControl.TabIndex = 1;
            this.t_FormulaGridControl.UseEmbeddedNavigator = true;
            this.t_FormulaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmi,
            this.colmd});
            this.gridView1.GridControl = this.t_FormulaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colmi
            // 
            this.colmi.Caption = "Miembro Derecho";
            this.colmi.FieldName = "mi";
            this.colmi.Name = "colmi";
            this.colmi.Visible = true;
            this.colmi.VisibleIndex = 0;
            // 
            // colmd
            // 
            this.colmd.Caption = "Miembro Izquierdo";
            this.colmd.FieldName = "md";
            this.colmd.Name = "colmd";
            this.colmd.Visible = true;
            this.colmd.VisibleIndex = 1;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = false;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 389);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.ucPieFormulario1.Size = new System.Drawing.Size(561, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cerrar";
            this.ucPieFormulario1.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(561, 389);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.t_FormulaGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(555, 361);
            this.xtraTabPage1.Text = "Fórmulas Generales";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(555, 361);
            this.xtraTabPage2.Text = "Por Puntos";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(555, 361);
            this.xtraTabPage3.Text = "Constantes";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.tConstanteBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView4;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(555, 361);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // tConstanteBindingSource
            // 
            this.tConstanteBindingSource.DataMember = "T_Constante";
            this.tConstanteBindingSource.DataSource = this.dSDatos;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameconstante,
            this.colvalorconst});
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            this.gridView4.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView4_RowUpdated);
            // 
            // colnameconstante
            // 
            this.colnameconstante.Caption = "Nombre";
            this.colnameconstante.FieldName = "nameconstante";
            this.colnameconstante.Name = "colnameconstante";
            this.colnameconstante.Visible = true;
            this.colnameconstante.VisibleIndex = 0;
            // 
            // colvalorconst
            // 
            this.colvalorconst.Caption = "Valor";
            this.colvalorconst.FieldName = "valorconst";
            this.colvalorconst.Name = "colvalorconst";
            this.colvalorconst.Visible = true;
            this.colvalorconst.VisibleIndex = 1;
            // 
            // t_AceroPuntoFormulaBindingSource
            // 
            this.t_AceroPuntoFormulaBindingSource.DataMember = "T_AceroPuntoFormula";
            this.t_AceroPuntoFormulaBindingSource.DataSource = this.dSDatos;
            // 
            // t_AceroPuntoFormulaTableAdapter
            // 
            this.t_AceroPuntoFormulaTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroTipoPuntoTableAdapter
            // 
            this.t_AceroTipoPuntoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ConstanteTableAdapter
            // 
            this.t_ConstanteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 419);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.Name = "FrmFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fórmulas";
            this.Load += new System.EventHandler(this.FrmFormula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroTipoPuntoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormulaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConstanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroPuntoFormulaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource t_FormulaBindingSource;
        private T_FormulaTableAdapter t_FormulaTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_FormulaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmi;
        private DevExpress.XtraGrid.Columns.GridColumn colmd;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.BindingSource t_AceroPuntoFormulaBindingSource;
        private T_AceroPuntoFormulaTableAdapter t_AceroPuntoFormulaTableAdapter;
        private System.Windows.Forms.BindingSource t_AceroTipoPuntoBindingSource;
        private T_AceroTipoPuntoTableAdapter t_AceroTipoPuntoTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colidformula;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colmi1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopunto;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource tConstanteBindingSource;
        private T_ConstanteTableAdapter t_ConstanteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameconstante;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorconst;
    }
}