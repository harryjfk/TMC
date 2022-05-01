using TMC.ACATTA.DSACATTATableAdapters;
namespace TMC.ACATTA.Tareas
{
    partial class FrmCalculoTT
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
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tRegimenCalentamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.ACATTA.DSACATTA();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameregcalent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.tCalculoTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtipopropsolSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoPropiedadSolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idhornoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tHornoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamehorno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfundidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idtipomaterialSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tAceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idtratamientoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoTratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametratamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idtipopiezaSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoPiezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idtipopiezageoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoPiezaGeometriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipopiezageo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idseparacionSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tSeparacionPiezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameseparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idcolocacionSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tColocacionPiezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTColocacionPiezaTTipoPiezaGeometriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamecolocacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForidhorno = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidtipomaterial = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidtratamiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcantpiezas = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForidtipopropsol = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpropini = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpropsol = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForidtipopiezageo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForancho = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidcolocacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidseparacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForvalorx = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForaltura = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForlargo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForidtipopieza = new DevExpress.XtraLayout.LayoutControlItem();
            this.tTratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_TipoPropiedadSolTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TipoPropiedadSolTableAdapter();
            this.t_HornoTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_HornoTableAdapter();
            this.t_TipoMaterialTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TipoMaterialTableAdapter();
            this.t_TratamientoTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TratamientoTableAdapter();
            this.t_TipoPiezaTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TipoPiezaTableAdapter();
            this.t_SeparacionPiezaTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_SeparacionPiezaTableAdapter();
            this.t_TipoPiezaGeometriaTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_TipoPiezaGeometriaTableAdapter();
            this.t_ColocacionPiezaTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_ColocacionPiezaTableAdapter();
            this.t_AceroTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_AceroTableAdapter();
            this.t_AceroNormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroNormaTableAdapter();
            this.t_NormaTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_NormaTableAdapter();
            this.t_AceroElementoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_AceroElementoTableAdapter();
            this.t_ElementoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_ElementoTableAdapter();
            this.t_TipoHornoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_TipoHornoTableAdapter();
            this.t_TipoTratamientoTableAdapter1 = new TMC.ACATTA.DSACATTATableAdapters.T_TipoTratamientoTableAdapter();
            this.t_RegimenCalentamientoTableAdapter = new TMC.ACATTA.DSACATTATableAdapters.T_RegimenCalentamientoTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cantpiezasSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.propsolSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.propiniSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.largoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.alturaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.anchoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.seph = new DevExpress.XtraEditors.SpinEdit();
            this.valorxSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRegimenCalentamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCalculoTTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipopropsolSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadSolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idhornoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHornoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipomaterialSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtratamientoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipopiezaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPiezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipopiezageoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPiezaGeometriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idseparacionSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeparacionPiezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcolocacionSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColocacionPiezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTColocacionPiezaTTipoPiezaGeometriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidhorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipomaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcantpiezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipopropsol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpropini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpropsol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipopiezageo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForancho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidcolocacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidseparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvalorx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForaltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipopieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantpiezasSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propsolSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiniSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seph.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorxSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = false;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 571);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(612, 30);
            this.ucPieFormulario1.StringAceptar = "Calcular";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 0;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.imageComboBoxEdit1);
            this.dataLayoutControl1.Controls.Add(this.idtipopropsolSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idhornoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idtipomaterialSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idtratamientoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idtipopiezaSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idtipopiezageoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idseparacionSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idcolocacionSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.cantpiezasSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.propsolSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.propiniSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.largoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.alturaSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.anchoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.seph);
            this.dataLayoutControl1.Controls.Add(this.valorxSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.DataSource = this.tCalculoTTBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(663, 214, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(612, 571);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(470, 170);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tRegimenCalentamientoBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nameregcalent";
            this.gridLookUpEdit1.Properties.ValueMember = "idregcalent";
            this.gridLookUpEdit1.Properties.View = this.gridView8;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(106, 20);
            this.gridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.gridLookUpEdit1.TabIndex = 23;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit1, conditionValidationRule1);
            // 
            // tRegimenCalentamientoBindingSource
            // 
            this.tRegimenCalentamientoBindingSource.DataMember = "T_RegimenCalentamiento";
            this.tRegimenCalentamientoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameregcalent});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // colnameregcalent
            // 
            this.colnameregcalent.Caption = "Nombre";
            this.colnameregcalent.FieldName = "nameregcalent";
            this.colnameregcalent.Name = "colnameregcalent";
            this.colnameregcalent.Visible = true;
            this.colnameregcalent.VisibleIndex = 0;
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(186, 170);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Horno eléctrico", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Horno con llama", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Baño de sales", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Baño de plomo", 3, -1)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(130, 20);
            this.imageComboBoxEdit1.StyleController = this.dataLayoutControl1;
            this.imageComboBoxEdit1.TabIndex = 20;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.imageComboBoxEdit1, conditionValidationRule2);
            // 
            // tCalculoTTBindingSource
            // 
            this.tCalculoTTBindingSource.DataMember = "T_CalculoTanqueTT";
            this.tCalculoTTBindingSource.DataSource = this.dSDatos;
            // 
            // idtipopropsolSpinEdit
            // 
            this.idtipopropsolSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idtipopropsol", true));
            this.idtipopropsolSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipopropsolSpinEdit.Location = new System.Drawing.Point(186, 237);
            this.idtipopropsolSpinEdit.Name = "idtipopropsolSpinEdit";
            this.idtipopropsolSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idtipopropsolSpinEdit.Properties.DataSource = this.tTipoPropiedadSolBindingSource;
            this.idtipopropsolSpinEdit.Properties.DisplayMember = "nametipopropiedad";
            this.idtipopropsolSpinEdit.Properties.NullText = "";
            this.idtipopropsolSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idtipopropsolSpinEdit.Properties.ValueMember = "idtipopropiedad";
            this.idtipopropsolSpinEdit.Properties.View = this.gridLookUpEdit1View;
            this.idtipopropsolSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtipopropsolSpinEdit_Properties_ButtonClick);
            this.idtipopropsolSpinEdit.Size = new System.Drawing.Size(390, 20);
            this.idtipopropsolSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtipopropsolSpinEdit.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idtipopropsolSpinEdit, conditionValidationRule3);
            // 
            // tTipoPropiedadSolBindingSource
            // 
            this.tTipoPropiedadSolBindingSource.DataMember = "T_TipoPropiedadSol";
            this.tTipoPropiedadSolBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopropiedad});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopropiedad
            // 
            this.colnametipopropiedad.Caption = "Propiedad";
            this.colnametipopropiedad.FieldName = "nametipopropiedad";
            this.colnametipopropiedad.Name = "colnametipopropiedad";
            this.colnametipopropiedad.Visible = true;
            this.colnametipopropiedad.VisibleIndex = 0;
            // 
            // idhornoSpinEdit
            // 
            this.idhornoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idhorno", true));
            this.idhornoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idhornoSpinEdit.Location = new System.Drawing.Point(186, 122);
            this.idhornoSpinEdit.Name = "idhornoSpinEdit";
            this.idhornoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idhornoSpinEdit.Properties.DataSource = this.tHornoBindingSource;
            this.idhornoSpinEdit.Properties.DisplayMember = "namehorno";
            this.idhornoSpinEdit.Properties.NullText = "";
            this.idhornoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idhornoSpinEdit.Properties.ValueMember = "idhorno";
            this.idhornoSpinEdit.Properties.View = this.gridView1;
            this.idhornoSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idhornoSpinEdit_Properties_ButtonClick);
            this.idhornoSpinEdit.Size = new System.Drawing.Size(390, 20);
            this.idhornoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idhornoSpinEdit.TabIndex = 6;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idhornoSpinEdit, conditionValidationRule4);
            this.idhornoSpinEdit.EditValueChanged += new System.EventHandler(this.idtratamientoSpinEdit_EditValueChanged);
            // 
            // tHornoBindingSource
            // 
            this.tHornoBindingSource.DataMember = "T_Horno";
            this.tHornoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamehorno,
            this.colProfundidad,
            this.colLargo,
            this.colAltura});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnamehorno
            // 
            this.colnamehorno.Caption = "Horno";
            this.colnamehorno.FieldName = "namehorno";
            this.colnamehorno.Name = "colnamehorno";
            this.colnamehorno.Visible = true;
            this.colnamehorno.VisibleIndex = 0;
            // 
            // colProfundidad
            // 
            this.colProfundidad.Caption = "Ancho";
            this.colProfundidad.FieldName = "Ancho_Diametro";
            this.colProfundidad.Name = "colProfundidad";
            this.colProfundidad.Visible = true;
            this.colProfundidad.VisibleIndex = 1;
            // 
            // colLargo
            // 
            this.colLargo.Caption = "Largo";
            this.colLargo.FieldName = "Largo";
            this.colLargo.Name = "colLargo";
            this.colLargo.Visible = true;
            this.colLargo.VisibleIndex = 2;
            // 
            // colAltura
            // 
            this.colAltura.Caption = "Altura";
            this.colAltura.FieldName = "Altura";
            this.colAltura.Name = "colAltura";
            this.colAltura.Visible = true;
            this.colAltura.VisibleIndex = 3;
            // 
            // idtipomaterialSpinEdit
            // 
            this.idtipomaterialSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idacero", true));
            this.idtipomaterialSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipomaterialSpinEdit.Location = new System.Drawing.Point(186, 98);
            this.idtipomaterialSpinEdit.Name = "idtipomaterialSpinEdit";
            this.idtipomaterialSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idtipomaterialSpinEdit.Properties.DataSource = this.tAceroBindingSource;
            this.idtipomaterialSpinEdit.Properties.DisplayMember = "nameacero";
            this.idtipomaterialSpinEdit.Properties.NullText = "";
            this.idtipomaterialSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idtipomaterialSpinEdit.Properties.ValueMember = "idacero";
            this.idtipomaterialSpinEdit.Properties.View = this.gridView2;
            this.idtipomaterialSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtipomaterialSpinEdit_Properties_ButtonClick);
            this.idtipomaterialSpinEdit.Size = new System.Drawing.Size(390, 20);
            this.idtipomaterialSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtipomaterialSpinEdit.TabIndex = 5;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idtipomaterialSpinEdit, conditionValidationRule5);
            this.idtipomaterialSpinEdit.EditValueChanged += new System.EventHandler(this.idtratamientoSpinEdit_EditValueChanged);
            // 
            // tAceroBindingSource
            // 
            this.tAceroBindingSource.DataMember = "T_Acero";
            this.tAceroBindingSource.DataSource = this.dSDatos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipomaterial});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipomaterial
            // 
            this.colnametipomaterial.Caption = "Acero";
            this.colnametipomaterial.FieldName = "nameacero";
            this.colnametipomaterial.Name = "colnametipomaterial";
            this.colnametipomaterial.Visible = true;
            this.colnametipomaterial.VisibleIndex = 0;
            // 
            // idtratamientoSpinEdit
            // 
            this.idtratamientoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idtratamiento", true));
            this.idtratamientoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtratamientoSpinEdit.Location = new System.Drawing.Point(186, 74);
            this.idtratamientoSpinEdit.Name = "idtratamientoSpinEdit";
            this.idtratamientoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idtratamientoSpinEdit.Properties.DataSource = this.tTipoTratamientoBindingSource;
            this.idtratamientoSpinEdit.Properties.DisplayMember = "nametratamiento";
            this.idtratamientoSpinEdit.Properties.NullText = "";
            this.idtratamientoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idtratamientoSpinEdit.Properties.ValueMember = "idtratamiento";
            this.idtratamientoSpinEdit.Properties.View = this.gridView3;
            this.idtratamientoSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtratamientoSpinEdit_Properties_ButtonClick);
            this.idtratamientoSpinEdit.Size = new System.Drawing.Size(390, 20);
            this.idtratamientoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtratamientoSpinEdit.TabIndex = 4;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            conditionValidationRule6.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idtratamientoSpinEdit, conditionValidationRule6);
            this.idtratamientoSpinEdit.EditValueChanged += new System.EventHandler(this.idtratamientoSpinEdit_EditValueChanged);
            // 
            // tTipoTratamientoBindingSource
            // 
            this.tTipoTratamientoBindingSource.DataMember = "T_TipoTratamiento";
            this.tTipoTratamientoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametratamiento});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colnametratamiento
            // 
            this.colnametratamiento.Caption = "Tratamiento";
            this.colnametratamiento.FieldName = "nametratamiento";
            this.colnametratamiento.Name = "colnametratamiento";
            this.colnametratamiento.Visible = true;
            this.colnametratamiento.VisibleIndex = 0;
            // 
            // idtipopiezaSpinEdit
            // 
            this.idtipopiezaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idtipopieza", true));
            this.idtipopiezaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipopiezaSpinEdit.Location = new System.Drawing.Point(174, 527);
            this.idtipopiezaSpinEdit.Name = "idtipopiezaSpinEdit";
            this.idtipopiezaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idtipopiezaSpinEdit.Properties.DataSource = this.tTipoPiezaBindingSource;
            this.idtipopiezaSpinEdit.Properties.DisplayMember = "nametipopieza";
            this.idtipopiezaSpinEdit.Properties.NullText = "";
            this.idtipopiezaSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idtipopiezaSpinEdit.Properties.ValueMember = "idtipopieza";
            this.idtipopiezaSpinEdit.Properties.View = this.gridView4;
            this.idtipopiezaSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtipopropsolSpinEdit_Properties_ButtonClick);
            this.idtipopiezaSpinEdit.Size = new System.Drawing.Size(414, 20);
            this.idtipopiezaSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtipopiezaSpinEdit.TabIndex = 18;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "This value is not valid";
            conditionValidationRule7.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idtipopiezaSpinEdit, conditionValidationRule7);
            // 
            // tTipoPiezaBindingSource
            // 
            this.tTipoPiezaBindingSource.DataMember = "T_TipoPieza";
            this.tTipoPiezaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopieza});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopieza
            // 
            this.colnametipopieza.Caption = "Tipo de Pieza";
            this.colnametipopieza.FieldName = "nametipopieza";
            this.colnametipopieza.Name = "colnametipopieza";
            this.colnametipopieza.Visible = true;
            this.colnametipopieza.VisibleIndex = 0;
            // 
            // idtipopiezageoSpinEdit
            // 
            this.idtipopiezageoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idtipopiezageo", true));
            this.idtipopiezageoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipopiezageoSpinEdit.Location = new System.Drawing.Point(174, 340);
            this.idtipopiezageoSpinEdit.Name = "idtipopiezageoSpinEdit";
            this.idtipopiezageoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idtipopiezageoSpinEdit.Properties.DataSource = this.tTipoPiezaGeometriaBindingSource;
            this.idtipopiezageoSpinEdit.Properties.DisplayMember = "nametipopiezageo";
            this.idtipopiezageoSpinEdit.Properties.NullText = "";
            this.idtipopiezageoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idtipopiezageoSpinEdit.Properties.ValueMember = "idtipopiezageo";
            this.idtipopiezageoSpinEdit.Properties.View = this.gridView5;
            this.idtipopiezageoSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtipopropsolSpinEdit_Properties_ButtonClick);
            this.idtipopiezageoSpinEdit.Properties.EditValueChanged += new System.EventHandler(this.idtipopiezageoSpinEdit_EditValueChanged);
            this.idtipopiezageoSpinEdit.Size = new System.Drawing.Size(414, 20);
            this.idtipopiezageoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtipopiezageoSpinEdit.TabIndex = 11;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "This value is not valid";
            conditionValidationRule8.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idtipopiezageoSpinEdit, conditionValidationRule8);
            // 
            // tTipoPiezaGeometriaBindingSource
            // 
            this.tTipoPiezaGeometriaBindingSource.DataMember = "T_TipoPiezaGeometria";
            this.tTipoPiezaGeometriaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipopiezageo});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipopiezageo
            // 
            this.colnametipopiezageo.Caption = "Tipo de Pieza";
            this.colnametipopiezageo.FieldName = "nametipopiezageo";
            this.colnametipopiezageo.Name = "colnametipopiezageo";
            this.colnametipopiezageo.Visible = true;
            this.colnametipopiezageo.VisibleIndex = 0;
            // 
            // idseparacionSpinEdit
            // 
            this.idseparacionSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idseparacion", true));
            this.idseparacionSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idseparacionSpinEdit.Location = new System.Drawing.Point(174, 412);
            this.idseparacionSpinEdit.Name = "idseparacionSpinEdit";
            this.idseparacionSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idseparacionSpinEdit.Properties.DataSource = this.tSeparacionPiezaBindingSource;
            this.idseparacionSpinEdit.Properties.DisplayMember = "nameseparacion";
            this.idseparacionSpinEdit.Properties.NullText = "";
            this.idseparacionSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idseparacionSpinEdit.Properties.ValueMember = "idseparacionpieza";
            this.idseparacionSpinEdit.Properties.View = this.gridView6;
            this.idseparacionSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtipopropsolSpinEdit_Properties_ButtonClick);
            this.idseparacionSpinEdit.Size = new System.Drawing.Size(414, 20);
            this.idseparacionSpinEdit.StyleController = this.dataLayoutControl1;
            this.idseparacionSpinEdit.TabIndex = 16;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule9.ErrorText = "This value is not valid";
            conditionValidationRule9.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idseparacionSpinEdit, conditionValidationRule9);
            this.idseparacionSpinEdit.EditValueChanged += new System.EventHandler(this.idtratamientoSpinEdit_EditValueChanged);
            // 
            // tSeparacionPiezaBindingSource
            // 
            this.tSeparacionPiezaBindingSource.DataMember = "T_SeparacionPieza";
            this.tSeparacionPiezaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameseparacion});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colnameseparacion
            // 
            this.colnameseparacion.Caption = "Separación";
            this.colnameseparacion.FieldName = "nameseparacion";
            this.colnameseparacion.Name = "colnameseparacion";
            this.colnameseparacion.Visible = true;
            this.colnameseparacion.VisibleIndex = 0;
            // 
            // idcolocacionSpinEdit
            // 
            this.idcolocacionSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "idcolocacion", true));
            this.idcolocacionSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idcolocacionSpinEdit.Location = new System.Drawing.Point(174, 388);
            this.idcolocacionSpinEdit.Name = "idcolocacionSpinEdit";
            this.idcolocacionSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idcolocacionSpinEdit.Properties.DataSource = this.tColocacionPiezaBindingSource;
            this.idcolocacionSpinEdit.Properties.DisplayMember = "namecolocacion";
            this.idcolocacionSpinEdit.Properties.NullText = "";
            this.idcolocacionSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idcolocacionSpinEdit.Properties.ValueMember = "idcolocacion";
            this.idcolocacionSpinEdit.Properties.View = this.gridView7;
            this.idcolocacionSpinEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.idtipopropsolSpinEdit_Properties_ButtonClick);
            this.idcolocacionSpinEdit.Size = new System.Drawing.Size(414, 20);
            this.idcolocacionSpinEdit.StyleController = this.dataLayoutControl1;
            this.idcolocacionSpinEdit.TabIndex = 15;
            this.idcolocacionSpinEdit.EditValueChanged += new System.EventHandler(this.idtratamientoSpinEdit_EditValueChanged);
            // 
            // tColocacionPiezaBindingSource
            // 
            this.tColocacionPiezaBindingSource.DataSource = this.fKTColocacionPiezaTTipoPiezaGeometriaBindingSource;
            // 
            // fKTColocacionPiezaTTipoPiezaGeometriaBindingSource
            // 
            this.fKTColocacionPiezaTTipoPiezaGeometriaBindingSource.DataMember = "FK_T_ColocacionPieza_T_TipoPiezaGeometria";
            this.fKTColocacionPiezaTTipoPiezaGeometriaBindingSource.DataSource = this.tTipoPiezaGeometriaBindingSource;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamecolocacion});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colnamecolocacion
            // 
            this.colnamecolocacion.Caption = "Colocacion";
            this.colnamecolocacion.FieldName = "namecolocacion";
            this.colnamecolocacion.Name = "colnamecolocacion";
            this.colnamecolocacion.Visible = true;
            this.colnamecolocacion.VisibleIndex = 0;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(612, 571);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup6,
            this.layoutControlGroup7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(592, 551);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Datos Generales";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(592, 297);
            this.layoutControlGroup3.Text = "Datos Generales";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Datos";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidhorno,
            this.ItemForidtipomaterial,
            this.ItemForidtratamiento,
            this.layoutControlItem2,
            this.ItemForcantpiezas,
            this.layoutControlItem5});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(568, 163);
            this.layoutControlGroup4.Text = "Datos";
            // 
            // ItemForidhorno
            // 
            this.ItemForidhorno.Control = this.idhornoSpinEdit;
            this.ItemForidhorno.CustomizationFormText = "Horno:";
            this.ItemForidhorno.Location = new System.Drawing.Point(0, 48);
            this.ItemForidhorno.Name = "ItemForidhorno";
            this.ItemForidhorno.Size = new System.Drawing.Size(544, 24);
            this.ItemForidhorno.Text = "Horno:";
            this.ItemForidhorno.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForidtipomaterial
            // 
            this.ItemForidtipomaterial.Control = this.idtipomaterialSpinEdit;
            this.ItemForidtipomaterial.CustomizationFormText = "Acero:";
            this.ItemForidtipomaterial.Location = new System.Drawing.Point(0, 24);
            this.ItemForidtipomaterial.Name = "ItemForidtipomaterial";
            this.ItemForidtipomaterial.Size = new System.Drawing.Size(544, 24);
            this.ItemForidtipomaterial.Text = "Acero:";
            this.ItemForidtipomaterial.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForidtratamiento
            // 
            this.ItemForidtratamiento.Control = this.idtratamientoSpinEdit;
            this.ItemForidtratamiento.CustomizationFormText = "Tratamiento termico a aplicar:";
            this.ItemForidtratamiento.Location = new System.Drawing.Point(0, 0);
            this.ItemForidtratamiento.Name = "ItemForidtratamiento";
            this.ItemForidtratamiento.Size = new System.Drawing.Size(544, 24);
            this.ItemForidtratamiento.Text = "Tratamiento térmico a aplicar:";
            this.ItemForidtratamiento.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.imageComboBoxEdit1;
            this.layoutControlItem2.CustomizationFormText = "Medio calentador:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem2.Text = "Medio calentador:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForcantpiezas
            // 
            this.ItemForcantpiezas.Control = this.cantpiezasSpinEdit;
            this.ItemForcantpiezas.CustomizationFormText = "Cantidad de piezas:";
            this.ItemForcantpiezas.Location = new System.Drawing.Point(0, 72);
            this.ItemForcantpiezas.Name = "ItemForcantpiezas";
            this.ItemForcantpiezas.Size = new System.Drawing.Size(544, 24);
            this.ItemForcantpiezas.Text = "Cantidad de piezas:";
            this.ItemForcantpiezas.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridLookUpEdit1;
            this.layoutControlItem5.CustomizationFormText = "Régimen calentamiento:";
            this.layoutControlItem5.Location = new System.Drawing.Point(284, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(260, 24);
            this.layoutControlItem5.Text = "Régimen calentamiento:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Propiedades";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidtipopropsol,
            this.ItemForpropini,
            this.ItemForpropsol});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 163);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(568, 91);
            this.layoutControlGroup5.Text = "Propiedades";
            // 
            // ItemForidtipopropsol
            // 
            this.ItemForidtipopropsol.Control = this.idtipopropsolSpinEdit;
            this.ItemForidtipopropsol.CustomizationFormText = "Tipo de Propiedad Solicitada:";
            this.ItemForidtipopropsol.Location = new System.Drawing.Point(0, 0);
            this.ItemForidtipopropsol.Name = "ItemForidtipopropsol";
            this.ItemForidtipopropsol.Size = new System.Drawing.Size(544, 24);
            this.ItemForidtipopropsol.Text = "Tipo de Propiedad Solicitada:";
            this.ItemForidtipopropsol.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForpropini
            // 
            this.ItemForpropini.Control = this.propiniSpinEdit;
            this.ItemForpropini.CustomizationFormText = "Propiedad Inicial:";
            this.ItemForpropini.Location = new System.Drawing.Point(0, 24);
            this.ItemForpropini.Name = "ItemForpropini";
            this.ItemForpropini.Size = new System.Drawing.Size(216, 24);
            this.ItemForpropini.Text = "Propiedad Inicial:";
            this.ItemForpropini.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForpropsol
            // 
            this.ItemForpropsol.Control = this.propsolSpinEdit;
            this.ItemForpropsol.CustomizationFormText = "Propiedad Solicitada:";
            this.ItemForpropsol.Location = new System.Drawing.Point(216, 24);
            this.ItemForpropsol.Name = "ItemForpropsol";
            this.ItemForpropsol.Size = new System.Drawing.Size(328, 24);
            this.ItemForpropsol.Text = "Propiedad Solicitada:";
            this.ItemForpropsol.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Piezas";
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidtipopiezageo,
            this.ItemForancho,
            this.ItemForidcolocacion,
            this.ItemForidseparacion,
            this.ItemForvalorx,
            this.ItemForaltura,
            this.ItemForlargo,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 297);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(592, 187);
            this.layoutControlGroup6.Text = "Piezas";
            // 
            // ItemForidtipopiezageo
            // 
            this.ItemForidtipopiezageo.Control = this.idtipopiezageoSpinEdit;
            this.ItemForidtipopiezageo.CustomizationFormText = "Tipo de Pieza:";
            this.ItemForidtipopiezageo.Location = new System.Drawing.Point(0, 0);
            this.ItemForidtipopiezageo.Name = "ItemForidtipopiezageo";
            this.ItemForidtipopiezageo.Size = new System.Drawing.Size(568, 24);
            this.ItemForidtipopiezageo.Text = "Pieza Tipo:";
            this.ItemForidtipopiezageo.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForancho
            // 
            this.ItemForancho.Control = this.anchoSpinEdit;
            this.ItemForancho.CustomizationFormText = "Ancho:";
            this.ItemForancho.Location = new System.Drawing.Point(0, 24);
            this.ItemForancho.Name = "ItemForancho";
            this.ItemForancho.Size = new System.Drawing.Size(190, 24);
            this.ItemForancho.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.ItemForancho.Text = "Ancho(mm):";
            this.ItemForancho.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForancho.TextSize = new System.Drawing.Size(58, 13);
            this.ItemForancho.TextToControlDistance = 5;
            // 
            // ItemForidcolocacion
            // 
            this.ItemForidcolocacion.Control = this.idcolocacionSpinEdit;
            this.ItemForidcolocacion.CustomizationFormText = "Colocacion:";
            this.ItemForidcolocacion.Location = new System.Drawing.Point(0, 48);
            this.ItemForidcolocacion.Name = "ItemForidcolocacion";
            this.ItemForidcolocacion.Size = new System.Drawing.Size(568, 24);
            this.ItemForidcolocacion.Text = "Colocación(mm):";
            this.ItemForidcolocacion.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForidseparacion
            // 
            this.ItemForidseparacion.Control = this.idseparacionSpinEdit;
            this.ItemForidseparacion.CustomizationFormText = "Separacion:";
            this.ItemForidseparacion.Location = new System.Drawing.Point(0, 72);
            this.ItemForidseparacion.Name = "ItemForidseparacion";
            this.ItemForidseparacion.Size = new System.Drawing.Size(568, 24);
            this.ItemForidseparacion.Text = "Separación(mm):";
            this.ItemForidseparacion.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForvalorx
            // 
            this.ItemForvalorx.Control = this.valorxSpinEdit;
            this.ItemForvalorx.CustomizationFormText = "Valor de X:";
            this.ItemForvalorx.Location = new System.Drawing.Point(0, 96);
            this.ItemForvalorx.Name = "ItemForvalorx";
            this.ItemForvalorx.Size = new System.Drawing.Size(284, 24);
            this.ItemForvalorx.Text = "Valor de X(mm):";
            this.ItemForvalorx.TextSize = new System.Drawing.Size(146, 13);
            // 
            // ItemForaltura
            // 
            this.ItemForaltura.Control = this.alturaSpinEdit;
            this.ItemForaltura.CustomizationFormText = "Altura:";
            this.ItemForaltura.Location = new System.Drawing.Point(190, 24);
            this.ItemForaltura.Name = "ItemForaltura";
            this.ItemForaltura.Size = new System.Drawing.Size(188, 24);
            this.ItemForaltura.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.ItemForaltura.Text = "Altura(mm):";
            this.ItemForaltura.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForaltura.TextSize = new System.Drawing.Size(57, 13);
            this.ItemForaltura.TextToControlDistance = 5;
            // 
            // ItemForlargo
            // 
            this.ItemForlargo.Control = this.largoSpinEdit;
            this.ItemForlargo.CustomizationFormText = "Largo:";
            this.ItemForlargo.Location = new System.Drawing.Point(378, 24);
            this.ItemForlargo.Name = "ItemForlargo";
            this.ItemForlargo.Size = new System.Drawing.Size(190, 24);
            this.ItemForlargo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.ItemForlargo.Text = "Largo(mm):";
            this.ItemForlargo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForlargo.TextSize = new System.Drawing.Size(55, 13);
            this.ItemForlargo.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.CustomizationFormText = "Dimensión caracteristica (mm):";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(568, 24);
            this.layoutControlItem1.Text = "Dimensión característica (mm):";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.seph;
            this.layoutControlItem4.CustomizationFormText = "Sep. pared del horno:";
            this.layoutControlItem4.Location = new System.Drawing.Point(284, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem4.Text = "Sep. pared del horno(mm):";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.CustomizationFormText = "Configuracion de la pieza";
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidtipopieza});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 484);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(592, 67);
            this.layoutControlGroup7.Text = "Configuración de la pieza";
            // 
            // ItemForidtipopieza
            // 
            this.ItemForidtipopieza.Control = this.idtipopiezaSpinEdit;
            this.ItemForidtipopieza.CustomizationFormText = "Tipo de Pieza:";
            this.ItemForidtipopieza.Location = new System.Drawing.Point(0, 0);
            this.ItemForidtipopieza.Name = "ItemForidtipopieza";
            this.ItemForidtipopieza.Size = new System.Drawing.Size(568, 24);
            this.ItemForidtipopieza.Text = "Tipo de Pieza:";
            this.ItemForidtipopieza.TextSize = new System.Drawing.Size(146, 13);
            // 
            // tTratamientoBindingSource
            // 
            this.tTratamientoBindingSource.DataMember = "T_Tratamiento";
            this.tTratamientoBindingSource.DataSource = this.dSDatos;
            // 
            // tTipoMaterialBindingSource
            // 
            this.tTipoMaterialBindingSource.DataMember = "T_TipoMaterial";
            this.tTipoMaterialBindingSource.DataSource = this.dSDatos;
            // 
            // t_TipoPropiedadSolTableAdapter
            // 
            this.t_TipoPropiedadSolTableAdapter.ClearBeforeFill = true;
            // 
            // t_HornoTableAdapter
            // 
            this.t_HornoTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoMaterialTableAdapter
            // 
            this.t_TipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // t_TratamientoTableAdapter
            // 
            this.t_TratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoPiezaTableAdapter
            // 
            this.t_TipoPiezaTableAdapter.ClearBeforeFill = true;
            // 
            // t_SeparacionPiezaTableAdapter
            // 
            this.t_SeparacionPiezaTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoPiezaGeometriaTableAdapter
            // 
            this.t_TipoPiezaGeometriaTableAdapter.ClearBeforeFill = true;
            // 
            // t_ColocacionPiezaTableAdapter
            // 
            this.t_ColocacionPiezaTableAdapter.ClearBeforeFill = true;
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
            // t_AceroElementoTableAdapter1
            // 
            this.t_AceroElementoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ElementoTableAdapter1
            // 
            this.t_ElementoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TipoHornoTableAdapter1
            // 
            this.t_TipoHornoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TipoTratamientoTableAdapter1
            // 
            this.t_TipoTratamientoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_RegimenCalentamientoTableAdapter
            // 
            this.t_RegimenCalentamientoTableAdapter.ClearBeforeFill = true;
            // 
            // cantpiezasSpinEdit
            // 
            this.cantpiezasSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "cantpiezas", true));
            this.cantpiezasSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.cantpiezasSpinEdit.Location = new System.Drawing.Point(186, 146);
            this.cantpiezasSpinEdit.Name = "cantpiezasSpinEdit";
            this.cantpiezasSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cantpiezasSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cantpiezasSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantpiezasSpinEdit.Size = new System.Drawing.Size(390, 20);
            this.cantpiezasSpinEdit.StyleController = this.dataLayoutControl1;
            this.cantpiezasSpinEdit.TabIndex = 10;
            // 
            // propsolSpinEdit
            // 
            this.propsolSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "propsol", true));
            this.propsolSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.propsolSpinEdit.Location = new System.Drawing.Point(402, 261);
            this.propsolSpinEdit.Name = "propsolSpinEdit";
            this.propsolSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.propsolSpinEdit.Properties.Mask.EditMask = "n";
            this.propsolSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.propsolSpinEdit.Size = new System.Drawing.Size(174, 20);
            this.propsolSpinEdit.StyleController = this.dataLayoutControl1;
            this.propsolSpinEdit.TabIndex = 9;
            this.propsolSpinEdit.EditValueChanged += new System.EventHandler(this.propsolSpinEdit_EditValueChanged);
            // 
            // propiniSpinEdit
            // 
            this.propiniSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "propini", true));
            this.propiniSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.propiniSpinEdit.Location = new System.Drawing.Point(186, 261);
            this.propiniSpinEdit.Name = "propiniSpinEdit";
            this.propiniSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.propiniSpinEdit.Properties.Mask.EditMask = "n";
            this.propiniSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.propiniSpinEdit.Size = new System.Drawing.Size(62, 20);
            this.propiniSpinEdit.StyleController = this.dataLayoutControl1;
            this.propiniSpinEdit.TabIndex = 8;
            // 
            // largoSpinEdit
            // 
            this.largoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "largo", true));
            this.largoSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.largoSpinEdit.Location = new System.Drawing.Point(462, 364);
            this.largoSpinEdit.Name = "largoSpinEdit";
            this.largoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.largoSpinEdit.Properties.Mask.EditMask = "n";
            this.largoSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.largoSpinEdit.Size = new System.Drawing.Size(126, 20);
            this.largoSpinEdit.StyleController = this.dataLayoutControl1;
            this.largoSpinEdit.TabIndex = 13;
            // 
            // alturaSpinEdit
            // 
            this.alturaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "altura", true));
            this.alturaSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.alturaSpinEdit.Location = new System.Drawing.Point(276, 364);
            this.alturaSpinEdit.Name = "alturaSpinEdit";
            this.alturaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.alturaSpinEdit.Properties.Mask.EditMask = "n";
            this.alturaSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.alturaSpinEdit.Size = new System.Drawing.Size(122, 20);
            this.alturaSpinEdit.StyleController = this.dataLayoutControl1;
            this.alturaSpinEdit.TabIndex = 14;
            // 
            // anchoSpinEdit
            // 
            this.anchoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "ancho", true));
            this.anchoSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.anchoSpinEdit.Location = new System.Drawing.Point(87, 364);
            this.anchoSpinEdit.Name = "anchoSpinEdit";
            this.anchoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.anchoSpinEdit.Properties.Mask.EditMask = "n";
            this.anchoSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.anchoSpinEdit.Size = new System.Drawing.Size(123, 20);
            this.anchoSpinEdit.StyleController = this.dataLayoutControl1;
            this.anchoSpinEdit.TabIndex = 12;
            // 
            // seph
            // 
            this.seph.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.seph.Location = new System.Drawing.Point(458, 436);
            this.seph.Name = "seph";
            this.seph.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seph.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seph.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seph.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seph.Size = new System.Drawing.Size(130, 20);
            this.seph.StyleController = this.dataLayoutControl1;
            this.seph.TabIndex = 22;
            // 
            // valorxSpinEdit
            // 
            this.valorxSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tCalculoTTBindingSource, "valorx", true));
            this.valorxSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.valorxSpinEdit.Location = new System.Drawing.Point(174, 436);
            this.valorxSpinEdit.Name = "valorxSpinEdit";
            this.valorxSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.valorxSpinEdit.Properties.Mask.EditMask = "n";
            this.valorxSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.valorxSpinEdit.Size = new System.Drawing.Size(130, 20);
            this.valorxSpinEdit.StyleController = this.dataLayoutControl1;
            this.valorxSpinEdit.TabIndex = 17;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.textEdit1.Location = new System.Drawing.Point(174, 460);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textEdit1.Size = new System.Drawing.Size(414, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 19;
            // 
            // FrmCalculoTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 601);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculoTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de tratamiento térmico";
            this.Load += new System.EventHandler(this.FrmCalculoTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRegimenCalentamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCalculoTTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipopropsolSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadSolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idhornoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHornoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipomaterialSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtratamientoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipopiezaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPiezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipopiezageoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPiezaGeometriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idseparacionSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeparacionPiezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcolocacionSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColocacionPiezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTColocacionPiezaTTipoPiezaGeometriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidhorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipomaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcantpiezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipopropsol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpropini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpropsol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipopiezageo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForancho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidcolocacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidseparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvalorx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForaltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipopieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantpiezasSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propsolSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiniSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seph.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorxSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource tCalculoTTBindingSource;
        private DSACATTA dSDatos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtipopiezageo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForancho;
        private DevExpress.XtraLayout.LayoutControlItem ItemForlargo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForaltura;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidcolocacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidseparacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForvalorx;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtipopieza;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcantpiezas;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidhorno;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtipomaterial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtratamiento;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtipopropsol;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpropini;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpropsol;
        private DevExpress.XtraEditors.GridLookUpEdit idtipopropsolSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tTipoPropiedadSolBindingSource;
        private T_TipoPropiedadSolTableAdapter t_TipoPropiedadSolTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idhornoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tHornoBindingSource;
        private T_HornoTableAdapter t_HornoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idtipomaterialSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource tTipoMaterialBindingSource;
        private T_TipoMaterialTableAdapter t_TipoMaterialTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idtratamientoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource tTratamientoBindingSource;
        private T_TratamientoTableAdapter t_TratamientoTableAdapter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraEditors.GridLookUpEdit idtipopiezaSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource tTipoPiezaBindingSource;
        private T_TipoPiezaTableAdapter t_TipoPiezaTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idtipopiezageoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.BindingSource tSeparacionPiezaBindingSource;
        private T_SeparacionPiezaTableAdapter t_SeparacionPiezaTableAdapter;
        private System.Windows.Forms.BindingSource tTipoPiezaGeometriaBindingSource;
        private T_TipoPiezaGeometriaTableAdapter t_TipoPiezaGeometriaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopieza;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopiezageo;
        private DevExpress.XtraEditors.GridLookUpEdit idseparacionSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colnameseparacion;
        private DevExpress.XtraEditors.GridLookUpEdit idcolocacionSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private System.Windows.Forms.BindingSource tColocacionPiezaBindingSource;
        private T_ColocacionPiezaTableAdapter t_ColocacionPiezaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamecolocacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipopropiedad;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipomaterial;
        private System.Windows.Forms.BindingSource tAceroBindingSource;
        private T_AceroTableAdapter t_AceroTableAdapter;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private T_NormaTableAdapter t_NormaTableAdapter1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource fKTColocacionPiezaTTipoPiezaGeometriaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnametratamiento;
        private DevExpress.XtraGrid.Columns.GridColumn colnamehorno;
        private DevExpress.XtraGrid.Columns.GridColumn colProfundidad;
        private DevExpress.XtraGrid.Columns.GridColumn colLargo;
        private DevExpress.XtraGrid.Columns.GridColumn colAltura;
        private T_AceroElementoTableAdapter t_AceroElementoTableAdapter1;
        private T_ElementoTableAdapter t_ElementoTableAdapter1;
        private T_TipoHornoTableAdapter t_TipoHornoTableAdapter1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private T_TipoTratamientoTableAdapter t_TipoTratamientoTableAdapter1;
        private System.Windows.Forms.BindingSource tTipoTratamientoBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource tRegimenCalentamientoBindingSource;
        private T_RegimenCalentamientoTableAdapter t_RegimenCalentamientoTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameregcalent;
        private DevExpress.XtraEditors.SpinEdit cantpiezasSpinEdit;
        private DevExpress.XtraEditors.SpinEdit propsolSpinEdit;
        private DevExpress.XtraEditors.SpinEdit propiniSpinEdit;
        private DevExpress.XtraEditors.SpinEdit largoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit alturaSpinEdit;
        private DevExpress.XtraEditors.SpinEdit anchoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit seph;
        private DevExpress.XtraEditors.SpinEdit valorxSpinEdit;
        private DevExpress.XtraEditors.SpinEdit textEdit1;
    }
}