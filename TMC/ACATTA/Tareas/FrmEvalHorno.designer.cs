using TMC.ACATTA;
using TMC.ACATTA.DSACATTATableAdapters;
namespace TMC.ACATTA.Tareas
{
    partial class FrmEvalHorno
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Hornoedit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.aceroedit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.ACATTA.DSACATTA();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantpiezasedit = new DevExpress.XtraEditors.SpinEdit();
            this.tempinicialedit = new DevExpress.XtraEditors.SpinEdit();
            this.tempfinaledit = new DevExpress.XtraEditors.SpinEdit();
            this.pesoedit = new DevExpress.XtraEditors.SpinEdit();
            this.potenciaedit = new DevExpress.XtraEditors.SpinEdit();
            this.eficienciaedit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.t_AceroTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_AceroTableAdapter();
            this.t_NormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_NormaTableAdapter();
            this.t_AceroNormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroNormaTableAdapter();
            this.t_HornoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_HornoTableAdapter();
            this.t_TipoHornoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_TipoHornoTableAdapter();
            this.t_TipoMaterialTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TipoMaterialTableAdapter();
            this.t_CapacidadCalorificaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_CapacidadCalorificaTableAdapter();
            this.t_CapacidadDeslozeTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_CapacidadDeslozeTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hornoedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceroedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantpiezasedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempinicialedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempfinaledit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potenciaedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eficienciaedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl6);
            this.layoutControl1.Controls.Add(this.labelControl5);
            this.layoutControl1.Controls.Add(this.labelControl4);
            this.layoutControl1.Controls.Add(this.labelControl3);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.Hornoedit);
            this.layoutControl1.Controls.Add(this.aceroedit);
            this.layoutControl1.Controls.Add(this.cantpiezasedit);
            this.layoutControl1.Controls.Add(this.tempinicialedit);
            this.layoutControl1.Controls.Add(this.tempfinaledit);
            this.layoutControl1.Controls.Add(this.pesoedit);
            this.layoutControl1.Controls.Add(this.potenciaedit);
            this.layoutControl1.Controls.Add(this.eficienciaedit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(608, 75, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(554, 291);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(144, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.StyleController = this.layoutControl1;
            this.labelControl6.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(144, 180);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.StyleController = this.layoutControl1;
            this.labelControl5.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(298, 235);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(220, 20);
            this.labelControl4.StyleController = this.layoutControl1;
            this.labelControl4.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(298, 211);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(220, 20);
            this.labelControl3.StyleController = this.layoutControl1;
            this.labelControl3.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(298, 194);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(220, 13);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(144, 163);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(360, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(182, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Calcular";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Hornoedit
            // 
            this.Hornoedit.Location = new System.Drawing.Point(132, 36);
            this.Hornoedit.Name = "Hornoedit";
            this.Hornoedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Hornoedit.Properties.PopupControl = this.popupContainerControl1;
            this.Hornoedit.Size = new System.Drawing.Size(410, 20);
            this.Hornoedit.StyleController = this.layoutControl1;
            this.Hornoedit.TabIndex = 8;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.Hornoedit, conditionValidationRule1);
            this.Hornoedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.treeList1);
            this.popupContainerControl1.Location = new System.Drawing.Point(107, 71);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(283, 106);
            this.popupContainerControl1.TabIndex = 6;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.ParentFieldName = "";
            this.treeList1.Size = new System.Drawing.Size(283, 106);
            this.treeList1.TabIndex = 0;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Hornos";
            this.treeListColumn1.FieldName = "Hornos";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // aceroedit
            // 
            this.aceroedit.Location = new System.Drawing.Point(400, 12);
            this.aceroedit.Name = "aceroedit";
            this.aceroedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aceroedit.Properties.DataSource = this.tTipoMaterialBindingSource;
            this.aceroedit.Properties.DisplayMember = "nametipomaterial";
            this.aceroedit.Properties.ValueMember = "idtipomaterial";
            this.aceroedit.Properties.View = this.gridLookUpEdit1View;
            this.aceroedit.Size = new System.Drawing.Size(142, 20);
            this.aceroedit.StyleController = this.layoutControl1;
            this.aceroedit.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.aceroedit, conditionValidationRule2);
            this.aceroedit.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            this.aceroedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // tTipoMaterialBindingSource
            // 
            this.tTipoMaterialBindingSource.DataMember = "T_TipoMaterial";
            this.tTipoMaterialBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipomaterial});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipomaterial
            // 
            this.colnametipomaterial.Caption = "Material";
            this.colnametipomaterial.FieldName = "nametipomaterial";
            this.colnametipomaterial.Name = "colnametipomaterial";
            this.colnametipomaterial.Visible = true;
            this.colnametipomaterial.VisibleIndex = 0;
            // 
            // cantpiezasedit
            // 
            this.cantpiezasedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantpiezasedit.Location = new System.Drawing.Point(132, 12);
            this.cantpiezasedit.Name = "cantpiezasedit";
            this.cantpiezasedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantpiezasedit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.cantpiezasedit.Properties.Mask.EditMask = "d";
            this.cantpiezasedit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.cantpiezasedit.Size = new System.Drawing.Size(144, 20);
            this.cantpiezasedit.StyleController = this.layoutControl1;
            this.cantpiezasedit.TabIndex = 4;
            this.cantpiezasedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // tempinicialedit
            // 
            this.tempinicialedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tempinicialedit.Location = new System.Drawing.Point(132, 60);
            this.tempinicialedit.Name = "tempinicialedit";
            this.tempinicialedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tempinicialedit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.tempinicialedit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tempinicialedit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tempinicialedit.Size = new System.Drawing.Size(50, 20);
            this.tempinicialedit.StyleController = this.layoutControl1;
            this.tempinicialedit.TabIndex = 6;
            this.tempinicialedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // tempfinaledit
            // 
            this.tempfinaledit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tempfinaledit.Location = new System.Drawing.Point(306, 60);
            this.tempfinaledit.Name = "tempfinaledit";
            this.tempfinaledit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tempfinaledit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.tempfinaledit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tempfinaledit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tempfinaledit.Size = new System.Drawing.Size(50, 20);
            this.tempfinaledit.StyleController = this.layoutControl1;
            this.tempfinaledit.TabIndex = 7;
            this.tempfinaledit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // pesoedit
            // 
            this.pesoedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pesoedit.Location = new System.Drawing.Point(132, 84);
            this.pesoedit.Name = "pesoedit";
            this.pesoedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.pesoedit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.pesoedit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.pesoedit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.pesoedit.Size = new System.Drawing.Size(224, 20);
            this.pesoedit.StyleController = this.layoutControl1;
            this.pesoedit.TabIndex = 10;
            this.pesoedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // potenciaedit
            // 
            this.potenciaedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.potenciaedit.Location = new System.Drawing.Point(132, 108);
            this.potenciaedit.Name = "potenciaedit";
            this.potenciaedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.potenciaedit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.potenciaedit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.potenciaedit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.potenciaedit.Size = new System.Drawing.Size(143, 20);
            this.potenciaedit.StyleController = this.layoutControl1;
            this.potenciaedit.TabIndex = 9;
            this.potenciaedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // eficienciaedit
            // 
            this.eficienciaedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.eficienciaedit.Location = new System.Drawing.Point(399, 108);
            this.eficienciaedit.Name = "eficienciaedit";
            this.eficienciaedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.eficienciaedit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.eficienciaedit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.eficienciaedit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.eficienciaedit.Size = new System.Drawing.Size(143, 20);
            this.eficienciaedit.StyleController = this.layoutControl1;
            this.eficienciaedit.TabIndex = 14;
            this.eficienciaedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eficienciaedit_KeyDown);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlGroup2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(554, 291);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cantpiezasedit;
            this.layoutControlItem1.CustomizationFormText = "Cantidad de Piezas:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(268, 24);
            this.layoutControlItem1.Text = "Cantidad de Piezas:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.aceroedit;
            this.layoutControlItem2.CustomizationFormText = "Acero:";
            this.layoutControlItem2.Location = new System.Drawing.Point(268, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem2.Text = "Tipo de Material:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tempfinaledit;
            this.layoutControlItem4.CustomizationFormText = "Temperatura Final:";
            this.layoutControlItem4.Location = new System.Drawing.Point(174, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(174, 24);
            this.layoutControlItem4.Text = "Temperatura Final(°C):";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.pesoedit;
            this.layoutControlItem7.CustomizationFormText = "Peso:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem7.Text = "Peso(kg):";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButton1;
            this.layoutControlItem8.CustomizationFormText = "Calcular";
            this.layoutControlItem8.Location = new System.Drawing.Point(348, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(186, 48);
            this.layoutControlItem8.Text = "Calcular";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            this.layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlGroup3,
            this.layoutControlItem14,
            this.layoutControlItem15});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 120);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(534, 151);
            this.layoutControlGroup2.Text = "Horno seleccionado";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.labelControl1;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(142, 17);
            this.layoutControlItem9.Text = "Horno:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Dimensiones";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem13});
            this.layoutControlGroup3.Location = new System.Drawing.Point(142, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(368, 108);
            this.layoutControlGroup3.Text = "Dimensiones";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.labelControl2;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(344, 17);
            this.layoutControlItem10.Text = "Largo(mm):";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.labelControl3;
            this.layoutControlItem12.CustomizationFormText = "Ancho o Diámetro:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(122, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(344, 24);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "Ancho o Diámetro (mm):";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.labelControl4;
            this.layoutControlItem13.CustomizationFormText = "Alto:";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(122, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(344, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "Alto(mm):";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.labelControl5;
            this.layoutControlItem14.CustomizationFormText = "Potencia:";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(142, 17);
            this.layoutControlItem14.Text = "Potencia(kW):";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.labelControl6;
            this.layoutControlItem15.CustomizationFormText = "Eficiencia:";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(142, 74);
            this.layoutControlItem15.Text = "Eficiencia(kWh):";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tempinicialedit;
            this.layoutControlItem3.CustomizationFormText = "Temperatura Inicial:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(174, 24);
            this.layoutControlItem3.Text = "Temperatura Inicial(°C):";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Hornoedit;
            this.layoutControlItem5.CustomizationFormText = "Horno:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(534, 24);
            this.layoutControlItem5.Text = "Horno:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.potenciaedit;
            this.layoutControlItem6.CustomizationFormText = "Potencia:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(267, 24);
            this.layoutControlItem6.Text = "Potencia(kW):";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.eficienciaedit;
            this.layoutControlItem11.CustomizationFormText = "Eficiencia:";
            this.layoutControlItem11.Location = new System.Drawing.Point(267, 96);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(267, 24);
            this.layoutControlItem11.Text = "Eficiencia(kWh):";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(116, 13);
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 291);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(554, 32);
            this.ucPieFormulario1.StringAceptar = "Evaluar";
            this.ucPieFormulario1.StringCancelar = "Salir";
            this.ucPieFormulario1.TabIndex = 5;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // t_AceroTableAdapter
            // 
            this.t_AceroTableAdapter.ClearBeforeFill = true;
            // 
            // t_NormaTableAdapter1
            // 
            this.t_NormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_AceroNormaTableAdapter1
            // 
            this.t_AceroNormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_HornoTableAdapter1
            // 
            this.t_HornoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TipoHornoTableAdapter1
            // 
            this.t_TipoHornoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TipoMaterialTableAdapter
            // 
            this.t_TipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // t_CapacidadCalorificaTableAdapter1
            // 
            this.t_CapacidadCalorificaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_CapacidadDeslozeTableAdapter1
            // 
            this.t_CapacidadDeslozeTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmEvalHorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 323);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.Controls.Add(this.popupContainerControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEvalHorno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluar Horno";
            this.Load += new System.EventHandler(this.FrmEvalHorno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hornoedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceroedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantpiezasedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempinicialedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempfinaledit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potenciaedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eficienciaedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PopupContainerEdit Hornoedit;
        private DevExpress.XtraEditors.GridLookUpEdit aceroedit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DSACATTA dSDatos;
        private T_AceroTableAdapter t_AceroTableAdapter;
        private T_NormaTableAdapter t_NormaTableAdapter1;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private T_HornoTableAdapter t_HornoTableAdapter1;
        private T_TipoHornoTableAdapter t_TipoHornoTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.BindingSource tTipoMaterialBindingSource;
        private T_TipoMaterialTableAdapter t_TipoMaterialTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipomaterial;
        private T_CapacidadCalorificaTableAdapter t_CapacidadCalorificaTableAdapter1;
        private T_CapacidadDeslozeTableAdapter t_CapacidadDeslozeTableAdapter1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.SpinEdit cantpiezasedit;
        private DevExpress.XtraEditors.SpinEdit tempinicialedit;
        private DevExpress.XtraEditors.SpinEdit tempfinaledit;
        private DevExpress.XtraEditors.SpinEdit pesoedit;
        private DevExpress.XtraEditors.SpinEdit potenciaedit;
        private DevExpress.XtraEditors.SpinEdit eficienciaedit;
    }
}