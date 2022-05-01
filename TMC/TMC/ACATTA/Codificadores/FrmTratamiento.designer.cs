using TMC.ACATTA.DSACATTATableAdapters;
using TMC.ACATTA;
namespace TMC.ACATTA.Codificadores
{
    partial class FrmTratamiento
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
            this.dSDatos = new DSACATTA();
            this.t_TratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_TratamientoTableAdapter = new T_TratamientoTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.t_TratamientoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametratamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TratamientoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_TratamientoBindingSource
            // 
            this.t_TratamientoBindingSource.DataMember = "T_Tratamiento";
            this.t_TratamientoBindingSource.DataSource = this.dSDatos;
            // 
            // t_TratamientoTableAdapter
            // 
            this.t_TratamientoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_TipoPiezaGeometriaTableAdapter = null;
            this.tableAdapterManager.T_TipoPiezaTableAdapter = null;
            this.tableAdapterManager.T_TipoPropiedadSolTableAdapter = null;
            this.tableAdapterManager.T_TipoTratamientoTableAdapter = null;
            this.tableAdapterManager.T_TratamientoDeslozeTableAdapter = null;
            this.tableAdapterManager.T_TratamientoTableAdapter = this.t_TratamientoTableAdapter;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_TratamientoGridControl
            // 
            this.t_TratamientoGridControl.DataSource = this.t_TratamientoBindingSource;
            this.t_TratamientoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TratamientoGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TratamientoGridControl.MainView = this.gridView1;
            this.t_TratamientoGridControl.Name = "t_TratamientoGridControl";
            this.t_TratamientoGridControl.Size = new System.Drawing.Size(366, 260);
            this.t_TratamientoGridControl.TabIndex = 1;
            this.t_TratamientoGridControl.UseEmbeddedNavigator = true;
            this.t_TratamientoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametratamiento});
            this.gridView1.GridControl = this.t_TratamientoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnametratamiento
            // 
            this.colnametratamiento.Caption = "Nombre";
            this.colnametratamiento.FieldName = "nametratamiento";
            this.colnametratamiento.Name = "colnametratamiento";
            this.colnametratamiento.Visible = true;
            this.colnametratamiento.VisibleIndex = 0;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 260);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.ucPieFormulario1.Size = new System.Drawing.Size(366, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cerrar";
            this.ucPieFormulario1.TabIndex = 2;
            // 
            // FrmTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 290);
            this.Controls.Add(this.t_TratamientoGridControl);
            this.Controls.Add(this.ucPieFormulario1);
            this.Name = "FrmTratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTratamiento_FormClosed);
            this.Load += new System.EventHandler(this.FrmTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TratamientoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource t_TratamientoBindingSource;
        private T_TratamientoTableAdapter t_TratamientoTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_TratamientoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnametratamiento;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
    }
}