using TMC.ACATTA.DSACATTATableAdapters;
using TMC.ACATTA;
namespace TMC.ACATTA.Prediccion
{
    partial class FrmPredecir
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView1 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView2 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.t_CurvaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_CurvaTableAdapter();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEdit5 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit4 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit3 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tAceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.ACATTA.DSACATTA();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameacero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aceroPredecGridControl = new DevExpress.XtraGrid.GridControl();
            this.aceroPredecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tElementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnameelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.t_AceroTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_AceroTableAdapter();
            this.t_AceroElementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_AceroElementoTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_AceroElementoTableAdapter();
            this.tableAdapterManager = new TMC.ACATTA.DSACATTATableAdapters.TableAdapterManager();
            this.t_ElementoTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_ElementoTableAdapter();
            this.t_AceroElementoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t_AceroNormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroNormaTableAdapter();
            this.t_NormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_NormaTableAdapter();
            this.t_AceroPuntoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroPuntoTableAdapter();
            this.t_AceroTipoPuntoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroTipoPuntoTableAdapter();
            this.t_ConstanteTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_ConstanteTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceroPredecGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceroPredecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroElementoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroElementoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.checkedListBoxControl1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.buttonEdit5);
            this.layoutControl1.Controls.Add(this.buttonEdit4);
            this.layoutControl1.Controls.Add(this.buttonEdit3);
            this.layoutControl1.Controls.Add(this.buttonEdit2);
            this.layoutControl1.Controls.Add(this.buttonEdit1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.layoutControl1.Controls.Add(this.aceroPredecGridControl);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(25, 220, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1028, 696);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Enabled = false;
            this.simpleButton3.Location = new System.Drawing.Point(900, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(116, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 19;
            this.simpleButton3.Text = "Reporte de curva TTT";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.t_CurvaTableAdapter1;
            xyDiagram1.AxisX.Logarithmic = true;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram1.AxisX.Title.Text = "Log t (s)";
            xyDiagram1.AxisX.Title.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = false;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram1.AxisY.Title.Text = "Temperatura (°C)";
            xyDiagram1.AxisY.Title.Visible = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(376, 54);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            scatterLineSeriesView1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash;
            series1.View = scatterLineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel2;
            this.chartControl1.SeriesTemplate.View = scatterLineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(640, 630);
            this.chartControl1.TabIndex = 16;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // t_CurvaTableAdapter1
            // 
            this.t_CurvaTableAdapter1.ClearBeforeFill = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = true;
            this.radioGroup1.Location = new System.Drawing.Point(233, 503);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Kirkaldy"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Li, et al")});
            this.radioGroup1.Size = new System.Drawing.Size(115, 81);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 14;
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Enabled = false;
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Ferrita Start"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Ferrita End"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Perlita Start"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Perlita End"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Bainita Start"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Bainita End")});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(188, 289);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(160, 210);
            this.checkedListBoxControl1.StyleController = this.layoutControl1;
            this.checkedListBoxControl1.TabIndex = 13;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(176, 650);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(184, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = " Predicción de dureza";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.Location = new System.Drawing.Point(298, 102);
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit5.Properties.ReadOnly = true;
            this.buttonEdit5.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            this.buttonEdit5.Size = new System.Drawing.Size(50, 20);
            this.buttonEdit5.StyleController = this.layoutControl1;
            this.buttonEdit5.TabIndex = 12;
            this.buttonEdit5.Tag = "G";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.buttonEdit5, conditionValidationRule1);
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.Location = new System.Drawing.Point(298, 222);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit4.Properties.ReadOnly = true;
            this.buttonEdit4.Size = new System.Drawing.Size(50, 20);
            this.buttonEdit4.StyleController = this.layoutControl1;
            this.buttonEdit4.TabIndex = 10;
            this.buttonEdit4.Tag = "Ms";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.buttonEdit4, conditionValidationRule2);
            this.buttonEdit4.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.Location = new System.Drawing.Point(298, 198);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit3.Properties.ReadOnly = true;
            this.buttonEdit3.Size = new System.Drawing.Size(50, 20);
            this.buttonEdit3.StyleController = this.layoutControl1;
            this.buttonEdit3.TabIndex = 9;
            this.buttonEdit3.Tag = "Bs";
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.buttonEdit3, conditionValidationRule3);
            this.buttonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Location = new System.Drawing.Point(298, 174);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Properties.ReadOnly = true;
            this.buttonEdit2.Size = new System.Drawing.Size(50, 20);
            this.buttonEdit2.StyleController = this.layoutControl1;
            this.buttonEdit2.TabIndex = 8;
            this.buttonEdit2.Tag = "Ae1";
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.buttonEdit2, conditionValidationRule4);
            this.buttonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(298, 150);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Properties.ReadOnly = true;
            this.buttonEdit1.Size = new System.Drawing.Size(50, 20);
            this.buttonEdit1.StyleController = this.layoutControl1;
            this.buttonEdit1.TabIndex = 7;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.buttonEdit1, conditionValidationRule5);
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(176, 624);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(184, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Calcular";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(122, 671);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(213, 24);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tAceroBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nameacero";
            this.gridLookUpEdit1.Properties.ValueMember = "idacero";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_Properties_EditValueChanged);
            this.gridLookUpEdit1.Size = new System.Drawing.Size(147, 20);
            this.gridLookUpEdit1.StyleController = this.layoutControl1;
            this.gridLookUpEdit1.TabIndex = 4;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            conditionValidationRule6.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit1, conditionValidationRule6);
            // 
            // tAceroBindingSource
            // 
            this.tAceroBindingSource.DataMember = "T_Acero";
            this.tAceroBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameacero1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameacero1
            // 
            this.colnameacero1.Caption = "Acero";
            this.colnameacero1.FieldName = "nameacero";
            this.colnameacero1.Name = "colnameacero1";
            this.colnameacero1.Visible = true;
            this.colnameacero1.VisibleIndex = 0;
            // 
            // aceroPredecGridControl
            // 
            this.aceroPredecGridControl.DataSource = this.aceroPredecBindingSource;
            this.aceroPredecGridControl.Location = new System.Drawing.Point(12, 28);
            this.aceroPredecGridControl.MainView = this.gridView1;
            this.aceroPredecGridControl.Name = "aceroPredecGridControl";
            this.aceroPredecGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.aceroPredecGridControl.Size = new System.Drawing.Size(148, 639);
            this.aceroPredecGridControl.TabIndex = 1;
            this.aceroPredecGridControl.UseEmbeddedNavigator = true;
            this.aceroPredecGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // aceroPredecBindingSource
            // 
            this.aceroPredecBindingSource.DataMember = "AceroPredec";
            this.aceroPredecBindingSource.DataSource = this.dSDatos;
            this.aceroPredecBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.aceroPredecBindingSource_ListChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidelemento,
            this.colvalor});
            this.gridView1.GridControl = this.aceroPredecGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colidelemento
            // 
            this.colidelemento.Caption = "Elemento";
            this.colidelemento.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidelemento.FieldName = "idelemento";
            this.colidelemento.Name = "colidelemento";
            this.colidelemento.Visible = true;
            this.colidelemento.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tElementoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "codelemento";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idelemento";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tElementoBindingSource
            // 
            this.tElementoBindingSource.DataMember = "T_Elemento";
            this.tElementoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodelemento,
            this.colnameelemento});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodelemento
            // 
            this.colcodelemento.Caption = "Codigo";
            this.colcodelemento.FieldName = "codelemento";
            this.colcodelemento.Name = "colcodelemento";
            this.colcodelemento.Visible = true;
            this.colcodelemento.VisibleIndex = 1;
            // 
            // colnameelemento
            // 
            this.colnameelemento.Caption = "Nombre";
            this.colnameelemento.FieldName = "nameelemento";
            this.colnameelemento.Name = "colnameelemento";
            this.colnameelemento.Visible = true;
            this.colnameelemento.VisibleIndex = 0;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(298, 126);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(50, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 18;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Enabled = false;
            this.checkEdit1.Location = new System.Drawing.Point(176, 48);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Utilizar datos de curva";
            this.checkEdit1.Properties.CheckStateChanged += new System.EventHandler(this.checkEdit1_Properties_CheckStateChanged);
            this.checkEdit1.Size = new System.Drawing.Size(184, 19);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 5;
            this.checkEdit1.Click += new System.EventHandler(this.checkEdit1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit1.Location = new System.Drawing.Point(298, 588);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Properties.MaxValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.textEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit1.Size = new System.Drawing.Size(50, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem14,
            this.layoutControlGroup4,
            this.layoutControlItem17,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1028, 696);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.aceroPredecGridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(152, 659);
            this.layoutControlItem2.Text = "Composición del acero";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl1;
            this.layoutControlItem4.CustomizationFormText = "Fe:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 659);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(152, 17);
            this.layoutControlItem4.Text = "Fe:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.chartControl1;
            this.layoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem14.CustomizationFormText = "Vista";
            this.layoutControlItem14.Location = new System.Drawing.Point(364, 26);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(110, 40);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(644, 650);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "Vista";
            this.layoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem9,
            this.layoutControlItem15,
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(152, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(212, 676);
            this.layoutControlGroup4.Text = "layoutControlGroup4";
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkEdit1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(188, 23);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Puntos criticos";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem16});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 47);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(188, 187);
            this.layoutControlGroup2.Text = "Puntos críticos";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.buttonEdit4;
            this.layoutControlItem8.CustomizationFormText = "Ms:";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem8.Text = "Ms(°C):";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.buttonEdit3;
            this.layoutControlItem7.CustomizationFormText = "Bs:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem7.Text = "Bs(°C):";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.buttonEdit2;
            this.layoutControlItem6.CustomizationFormText = "Ac1:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem6.Text = "Ae1(°C):";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.buttonEdit1;
            this.layoutControlItem5.CustomizationFormText = "Ac3 ó Acm:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem5.Text = "Ac3 ó Acm:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.buttonEdit5;
            this.layoutControlItem10.CustomizationFormText = "G:";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem10.Text = "G(ASTM):";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.textEdit2;
            this.layoutControlItem16.CustomizationFormText = "Q:";
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem16.Text = "Q:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(106, 13);
            this.layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Curvas posibles a calcular";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 234);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(188, 366);
            this.layoutControlGroup3.Text = "Curvas posibles a calcular";
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.checkedListBoxControl1;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(164, 214);
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.radioGroup1;
            this.layoutControlItem12.CustomizationFormText = "Método:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 214);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(164, 85);
            this.layoutControlItem12.Text = "Método:";
            this.layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(40, 13);
            this.layoutControlItem12.TextToControlDistance = 5;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.textEdit1;
            this.layoutControlItem13.CustomizationFormText = "Paso de Temp:";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 299);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem13.Text = "Paso de Temp(°C):";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.simpleButton1;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 600);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.simpleButton2;
            this.layoutControlItem15.CustomizationFormText = "layoutControlItem15";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 626);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem15.Text = "layoutControlItem15";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextToControlDistance = 0;
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridLookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Acero:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 24);
            this.layoutControlItem1.Text = "Acero:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(32, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.simpleButton3;
            this.layoutControlItem17.CustomizationFormText = "layoutControlItem17";
            this.layoutControlItem17.Location = new System.Drawing.Point(888, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem17.Text = "layoutControlItem17";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextToControlDistance = 0;
            this.layoutControlItem17.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(364, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(524, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // t_AceroTableAdapter
            // 
            this.t_AceroTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroElementoBindingSource
            // 
            this.t_AceroElementoBindingSource.DataMember = "T_AceroElemento";
            this.t_AceroElementoBindingSource.DataSource = this.dSDatos;
            // 
            // t_AceroElementoTableAdapter
            // 
            this.t_AceroElementoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_AceroElementoTableAdapter = this.t_AceroElementoTableAdapter;
            this.tableAdapterManager.T_AceroNormaTableAdapter = null;
            this.tableAdapterManager.T_AceroPuntoFormulaTableAdapter = null;
            this.tableAdapterManager.T_AceroPuntoTableAdapter = null;
            this.tableAdapterManager.T_AceroTableAdapter = this.t_AceroTableAdapter;
            this.tableAdapterManager.T_AceroTipoPuntoTableAdapter = null;
            this.tableAdapterManager.T_CapacidadCalorificaTableAdapter = null;
            this.tableAdapterManager.T_CapacidadDeslozeTableAdapter = null;
            this.tableAdapterManager.T_ColocacionPiezaTableAdapter = null;
            this.tableAdapterManager.T_ConstanteTableAdapter = null;
            this.tableAdapterManager.T_CurvaTableAdapter = null;
            this.tableAdapterManager.T_ElementoTableAdapter = this.t_ElementoTableAdapter;
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
            this.tableAdapterManager.T_TratamientoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMC.ACATTA.DSACATTATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_ElementoTableAdapter
            // 
            this.t_ElementoTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroElementoBindingSource1
            // 
            this.t_AceroElementoBindingSource1.DataMember = "FK_T_AceroElemento_T_Acero";
            this.t_AceroElementoBindingSource1.DataSource = this.tAceroBindingSource;
            // 
            // t_AceroNormaTableAdapter1
            // 
            this.t_AceroNormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_NormaTableAdapter1
            // 
            this.t_NormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_AceroPuntoTableAdapter1
            // 
            this.t_AceroPuntoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_AceroTipoPuntoTableAdapter1
            // 
            this.t_AceroTipoPuntoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ConstanteTableAdapter1
            // 
            this.t_ConstanteTableAdapter1.ClearBeforeFill = true;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidateHiddenControls = false;
            // 
            // FrmPredecir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 696);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPredecir";
            this.Text = "Predicción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPredecir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceroPredecGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceroPredecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroElementoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_AceroElementoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource tAceroBindingSource;
        private T_AceroTableAdapter t_AceroTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameacero1;
        private System.Windows.Forms.BindingSource t_AceroElementoBindingSource;
        private T_AceroElementoTableAdapter t_AceroElementoTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private T_ElementoTableAdapter t_ElementoTableAdapter;
        private System.Windows.Forms.BindingSource t_AceroElementoBindingSource1;
        private System.Windows.Forms.BindingSource tElementoBindingSource;
        private System.Windows.Forms.BindingSource aceroPredecBindingSource;
        private DevExpress.XtraGrid.GridControl aceroPredecGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidelemento;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcodelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colnameelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit4;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit3;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private T_NormaTableAdapter t_NormaTableAdapter1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private T_AceroPuntoTableAdapter t_AceroPuntoTableAdapter1;
        private T_AceroTipoPuntoTableAdapter t_AceroTipoPuntoTableAdapter1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private T_ConstanteTableAdapter t_ConstanteTableAdapter1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private T_CurvaTableAdapter t_CurvaTableAdapter1;
        private DevExpress.XtraEditors.ButtonEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        public DevExpress.XtraEditors.RadioGroup radioGroup1;
        public DSACATTA dSDatos;
        private DevExpress.XtraEditors.SpinEdit textEdit1;
    }
}