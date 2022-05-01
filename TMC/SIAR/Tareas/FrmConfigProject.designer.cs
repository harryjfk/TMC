using TMC.SIAR.DSRDTableAdapters;
using TMC.SIAR;
namespace TMC.SIAR.Tareas
{
    partial class FrmCreateProject
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule9 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule10 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule11 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule12 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule13 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dSDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.SIAR.DSRD();
            this.tDegradeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamedegrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgdegrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoParedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameprojectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.valueparedSpinEdit = new DevExpress.XtraEditors.TrackBarControl();
            this.formulatTextEdit = new DevExpress.XtraEditors.RadioGroup();
            this.areaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.tempambSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tempdiseSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.coefinintercambioSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.vcformSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.emchapaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFornameproject = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForarea = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFortempdise = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFortempamb = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForvaluepared = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcoefinintercambio = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForformulat = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForemchapa = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForvcform = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.tPropiedadProduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Propiedad_ProduccionTableAdapter = new TMC.SIAR.DSRDTableAdapters.T_Propiedad_ProduccionTableAdapter();
            this.t_Tipo_ParedTableAdapter = new TMC.SIAR.DSRDTableAdapters.T_Tipo_ParedTableAdapter();
            this.tProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ProjectTableAdapter = new TMC.SIAR.DSRDTableAdapters.T_ProjectTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.t_DegradeeTableAdapter = new TMC.SIAR.DSRDTableAdapters.T_DegradeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDegradeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoParedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameprojectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueparedSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueparedSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulatTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempambSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdiseSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefinintercambioSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcformSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emchapaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornameproject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortempdise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortempamb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvaluepared)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcoefinintercambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForformulat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForemchapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvcform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPropiedadProduccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridLookUpEdit2);
            this.dataLayoutControl1.Controls.Add(this.checkEdit1);
            this.dataLayoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.nameprojectTextEdit);
            this.dataLayoutControl1.Controls.Add(this.valueparedSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.formulatTextEdit);
            this.dataLayoutControl1.Controls.Add(this.areaSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.Controls.Add(this.tempambSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.tempdiseSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.coefinintercambioSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.vcformSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.emchapaSpinEdit);
            this.dataLayoutControl1.DataSource = this.dSDatosBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(798, 170, 242, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(489, 453);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "iddegrade", true));
            this.gridLookUpEdit2.Location = new System.Drawing.Point(150, 398);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.tDegradeeBindingSource;
            this.gridLookUpEdit2.Properties.DisplayMember = "namedegrade";
            this.gridLookUpEdit2.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridLookUpEdit2.Properties.ValueMember = "iddegrade";
            this.gridLookUpEdit2.Properties.View = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Size = new System.Drawing.Size(315, 20);
            this.gridLookUpEdit2.StyleController = this.dataLayoutControl1;
            this.gridLookUpEdit2.TabIndex = 19;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit2, conditionValidationRule1);
            // 
            // dSDatosBindingSource
            // 
            this.dSDatosBindingSource.DataMember = "T_Project";
            this.dSDatosBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDegradeeBindingSource
            // 
            this.tDegradeeBindingSource.DataMember = "T_Degradee";
            this.tDegradeeBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamedegrade,
            this.colimgdegrade});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamedegrade
            // 
            this.colnamedegrade.Caption = "Nombre";
            this.colnamedegrade.FieldName = "namedegrade";
            this.colnamedegrade.Name = "colnamedegrade";
            this.colnamedegrade.Visible = true;
            this.colnamedegrade.VisibleIndex = 0;
            // 
            // colimgdegrade
            // 
            this.colimgdegrade.Caption = "Colores";
            this.colimgdegrade.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colimgdegrade.FieldName = "imgdegrade";
            this.colimgdegrade.Name = "colimgdegrade";
            this.colimgdegrade.Visible = true;
            this.colimgdegrade.VisibleIndex = 1;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(24, 266);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Considerar";
            this.checkEdit1.Size = new System.Drawing.Size(218, 19);
            this.checkEdit1.StyleController = this.dataLayoutControl1;
            this.checkEdit1.TabIndex = 17;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.checkEdit1, conditionValidationRule2);
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "tipopared", true));
            this.gridLookUpEdit1.Location = new System.Drawing.Point(138, 169);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tTipoParedBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nametipopared";
            this.gridLookUpEdit1.Properties.ValueMember = "idtipopared";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_Properties_EditValueChanged);
            this.gridLookUpEdit1.Size = new System.Drawing.Size(104, 20);
            this.gridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.gridLookUpEdit1.TabIndex = 16;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit1, conditionValidationRule3);
            // 
            // tTipoParedBindingSource
            // 
            this.tTipoParedBindingSource.DataMember = "T_Tipo_Pared";
            this.tTipoParedBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopared});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopared
            // 
            this.colnametipopared.Caption = "Tipo de Pared";
            this.colnametipopared.FieldName = "nametipopared";
            this.colnametipopared.Name = "colnametipopared";
            this.colnametipopared.Visible = true;
            this.colnametipopared.VisibleIndex = 0;
            // 
            // nameprojectTextEdit
            // 
            this.nameprojectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSDatosBindingSource, "nameproject", true));
            this.nameprojectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "nameproject", true));
            this.nameprojectTextEdit.Location = new System.Drawing.Point(138, 12);
            this.nameprojectTextEdit.Name = "nameprojectTextEdit";
            this.nameprojectTextEdit.Size = new System.Drawing.Size(339, 20);
            this.nameprojectTextEdit.StyleController = this.dataLayoutControl1;
            this.nameprojectTextEdit.TabIndex = 5;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.nameprojectTextEdit, conditionValidationRule4);
            // 
            // valueparedSpinEdit
            // 
            this.valueparedSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "valuepared", true));
            this.valueparedSpinEdit.EditValue = null;
            this.valueparedSpinEdit.Location = new System.Drawing.Point(246, 169);
            this.valueparedSpinEdit.Name = "valueparedSpinEdit";
            this.valueparedSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.valueparedSpinEdit.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.valueparedSpinEdit_Properties_EditValueChanging);
            this.valueparedSpinEdit.Size = new System.Drawing.Size(220, 45);
            this.valueparedSpinEdit.StyleController = this.dataLayoutControl1;
            this.valueparedSpinEdit.TabIndex = 10;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.valueparedSpinEdit, conditionValidationRule5);
            this.valueparedSpinEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.valueparedSpinEdit_EditValueChanging);
            // 
            // formulatTextEdit
            // 
            this.formulatTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "formulat", true));
            this.formulatTextEdit.EditValue = 0;
            this.formulatTextEdit.Location = new System.Drawing.Point(24, 333);
            this.formulatTextEdit.Name = "formulatTextEdit";
            this.formulatTextEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Valor(W/m² °C)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Fórmulas empíricas (Autor)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Norma ASTM C680-10"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Churchill y Chu (Ra,Pr)")});
            this.formulatTextEdit.Size = new System.Drawing.Size(441, 37);
            this.formulatTextEdit.StyleController = this.dataLayoutControl1;
            this.formulatTextEdit.TabIndex = 15;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            conditionValidationRule6.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.formulatTextEdit, conditionValidationRule6);
            this.formulatTextEdit.SelectedIndexChanged += new System.EventHandler(this.formulatTextEdit_SelectedIndexChanged);
            // 
            // areaSpinEdit
            // 
            this.areaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "area", true));
            this.areaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.areaSpinEdit.Location = new System.Drawing.Point(138, 36);
            this.areaSpinEdit.Name = "areaSpinEdit";
            this.areaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.areaSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.areaSpinEdit.Size = new System.Drawing.Size(339, 20);
            this.areaSpinEdit.StyleController = this.dataLayoutControl1;
            this.areaSpinEdit.TabIndex = 6;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "This value is not valid";
            conditionValidationRule7.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.areaSpinEdit, conditionValidationRule7);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "presicionest", true));
            this.textEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEdit1.Location = new System.Drawing.Point(12, 78);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.textEdit1.Size = new System.Drawing.Size(465, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 18;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.textEdit1, conditionValidationRule8);
            // 
            // tempambSpinEdit
            // 
            this.tempambSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "tempamb", true));
            this.tempambSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tempambSpinEdit.Location = new System.Drawing.Point(372, 133);
            this.tempambSpinEdit.Name = "tempambSpinEdit";
            this.tempambSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tempambSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tempambSpinEdit.Size = new System.Drawing.Size(93, 20);
            this.tempambSpinEdit.StyleController = this.dataLayoutControl1;
            this.tempambSpinEdit.TabIndex = 8;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule9.ErrorText = "This value is not valid";
            conditionValidationRule9.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.tempambSpinEdit, conditionValidationRule9);
            // 
            // tempdiseSpinEdit
            // 
            this.tempdiseSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "tempdise", true));
            this.tempdiseSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tempdiseSpinEdit.Location = new System.Drawing.Point(150, 133);
            this.tempdiseSpinEdit.Name = "tempdiseSpinEdit";
            this.tempdiseSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tempdiseSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tempdiseSpinEdit.Size = new System.Drawing.Size(92, 20);
            this.tempdiseSpinEdit.StyleController = this.dataLayoutControl1;
            this.tempdiseSpinEdit.TabIndex = 7;
            conditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule10.ErrorText = "This value is not valid";
            conditionValidationRule10.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.tempdiseSpinEdit, conditionValidationRule10);
            // 
            // coefinintercambioSpinEdit
            // 
            this.coefinintercambioSpinEdit.EditValue = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.coefinintercambioSpinEdit.Location = new System.Drawing.Point(372, 266);
            this.coefinintercambioSpinEdit.Name = "coefinintercambioSpinEdit";
            this.coefinintercambioSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.coefinintercambioSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.coefinintercambioSpinEdit.Size = new System.Drawing.Size(93, 20);
            this.coefinintercambioSpinEdit.StyleController = this.dataLayoutControl1;
            this.coefinintercambioSpinEdit.TabIndex = 11;
            conditionValidationRule11.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule11.ErrorText = "This value is not valid";
            conditionValidationRule11.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.coefinintercambioSpinEdit, conditionValidationRule11);
            // 
            // vcformSpinEdit
            // 
            this.vcformSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "vcform", true));
            this.vcformSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vcformSpinEdit.Location = new System.Drawing.Point(372, 374);
            this.vcformSpinEdit.Name = "vcformSpinEdit";
            this.vcformSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.vcformSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.vcformSpinEdit.Size = new System.Drawing.Size(93, 20);
            this.vcformSpinEdit.StyleController = this.dataLayoutControl1;
            this.vcformSpinEdit.TabIndex = 14;
            conditionValidationRule12.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule12.ErrorText = "This value is not valid";
            conditionValidationRule12.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.vcformSpinEdit, conditionValidationRule12);
            // 
            // emchapaSpinEdit
            // 
            this.emchapaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSDatosBindingSource, "emchapa", true));
            this.emchapaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.emchapaSpinEdit.Location = new System.Drawing.Point(150, 374);
            this.emchapaSpinEdit.Name = "emchapaSpinEdit";
            this.emchapaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.emchapaSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.emchapaSpinEdit.Size = new System.Drawing.Size(92, 20);
            this.emchapaSpinEdit.StyleController = this.dataLayoutControl1;
            this.emchapaSpinEdit.TabIndex = 13;
            conditionValidationRule13.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule13.ErrorText = "This value is not valid";
            conditionValidationRule13.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.emchapaSpinEdit, conditionValidationRule13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(489, 453);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFornameproject,
            this.ItemForarea,
            this.layoutControlGroup3,
            this.layoutControlItem1,
            this.ItemForvaluepared,
            this.simpleLabelItem1,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(469, 422);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemFornameproject
            // 
            this.ItemFornameproject.Control = this.nameprojectTextEdit;
            this.ItemFornameproject.CustomizationFormText = "Nombre:";
            this.ItemFornameproject.Location = new System.Drawing.Point(0, 0);
            this.ItemFornameproject.Name = "ItemFornameproject";
            this.ItemFornameproject.Size = new System.Drawing.Size(469, 24);
            this.ItemFornameproject.Text = "Nombre:";
            this.ItemFornameproject.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForarea
            // 
            this.ItemForarea.Control = this.areaSpinEdit;
            this.ItemForarea.CustomizationFormText = "Área:";
            this.ItemForarea.Location = new System.Drawing.Point(0, 24);
            this.ItemForarea.Name = "ItemForarea";
            this.ItemForarea.Size = new System.Drawing.Size(469, 24);
            this.ItemForarea.Text = "Área: (m²)";
            this.ItemForarea.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Temperatura";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFortempdise,
            this.ItemFortempamb});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 90);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(469, 67);
            this.layoutControlGroup3.Text = "Temperatura";
            // 
            // ItemFortempdise
            // 
            this.ItemFortempdise.Control = this.tempdiseSpinEdit;
            this.ItemFortempdise.CustomizationFormText = "Diseño:";
            this.ItemFortempdise.Location = new System.Drawing.Point(0, 0);
            this.ItemFortempdise.Name = "ItemFortempdise";
            this.ItemFortempdise.Size = new System.Drawing.Size(222, 24);
            this.ItemFortempdise.Text = "Diseño: (C°)";
            this.ItemFortempdise.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemFortempamb
            // 
            this.ItemFortempamb.Control = this.tempambSpinEdit;
            this.ItemFortempamb.CustomizationFormText = "Ambiente";
            this.ItemFortempamb.Location = new System.Drawing.Point(222, 0);
            this.ItemFortempamb.Name = "ItemFortempamb";
            this.ItemFortempamb.Size = new System.Drawing.Size(223, 24);
            this.ItemFortempamb.Text = "Ambiente: (C°)";
            this.ItemFortempamb.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridLookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Tipo de Pared:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 157);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(234, 66);
            this.layoutControlItem1.Text = "Tipo de Pared:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForvaluepared
            // 
            this.ItemForvaluepared.Control = this.valueparedSpinEdit;
            this.ItemForvaluepared.CustomizationFormText = "valuepared";
            this.ItemForvaluepared.Location = new System.Drawing.Point(234, 157);
            this.ItemForvaluepared.MinSize = new System.Drawing.Size(174, 49);
            this.ItemForvaluepared.Name = "ItemForvaluepared";
            this.ItemForvaluepared.Size = new System.Drawing.Size(235, 49);
            this.ItemForvaluepared.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForvaluepared.Text = "0";
            this.ItemForvaluepared.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForvaluepared.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForvaluepared.TextSize = new System.Drawing.Size(6, 13);
            this.ItemForvaluepared.TextToControlDistance = 5;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.CustomizationFormText = "EtiquetasimpleLabelItem1";
            this.simpleLabelItem1.Location = new System.Drawing.Point(234, 206);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(235, 17);
            this.simpleLabelItem1.Text = "EtiquetasimpleLabelItem1";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Coeficiente de intercambio interno";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.ItemForcoefinintercambio});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 223);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(469, 67);
            this.layoutControlGroup4.Text = "Coeficiente de intercambio interno";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEdit1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForcoefinintercambio
            // 
            this.ItemForcoefinintercambio.Control = this.coefinintercambioSpinEdit;
            this.ItemForcoefinintercambio.CustomizationFormText = "coefinintercambio";
            this.ItemForcoefinintercambio.Location = new System.Drawing.Point(222, 0);
            this.ItemForcoefinintercambio.Name = "ItemForcoefinintercambio";
            this.ItemForcoefinintercambio.Size = new System.Drawing.Size(223, 24);
            this.ItemForcoefinintercambio.Text = "Valor(W/m² °C):";
            this.ItemForcoefinintercambio.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Coeficiente de intercambio externo";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForformulat,
            this.ItemForemchapa,
            this.ItemForvcform,
            this.layoutControlItem4});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 290);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(469, 132);
            this.layoutControlGroup5.Text = "Coeficiente de intercambio externo";
            // 
            // ItemForformulat
            // 
            this.ItemForformulat.Control = this.formulatTextEdit;
            this.ItemForformulat.CustomizationFormText = "formulat";
            this.ItemForformulat.Location = new System.Drawing.Point(0, 0);
            this.ItemForformulat.Name = "ItemForformulat";
            this.ItemForformulat.Size = new System.Drawing.Size(445, 41);
            this.ItemForformulat.Text = "Coeficiente de intercambio externo";
            this.ItemForformulat.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForformulat.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForformulat.TextToControlDistance = 0;
            this.ItemForformulat.TextVisible = false;
            // 
            // ItemForemchapa
            // 
            this.ItemForemchapa.Control = this.emchapaSpinEdit;
            this.ItemForemchapa.CustomizationFormText = "emchapa";
            this.ItemForemchapa.Location = new System.Drawing.Point(0, 41);
            this.ItemForemchapa.Name = "ItemForemchapa";
            this.ItemForemchapa.Size = new System.Drawing.Size(222, 24);
            this.ItemForemchapa.Text = "Emisividad de la chapa:";
            this.ItemForemchapa.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForvcform
            // 
            this.ItemForvcform.Control = this.vcformSpinEdit;
            this.ItemForvcform.CustomizationFormText = "vcform";
            this.ItemForvcform.Location = new System.Drawing.Point(222, 41);
            this.ItemForvcform.Name = "ItemForvcform";
            this.ItemForvcform.Size = new System.Drawing.Size(223, 24);
            this.ItemForvcform.Text = "Valor Constante:";
            this.ItemForvcform.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridLookUpEdit2;
            this.layoutControlItem4.CustomizationFormText = "Tipo de Degradado:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem4.Text = "Tipo de Degradado:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit1;
            this.layoutControlItem3.CustomizationFormText = "Presición de estimación de temperaturas (°C):";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(469, 42);
            this.layoutControlItem3.Text = "Presición de estimación de temperaturas (°C):";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(220, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 422);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(469, 11);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 453);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(489, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 1;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            this.ucPieFormulario1.Load += new System.EventHandler(this.ucPieFormulario1_Load);
            // 
            // tPropiedadProduccionBindingSource
            // 
            this.tPropiedadProduccionBindingSource.DataMember = "T_Propiedad_Produccion";
            this.tPropiedadProduccionBindingSource.DataSource = this.dSDatos;
            // 
            // t_Propiedad_ProduccionTableAdapter
            // 
            this.t_Propiedad_ProduccionTableAdapter.ClearBeforeFill = true;
            // 
            // t_Tipo_ParedTableAdapter
            // 
            this.t_Tipo_ParedTableAdapter.ClearBeforeFill = true;
            // 
            // tProjectBindingSource
            // 
            this.tProjectBindingSource.DataMember = "T_Project";
            this.tProjectBindingSource.DataSource = this.dSDatos;
            // 
            // t_ProjectTableAdapter
            // 
            this.t_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // t_DegradeeTableAdapter
            // 
            this.t_DegradeeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 483);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.Name = "FrmCreateProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateProject";
            this.Load += new System.EventHandler(this.FrmCreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDegradeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoParedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameprojectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueparedSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueparedSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulatTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempambSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdiseSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefinintercambioSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcformSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emchapaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornameproject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortempdise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortempamb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvaluepared)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcoefinintercambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForformulat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForemchapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvcform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPropiedadProduccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit nameprojectTextEdit;
        private System.Windows.Forms.BindingSource dSDatosBindingSource;
        private DSRD dSDatos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornameproject;
        private DevExpress.XtraLayout.LayoutControlItem ItemForarea;
        private DevExpress.XtraLayout.LayoutControlItem ItemForvaluepared;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcoefinintercambio;
        private DevExpress.XtraLayout.LayoutControlItem ItemForemchapa;
        private DevExpress.XtraLayout.LayoutControlItem ItemForvcform;
        private DevExpress.XtraLayout.LayoutControlItem ItemForformulat;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemFortempdise;
        private DevExpress.XtraLayout.LayoutControlItem ItemFortempamb;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource tPropiedadProduccionBindingSource;
        private T_Propiedad_ProduccionTableAdapter t_Propiedad_ProduccionTableAdapter;
        private System.Windows.Forms.BindingSource tTipoParedBindingSource;
        private T_Tipo_ParedTableAdapter t_Tipo_ParedTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopared;
        private System.Windows.Forms.BindingSource tProjectBindingSource;
        private T_ProjectTableAdapter t_ProjectTableAdapter;
        private DevExpress.XtraEditors.TrackBarControl valueparedSpinEdit;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.RadioGroup formulatTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource tDegradeeBindingSource;
        private T_DegradeeTableAdapter t_DegradeeTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedegrade;
        private DevExpress.XtraGrid.Columns.GridColumn colimgdegrade;
        private DevExpress.XtraEditors.SpinEdit areaSpinEdit;
        private DevExpress.XtraEditors.SpinEdit textEdit1;
        private DevExpress.XtraEditors.SpinEdit tempambSpinEdit;
        private DevExpress.XtraEditors.SpinEdit tempdiseSpinEdit;
        private DevExpress.XtraEditors.SpinEdit coefinintercambioSpinEdit;
        private DevExpress.XtraEditors.SpinEdit vcformSpinEdit;
        private DevExpress.XtraEditors.SpinEdit emchapaSpinEdit;
    }
}