namespace TMC.BCE.Tareas
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.idprojectbalanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tProjectBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBCE = new TMC.BCE.DSBCE();
            this.name_PTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fecha_PDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.idpatronSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tPatronBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamepatron = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemForidprojectbalance = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForname_P = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForfecha_P = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidpatron = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.t_Project_BalanceTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Project_BalanceTableAdapter();
            this.t_Patron_BalanceTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Patron_BalanceTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idprojectbalanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_PTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_PDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_PDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idpatronSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPatronBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidprojectbalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForname_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfecha_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidpatron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.idprojectbalanceSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.name_PTextEdit);
            this.dataLayoutControl1.Controls.Add(this.fecha_PDateEdit);
            this.dataLayoutControl1.Controls.Add(this.idpatronSpinEdit);
            this.dataLayoutControl1.DataSource = this.tProjectBalanceBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidprojectbalance});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(365, 92);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // idprojectbalanceSpinEdit
            // 
            this.idprojectbalanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tProjectBalanceBindingSource, "idprojectbalance", true));
            this.idprojectbalanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idprojectbalanceSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.idprojectbalanceSpinEdit.Name = "idprojectbalanceSpinEdit";
            this.idprojectbalanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idprojectbalanceSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.idprojectbalanceSpinEdit.StyleController = this.dataLayoutControl1;
            this.idprojectbalanceSpinEdit.TabIndex = 4;
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
            // name_PTextEdit
            // 
            this.name_PTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tProjectBalanceBindingSource, "name_P", true));
            this.name_PTextEdit.Location = new System.Drawing.Point(57, 12);
            this.name_PTextEdit.Name = "name_PTextEdit";
            this.name_PTextEdit.Size = new System.Drawing.Size(296, 20);
            this.name_PTextEdit.StyleController = this.dataLayoutControl1;
            this.name_PTextEdit.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.name_PTextEdit, conditionValidationRule1);
            // 
            // fecha_PDateEdit
            // 
            this.fecha_PDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tProjectBalanceBindingSource, "fecha_P", true));
            this.fecha_PDateEdit.EditValue = null;
            this.fecha_PDateEdit.Location = new System.Drawing.Point(57, 36);
            this.fecha_PDateEdit.Name = "fecha_PDateEdit";
            this.fecha_PDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha_PDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fecha_PDateEdit.Size = new System.Drawing.Size(296, 20);
            this.fecha_PDateEdit.StyleController = this.dataLayoutControl1;
            this.fecha_PDateEdit.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.fecha_PDateEdit, conditionValidationRule2);
            // 
            // idpatronSpinEdit
            // 
            this.idpatronSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tProjectBalanceBindingSource, "idpatron", true));
            this.idpatronSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idpatronSpinEdit.Location = new System.Drawing.Point(57, 60);
            this.idpatronSpinEdit.Name = "idpatronSpinEdit";
            this.idpatronSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idpatronSpinEdit.Properties.DataSource = this.tPatronBalanceBindingSource;
            this.idpatronSpinEdit.Properties.DisplayMember = "namepatron";
            this.idpatronSpinEdit.Properties.NullText = "";
            this.idpatronSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idpatronSpinEdit.Properties.ValueMember = "idpatron";
            this.idpatronSpinEdit.Properties.View = this.gridLookUpEdit1View;
            this.idpatronSpinEdit.Size = new System.Drawing.Size(296, 20);
            this.idpatronSpinEdit.StyleController = this.dataLayoutControl1;
            this.idpatronSpinEdit.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idpatronSpinEdit, conditionValidationRule3);
            // 
            // tPatronBalanceBindingSource
            // 
            this.tPatronBalanceBindingSource.DataMember = "T_Patron_Balance";
            this.tPatronBalanceBindingSource.DataSource = this.dSBCE;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamepatron});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamepatron
            // 
            this.colnamepatron.Caption = "Patrón";
            this.colnamepatron.FieldName = "namepatron";
            this.colnamepatron.Name = "colnamepatron";
            this.colnamepatron.Visible = true;
            this.colnamepatron.VisibleIndex = 0;
            // 
            // ItemForidprojectbalance
            // 
            this.ItemForidprojectbalance.Control = this.idprojectbalanceSpinEdit;
            this.ItemForidprojectbalance.CustomizationFormText = "idprojectbalance";
            this.ItemForidprojectbalance.Location = new System.Drawing.Point(0, 0);
            this.ItemForidprojectbalance.Name = "ItemForidprojectbalance";
            this.ItemForidprojectbalance.Size = new System.Drawing.Size(0, 0);
            this.ItemForidprojectbalance.Text = "idprojectbalance";
            this.ItemForidprojectbalance.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForidprojectbalance.TextToControlDistance = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(365, 92);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForname_P,
            this.ItemForfecha_P,
            this.ItemForidpatron});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(345, 72);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForname_P
            // 
            this.ItemForname_P.Control = this.name_PTextEdit;
            this.ItemForname_P.CustomizationFormText = "Nombre:";
            this.ItemForname_P.Location = new System.Drawing.Point(0, 0);
            this.ItemForname_P.Name = "ItemForname_P";
            this.ItemForname_P.Size = new System.Drawing.Size(345, 24);
            this.ItemForname_P.Text = "Nombre:";
            this.ItemForname_P.TextSize = new System.Drawing.Size(41, 13);
            // 
            // ItemForfecha_P
            // 
            this.ItemForfecha_P.Control = this.fecha_PDateEdit;
            this.ItemForfecha_P.CustomizationFormText = "Fecha:";
            this.ItemForfecha_P.Location = new System.Drawing.Point(0, 24);
            this.ItemForfecha_P.Name = "ItemForfecha_P";
            this.ItemForfecha_P.Size = new System.Drawing.Size(345, 24);
            this.ItemForfecha_P.Text = "Fecha:";
            this.ItemForfecha_P.TextSize = new System.Drawing.Size(41, 13);
            // 
            // ItemForidpatron
            // 
            this.ItemForidpatron.Control = this.idpatronSpinEdit;
            this.ItemForidpatron.CustomizationFormText = "Patrón:";
            this.ItemForidpatron.Location = new System.Drawing.Point(0, 48);
            this.ItemForidpatron.Name = "ItemForidpatron";
            this.ItemForidpatron.Size = new System.Drawing.Size(345, 24);
            this.ItemForidpatron.Text = "Patrón:";
            this.ItemForidpatron.TextSize = new System.Drawing.Size(41, 13);
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 92);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(365, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 1;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // t_Project_BalanceTableAdapter
            // 
            this.t_Project_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // t_Patron_BalanceTableAdapter
            // 
            this.t_Patron_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 122);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageProject";
            this.Load += new System.EventHandler(this.FrmManageProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idprojectbalanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_PTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_PDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_PDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idpatronSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPatronBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidprojectbalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForname_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfecha_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidpatron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSBCE dSBCE;
        private System.Windows.Forms.BindingSource tProjectBalanceBindingSource;
        private DSBCETableAdapters.T_Project_BalanceTableAdapter t_Project_BalanceTableAdapter;
        private DevExpress.XtraEditors.SpinEdit idprojectbalanceSpinEdit;
        private DevExpress.XtraEditors.TextEdit name_PTextEdit;
        private DevExpress.XtraEditors.DateEdit fecha_PDateEdit;
        private DevExpress.XtraEditors.GridLookUpEdit idpatronSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidprojectbalance;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForname_P;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfecha_P;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidpatron;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private System.Windows.Forms.BindingSource tPatronBalanceBindingSource;
        private DSBCETableAdapters.T_Patron_BalanceTableAdapter t_Patron_BalanceTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamepatron;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;

    }
}