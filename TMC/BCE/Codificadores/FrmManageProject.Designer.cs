namespace TMC.BCE.Codificadores
{
    partial class FrmManageProject
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.t_Proyecto_Balance_BCGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_Proyecto_Balance_BCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBCE = new TMC.BCE.DSBCE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidpropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tBalancePropiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoPropiedadBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopropiedadbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname_Balance_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipopropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_Proyecto_Balance_BCTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Proyecto_Balance_BCTableAdapter();
            this.tableAdapterManager = new TMC.BCE.DSBCETableAdapters.TableAdapterManager();
            this.t_Balance_PropiedadTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Balance_PropiedadTableAdapter();
            this.t_Tipo_Propiedad_BalanceTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Tipo_Propiedad_BalanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBalancePropiedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 391);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(532, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 0;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.t_Proyecto_Balance_BCGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(532, 391);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // t_Proyecto_Balance_BCGridControl
            // 
            this.t_Proyecto_Balance_BCGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_Proyecto_Balance_BCGridControl.DataSource = this.t_Proyecto_Balance_BCBindingSource;
            this.t_Proyecto_Balance_BCGridControl.Location = new System.Drawing.Point(12, 28);
            this.t_Proyecto_Balance_BCGridControl.MainView = this.gridView1;
            this.t_Proyecto_Balance_BCGridControl.Name = "t_Proyecto_Balance_BCGridControl";
            this.t_Proyecto_Balance_BCGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_Proyecto_Balance_BCGridControl.Size = new System.Drawing.Size(508, 351);
            this.t_Proyecto_Balance_BCGridControl.TabIndex = 4;
            this.t_Proyecto_Balance_BCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // t_Proyecto_Balance_BCBindingSource
            // 
            this.t_Proyecto_Balance_BCBindingSource.DataMember = "T_Proyecto_Balance_BC";
            this.t_Proyecto_Balance_BCBindingSource.DataSource = this.dSBCE;
            // 
            // dSBCE
            // 
            this.dSBCE.DataSetName = "DSBCE";
            this.dSBCE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidpropiedad,
            this.colidelemento,
            this.colvalor});
            this.gridView1.GridControl = this.t_Proyecto_Balance_BCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colidpropiedad
            // 
            this.colidpropiedad.Caption = "Propiedad";
            this.colidpropiedad.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidpropiedad.FieldName = "idpropiedad";
            this.colidpropiedad.Name = "colidpropiedad";
            this.colidpropiedad.Visible = true;
            this.colidpropiedad.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tBalancePropiedadBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "name_Balance_P";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2});
            this.repositoryItemGridLookUpEdit1.ValueMember = "idBalance_Propiedad";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tBalancePropiedadBindingSource
            // 
            this.tBalancePropiedadBindingSource.DataMember = "T_Balance_Propiedad";
            this.tBalancePropiedadBindingSource.DataSource = this.dSBCE;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tTipoPropiedadBalanceBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "nametipopropiedadbalance";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idtipopropiedadbalance";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tTipoPropiedadBalanceBindingSource
            // 
            this.tTipoPropiedadBalanceBindingSource.DataMember = "T_Tipo_Propiedad_Balance";
            this.tTipoPropiedadBalanceBindingSource.DataSource = this.dSBCE;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopropiedadbalance});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopropiedadbalance
            // 
            this.colnametipopropiedadbalance.Caption = "Nombre";
            this.colnametipopropiedadbalance.FieldName = "nametipopropiedadbalance";
            this.colnametipopropiedadbalance.Name = "colnametipopropiedadbalance";
            this.colnametipopropiedadbalance.Visible = true;
            this.colnametipopropiedadbalance.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname_Balance_P,
            this.colidtipopropiedad});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colname_Balance_P
            // 
            this.colname_Balance_P.Caption = "Nombre";
            this.colname_Balance_P.FieldName = "name_Balance_P";
            this.colname_Balance_P.Name = "colname_Balance_P";
            this.colname_Balance_P.Visible = true;
            this.colname_Balance_P.VisibleIndex = 0;
            // 
            // colidtipopropiedad
            // 
            this.colidtipopropiedad.Caption = "Tipo de Propiedad";
            this.colidtipopropiedad.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidtipopropiedad.FieldName = "idtipopropiedad";
            this.colidtipopropiedad.Name = "colidtipopropiedad";
            this.colidtipopropiedad.Visible = true;
            this.colidtipopropiedad.VisibleIndex = 1;
            // 
            // colidelemento
            // 
            this.colidelemento.Caption = "Elemento";
            this.colidelemento.FieldName = "idelemento";
            this.colidelemento.Name = "colidelemento";
            this.colidelemento.Visible = true;
            this.colidelemento.VisibleIndex = 1;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(532, 391);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.t_Proyecto_Balance_BCGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(512, 371);
            this.layoutControlItem1.Text = "Valores iniciales";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // t_Proyecto_Balance_BCTableAdapter
            // 
            this.t_Proyecto_Balance_BCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_Balance_CompDefaultTableAdapter = null;
            this.tableAdapterManager.T_Balance_PropiedadTableAdapter = null;
            this.tableAdapterManager.T_ElementoTableAdapter = null;
            this.tableAdapterManager.T_Project_BalanceTableAdapter = null;
            this.tableAdapterManager.T_Proyecto_Balance_BCTableAdapter = this.t_Proyecto_Balance_BCTableAdapter;
            this.tableAdapterManager.T_Tipo_Propiedad_BalanceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMC.BCE.DSBCETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_Balance_PropiedadTableAdapter
            // 
            this.t_Balance_PropiedadTableAdapter.ClearBeforeFill = true;
            // 
            // t_Tipo_Propiedad_BalanceTableAdapter
            // 
            this.t_Tipo_Propiedad_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 421);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageProject";
            this.Load += new System.EventHandler(this.FrmManageProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBalancePropiedadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSBCE dSBCE;
        private System.Windows.Forms.BindingSource t_Proyecto_Balance_BCBindingSource;
        private DSBCETableAdapters.T_Proyecto_Balance_BCTableAdapter t_Proyecto_Balance_BCTableAdapter;
        private DSBCETableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_Proyecto_Balance_BCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colidpropiedad;
        private DevExpress.XtraGrid.Columns.GridColumn colidelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tBalancePropiedadBindingSource;
        private DSBCETableAdapters.T_Balance_PropiedadTableAdapter t_Balance_PropiedadTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colname_Balance_P;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipopropiedad;
        private System.Windows.Forms.BindingSource tTipoPropiedadBalanceBindingSource;
        private DSBCETableAdapters.T_Tipo_Propiedad_BalanceTableAdapter t_Tipo_Propiedad_BalanceTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopropiedadbalance;
    }
}