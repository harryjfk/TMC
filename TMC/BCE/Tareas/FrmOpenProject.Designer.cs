namespace TMC.BCE.Tareas
{
    partial class FrmOpenProject
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
            this.tProjectBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBCE = new TMC.BCE.DSBCE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.t_Project_BalanceTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Project_BalanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tProjectBalanceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(505, 385);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // tProjectBalanceBindingSource
            // 
            this.tProjectBalanceBindingSource.DataMember = "T_Project_Balance";
            this.tProjectBalanceBindingSource.DataSource = this.dSBCE;
            // 
            // dSBCE
            // 
            this.dSBCE.DataSetName = "DSBCE";
            this.dSBCE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname_P,
            this.colfecha_P});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colname_P
            // 
            this.colname_P.Caption = "Nombre";
            this.colname_P.FieldName = "name_P";
            this.colname_P.Name = "colname_P";
            this.colname_P.Visible = true;
            this.colname_P.VisibleIndex = 0;
            // 
            // colfecha_P
            // 
            this.colfecha_P.Caption = "Fecha";
            this.colfecha_P.FieldName = "fecha_P";
            this.colfecha_P.Name = "colfecha_P";
            this.colfecha_P.Visible = true;
            this.colfecha_P.VisibleIndex = 1;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 385);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(505, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 1;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // t_Project_BalanceTableAdapter
            // 
            this.t_Project_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 415);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpenProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir proyecto";
            this.Load += new System.EventHandler(this.FrmOpenProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DSBCE dSBCE;
        private System.Windows.Forms.BindingSource tProjectBalanceBindingSource;
        private DSBCETableAdapters.T_Project_BalanceTableAdapter t_Project_BalanceTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colname_P;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_P;
    }
}