using TMC.ACATTA;
using TMC.ACATTA.DSACATTATableAdapters;
namespace TMC.ACATTA.Tareas
{
    partial class FrmTanque
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
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.finalliquidoedit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.inicialliquidoedit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tipomatedit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.ACATTA.DSACATTA();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.medioenfedit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tMedioEnfriamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemedioenf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_MedioEnfriamientoTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_MedioEnfriamientoTableAdapter();
            this.t_TipoMaterialTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TipoMaterialTableAdapter();
            this.t_CapacidadCalorificaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_CapacidadCalorificaTableAdapter();
            this.t_CapacidadDeslozeTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_CapacidadDeslozeTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dimensionedit = new DevExpress.XtraEditors.SpinEdit();
            this.cantpiezasedit = new DevExpress.XtraEditors.SpinEdit();
            this.inicialmetaledit = new DevExpress.XtraEditors.SpinEdit();
            this.finmetaledit = new DevExpress.XtraEditors.SpinEdit();
            this.pesoedit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalliquidoedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicialliquidoedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipomatedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioenfedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMedioEnfriamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantpiezasedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicialmetaledit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finmetaledit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoedit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = false;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 270);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(633, 30);
            this.ucPieFormulario1.StringAceptar = "Calcular";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 0;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.finalliquidoedit);
            this.layoutControl1.Controls.Add(this.inicialliquidoedit);
            this.layoutControl1.Controls.Add(this.tipomatedit);
            this.layoutControl1.Controls.Add(this.medioenfedit);
            this.layoutControl1.Controls.Add(this.dimensionedit);
            this.layoutControl1.Controls.Add(this.cantpiezasedit);
            this.layoutControl1.Controls.Add(this.inicialmetaledit);
            this.layoutControl1.Controls.Add(this.finmetaledit);
            this.layoutControl1.Controls.Add(this.pesoedit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(430, 86, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(633, 270);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(461, 222);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Calcular peso";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // finalliquidoedit
            // 
            this.finalliquidoedit.Location = new System.Drawing.Point(431, 155);
            this.finalliquidoedit.Name = "finalliquidoedit";
            this.finalliquidoedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.finalliquidoedit.Size = new System.Drawing.Size(178, 20);
            this.finalliquidoedit.StyleController = this.layoutControl1;
            this.finalliquidoedit.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.finalliquidoedit, conditionValidationRule1);
            // 
            // inicialliquidoedit
            // 
            this.inicialliquidoedit.Location = new System.Drawing.Point(430, 131);
            this.inicialliquidoedit.Name = "inicialliquidoedit";
            this.inicialliquidoedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inicialliquidoedit.Size = new System.Drawing.Size(179, 20);
            this.inicialliquidoedit.StyleController = this.layoutControl1;
            this.inicialliquidoedit.TabIndex = 10;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.inicialliquidoedit, conditionValidationRule2);
            // 
            // tipomatedit
            // 
            this.tipomatedit.Location = new System.Drawing.Point(139, 149);
            this.tipomatedit.Name = "tipomatedit";
            this.tipomatedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tipomatedit.Properties.DataSource = this.tTipoMaterialBindingSource;
            this.tipomatedit.Properties.DisplayMember = "nametipomaterial";
            this.tipomatedit.Properties.ValueMember = "idtipomaterial";
            this.tipomatedit.Properties.View = this.gridLookUpEdit2View;
            this.tipomatedit.Size = new System.Drawing.Size(168, 20);
            this.tipomatedit.StyleController = this.layoutControl1;
            this.tipomatedit.TabIndex = 9;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.tipomatedit, conditionValidationRule3);
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
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipomaterial});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipomaterial
            // 
            this.colnametipomaterial.Caption = "Tipo de material";
            this.colnametipomaterial.FieldName = "nametipomaterial";
            this.colnametipomaterial.Name = "colnametipomaterial";
            this.colnametipomaterial.Visible = true;
            this.colnametipomaterial.VisibleIndex = 0;
            // 
            // medioenfedit
            // 
            this.medioenfedit.Location = new System.Drawing.Point(139, 125);
            this.medioenfedit.Name = "medioenfedit";
            this.medioenfedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.medioenfedit.Properties.DataSource = this.tMedioEnfriamientoBindingSource;
            this.medioenfedit.Properties.DisplayMember = "namemedioenf";
            this.medioenfedit.Properties.ValueMember = "idmedioenf";
            this.medioenfedit.Properties.View = this.gridLookUpEdit1View;
            this.medioenfedit.Size = new System.Drawing.Size(168, 20);
            this.medioenfedit.StyleController = this.layoutControl1;
            this.medioenfedit.TabIndex = 8;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.medioenfedit, conditionValidationRule4);
            // 
            // tMedioEnfriamientoBindingSource
            // 
            this.tMedioEnfriamientoBindingSource.DataMember = "T_MedioEnfriamiento";
            this.tMedioEnfriamientoBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemedioenf});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemedioenf
            // 
            this.colnamemedioenf.Caption = "Medio de Enfriamiento";
            this.colnamemedioenf.FieldName = "namemedioenf";
            this.colnamemedioenf.Name = "colnamemedioenf";
            this.colnamemedioenf.Visible = true;
            this.colnamemedioenf.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(633, 270);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dimensionedit;
            this.layoutControlItem1.CustomizationFormText = "Dimensión máxima de las piezas  a tratar (mm):";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(613, 40);
            this.layoutControlItem1.Text = "Dimensión máxima de las piezas  a tratar (mm):";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(225, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Temperatura";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(311, 40);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(302, 139);
            this.layoutControlGroup2.Text = "Temperatura (°C)";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.inicialmetaledit;
            this.layoutControlItem3.CustomizationFormText = "Inicial del metal:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem3.Text = "Inicial del metal:    ";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.finmetaledit;
            this.layoutControlItem4.CustomizationFormText = "Final del metal:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem4.Text = "Final del metal:      ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.inicialliquidoedit;
            this.layoutControlItem7.CustomizationFormText = "Inicial del liquido:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem7.Text = "Inicial del líquido:   ";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(90, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.finalliquidoedit;
            this.layoutControlItem8.CustomizationFormText = "Final del liquido:";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem8.Text = "Final del líquido:     ";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(91, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Entorno";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(311, 139);
            this.layoutControlGroup3.Text = "Entorno";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cantpiezasedit;
            this.layoutControlItem2.CustomizationFormText = "Cantidad de piezas que se introducen a la vez en el liquido:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(287, 42);
            this.layoutControlItem2.Text = "Cantidad de piezas que se introducen  en el líquido:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(246, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.medioenfedit;
            this.layoutControlItem5.CustomizationFormText = "Medio de enfriamiento:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(287, 24);
            this.layoutControlItem5.Text = "Medio de enfriamiento:";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(110, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tipomatedit;
            this.layoutControlItem6.CustomizationFormText = "Tipo de material:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(287, 30);
            this.layoutControlItem6.Text = "Tipo de material:          ";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(110, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Piezas:";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem9});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 179);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(613, 71);
            this.layoutControlGroup4.Text = "Piezas:";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.simpleButton1;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(437, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(152, 28);
            this.layoutControlItem10.Text = "layoutControlItem10";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextToControlDistance = 0;
            this.layoutControlItem10.TextVisible = false;
            this.layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.pesoedit;
            this.layoutControlItem9.CustomizationFormText = "Peso (Kg):";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(437, 28);
            this.layoutControlItem9.Text = "Peso (Kg):";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // t_MedioEnfriamientoTableAdapter
            // 
            this.t_MedioEnfriamientoTableAdapter.ClearBeforeFill = true;
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
            // dimensionedit
            // 
            this.dimensionedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dimensionedit.Location = new System.Drawing.Point(12, 28);
            this.dimensionedit.Name = "dimensionedit";
            this.dimensionedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dimensionedit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.dimensionedit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dimensionedit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.dimensionedit.Size = new System.Drawing.Size(609, 20);
            this.dimensionedit.StyleController = this.layoutControl1;
            this.dimensionedit.TabIndex = 4;
            // 
            // cantpiezasedit
            // 
            this.cantpiezasedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantpiezasedit.Location = new System.Drawing.Point(24, 101);
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
            this.cantpiezasedit.Size = new System.Drawing.Size(283, 20);
            this.cantpiezasedit.StyleController = this.layoutControl1;
            this.cantpiezasedit.TabIndex = 5;
            // 
            // inicialmetaledit
            // 
            this.inicialmetaledit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inicialmetaledit.Location = new System.Drawing.Point(429, 83);
            this.inicialmetaledit.Name = "inicialmetaledit";
            this.inicialmetaledit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.inicialmetaledit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.inicialmetaledit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.inicialmetaledit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.inicialmetaledit.Size = new System.Drawing.Size(180, 20);
            this.inicialmetaledit.StyleController = this.layoutControl1;
            this.inicialmetaledit.TabIndex = 6;
            // 
            // finmetaledit
            // 
            this.finmetaledit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.finmetaledit.Location = new System.Drawing.Point(430, 107);
            this.finmetaledit.Name = "finmetaledit";
            this.finmetaledit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.finmetaledit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.finmetaledit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.finmetaledit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.finmetaledit.Size = new System.Drawing.Size(179, 20);
            this.finmetaledit.StyleController = this.layoutControl1;
            this.finmetaledit.TabIndex = 7;
            // 
            // pesoedit
            // 
            this.pesoedit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pesoedit.Location = new System.Drawing.Point(79, 222);
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
            this.pesoedit.Size = new System.Drawing.Size(378, 20);
            this.pesoedit.StyleController = this.layoutControl1;
            this.pesoedit.TabIndex = 12;
            // 
            // FrmTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 300);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluar Tanque";
            this.Load += new System.EventHandler(this.FrmTanque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalliquidoedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicialliquidoedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipomatedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioenfedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMedioEnfriamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantpiezasedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicialmetaledit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finmetaledit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoedit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit finalliquidoedit;
        private DevExpress.XtraEditors.ComboBoxEdit inicialliquidoedit;
        private DevExpress.XtraEditors.GridLookUpEdit tipomatedit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit medioenfedit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DSACATTA dSDatos;
        private System.Windows.Forms.BindingSource tMedioEnfriamientoBindingSource;
        private T_MedioEnfriamientoTableAdapter t_MedioEnfriamientoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemedioenf;
        private System.Windows.Forms.BindingSource tTipoMaterialBindingSource;
        private T_TipoMaterialTableAdapter t_TipoMaterialTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipomaterial;
        private T_CapacidadCalorificaTableAdapter t_CapacidadCalorificaTableAdapter1;
        private T_CapacidadDeslozeTableAdapter t_CapacidadDeslozeTableAdapter1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SpinEdit dimensionedit;
        private DevExpress.XtraEditors.SpinEdit cantpiezasedit;
        private DevExpress.XtraEditors.SpinEdit inicialmetaledit;
        private DevExpress.XtraEditors.SpinEdit finmetaledit;
        private DevExpress.XtraEditors.SpinEdit pesoedit;
    }
}