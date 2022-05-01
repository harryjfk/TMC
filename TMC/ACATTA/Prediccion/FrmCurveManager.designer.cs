using TMC.ACATTA;
using TMC.ACATTA.DSACATTATableAdapters;
namespace TMC.ACATTA.Prediccion
{
    partial class FrmCurveManager
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
            this.tCurvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.ACATTA.DSACATTA();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidacero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tAceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameacero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatacurva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.t_CurvaTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_CurvaTableAdapter();
            this.t_AceroTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_AceroTableAdapter();
            this.t_AceroNormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroNormaTableAdapter();
            this.t_NormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_NormaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCurvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tCurvaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(531, 385);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tCurvaBindingSource
            // 
            this.tCurvaBindingSource.DataMember = "T_Curva";
            this.tCurvaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidacero,
            this.coldatacurva});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colidacero
            // 
            this.colidacero.Caption = "Acero";
            this.colidacero.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidacero.FieldName = "idacero";
            this.colidacero.Name = "colidacero";
            this.colidacero.Visible = true;
            this.colidacero.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tAceroBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nameacero";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idacero";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tAceroBindingSource
            // 
            this.tAceroBindingSource.DataMember = "T_Acero";
            this.tAceroBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameacero});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameacero
            // 
            this.colnameacero.Caption = "Acero";
            this.colnameacero.FieldName = "nameacero";
            this.colnameacero.Name = "colnameacero";
            this.colnameacero.Visible = true;
            this.colnameacero.VisibleIndex = 0;
            // 
            // coldatacurva
            // 
            this.coldatacurva.Caption = "Gráfico";
            this.coldatacurva.ColumnEdit = this.repositoryItemButtonEdit1;
            this.coldatacurva.FieldName = "datacurva";
            this.coldatacurva.Name = "coldatacurva";
            this.coldatacurva.Visible = true;
            this.coldatacurva.VisibleIndex = 1;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonPressed);
            // 
            // t_CurvaTableAdapter
            // 
            this.t_CurvaTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroTableAdapter
            // 
            this.t_AceroTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroNormaTableAdapter1
            // 
            this.t_AceroNormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_NormaTableAdapter1
            // 
            this.t_NormaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmCurveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 385);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmCurveManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de curvas";
            this.Load += new System.EventHandler(this.FrmCurveManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCurvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource tCurvaBindingSource;
        private T_CurvaTableAdapter t_CurvaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidacero;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldatacurva;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.BindingSource tAceroBindingSource;
        private T_AceroTableAdapter t_AceroTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameacero;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private T_NormaTableAdapter t_NormaTableAdapter1;

    }
}