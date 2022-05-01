namespace TMC.BCE.Codificadores
{
    partial class FrmPropiedades
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
            this.dSBCE = new TMC.BCE.DSBCE();
            this.t_Balance_PropiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Balance_PropiedadTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Balance_PropiedadTableAdapter();
            this.tableAdapterManager = new TMC.BCE.DSBCETableAdapters.TableAdapterManager();
            this.t_Balance_PropiedadGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname_Balance_P = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Balance_PropiedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Balance_PropiedadGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = false;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 402);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.ucPieFormulario1.Size = new System.Drawing.Size(592, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cerrar";
            this.ucPieFormulario1.TabIndex = 0;
            // 
            // dSBCE
            // 
            this.dSBCE.DataSetName = "DSBCE";
            this.dSBCE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_Balance_PropiedadBindingSource
            // 
            this.t_Balance_PropiedadBindingSource.DataMember = "T_Balance_Propiedad";
            this.t_Balance_PropiedadBindingSource.DataSource = this.dSBCE;
            // 
            // t_Balance_PropiedadTableAdapter
            // 
            this.t_Balance_PropiedadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_Balance_PropiedadTableAdapter = this.t_Balance_PropiedadTableAdapter;
            this.tableAdapterManager.UpdateOrder = TMC.BCE.DSBCETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_Balance_PropiedadGridControl
            // 
            this.t_Balance_PropiedadGridControl.DataSource = this.t_Balance_PropiedadBindingSource;
            this.t_Balance_PropiedadGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_Balance_PropiedadGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_Balance_PropiedadGridControl.MainView = this.gridView1;
            this.t_Balance_PropiedadGridControl.Name = "t_Balance_PropiedadGridControl";
            this.t_Balance_PropiedadGridControl.Size = new System.Drawing.Size(592, 402);
            this.t_Balance_PropiedadGridControl.TabIndex = 2;
            this.t_Balance_PropiedadGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname_Balance_P});
            this.gridView1.GridControl = this.t_Balance_PropiedadGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colname_Balance_P
            // 
            this.colname_Balance_P.Caption = "Nombre";
            this.colname_Balance_P.FieldName = "name_Balance_P";
            this.colname_Balance_P.Name = "colname_Balance_P";
            this.colname_Balance_P.Visible = true;
            this.colname_Balance_P.VisibleIndex = 0;
            // 
            // FrmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 432);
            this.Controls.Add(this.t_Balance_PropiedadGridControl);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPropiedades";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Propiedades";
            this.Load += new System.EventHandler(this.FrmPropiedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Balance_PropiedadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Balance_PropiedadGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DSBCE dSBCE;
        private System.Windows.Forms.BindingSource t_Balance_PropiedadBindingSource;
        private DSBCETableAdapters.T_Balance_PropiedadTableAdapter t_Balance_PropiedadTableAdapter;
        private DSBCETableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_Balance_PropiedadGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname_Balance_P;
    }
}