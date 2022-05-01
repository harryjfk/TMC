using TMC.RD;
using TMC.RD.DSRDTableAdapters;
namespace TMC.RD.Codificadores
{
    partial class FrmElemento_Oxido
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.T_Elemento_OxidobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new DSRD();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tElementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_Electrones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrado_acides = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_Elemento_OxidoTableAdapter1 = new T_Elemento_OxidoTableAdapter();
            this.t_ElementoTableAdapter = new T_ElementoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Elemento_OxidobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.T_Elemento_OxidobindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(552, 398);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // T_Elemento_OxidobindingSource
            // 
            this.T_Elemento_OxidobindingSource.DataMember = "T_Elemento_Oxido";
            this.T_Elemento_OxidobindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colnum_Electrones,
            this.colgrado_acides});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.gridColumn1.FieldName = "idElemento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
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
            this.tElementoBindingSource.DataSource = this.dSDatosBindingSource;
            // 
            // dSDatosBindingSource
            // 
            this.dSDatosBindingSource.DataSource = this.dSDatos;
            this.dSDatosBindingSource.Position = 0;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameelemento});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameelemento
            // 
            this.colnameelemento.Caption = "Nombre";
            this.colnameelemento.FieldName = "nameelemento";
            this.colnameelemento.Name = "colnameelemento";
            this.colnameelemento.Visible = true;
            this.colnameelemento.VisibleIndex = 0;
            // 
            // colnum_Electrones
            // 
            this.colnum_Electrones.Caption = "Cantidad Electrones";
            this.colnum_Electrones.FieldName = "num_Electrones";
            this.colnum_Electrones.Name = "colnum_Electrones";
            this.colnum_Electrones.Visible = true;
            this.colnum_Electrones.VisibleIndex = 1;
            // 
            // colgrado_acides
            // 
            this.colgrado_acides.Caption = "Grado Acides";
            this.colgrado_acides.FieldName = "grado_acides";
            this.colgrado_acides.Name = "colgrado_acides";
            this.colgrado_acides.Visible = true;
            this.colgrado_acides.VisibleIndex = 2;
            // 
            // t_Elemento_OxidoTableAdapter1
            // 
            this.t_Elemento_OxidoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ElementoTableAdapter
            // 
            this.t_ElementoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmElemento_Oxido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 398);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmElemento_Oxido";
            this.Text = "FrmElemento_Oxido";
            this.Load += new System.EventHandler(this.FrmElemento_Oxido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Elemento_OxidobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private T_Elemento_OxidoTableAdapter t_Elemento_OxidoTableAdapter1;
        private System.Windows.Forms.BindingSource T_Elemento_OxidobindingSource;
        private DSRD dSDatos;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_Electrones;
        private DevExpress.XtraGrid.Columns.GridColumn colgrado_acides;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource dSDatosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tElementoBindingSource;
        private T_ElementoTableAdapter t_ElementoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameelemento;
    }
}