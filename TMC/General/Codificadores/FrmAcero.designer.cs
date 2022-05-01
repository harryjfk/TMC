using TMC.ACATTA.DSACATTATableAdapters;
using TMC.ACATTA;
namespace TMC.General.Codificadores
{
    partial class FrmAcero
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tElementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new DSACATTA();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnameelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorinicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_AceroGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_AceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidnorma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tNormaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamenorma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidtipopunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tAceroTipoPuntoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit9View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidformula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tFormulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit10View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidtipomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidpropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoPropiedadSolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit8View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalormin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalormax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tTratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidacero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tAceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameacero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltempmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltempmax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmedioenf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tMedioEnfriamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit5View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemedioenf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipotrat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoTratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit6View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametratamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit7View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.t_ElementoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodelemento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnameelemento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.t_NormaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamenorma1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.tRegimenCalentamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameregcalent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgregcalent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopunto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.t_AceroTableAdapter = new T_AceroTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.t_ElementoTableAdapter = new T_ElementoTableAdapter();
            this.t_NormaTableAdapter = new T_NormaTableAdapter();
            this.t_TipoMaterialTableAdapter = new T_TipoMaterialTableAdapter();
            this.t_AceroElementoTableAdapter1 = new T_AceroElementoTableAdapter();
            this.t_AceroNormaTableAdapter1 = new T_AceroNormaTableAdapter();
            this.t_TratamientoTableAdapter = new T_TratamientoTableAdapter();
            this.t_MedioEnfriamientoTableAdapter = new T_MedioEnfriamientoTableAdapter();
            this.t_TipoTratamientoTableAdapter = new T_TipoTratamientoTableAdapter();
            this.tTipoTratamientoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t_TipoPropiedadSolTableAdapter = new T_TipoPropiedadSolTableAdapter();
            this.t_TratamientoDeslozeTableAdapter1 = new T_TratamientoDeslozeTableAdapter();
            this.t_RegimenCalentamientoTableAdapter = new T_RegimenCalentamientoTableAdapter();
            this.t_AceroTipoPuntoTableAdapter = new T_AceroTipoPuntoTableAdapter();
            this.t_AceroPuntoTableAdapter1 = new T_AceroPuntoTableAdapter();
            this.t_FormulaTableAdapter = new T_FormulaTableAdapter();
            this.t_AceroPuntoFormulaTableAdapter1 = new T_AceroPuntoFormulaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNormaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroTipoPuntoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit9View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFormulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit10View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadSolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMedioEnfriamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_ElementoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_NormaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRegimenCalentamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTratamientoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidelemento,
            this.colvalorinicial,
            this.colvalorfinal});
            this.gridView2.GridControl = this.t_AceroGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.ViewCaption = "Composición";
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colidelemento
            // 
            this.colidelemento.Caption = "Elemento";
            this.colidelemento.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidelemento.FieldName = "idelemento";
            this.colidelemento.Name = "colidelemento";
            this.colidelemento.Visible = true;
            this.colidelemento.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tElementoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nameelemento";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idelemento";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tElementoBindingSource
            // 
            this.tElementoBindingSource.DataMember = "T_Elemento";
            this.tElementoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSACATTA";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodelemento,
            this.colnameelemento});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodelemento
            // 
            this.colcodelemento.Caption = "Codigo";
            this.colcodelemento.FieldName = "codelemento";
            this.colcodelemento.Name = "colcodelemento";
            this.colcodelemento.Visible = true;
            this.colcodelemento.VisibleIndex = 1;
            // 
            // colnameelemento
            // 
            this.colnameelemento.Caption = "Nombre";
            this.colnameelemento.FieldName = "nameelemento";
            this.colnameelemento.Name = "colnameelemento";
            this.colnameelemento.Visible = true;
            this.colnameelemento.VisibleIndex = 0;
            // 
            // colvalorinicial
            // 
            this.colvalorinicial.Caption = "Valor Inicial";
            this.colvalorinicial.FieldName = "valorinicial";
            this.colvalorinicial.Name = "colvalorinicial";
            this.colvalorinicial.Visible = true;
            this.colvalorinicial.VisibleIndex = 1;
            // 
            // colvalorfinal
            // 
            this.colvalorfinal.Caption = "Valor Final";
            this.colvalorfinal.FieldName = "valorfinal";
            this.colvalorfinal.Name = "colvalorfinal";
            this.colvalorfinal.Visible = true;
            this.colvalorfinal.VisibleIndex = 2;
            // 
            // t_AceroGridControl
            // 
            this.t_AceroGridControl.DataSource = this.t_AceroBindingSource;
            this.t_AceroGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "FK_T_AceroElemento_T_Acero";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "FK_T_AceroNorma_T_Acero";
            gridLevelNode3.LevelTemplate = this.gridView9;
            gridLevelNode4.LevelTemplate = this.gridView11;
            gridLevelNode4.RelationName = "FK_T_AceroPuntoFormula_T_AceroPunto";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            gridLevelNode3.RelationName = "FK_T_AceroPunto_T_Acero";
            this.t_AceroGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.t_AceroGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_AceroGridControl.MainView = this.gridView1;
            this.t_AceroGridControl.Name = "t_AceroGridControl";
            this.t_AceroGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemGridLookUpEdit9,
            this.repositoryItemGridLookUpEdit10});
            this.t_AceroGridControl.ShowOnlyPredefinedDetails = true;
            this.t_AceroGridControl.Size = new System.Drawing.Size(512, 388);
            this.t_AceroGridControl.TabIndex = 0;
            this.t_AceroGridControl.UseEmbeddedNavigator = true;
            this.t_AceroGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView9,
            this.gridView11,
            this.gridView1,
            this.gridView2});
            // 
            // t_AceroBindingSource
            // 
            this.t_AceroBindingSource.DataMember = "T_Acero";
            this.t_AceroBindingSource.DataSource = this.dSDatos;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidnorma,
            this.colvalor});
            this.gridView3.GridControl = this.t_AceroGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.ViewCaption = "Norma";
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            // 
            // colidnorma
            // 
            this.colidnorma.Caption = "Norma";
            this.colidnorma.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidnorma.FieldName = "idnorma";
            this.colidnorma.Name = "colidnorma";
            this.colidnorma.Visible = true;
            this.colidnorma.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tNormaBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "namenorma";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idnorma";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tNormaBindingSource
            // 
            this.tNormaBindingSource.DataMember = "T_Norma";
            this.tNormaBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamenorma});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamenorma
            // 
            this.colnamenorma.Caption = "Norma";
            this.colnamenorma.FieldName = "namenorma";
            this.colnamenorma.Name = "colnamenorma";
            this.colnamenorma.Visible = true;
            this.colnamenorma.VisibleIndex = 0;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 1;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidtipopunto,
            this.colvalor1});
            this.gridView9.GridControl = this.t_AceroGridControl;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView9.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView9.ViewCaption = "Puntos Críticos";
            this.gridView9.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView9_RowUpdated);
            // 
            // colidtipopunto
            // 
            this.colidtipopunto.Caption = "Punto Critico";
            this.colidtipopunto.ColumnEdit = this.repositoryItemGridLookUpEdit9;
            this.colidtipopunto.FieldName = "idtipopunto";
            this.colidtipopunto.Name = "colidtipopunto";
            this.colidtipopunto.Visible = true;
            this.colidtipopunto.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit9
            // 
            this.repositoryItemGridLookUpEdit9.AutoHeight = false;
            this.repositoryItemGridLookUpEdit9.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit9.DataSource = this.tAceroTipoPuntoBindingSource;
            this.repositoryItemGridLookUpEdit9.DisplayMember = "nametipopunto";
            this.repositoryItemGridLookUpEdit9.Name = "repositoryItemGridLookUpEdit9";
            this.repositoryItemGridLookUpEdit9.ValueMember = "idtipopunto";
            this.repositoryItemGridLookUpEdit9.View = this.repositoryItemGridLookUpEdit9View;
            // 
            // tAceroTipoPuntoBindingSource
            // 
            this.tAceroTipoPuntoBindingSource.DataMember = "T_AceroTipoPunto";
            this.tAceroTipoPuntoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit9View
            // 
            this.repositoryItemGridLookUpEdit9View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopunto});
            this.repositoryItemGridLookUpEdit9View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit9View.Name = "repositoryItemGridLookUpEdit9View";
            this.repositoryItemGridLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit9View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopunto
            // 
            this.colnametipopunto.Caption = "Tipo de Punto";
            this.colnametipopunto.FieldName = "nametipopunto";
            this.colnametipopunto.Name = "colnametipopunto";
            this.colnametipopunto.Visible = true;
            this.colnametipopunto.VisibleIndex = 0;
            // 
            // colvalor1
            // 
            this.colvalor1.Caption = "Valor (°C)";
            this.colvalor1.FieldName = "valor";
            this.colvalor1.Name = "colvalor1";
            this.colvalor1.Visible = true;
            this.colvalor1.VisibleIndex = 1;
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidformula});
            this.gridView11.GridControl = this.t_AceroGridControl;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView11.ViewCaption = "Fórmulas";
            this.gridView11.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView11_RowUpdated);
            // 
            // colidformula
            // 
            this.colidformula.Caption = "Formula";
            this.colidformula.ColumnEdit = this.repositoryItemGridLookUpEdit10;
            this.colidformula.FieldName = "idformula";
            this.colidformula.Name = "colidformula";
            this.colidformula.Visible = true;
            this.colidformula.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit10
            // 
            this.repositoryItemGridLookUpEdit10.AutoHeight = false;
            this.repositoryItemGridLookUpEdit10.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit10.DataSource = this.tFormulaBindingSource;
            this.repositoryItemGridLookUpEdit10.DisplayMember = "mi";
            this.repositoryItemGridLookUpEdit10.Name = "repositoryItemGridLookUpEdit10";
            this.repositoryItemGridLookUpEdit10.ValueMember = "idformula";
            this.repositoryItemGridLookUpEdit10.View = this.repositoryItemGridLookUpEdit10View;
            // 
            // tFormulaBindingSource
            // 
            this.tFormulaBindingSource.DataMember = "T_Formula";
            this.tFormulaBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit10View
            // 
            this.repositoryItemGridLookUpEdit10View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmi,
            this.colmd});
            this.repositoryItemGridLookUpEdit10View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit10View.Name = "repositoryItemGridLookUpEdit10View";
            this.repositoryItemGridLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit10View.OptionsView.ShowGroupPanel = false;
            // 
            // colmi
            // 
            this.colmi.Caption = "MI";
            this.colmi.FieldName = "mi";
            this.colmi.Name = "colmi";
            this.colmi.Visible = true;
            this.colmi.VisibleIndex = 0;
            // 
            // colmd
            // 
            this.colmd.Caption = "MD";
            this.colmd.FieldName = "md";
            this.colmd.Name = "colmd";
            this.colmd.Visible = true;
            this.colmd.VisibleIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidtipomaterial,
            this.gridColumn1});
            this.gridView1.GridControl = this.t_AceroGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colidtipomaterial
            // 
            this.colidtipomaterial.Caption = "Tipo de Acero";
            this.colidtipomaterial.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colidtipomaterial.FieldName = "idtipomaterial";
            this.colidtipomaterial.Name = "colidtipomaterial";
            this.colidtipomaterial.Visible = true;
            this.colidtipomaterial.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tTipoMaterialBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "nametipomaterial";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "idtipomaterial";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // tTipoMaterialBindingSource
            // 
            this.tTipoMaterialBindingSource.DataMember = "T_TipoMaterial";
            this.tTipoMaterialBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipomaterial});
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipomaterial
            // 
            this.colnametipomaterial.Caption = "Acero";
            this.colnametipomaterial.FieldName = "nametipomaterial";
            this.colnametipomaterial.Name = "colnametipomaterial";
            this.colnametipomaterial.Visible = true;
            this.colnametipomaterial.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Marca";
            this.gridColumn1.FieldName = "nameacero";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidpropiedad,
            this.colvalormin,
            this.colvalormax});
            this.gridView7.GridControl = this.gridControl1;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView7.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView7_RowUpdated);
            // 
            // colidpropiedad
            // 
            this.colidpropiedad.Caption = "Propiedad";
            this.colidpropiedad.ColumnEdit = this.repositoryItemGridLookUpEdit8;
            this.colidpropiedad.FieldName = "idpropiedad";
            this.colidpropiedad.Name = "colidpropiedad";
            this.colidpropiedad.Visible = true;
            this.colidpropiedad.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit8
            // 
            this.repositoryItemGridLookUpEdit8.AutoHeight = false;
            this.repositoryItemGridLookUpEdit8.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit8.DataSource = this.tTipoPropiedadSolBindingSource;
            this.repositoryItemGridLookUpEdit8.DisplayMember = "nametipopropiedad";
            this.repositoryItemGridLookUpEdit8.Name = "repositoryItemGridLookUpEdit8";
            this.repositoryItemGridLookUpEdit8.ValueMember = "idtipopropiedad";
            this.repositoryItemGridLookUpEdit8.View = this.repositoryItemGridLookUpEdit8View;
            // 
            // tTipoPropiedadSolBindingSource
            // 
            this.tTipoPropiedadSolBindingSource.DataMember = "T_TipoPropiedadSol";
            this.tTipoPropiedadSolBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit8View
            // 
            this.repositoryItemGridLookUpEdit8View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopropiedad});
            this.repositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit8View.Name = "repositoryItemGridLookUpEdit8View";
            this.repositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopropiedad
            // 
            this.colnametipopropiedad.Caption = "Propiedad";
            this.colnametipopropiedad.FieldName = "nametipopropiedad";
            this.colnametipopropiedad.Name = "colnametipopropiedad";
            this.colnametipopropiedad.Visible = true;
            this.colnametipopropiedad.VisibleIndex = 0;
            // 
            // colvalormin
            // 
            this.colvalormin.Caption = "Mínimo";
            this.colvalormin.FieldName = "valormin";
            this.colvalormin.Name = "colvalormin";
            this.colvalormin.Visible = true;
            this.colvalormin.VisibleIndex = 1;
            // 
            // colvalormax
            // 
            this.colvalormax.Caption = "Máximo";
            this.colvalormax.FieldName = "valormax";
            this.colvalormax.Name = "colvalormax";
            this.colvalormax.Visible = true;
            this.colvalormax.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tTratamientoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode5.LevelTemplate = this.gridView7;
            gridLevelNode5.RelationName = "FK_T_TempleDesloze_T_Temple";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode5});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView6;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit4,
            this.repositoryItemGridLookUpEdit5,
            this.repositoryItemGridLookUpEdit6,
            this.repositoryItemGridLookUpEdit7,
            this.repositoryItemGridLookUpEdit8});
            this.gridControl1.Size = new System.Drawing.Size(512, 388);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6,
            this.gridView7});
            // 
            // tTratamientoBindingSource
            // 
            this.tTratamientoBindingSource.DataMember = "T_Tratamiento";
            this.tTratamientoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidacero,
            this.coltempmin,
            this.coltempmax,
            this.colidmedioenf,
            this.colidtipotrat});
            this.gridView6.GridControl = this.gridControl1;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView6.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView6_RowUpdated);
            // 
            // colidacero
            // 
            this.colidacero.Caption = "Acero";
            this.colidacero.ColumnEdit = this.repositoryItemGridLookUpEdit4;
            this.colidacero.FieldName = "idacero";
            this.colidacero.Name = "colidacero";
            this.colidacero.Visible = true;
            this.colidacero.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.AutoHeight = false;
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DataSource = this.tAceroBindingSource;
            this.repositoryItemGridLookUpEdit4.DisplayMember = "nameacero";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.ValueMember = "idacero";
            this.repositoryItemGridLookUpEdit4.View = this.repositoryItemGridLookUpEdit4View;
            // 
            // tAceroBindingSource
            // 
            this.tAceroBindingSource.DataMember = "T_Acero";
            this.tAceroBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit4View
            // 
            this.repositoryItemGridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameacero});
            this.repositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit4View.Name = "repositoryItemGridLookUpEdit4View";
            this.repositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameacero
            // 
            this.colnameacero.Caption = "Acero";
            this.colnameacero.FieldName = "nameacero";
            this.colnameacero.Name = "colnameacero";
            this.colnameacero.Visible = true;
            this.colnameacero.VisibleIndex = 0;
            // 
            // coltempmin
            // 
            this.coltempmin.Caption = "Temperatura Mín (°C)";
            this.coltempmin.FieldName = "tempmin";
            this.coltempmin.Name = "coltempmin";
            this.coltempmin.Visible = true;
            this.coltempmin.VisibleIndex = 1;
            // 
            // coltempmax
            // 
            this.coltempmax.Caption = "Temperatura Máx(°C)";
            this.coltempmax.FieldName = "tempmax";
            this.coltempmax.Name = "coltempmax";
            this.coltempmax.Visible = true;
            this.coltempmax.VisibleIndex = 2;
            // 
            // colidmedioenf
            // 
            this.colidmedioenf.Caption = "Medio Enfriamiento";
            this.colidmedioenf.ColumnEdit = this.repositoryItemGridLookUpEdit5;
            this.colidmedioenf.FieldName = "idmedioenf";
            this.colidmedioenf.Name = "colidmedioenf";
            this.colidmedioenf.Visible = true;
            this.colidmedioenf.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEdit5
            // 
            this.repositoryItemGridLookUpEdit5.AutoHeight = false;
            this.repositoryItemGridLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit5.DataSource = this.tMedioEnfriamientoBindingSource;
            this.repositoryItemGridLookUpEdit5.DisplayMember = "namemedioenf";
            this.repositoryItemGridLookUpEdit5.Name = "repositoryItemGridLookUpEdit5";
            this.repositoryItemGridLookUpEdit5.ValueMember = "idmedioenf";
            this.repositoryItemGridLookUpEdit5.View = this.repositoryItemGridLookUpEdit5View;
            // 
            // tMedioEnfriamientoBindingSource
            // 
            this.tMedioEnfriamientoBindingSource.DataMember = "T_MedioEnfriamiento";
            this.tMedioEnfriamientoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit5View
            // 
            this.repositoryItemGridLookUpEdit5View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemedioenf});
            this.repositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit5View.Name = "repositoryItemGridLookUpEdit5View";
            this.repositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemedioenf
            // 
            this.colnamemedioenf.Caption = "Medio Enfriamiento";
            this.colnamemedioenf.FieldName = "namemedioenf";
            this.colnamemedioenf.Name = "colnamemedioenf";
            this.colnamemedioenf.Visible = true;
            this.colnamemedioenf.VisibleIndex = 0;
            // 
            // colidtipotrat
            // 
            this.colidtipotrat.Caption = "Tipo Tratamiento";
            this.colidtipotrat.ColumnEdit = this.repositoryItemGridLookUpEdit6;
            this.colidtipotrat.FieldName = "idtipotrat";
            this.colidtipotrat.Name = "colidtipotrat";
            this.colidtipotrat.Visible = true;
            this.colidtipotrat.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEdit6
            // 
            this.repositoryItemGridLookUpEdit6.AutoHeight = false;
            this.repositoryItemGridLookUpEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit6.DataSource = this.tTipoTratamientoBindingSource;
            this.repositoryItemGridLookUpEdit6.DisplayMember = "nametratamiento";
            this.repositoryItemGridLookUpEdit6.Name = "repositoryItemGridLookUpEdit6";
            this.repositoryItemGridLookUpEdit6.ValueMember = "idtratamiento";
            this.repositoryItemGridLookUpEdit6.View = this.repositoryItemGridLookUpEdit6View;
            // 
            // tTipoTratamientoBindingSource
            // 
            this.tTipoTratamientoBindingSource.DataMember = "T_TipoTratamiento";
            this.tTipoTratamientoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit6View
            // 
            this.repositoryItemGridLookUpEdit6View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametratamiento});
            this.repositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit6View.Name = "repositoryItemGridLookUpEdit6View";
            this.repositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametratamiento
            // 
            this.colnametratamiento.Caption = "Tratamiento";
            this.colnametratamiento.FieldName = "nametratamiento";
            this.colnametratamiento.Name = "colnametratamiento";
            this.colnametratamiento.Visible = true;
            this.colnametratamiento.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit7
            // 
            this.repositoryItemGridLookUpEdit7.AutoHeight = false;
            this.repositoryItemGridLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit7.DataSource = this.tTratamientoBindingSource;
            this.repositoryItemGridLookUpEdit7.DisplayMember = "nametratamiento";
            this.repositoryItemGridLookUpEdit7.Name = "repositoryItemGridLookUpEdit7";
            this.repositoryItemGridLookUpEdit7.View = this.repositoryItemGridLookUpEdit7View;
            // 
            // repositoryItemGridLookUpEdit7View
            // 
            this.repositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit7View.Name = "repositoryItemGridLookUpEdit7View";
            this.repositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(518, 416);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.t_AceroGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(512, 388);
            this.xtraTabPage1.Text = "Acero";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.t_ElementoGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(512, 388);
            this.xtraTabPage2.Text = "Elementos";
            // 
            // t_ElementoGridControl
            // 
            this.t_ElementoGridControl.DataSource = this.tElementoBindingSource;
            this.t_ElementoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_ElementoGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_ElementoGridControl.MainView = this.gridView4;
            this.t_ElementoGridControl.Name = "t_ElementoGridControl";
            this.t_ElementoGridControl.Size = new System.Drawing.Size(512, 388);
            this.t_ElementoGridControl.TabIndex = 0;
            this.t_ElementoGridControl.UseEmbeddedNavigator = true;
            this.t_ElementoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodelemento1,
            this.colnameelemento1});
            this.gridView4.GridControl = this.t_ElementoGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsDetail.EnableMasterViewMode = false;
            this.gridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView4.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView4_RowUpdated);
            // 
            // colcodelemento1
            // 
            this.colcodelemento1.Caption = "Código";
            this.colcodelemento1.FieldName = "codelemento";
            this.colcodelemento1.Name = "colcodelemento1";
            this.colcodelemento1.Visible = true;
            this.colcodelemento1.VisibleIndex = 1;
            // 
            // colnameelemento1
            // 
            this.colnameelemento1.Caption = "Nombre";
            this.colnameelemento1.FieldName = "nameelemento";
            this.colnameelemento1.Name = "colnameelemento1";
            this.colnameelemento1.Visible = true;
            this.colnameelemento1.VisibleIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.t_NormaGridControl);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(512, 388);
            this.xtraTabPage3.Text = "Norma";
            // 
            // t_NormaGridControl
            // 
            this.t_NormaGridControl.DataSource = this.tNormaBindingSource;
            this.t_NormaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_NormaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_NormaGridControl.MainView = this.gridView5;
            this.t_NormaGridControl.Name = "t_NormaGridControl";
            this.t_NormaGridControl.Size = new System.Drawing.Size(512, 388);
            this.t_NormaGridControl.TabIndex = 0;
            this.t_NormaGridControl.UseEmbeddedNavigator = true;
            this.t_NormaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamenorma1});
            this.gridView5.GridControl = this.t_NormaGridControl;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsDetail.EnableMasterViewMode = false;
            this.gridView5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView5.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView5_RowUpdated);
            // 
            // colnamenorma1
            // 
            this.colnamenorma1.Caption = "Norma";
            this.colnamenorma1.FieldName = "namenorma";
            this.colnamenorma1.Name = "colnamenorma1";
            this.colnamenorma1.Visible = true;
            this.colnamenorma1.VisibleIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gridControl1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(512, 388);
            this.xtraTabPage4.Text = "Tratamiento";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.gridControl2);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(512, 388);
            this.xtraTabPage5.Text = "Regímenes";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.tRegimenCalentamientoBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView8;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridControl2.Size = new System.Drawing.Size(512, 388);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // tRegimenCalentamientoBindingSource
            // 
            this.tRegimenCalentamientoBindingSource.DataMember = "T_RegimenCalentamiento";
            this.tRegimenCalentamientoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameregcalent,
            this.colimgregcalent});
            this.gridView8.GridControl = this.gridControl2;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsDetail.EnableMasterViewMode = false;
            this.gridView8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView8.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView8_RowUpdated);
            // 
            // colnameregcalent
            // 
            this.colnameregcalent.Caption = "Nombre";
            this.colnameregcalent.FieldName = "nameregcalent";
            this.colnameregcalent.Name = "colnameregcalent";
            this.colnameregcalent.Visible = true;
            this.colnameregcalent.VisibleIndex = 0;
            // 
            // colimgregcalent
            // 
            this.colimgregcalent.Caption = "Imagen";
            this.colimgregcalent.ColumnEdit = this.repositoryItemImageEdit1;
            this.colimgregcalent.FieldName = "imgregcalent";
            this.colimgregcalent.Name = "colimgregcalent";
            this.colimgregcalent.Visible = true;
            this.colimgregcalent.VisibleIndex = 1;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.AutoScroll = true;
            this.xtraTabPage6.Controls.Add(this.gridControl3);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(512, 388);
            this.xtraTabPage6.Text = "Puntos Críticos";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.tAceroTipoPuntoBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView10;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(512, 388);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.UseEmbeddedNavigator = true;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView10});
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopunto1});
            this.gridView10.GridControl = this.gridControl3;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsDetail.EnableMasterViewMode = false;
            this.gridView10.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView10.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView10_RowUpdated);
            // 
            // colnametipopunto1
            // 
            this.colnametipopunto1.Caption = "Tipo de Punto";
            this.colnametipopunto1.FieldName = "nametipopunto";
            this.colnametipopunto1.Name = "colnametipopunto1";
            this.colnametipopunto1.Visible = true;
            this.colnametipopunto1.VisibleIndex = 0;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 416);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.ucPieFormulario1.Size = new System.Drawing.Size(518, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cerrar";
            this.ucPieFormulario1.TabIndex = 1;
            // 
            // t_AceroTableAdapter
            // 
            this.t_AceroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_AceroElementoTableAdapter = null;
            this.tableAdapterManager.T_AceroNormaTableAdapter = null;
            this.tableAdapterManager.T_AceroPuntoFormulaTableAdapter = null;
            this.tableAdapterManager.T_AceroPuntoTableAdapter = null;
            this.tableAdapterManager.T_AceroTableAdapter = this.t_AceroTableAdapter;
            this.tableAdapterManager.T_AceroTipoPuntoTableAdapter = null;
            this.tableAdapterManager.T_CapacidadCalorificaTableAdapter = null;
            this.tableAdapterManager.T_CapacidadDeslozeTableAdapter = null;
            this.tableAdapterManager.T_ColocacionPiezaTableAdapter = null;
            this.tableAdapterManager.T_ConstanteTableAdapter = null;
            this.tableAdapterManager.T_CurvaTableAdapter = null;
            this.tableAdapterManager.T_ElementoTableAdapter = this.t_ElementoTableAdapter;
            this.tableAdapterManager.T_FormulaTableAdapter = null;
            this.tableAdapterManager.T_HornoTableAdapter = null;
            this.tableAdapterManager.T_MaterialTableAdapter = null;
            this.tableAdapterManager.T_MedioEnfriamientoTableAdapter = null;
            this.tableAdapterManager.T_NormaTableAdapter = this.t_NormaTableAdapter;
            this.tableAdapterManager.T_RegimenCalentamientoTableAdapter = null;
            this.tableAdapterManager.T_SeparacionPiezaTableAdapter = null;
            this.tableAdapterManager.T_TemperaturaTableAdapter = null;
            this.tableAdapterManager.T_TipoCurvaTableAdapter = null;
            this.tableAdapterManager.T_TipoFundicionTableAdapter = null;
            this.tableAdapterManager.T_TipoHornoTableAdapter = null;
            this.tableAdapterManager.T_TipoMaterialTableAdapter = this.t_TipoMaterialTableAdapter;
            this.tableAdapterManager.T_TipoPiezaGeometriaTableAdapter = null;
            this.tableAdapterManager.T_TipoPiezaTableAdapter = null;
            this.tableAdapterManager.T_TipoPropiedadSolTableAdapter = null;
            this.tableAdapterManager.T_TipoTratamientoTableAdapter = null;
            this.tableAdapterManager.T_TratamientoDeslozeTableAdapter = null;
            this.tableAdapterManager.T_TratamientoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_ElementoTableAdapter
            // 
            this.t_ElementoTableAdapter.ClearBeforeFill = true;
            // 
            // t_NormaTableAdapter
            // 
            this.t_NormaTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoMaterialTableAdapter
            // 
            this.t_TipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroElementoTableAdapter1
            // 
            this.t_AceroElementoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_AceroNormaTableAdapter1
            // 
            this.t_AceroNormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TratamientoTableAdapter
            // 
            this.t_TratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // t_MedioEnfriamientoTableAdapter
            // 
            this.t_MedioEnfriamientoTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoTratamientoTableAdapter
            // 
            this.t_TipoTratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // tTipoTratamientoBindingSource1
            // 
            this.tTipoTratamientoBindingSource1.DataMember = "T_TipoTratamiento";
            this.tTipoTratamientoBindingSource1.DataSource = this.dSDatos;
            // 
            // t_TipoPropiedadSolTableAdapter
            // 
            this.t_TipoPropiedadSolTableAdapter.ClearBeforeFill = true;
            // 
            // t_TratamientoDeslozeTableAdapter1
            // 
            this.t_TratamientoDeslozeTableAdapter1.ClearBeforeFill = true;
            // 
            // t_RegimenCalentamientoTableAdapter
            // 
            this.t_RegimenCalentamientoTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroTipoPuntoTableAdapter
            // 
            this.t_AceroTipoPuntoTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroPuntoTableAdapter1
            // 
            this.t_AceroPuntoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_FormulaTableAdapter
            // 
            this.t_FormulaTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroPuntoFormulaTableAdapter1
            // 
            this.t_AceroPuntoFormulaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAcero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 446);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aceros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAcero_FormClosed);
            this.Load += new System.EventHandler(this.FrmAcero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNormaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroTipoPuntoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit9View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFormulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit10View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadSolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMedioEnfriamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_ElementoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_NormaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRegimenCalentamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTratamientoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource t_AceroBindingSource;
        private T_AceroTableAdapter t_AceroTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_AceroGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colidelemento;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorinicial;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorfinal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipomaterial;
        private T_ElementoTableAdapter t_ElementoTableAdapter;
        private System.Windows.Forms.BindingSource tElementoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcodelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colnameelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colidnorma;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private T_NormaTableAdapter t_NormaTableAdapter;
        private System.Windows.Forms.BindingSource tNormaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnamenorma;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private T_TipoMaterialTableAdapter t_TipoMaterialTableAdapter;
        private System.Windows.Forms.BindingSource tTipoMaterialBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipomaterial;
        private DevExpress.XtraGrid.GridControl t_ElementoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colcodelemento1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameelemento1;
        private DevExpress.XtraGrid.GridControl t_NormaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colnamenorma1;
        private T_AceroElementoTableAdapter t_AceroElementoTableAdapter1;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.BindingSource tTratamientoBindingSource;
        private T_TratamientoTableAdapter t_TratamientoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidacero;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private System.Windows.Forms.BindingSource tAceroBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit4View;
        private DevExpress.XtraGrid.Columns.GridColumn colnameacero;
        private DevExpress.XtraGrid.Columns.GridColumn coltempmin;
        private DevExpress.XtraGrid.Columns.GridColumn coltempmax;
        private DevExpress.XtraGrid.Columns.GridColumn colidmedioenf;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit5View;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipotrat;
        private System.Windows.Forms.BindingSource tMedioEnfriamientoBindingSource;
        private T_MedioEnfriamientoTableAdapter t_MedioEnfriamientoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemedioenf;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit6;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit6View;
        private System.Windows.Forms.BindingSource tTipoTratamientoBindingSource;
        private T_TipoTratamientoTableAdapter t_TipoTratamientoTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colidpropiedad;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit8;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit8View;
        private DevExpress.XtraGrid.Columns.GridColumn colvalormin;
        private DevExpress.XtraGrid.Columns.GridColumn colvalormax;
        private DevExpress.XtraGrid.Columns.GridColumn colnametratamiento;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit7;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit7View;
        private System.Windows.Forms.BindingSource tTipoTratamientoBindingSource1;
        private System.Windows.Forms.BindingSource tTipoPropiedadSolBindingSource;
        private T_TipoPropiedadSolTableAdapter t_TipoPropiedadSolTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopropiedad;
        private T_TratamientoDeslozeTableAdapter t_TratamientoDeslozeTableAdapter1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private System.Windows.Forms.BindingSource tRegimenCalentamientoBindingSource;
        private T_RegimenCalentamientoTableAdapter t_RegimenCalentamientoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameregcalent;
        private DevExpress.XtraGrid.Columns.GridColumn colimgregcalent;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipopunto;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit9;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit9View;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor1;
        private System.Windows.Forms.BindingSource tAceroTipoPuntoBindingSource;
        private T_AceroTipoPuntoTableAdapter t_AceroTipoPuntoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopunto;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopunto1;
        private T_AceroPuntoTableAdapter t_AceroPuntoTableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn colidformula;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit10;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit10View;
        private System.Windows.Forms.BindingSource tFormulaBindingSource;
        private T_FormulaTableAdapter t_FormulaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmi;
        private DevExpress.XtraGrid.Columns.GridColumn colmd;
        private T_AceroPuntoFormulaTableAdapter t_AceroPuntoFormulaTableAdapter1;
    }
}