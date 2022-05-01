using TMC.MCC;
using TMC.MCC.DSMCCTableAdapters;
using TMC.Components;
namespace TMC.MCC.Tareas
{
    partial class FrmSimulate
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridLookUpEdit3 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fKTPalanquillaTMaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.MCC.DSMCC();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltipopalanquilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colareapalanquilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmodelomaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarcamaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameacero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.LOPage = new DevExpress.XtraWizard.WizardPage();
            this.groupContr_Formula = new DevExpress.XtraEditors.GroupControl();
            this.FCLargoMetal = new TMC.Components.FormulateControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupContr_Opciones = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_Calc_Pers = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_Calc_Anterior = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_Larg_Maq = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Radio = new DevExpress.XtraEditors.TextEdit();
            this.labelContr_Larg_Maq = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_Radio = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_Tecnologias = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_Tecnologia = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTecnologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VCPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.FCVelocidadColada = new TMC.Components.FormulateControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_Calc_Pers2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_Cal_Anterior2 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_Alt_Acero = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Diam_Boq_Dist = new DevExpress.XtraEditors.TextEdit();
            this.labelContr_AA = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_DBD = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_Tecnologia2 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_Tecnol_VC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.FCVelocidadExtraccion = new TMC.Components.FormulateControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_VE_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_VE_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl_VE_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdi_Velc_Extr = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VPPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.FCVelocidadProduccion = new TMC.Components.FormulateControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_Calc_Pers3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_Cal_Anterior3 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_lineas = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Dens_Ace_Sol = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_NL = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_DAS = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_Tecnologia3 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_Velc_Prod = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPACPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.FCTiempoPAC = new TMC.Components.FormulateControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_Calc_Pers4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_Cal_Anterior4 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_Num_L_C = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Cant_AC_C = new DevExpress.XtraEditors.TextEdit();
            this.labelContr_NLC = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_CAC = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_Tecnologia4 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_TPAC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLDFPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.FCLongitud_M_calculada = new TMC.Components.FormulateControl();
            this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_LMAC_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_LMAC_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl_LMAC_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_LMAC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CTTPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl13 = new DevExpress.XtraEditors.GroupControl();
            this.FCCalorTotalTransferido = new TMC.Components.FormulateControl();
            this.groupControl14 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit_DT_CTT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl56 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_GAP_CTT = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Esp_Mold_CTT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl52 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl53 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl54 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit4 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMAEPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl15 = new DevExpress.XtraEditors.GroupControl();
            this.FCCant_Max_AE = new TMC.Components.FormulateControl();
            this.groupControl16 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_CAME_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_CAME_1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_Calor_Esp_Agu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl64 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl65 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_CMAE = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPADPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl11 = new DevExpress.XtraEditors.GroupControl();
            this.FCTiempoRAD = new TMC.Components.FormulateControl();
            this.groupControl12 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_Calc_Pers5 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit__Calc_Anterior5 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_Num_L_D = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Cant_AC_D = new DevExpress.XtraEditors.TextEdit();
            this.labelContr_NLC2 = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_CAD = new DevExpress.XtraEditors.LabelControl();
            this.labelContr_Tecnologia5 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_TPAD = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VMAPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl17 = new DevExpress.XtraEditors.GroupControl();
            this.FCVMA = new TMC.Components.FormulateControl();
            this.groupControl18 = new DevExpress.XtraEditors.GroupControl();
            this.gridLookUpEdit_Area_Circulacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tCirculacionAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit8View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colarea_circulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl_Area_Circulacion = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_VMA_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_VMA_1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_Caudal_Agua = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_VMA_CA = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Tecnologia_VMA = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_VMA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EPPaje = new DevExpress.XtraWizard.WizardPage();
            this.groupControl19 = new DevExpress.XtraEditors.GroupControl();
            this.FCEP = new TMC.Components.FormulateControl();
            this.groupControl20 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_EP_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_EP_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl_EP_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_EP = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OMPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl21 = new DevExpress.XtraEditors.GroupControl();
            this.FCOM = new TMC.Components.FormulateControl();
            this.groupControl22 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_OM_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_OM_1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_OM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_OM_2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_OM_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_OM_1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TSPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl23 = new DevExpress.XtraEditors.GroupControl();
            this.FCTS = new TMC.Components.FormulateControl();
            this.groupControl24 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit_TS_2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_TS_3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_TS_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_TS_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl_TS_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_TS = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DMOPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl25 = new DevExpress.XtraEditors.GroupControl();
            this.FCDMO = new TMC.Components.FormulateControl();
            this.groupControl26 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit_DMO_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_DMO_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl_DMO_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_DMO_1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ESPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl27 = new DevExpress.XtraEditors.GroupControl();
            this.FCES = new TMC.Components.FormulateControl();
            this.groupControl28 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit5 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl_CAES_5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_CAES_4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_CAES_3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_CAES_2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_ES_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_ES_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_ES = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALPage = new DevExpress.XtraWizard.WizardPage();
            this.groupControl29 = new DevExpress.XtraEditors.GroupControl();
            this.FCAL = new TMC.Components.FormulateControl();
            this.groupControl30 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit_AL_2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_AL_3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_AL_1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_AL_2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_AL_2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit_AL_1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl_AL_1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_AL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tPalanquillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_MaquinaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_MaquinaTableAdapter();
            this.t_PalanquillaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_PalanquillaTableAdapter();
            this.t_MarcaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_AceroTableAdapter();
            this.t_MaquinaParametroTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_ParametroValorTableAdapter();
            this.t_ParametrosTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_ParametrosTableAdapter();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.t_Circulacion_AMTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_Circulacion_AMTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.t_TecnologiaTableAdapter = new TMC.MCC.DSMCCTableAdapters.T_TecnologiaTableAdapter();
            this.t_AceroNormaTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_AceroNormaTableAdapter();
            this.t_ParametroValorTableAdapter1 = new TMC.MCC.DSMCCTableAdapters.T_ParametroValorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTPalanquillaTMaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.completionWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.LOPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupContr_Formula)).BeginInit();
            this.groupContr_Formula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupContr_Opciones)).BeginInit();
            this.groupContr_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Anterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Larg_Maq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Radio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Tecnologia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTecnologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.VCPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Cal_Anterior2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Alt_Acero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Diam_Boq_Dist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Tecnol_VC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.VEPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VE_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VE_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdi_Velc_Extr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.VPPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Cal_Anterior3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_lineas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Dens_Ace_Sol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Velc_Prod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.TIPACPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Cal_Anterior4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Num_L_C.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Cant_AC_C.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_TPAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SOLDFPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
            this.groupControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_LMAC_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_LMAC_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_LMAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.CTTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl13)).BeginInit();
            this.groupControl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl14)).BeginInit();
            this.groupControl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DT_CTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_GAP_CTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Esp_Mold_CTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.CMAEPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).BeginInit();
            this.groupControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl16)).BeginInit();
            this.groupControl16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_CAME_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_CAME_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Calor_Esp_Agu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_CMAE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.TIPADPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).BeginInit();
            this.groupControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl12)).BeginInit();
            this.groupControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit__Calc_Anterior5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Num_L_D.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Cant_AC_D.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_TPAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.VMAPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).BeginInit();
            this.groupControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl18)).BeginInit();
            this.groupControl18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Area_Circulacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCirculacionAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit8View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VMA_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VMA_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Caudal_Agua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_VMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            this.EPPaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl19)).BeginInit();
            this.groupControl19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl20)).BeginInit();
            this.groupControl20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_EP_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_EP_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_EP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            this.OMPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl21)).BeginInit();
            this.groupControl21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl22)).BeginInit();
            this.groupControl22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_OM_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_OM_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_OM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_OM_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            this.TSPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl23)).BeginInit();
            this.groupControl23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl24)).BeginInit();
            this.groupControl24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TS_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_TS_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_TS_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_TS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            this.DMOPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl25)).BeginInit();
            this.groupControl25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl26)).BeginInit();
            this.groupControl26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DMO_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DMO_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_DMO_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            this.ESPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl27)).BeginInit();
            this.groupControl27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl28)).BeginInit();
            this.groupControl28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_ES_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_ES_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_ES.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            this.ALPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl29)).BeginInit();
            this.groupControl29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl30)).BeginInit();
            this.groupControl30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AL_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AL_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_AL_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_AL_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_AL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPalanquillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.LOPage);
            this.wizardControl1.Controls.Add(this.VCPage);
            this.wizardControl1.Controls.Add(this.VEPage);
            this.wizardControl1.Controls.Add(this.VPPage);
            this.wizardControl1.Controls.Add(this.TIPACPage);
            this.wizardControl1.Controls.Add(this.SOLDFPage);
            this.wizardControl1.Controls.Add(this.CTTPage);
            this.wizardControl1.Controls.Add(this.CMAEPage);
            this.wizardControl1.Controls.Add(this.TIPADPage);
            this.wizardControl1.Controls.Add(this.VMAPage);
            this.wizardControl1.Controls.Add(this.EPPaje);
            this.wizardControl1.Controls.Add(this.OMPage);
            this.wizardControl1.Controls.Add(this.TSPage);
            this.wizardControl1.Controls.Add(this.DMOPage);
            this.wizardControl1.Controls.Add(this.ESPage);
            this.wizardControl1.Controls.Add(this.ALPage);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.LOPage,
            this.VCPage,
            this.VEPage,
            this.VPPage,
            this.TIPACPage,
            this.TIPADPage,
            this.SOLDFPage,
            this.CTTPage,
            this.CMAEPage,
            this.VMAPage,
            this.EPPaje,
            this.OMPage,
            this.TSPage,
            this.DMOPage,
            this.ESPage,
            this.ALPage,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(694, 458);
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(477, 325);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.layoutControl1);
            this.wizardPage1.DescriptionText = "Introduzca los parámetros iniciales";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(662, 313);
            this.wizardPage1.Text = "Parámetros Generales";
            this.wizardPage1.Click += new System.EventHandler(this.wizardPage1_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit3);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit2);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(662, 313);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(70, 84);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(580, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 7;
            // 
            // gridLookUpEdit3
            // 
            this.gridLookUpEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKTPalanquillaTMaquinaBindingSource, "idpalanquilla", true));
            this.gridLookUpEdit3.Location = new System.Drawing.Point(70, 60);
            this.gridLookUpEdit3.Name = "gridLookUpEdit3";
            this.gridLookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit3.Properties.DataSource = this.fKTPalanquillaTMaquinaBindingSource;
            this.gridLookUpEdit3.Properties.DisplayMember = "tipopalanquilla";
            this.gridLookUpEdit3.Properties.ValueMember = "idpalanquilla";
            this.gridLookUpEdit3.Properties.View = this.gridLookUpEdit3View;
            this.gridLookUpEdit3.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit2_Properties_EditValueChanged);
            this.gridLookUpEdit3.Size = new System.Drawing.Size(580, 20);
            this.gridLookUpEdit3.StyleController = this.layoutControl1;
            this.gridLookUpEdit3.TabIndex = 6;
            // 
            // fKTPalanquillaTMaquinaBindingSource
            // 
            this.fKTPalanquillaTMaquinaBindingSource.DataMember = "FK_T_Palanquilla_T_Maquina";
            this.fKTPalanquillaTMaquinaBindingSource.DataSource = this.tMaquinaBindingSource;
            // 
            // tMaquinaBindingSource
            // 
            this.tMaquinaBindingSource.DataMember = "T_Maquina";
            this.tMaquinaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltipopalanquilla,
            this.colareapalanquilla});
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // coltipopalanquilla
            // 
            this.coltipopalanquilla.Caption = "Tipo";
            this.coltipopalanquilla.FieldName = "tipopalanquilla";
            this.coltipopalanquilla.Name = "coltipopalanquilla";
            this.coltipopalanquilla.Visible = true;
            this.coltipopalanquilla.VisibleIndex = 0;
            // 
            // colareapalanquilla
            // 
            this.colareapalanquilla.Caption = "Area";
            this.colareapalanquilla.FieldName = "areapalanquilla";
            this.colareapalanquilla.Name = "colareapalanquilla";
            this.colareapalanquilla.Visible = true;
            this.colareapalanquilla.VisibleIndex = 1;
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tMaquinaBindingSource, "idmaquina", true));
            this.gridLookUpEdit2.Location = new System.Drawing.Point(70, 36);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.tMaquinaBindingSource;
            this.gridLookUpEdit2.Properties.DisplayMember = "marcamaquina";
            this.gridLookUpEdit2.Properties.ValueMember = "idmaquina";
            this.gridLookUpEdit2.Properties.View = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit2_Properties_EditValueChanged);
            this.gridLookUpEdit2.Size = new System.Drawing.Size(580, 20);
            this.gridLookUpEdit2.StyleController = this.layoutControl1;
            this.gridLookUpEdit2.TabIndex = 5;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmodelomaquina,
            this.colmarcamaquina});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colmodelomaquina
            // 
            this.colmodelomaquina.Caption = "Modelo";
            this.colmodelomaquina.FieldName = "modelomaquina";
            this.colmodelomaquina.Name = "colmodelomaquina";
            this.colmodelomaquina.Visible = true;
            this.colmodelomaquina.VisibleIndex = 0;
            // 
            // colmarcamaquina
            // 
            this.colmarcamaquina.Caption = "Marca";
            this.colmarcamaquina.FieldName = "marcamaquina";
            this.colmarcamaquina.Name = "colmarcamaquina";
            this.colmarcamaquina.Visible = true;
            this.colmarcamaquina.VisibleIndex = 1;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tMarcaBindingSource, "idacero", true));
            this.gridLookUpEdit1.Location = new System.Drawing.Point(70, 12);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tMarcaBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nameacero";
            this.gridLookUpEdit1.Properties.ValueMember = "idacero";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit2_Properties_EditValueChanged);
            this.gridLookUpEdit1.Size = new System.Drawing.Size(580, 20);
            this.gridLookUpEdit1.StyleController = this.layoutControl1;
            this.gridLookUpEdit1.TabIndex = 4;
            // 
            // tMarcaBindingSource
            // 
            this.tMarcaBindingSource.DataMember = "T_Acero";
            this.tMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameacero});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameacero
            // 
            this.colnameacero.Caption = "Acero";
            this.colnameacero.FieldName = "nameacero";
            this.colnameacero.Name = "colnameacero";
            this.colnameacero.Visible = true;
            this.colnameacero.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(662, 313);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridLookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Acero:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(642, 24);
            this.layoutControlItem1.Text = "Acero:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridLookUpEdit2;
            this.layoutControlItem2.CustomizationFormText = "Máquina:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(642, 24);
            this.layoutControlItem2.Text = "Máquina:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridLookUpEdit3;
            this.layoutControlItem3.CustomizationFormText = "Palanquilla:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(642, 24);
            this.layoutControlItem3.Text = "Palanquilla:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit1;
            this.layoutControlItem4.CustomizationFormText = "Longitud:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(642, 221);
            this.layoutControlItem4.Text = "Longitud:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Controls.Add(this.textEdit3);
            this.completionWizardPage1.Controls.Add(this.simpleButton2);
            this.completionWizardPage1.Controls.Add(this.simpleButton1);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(477, 325);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(184, 39);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(16, 83);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(130, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Reporte Tecnologia";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(16, 42);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Guardar Tecnologia";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // LOPage
            // 
            this.LOPage.Controls.Add(this.groupContr_Formula);
            this.LOPage.Controls.Add(this.groupContr_Opciones);
            this.LOPage.DescriptionText = "Seleccione las opciones para calcular el largo métalurgico";
            this.LOPage.Name = "LOPage";
            this.LOPage.Size = new System.Drawing.Size(662, 313);
            this.LOPage.Text = "Largo Métalurgico";
            // 
            // groupContr_Formula
            // 
            this.groupContr_Formula.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupContr_Formula.AppearanceCaption.Options.UseFont = true;
            this.groupContr_Formula.Controls.Add(this.FCLargoMetal);
            this.groupContr_Formula.Controls.Add(this.labelControl13);
            this.groupContr_Formula.Location = new System.Drawing.Point(395, 3);
            this.groupContr_Formula.Name = "groupContr_Formula";
            this.groupContr_Formula.Size = new System.Drawing.Size(264, 307);
            this.groupContr_Formula.TabIndex = 3;
            this.groupContr_Formula.Text = "Fórmula";
            // 
            // FCLargoMetal
            // 
            this.FCLargoMetal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCLargoMetal.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCLargoMetal.FontColor = System.Drawing.Color.Black;
            this.FCLargoMetal.Location = new System.Drawing.Point(2, 24);
            this.FCLargoMetal.Name = "FCLargoMetal";
            this.FCLargoMetal.Separator = 10;
            this.FCLargoMetal.Size = new System.Drawing.Size(260, 281);
            this.FCLargoMetal.TabIndex = 26;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(143, 233);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(0, 14);
            this.labelControl13.TabIndex = 25;
            // 
            // groupContr_Opciones
            // 
            this.groupContr_Opciones.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupContr_Opciones.AppearanceCaption.Options.UseFont = true;
            this.groupContr_Opciones.Controls.Add(this.checkEdit_Calc_Pers);
            this.groupContr_Opciones.Controls.Add(this.checkEdit_Calc_Anterior);
            this.groupContr_Opciones.Controls.Add(this.textEdit_Larg_Maq);
            this.groupContr_Opciones.Controls.Add(this.textEdit_Radio);
            this.groupContr_Opciones.Controls.Add(this.labelContr_Larg_Maq);
            this.groupContr_Opciones.Controls.Add(this.labelContr_Radio);
            this.groupContr_Opciones.Controls.Add(this.labelContr_Tecnologias);
            this.groupContr_Opciones.Controls.Add(this.gridLookUpEdit_Tecnologia);
            this.groupContr_Opciones.Location = new System.Drawing.Point(3, 3);
            this.groupContr_Opciones.Name = "groupContr_Opciones";
            this.groupContr_Opciones.Size = new System.Drawing.Size(386, 307);
            this.groupContr_Opciones.TabIndex = 2;
            this.groupContr_Opciones.Text = "Opciones";
            // 
            // checkEdit_Calc_Pers
            // 
            this.checkEdit_Calc_Pers.Location = new System.Drawing.Point(14, 163);
            this.checkEdit_Calc_Pers.Name = "checkEdit_Calc_Pers";
            this.checkEdit_Calc_Pers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Calc_Pers.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Calc_Pers.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_Calc_Pers.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Calc_Pers.Properties.RadioGroupIndex = 0;
            this.checkEdit_Calc_Pers.Size = new System.Drawing.Size(172, 21);
            this.checkEdit_Calc_Pers.TabIndex = 9;
            this.checkEdit_Calc_Pers.TabStop = false;
            this.checkEdit_Calc_Pers.Click += new System.EventHandler(this.checkEdit_Calc_Pers_Click_1);
            // 
            // checkEdit_Calc_Anterior
            // 
            this.checkEdit_Calc_Anterior.EditValue = true;
            this.checkEdit_Calc_Anterior.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_Calc_Anterior.Name = "checkEdit_Calc_Anterior";
            this.checkEdit_Calc_Anterior.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Calc_Anterior.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Calc_Anterior.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_Calc_Anterior.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Calc_Anterior.Properties.RadioGroupIndex = 0;
            this.checkEdit_Calc_Anterior.Size = new System.Drawing.Size(172, 21);
            this.checkEdit_Calc_Anterior.TabIndex = 8;
            this.checkEdit_Calc_Anterior.Click += new System.EventHandler(this.checkEdit_Calc_Anterior_Click_1);
            // 
            // textEdit_Larg_Maq
            // 
            this.textEdit_Larg_Maq.EditValue = "0";
            this.textEdit_Larg_Maq.Location = new System.Drawing.Point(233, 250);
            this.textEdit_Larg_Maq.Name = "textEdit_Larg_Maq";
            this.textEdit_Larg_Maq.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Larg_Maq.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Larg_Maq.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Larg_Maq.TabIndex = 7;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Llenelo";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.textEdit_Larg_Maq, conditionValidationRule1);
            this.textEdit_Larg_Maq.EditValueChanged += new System.EventHandler(this.textEdit_Radio_EditValueChanged_1);
            // 
            // textEdit_Radio
            // 
            this.textEdit_Radio.EditValue = "0";
            this.textEdit_Radio.Location = new System.Drawing.Point(233, 200);
            this.textEdit_Radio.Name = "textEdit_Radio";
            this.textEdit_Radio.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit_Radio.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.textEdit_Radio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Radio.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_Radio.Properties.Appearance.Options.UseBorderColor = true;
            this.textEdit_Radio.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Radio.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Radio.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "LLenelo";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.textEdit_Radio, conditionValidationRule2);
            this.textEdit_Radio.EditValueChanged += new System.EventHandler(this.textEdit_Radio_EditValueChanged_1);
            // 
            // labelContr_Larg_Maq
            // 
            this.labelContr_Larg_Maq.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_Larg_Maq.Location = new System.Drawing.Point(16, 256);
            this.labelContr_Larg_Maq.Name = "labelContr_Larg_Maq";
            this.labelContr_Larg_Maq.Size = new System.Drawing.Size(150, 16);
            this.labelContr_Larg_Maq.TabIndex = 5;
            this.labelContr_Larg_Maq.Text = "Largo de Máquina: en (m)";
            // 
            // labelContr_Radio
            // 
            this.labelContr_Radio.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_Radio.Location = new System.Drawing.Point(16, 206);
            this.labelContr_Radio.Name = "labelContr_Radio";
            this.labelContr_Radio.Size = new System.Drawing.Size(80, 16);
            this.labelContr_Radio.TabIndex = 3;
            this.labelContr_Radio.Text = "Radio: (en m)";
            // 
            // labelContr_Tecnologias
            // 
            this.labelContr_Tecnologias.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_Tecnologias.Enabled = false;
            this.labelContr_Tecnologias.Location = new System.Drawing.Point(36, 76);
            this.labelContr_Tecnologias.Name = "labelContr_Tecnologias";
            this.labelContr_Tecnologias.Size = new System.Drawing.Size(73, 16);
            this.labelContr_Tecnologias.TabIndex = 1;
            this.labelContr_Tecnologias.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_Tecnologia
            // 
            this.gridLookUpEdit_Tecnologia.Enabled = false;
            this.gridLookUpEdit_Tecnologia.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_Tecnologia.Name = "gridLookUpEdit_Tecnologia";
            this.gridLookUpEdit_Tecnologia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_Tecnologia.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_Tecnologia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_Tecnologia.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_Tecnologia.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_Tecnologia.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_Tecnologia.Properties.View = this.gridView1;
            this.gridLookUpEdit_Tecnologia.Properties.EditValueChanged += new System.EventHandler(this.textEdit_Radio_EditValueChanged_1);
            this.gridLookUpEdit_Tecnologia.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_Tecnologia.TabIndex = 0;
            // 
            // tTecnologiaBindingSource
            // 
            this.tTecnologiaBindingSource.DataMember = "T_Tecnologia";
            this.tTecnologiaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // VCPage
            // 
            this.VCPage.Controls.Add(this.groupControl1);
            this.VCPage.Controls.Add(this.groupControl2);
            this.VCPage.DescriptionText = "Seleccione las opciones para calcular la Velocidad de Colada";
            this.VCPage.Name = "VCPage";
            this.VCPage.Size = new System.Drawing.Size(662, 313);
            this.VCPage.Text = "Velocidad de Colada";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.FCVelocidadColada);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(395, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(264, 307);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Fórmula";
            // 
            // FCVelocidadColada
            // 
            this.FCVelocidadColada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCVelocidadColada.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCVelocidadColada.FontColor = System.Drawing.Color.Black;
            this.FCVelocidadColada.Location = new System.Drawing.Point(2, 24);
            this.FCVelocidadColada.Name = "FCVelocidadColada";
            this.FCVelocidadColada.Separator = 10;
            this.FCVelocidadColada.Size = new System.Drawing.Size(260, 281);
            this.FCVelocidadColada.TabIndex = 27;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(170, 246);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 19);
            this.labelControl1.TabIndex = 25;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.checkEdit_Calc_Pers2);
            this.groupControl2.Controls.Add(this.checkEdit_Cal_Anterior2);
            this.groupControl2.Controls.Add(this.textEdit_Alt_Acero);
            this.groupControl2.Controls.Add(this.textEdit_Diam_Boq_Dist);
            this.groupControl2.Controls.Add(this.labelContr_AA);
            this.groupControl2.Controls.Add(this.labelContr_DBD);
            this.groupControl2.Controls.Add(this.labelContr_Tecnologia2);
            this.groupControl2.Controls.Add(this.gridLookUpEdit_Tecnol_VC);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(386, 307);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Opciones";
            // 
            // checkEdit_Calc_Pers2
            // 
            this.checkEdit_Calc_Pers2.Location = new System.Drawing.Point(14, 163);
            this.checkEdit_Calc_Pers2.Name = "checkEdit_Calc_Pers2";
            this.checkEdit_Calc_Pers2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEdit_Calc_Pers2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Calc_Pers2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_Calc_Pers2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Calc_Pers2.Properties.RadioGroupIndex = 0;
            this.checkEdit_Calc_Pers2.Size = new System.Drawing.Size(166, 21);
            this.checkEdit_Calc_Pers2.TabIndex = 9;
            this.checkEdit_Calc_Pers2.TabStop = false;
            this.checkEdit_Calc_Pers2.Click += new System.EventHandler(this.checkEdit_Calc_Pers2_Click);
            // 
            // checkEdit_Cal_Anterior2
            // 
            this.checkEdit_Cal_Anterior2.EditValue = true;
            this.checkEdit_Cal_Anterior2.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_Cal_Anterior2.Name = "checkEdit_Cal_Anterior2";
            this.checkEdit_Cal_Anterior2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEdit_Cal_Anterior2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Cal_Anterior2.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_Cal_Anterior2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Cal_Anterior2.Properties.RadioGroupIndex = 2;
            this.checkEdit_Cal_Anterior2.Size = new System.Drawing.Size(180, 21);
            this.checkEdit_Cal_Anterior2.TabIndex = 8;
            this.checkEdit_Cal_Anterior2.Click += new System.EventHandler(this.checkEdit_Cal_Anterior2_Click);
            // 
            // textEdit_Alt_Acero
            // 
            this.textEdit_Alt_Acero.EditValue = "0";
            this.textEdit_Alt_Acero.Location = new System.Drawing.Point(233, 250);
            this.textEdit_Alt_Acero.Name = "textEdit_Alt_Acero";
            this.textEdit_Alt_Acero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Alt_Acero.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Alt_Acero.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Alt_Acero.TabIndex = 7;
            this.textEdit_Alt_Acero.EditValueChanged += new System.EventHandler(this.textEdit_Diam_Boq_Dist_EditValueChanged);
            // 
            // textEdit_Diam_Boq_Dist
            // 
            this.textEdit_Diam_Boq_Dist.EditValue = "0";
            this.textEdit_Diam_Boq_Dist.Location = new System.Drawing.Point(233, 200);
            this.textEdit_Diam_Boq_Dist.Name = "textEdit_Diam_Boq_Dist";
            this.textEdit_Diam_Boq_Dist.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Diam_Boq_Dist.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Diam_Boq_Dist.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Diam_Boq_Dist.TabIndex = 6;
            this.textEdit_Diam_Boq_Dist.EditValueChanged += new System.EventHandler(this.textEdit_Diam_Boq_Dist_EditValueChanged);
            // 
            // labelContr_AA
            // 
            this.labelContr_AA.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelContr_AA.Location = new System.Drawing.Point(16, 256);
            this.labelContr_AA.Name = "labelContr_AA";
            this.labelContr_AA.Size = new System.Drawing.Size(135, 16);
            this.labelContr_AA.TabIndex = 5;
            this.labelContr_AA.Text = "Altura del Acero en (m)";
            // 
            // labelContr_DBD
            // 
            this.labelContr_DBD.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelContr_DBD.Location = new System.Drawing.Point(16, 206);
            this.labelContr_DBD.Name = "labelContr_DBD";
            this.labelContr_DBD.Size = new System.Drawing.Size(211, 16);
            this.labelContr_DBD.TabIndex = 3;
            this.labelContr_DBD.Text = "Diámetro de Boquillas de Distribuidor";
            // 
            // labelContr_Tecnologia2
            // 
            this.labelContr_Tecnologia2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelContr_Tecnologia2.Enabled = false;
            this.labelContr_Tecnologia2.Location = new System.Drawing.Point(36, 76);
            this.labelContr_Tecnologia2.Name = "labelContr_Tecnologia2";
            this.labelContr_Tecnologia2.Size = new System.Drawing.Size(73, 16);
            this.labelContr_Tecnologia2.TabIndex = 1;
            this.labelContr_Tecnologia2.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_Tecnol_VC
            // 
            this.gridLookUpEdit_Tecnol_VC.Enabled = false;
            this.gridLookUpEdit_Tecnol_VC.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_Tecnol_VC.Name = "gridLookUpEdit_Tecnol_VC";
            this.gridLookUpEdit_Tecnol_VC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_Tecnol_VC.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_Tecnol_VC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_Tecnol_VC.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_Tecnol_VC.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_Tecnol_VC.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_Tecnol_VC.Properties.View = this.gridView2;
            this.gridLookUpEdit_Tecnol_VC.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_Tecnol_VC.TabIndex = 0;
            this.gridLookUpEdit_Tecnol_VC.EditValueChanged += new System.EventHandler(this.textEdit_Diam_Boq_Dist_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo1
            // 
            this.colcodigo1.Caption = "Codigo";
            this.colcodigo1.FieldName = "codigo";
            this.colcodigo1.Name = "colcodigo1";
            this.colcodigo1.Visible = true;
            this.colcodigo1.VisibleIndex = 0;
            // 
            // VEPage
            // 
            this.VEPage.Controls.Add(this.groupControl3);
            this.VEPage.Controls.Add(this.groupControl4);
            this.VEPage.DescriptionText = "Seleccione las opciones para calcular la Velocidad de Extracción";
            this.VEPage.Name = "VEPage";
            this.VEPage.Size = new System.Drawing.Size(662, 313);
            this.VEPage.Text = "Velocidad de Extracción";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.FCVelocidadExtraccion);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(395, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(264, 307);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Fórmula";
            // 
            // FCVelocidadExtraccion
            // 
            this.FCVelocidadExtraccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCVelocidadExtraccion.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCVelocidadExtraccion.FontColor = System.Drawing.Color.Black;
            this.FCVelocidadExtraccion.Location = new System.Drawing.Point(2, 24);
            this.FCVelocidadExtraccion.Name = "FCVelocidadExtraccion";
            this.FCVelocidadExtraccion.Separator = 10;
            this.FCVelocidadExtraccion.Size = new System.Drawing.Size(260, 281);
            this.FCVelocidadExtraccion.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(170, 246);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 19);
            this.labelControl3.TabIndex = 25;
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.checkEdit_VE_2);
            this.groupControl4.Controls.Add(this.checkEdit_VE_1);
            this.groupControl4.Controls.Add(this.labelControl_VE_1);
            this.groupControl4.Controls.Add(this.gridLookUpEdi_Velc_Extr);
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(386, 307);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Opciones";
            // 
            // checkEdit_VE_2
            // 
            this.checkEdit_VE_2.Location = new System.Drawing.Point(14, 163);
            this.checkEdit_VE_2.Name = "checkEdit_VE_2";
            this.checkEdit_VE_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEdit_VE_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_VE_2.Properties.Caption = "Tecnología Actual";
            this.checkEdit_VE_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_VE_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_VE_2.Properties.CheckedChanged += new System.EventHandler(this.gridLookUpEdi_Velc_Extr_Properties_EditValueChange);
            this.checkEdit_VE_2.Size = new System.Drawing.Size(179, 21);
            this.checkEdit_VE_2.TabIndex = 9;
            this.checkEdit_VE_2.TabStop = false;
            this.checkEdit_VE_2.Click += new System.EventHandler(this.checkEdit_VE_2_Click);
            // 
            // checkEdit_VE_1
            // 
            this.checkEdit_VE_1.EditValue = true;
            this.checkEdit_VE_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_VE_1.Name = "checkEdit_VE_1";
            this.checkEdit_VE_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEdit_VE_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_VE_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_VE_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_VE_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_VE_1.Properties.CheckedChanged += new System.EventHandler(this.gridLookUpEdi_Velc_Extr_Properties_EditValueChange);
            this.checkEdit_VE_1.Size = new System.Drawing.Size(179, 21);
            this.checkEdit_VE_1.TabIndex = 8;
            this.checkEdit_VE_1.Click += new System.EventHandler(this.checkEdit_VE_1_Click);
            // 
            // labelControl_VE_1
            // 
            this.labelControl_VE_1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl_VE_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_VE_1.Name = "labelControl_VE_1";
            this.labelControl_VE_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_VE_1.TabIndex = 1;
            this.labelControl_VE_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdi_Velc_Extr
            // 
            this.gridLookUpEdi_Velc_Extr.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdi_Velc_Extr.Name = "gridLookUpEdi_Velc_Extr";
            this.gridLookUpEdi_Velc_Extr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdi_Velc_Extr.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdi_Velc_Extr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdi_Velc_Extr.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdi_Velc_Extr.Properties.DisplayMember = "codigo";
            this.gridLookUpEdi_Velc_Extr.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdi_Velc_Extr.Properties.View = this.gridView3;
            this.gridLookUpEdi_Velc_Extr.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdi_Velc_Extr_Properties_EditValueChange);
            this.gridLookUpEdi_Velc_Extr.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdi_Velc_Extr.TabIndex = 0;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo2});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo2
            // 
            this.colcodigo2.Caption = "Codigo";
            this.colcodigo2.FieldName = "codigo";
            this.colcodigo2.Name = "colcodigo2";
            this.colcodigo2.Visible = true;
            this.colcodigo2.VisibleIndex = 0;
            // 
            // VPPage
            // 
            this.VPPage.Controls.Add(this.groupControl5);
            this.VPPage.Controls.Add(this.groupControl6);
            this.VPPage.DescriptionText = "Seleccione las opciones para calcular la Velocidad de producción";
            this.VPPage.Name = "VPPage";
            this.VPPage.Size = new System.Drawing.Size(662, 313);
            this.VPPage.Text = "Velocidad de Producción";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.FCVelocidadProduccion);
            this.groupControl5.Location = new System.Drawing.Point(395, 3);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(264, 307);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "Fórmula";
            // 
            // FCVelocidadProduccion
            // 
            this.FCVelocidadProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCVelocidadProduccion.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCVelocidadProduccion.FontColor = System.Drawing.Color.Black;
            this.FCVelocidadProduccion.Location = new System.Drawing.Point(2, 24);
            this.FCVelocidadProduccion.Name = "FCVelocidadProduccion";
            this.FCVelocidadProduccion.Separator = 10;
            this.FCVelocidadProduccion.Size = new System.Drawing.Size(260, 281);
            this.FCVelocidadProduccion.TabIndex = 30;
            // 
            // groupControl6
            // 
            this.groupControl6.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl6.AppearanceCaption.Options.UseFont = true;
            this.groupControl6.Controls.Add(this.checkEdit_Calc_Pers3);
            this.groupControl6.Controls.Add(this.checkEdit_Cal_Anterior3);
            this.groupControl6.Controls.Add(this.textEdit_lineas);
            this.groupControl6.Controls.Add(this.textEdit_Dens_Ace_Sol);
            this.groupControl6.Controls.Add(this.labelControl_NL);
            this.groupControl6.Controls.Add(this.labelControl_DAS);
            this.groupControl6.Controls.Add(this.labelContr_Tecnologia3);
            this.groupControl6.Controls.Add(this.gridLookUpEdit_Velc_Prod);
            this.groupControl6.Location = new System.Drawing.Point(3, 3);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(386, 307);
            this.groupControl6.TabIndex = 4;
            this.groupControl6.Text = "Opciones";
            // 
            // checkEdit_Calc_Pers3
            // 
            this.checkEdit_Calc_Pers3.Location = new System.Drawing.Point(14, 163);
            this.checkEdit_Calc_Pers3.Name = "checkEdit_Calc_Pers3";
            this.checkEdit_Calc_Pers3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Calc_Pers3.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Calc_Pers3.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_Calc_Pers3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Calc_Pers3.Properties.RadioGroupIndex = 0;
            this.checkEdit_Calc_Pers3.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_Calc_Pers3.TabIndex = 9;
            this.checkEdit_Calc_Pers3.TabStop = false;
            this.checkEdit_Calc_Pers3.Click += new System.EventHandler(this.checkEdit_Calc_Pers3_Click);
            // 
            // checkEdit_Cal_Anterior3
            // 
            this.checkEdit_Cal_Anterior3.EditValue = true;
            this.checkEdit_Cal_Anterior3.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_Cal_Anterior3.Name = "checkEdit_Cal_Anterior3";
            this.checkEdit_Cal_Anterior3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Cal_Anterior3.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Cal_Anterior3.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_Cal_Anterior3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Cal_Anterior3.Properties.RadioGroupIndex = 0;
            this.checkEdit_Cal_Anterior3.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_Cal_Anterior3.TabIndex = 8;
            this.checkEdit_Cal_Anterior3.Click += new System.EventHandler(this.checkEdit_Cal_Anterior3_Click);
            // 
            // textEdit_lineas
            // 
            this.textEdit_lineas.EditValue = "1";
            this.textEdit_lineas.Location = new System.Drawing.Point(233, 250);
            this.textEdit_lineas.Name = "textEdit_lineas";
            this.textEdit_lineas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_lineas.Properties.Appearance.Options.UseFont = true;
            this.textEdit_lineas.Size = new System.Drawing.Size(120, 22);
            this.textEdit_lineas.TabIndex = 7;
            this.textEdit_lineas.EditValueChanged += new System.EventHandler(this.textEdit_Dens_Ace_Sol_EditValueChanged);
            // 
            // textEdit_Dens_Ace_Sol
            // 
            this.textEdit_Dens_Ace_Sol.EditValue = "0";
            this.textEdit_Dens_Ace_Sol.Location = new System.Drawing.Point(233, 200);
            this.textEdit_Dens_Ace_Sol.Name = "textEdit_Dens_Ace_Sol";
            this.textEdit_Dens_Ace_Sol.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Dens_Ace_Sol.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Dens_Ace_Sol.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Dens_Ace_Sol.TabIndex = 6;
            this.textEdit_Dens_Ace_Sol.EditValueChanged += new System.EventHandler(this.textEdit_Dens_Ace_Sol_EditValueChanged);
            // 
            // labelControl_NL
            // 
            this.labelControl_NL.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_NL.Location = new System.Drawing.Point(16, 256);
            this.labelControl_NL.Name = "labelControl_NL";
            this.labelControl_NL.Size = new System.Drawing.Size(110, 16);
            this.labelControl_NL.TabIndex = 5;
            this.labelControl_NL.Text = "Número de Líeneas";
            // 
            // labelControl_DAS
            // 
            this.labelControl_DAS.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_DAS.Location = new System.Drawing.Point(16, 205);
            this.labelControl_DAS.Name = "labelControl_DAS";
            this.labelControl_DAS.Size = new System.Drawing.Size(154, 32);
            this.labelControl_DAS.TabIndex = 3;
            this.labelControl_DAS.Text = "Densidad del Acero Sólido: \r\nen (T/m³)";
            // 
            // labelContr_Tecnologia3
            // 
            this.labelContr_Tecnologia3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_Tecnologia3.Enabled = false;
            this.labelContr_Tecnologia3.Location = new System.Drawing.Point(36, 76);
            this.labelContr_Tecnologia3.Name = "labelContr_Tecnologia3";
            this.labelContr_Tecnologia3.Size = new System.Drawing.Size(73, 16);
            this.labelContr_Tecnologia3.TabIndex = 1;
            this.labelContr_Tecnologia3.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_Velc_Prod
            // 
            this.gridLookUpEdit_Velc_Prod.Enabled = false;
            this.gridLookUpEdit_Velc_Prod.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_Velc_Prod.Name = "gridLookUpEdit_Velc_Prod";
            this.gridLookUpEdit_Velc_Prod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_Velc_Prod.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_Velc_Prod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_Velc_Prod.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_Velc_Prod.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_Velc_Prod.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_Velc_Prod.Properties.View = this.gridView4;
            this.gridLookUpEdit_Velc_Prod.Properties.EditValueChanged += new System.EventHandler(this.textEdit_Dens_Ace_Sol_EditValueChanged);
            this.gridLookUpEdit_Velc_Prod.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_Velc_Prod.TabIndex = 0;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo3});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo3
            // 
            this.colcodigo3.FieldName = "codigo";
            this.colcodigo3.Name = "colcodigo3";
            this.colcodigo3.Visible = true;
            this.colcodigo3.VisibleIndex = 0;
            // 
            // TIPACPage
            // 
            this.TIPACPage.Controls.Add(this.groupControl7);
            this.TIPACPage.Controls.Add(this.groupControl8);
            this.TIPACPage.DescriptionText = "Seleccione las opciones para calcular el Tiempo de Permanencia del Acero en la Ca" +
                "zuela";
            this.TIPACPage.Name = "TIPACPage";
            this.TIPACPage.Size = new System.Drawing.Size(662, 313);
            this.TIPACPage.Text = "Tiempo de Permanencia del Acero en la Cazuela";
            // 
            // groupControl7
            // 
            this.groupControl7.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl7.AppearanceCaption.Options.UseFont = true;
            this.groupControl7.Controls.Add(this.FCTiempoPAC);
            this.groupControl7.Location = new System.Drawing.Point(395, 3);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(264, 307);
            this.groupControl7.TabIndex = 7;
            this.groupControl7.Text = "Fórmula";
            // 
            // FCTiempoPAC
            // 
            this.FCTiempoPAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCTiempoPAC.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCTiempoPAC.FontColor = System.Drawing.Color.Black;
            this.FCTiempoPAC.Location = new System.Drawing.Point(2, 24);
            this.FCTiempoPAC.Name = "FCTiempoPAC";
            this.FCTiempoPAC.Separator = 10;
            this.FCTiempoPAC.Size = new System.Drawing.Size(260, 281);
            this.FCTiempoPAC.TabIndex = 40;
            // 
            // groupControl8
            // 
            this.groupControl8.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl8.AppearanceCaption.Options.UseFont = true;
            this.groupControl8.Controls.Add(this.checkEdit_Calc_Pers4);
            this.groupControl8.Controls.Add(this.checkEdit_Cal_Anterior4);
            this.groupControl8.Controls.Add(this.textEdit_Num_L_C);
            this.groupControl8.Controls.Add(this.textEdit_Cant_AC_C);
            this.groupControl8.Controls.Add(this.labelContr_NLC);
            this.groupControl8.Controls.Add(this.labelContr_CAC);
            this.groupControl8.Controls.Add(this.labelContr_Tecnologia4);
            this.groupControl8.Controls.Add(this.gridLookUpEdit_TPAC);
            this.groupControl8.Location = new System.Drawing.Point(3, 3);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(386, 307);
            this.groupControl8.TabIndex = 6;
            this.groupControl8.Text = "Opciones";
            // 
            // checkEdit_Calc_Pers4
            // 
            this.checkEdit_Calc_Pers4.Location = new System.Drawing.Point(14, 163);
            this.checkEdit_Calc_Pers4.Name = "checkEdit_Calc_Pers4";
            this.checkEdit_Calc_Pers4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Calc_Pers4.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Calc_Pers4.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_Calc_Pers4.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Calc_Pers4.Properties.RadioGroupIndex = 0;
            this.checkEdit_Calc_Pers4.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_Calc_Pers4.TabIndex = 9;
            this.checkEdit_Calc_Pers4.TabStop = false;
            this.checkEdit_Calc_Pers4.Click += new System.EventHandler(this.checkEdit_Cal_Anterior4_Click);
            // 
            // checkEdit_Cal_Anterior4
            // 
            this.checkEdit_Cal_Anterior4.EditValue = true;
            this.checkEdit_Cal_Anterior4.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_Cal_Anterior4.Name = "checkEdit_Cal_Anterior4";
            this.checkEdit_Cal_Anterior4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Cal_Anterior4.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Cal_Anterior4.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_Cal_Anterior4.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Cal_Anterior4.Properties.RadioGroupIndex = 0;
            this.checkEdit_Cal_Anterior4.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_Cal_Anterior4.TabIndex = 8;
            this.checkEdit_Cal_Anterior4.Click += new System.EventHandler(this.checkEdit_Cal_Anterior4_Click);
            // 
            // textEdit_Num_L_C
            // 
            this.textEdit_Num_L_C.EditValue = "1";
            this.textEdit_Num_L_C.Location = new System.Drawing.Point(233, 250);
            this.textEdit_Num_L_C.Name = "textEdit_Num_L_C";
            this.textEdit_Num_L_C.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Num_L_C.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Num_L_C.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Num_L_C.TabIndex = 7;
            this.textEdit_Num_L_C.EditValueChanged += new System.EventHandler(this.textEdit_Cant_AC_C_EditValueChanged);
            // 
            // textEdit_Cant_AC_C
            // 
            this.textEdit_Cant_AC_C.EditValue = "0";
            this.textEdit_Cant_AC_C.Location = new System.Drawing.Point(233, 200);
            this.textEdit_Cant_AC_C.Name = "textEdit_Cant_AC_C";
            this.textEdit_Cant_AC_C.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Cant_AC_C.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Cant_AC_C.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Cant_AC_C.TabIndex = 6;
            this.textEdit_Cant_AC_C.EditValueChanged += new System.EventHandler(this.textEdit_Cant_AC_C_EditValueChanged);
            // 
            // labelContr_NLC
            // 
            this.labelContr_NLC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_NLC.Location = new System.Drawing.Point(16, 256);
            this.labelContr_NLC.Name = "labelContr_NLC";
            this.labelContr_NLC.Size = new System.Drawing.Size(160, 16);
            this.labelContr_NLC.TabIndex = 5;
            this.labelContr_NLC.Text = "Número de Líeneas Colando";
            // 
            // labelContr_CAC
            // 
            this.labelContr_CAC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_CAC.Location = new System.Drawing.Point(16, 203);
            this.labelContr_CAC.Name = "labelContr_CAC";
            this.labelContr_CAC.Size = new System.Drawing.Size(191, 32);
            this.labelContr_CAC.TabIndex = 3;
            this.labelContr_CAC.Text = "Cantidad de Acero en la Cazuela: \r\nen (T)";
            // 
            // labelContr_Tecnologia4
            // 
            this.labelContr_Tecnologia4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_Tecnologia4.Enabled = false;
            this.labelContr_Tecnologia4.Location = new System.Drawing.Point(36, 76);
            this.labelContr_Tecnologia4.Name = "labelContr_Tecnologia4";
            this.labelContr_Tecnologia4.Size = new System.Drawing.Size(73, 16);
            this.labelContr_Tecnologia4.TabIndex = 1;
            this.labelContr_Tecnologia4.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_TPAC
            // 
            this.gridLookUpEdit_TPAC.Enabled = false;
            this.gridLookUpEdit_TPAC.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_TPAC.Name = "gridLookUpEdit_TPAC";
            this.gridLookUpEdit_TPAC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_TPAC.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_TPAC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_TPAC.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_TPAC.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_TPAC.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_TPAC.Properties.View = this.gridView5;
            this.gridLookUpEdit_TPAC.Properties.EditValueChanged += new System.EventHandler(this.textEdit_Cant_AC_C_EditValueChanged);
            this.gridLookUpEdit_TPAC.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_TPAC.TabIndex = 0;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo4});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo4
            // 
            this.colcodigo4.Caption = "Codigo";
            this.colcodigo4.FieldName = "codigo";
            this.colcodigo4.Name = "colcodigo4";
            this.colcodigo4.Visible = true;
            this.colcodigo4.VisibleIndex = 0;
            // 
            // SOLDFPage
            // 
            this.SOLDFPage.Controls.Add(this.groupControl9);
            this.SOLDFPage.Controls.Add(this.groupControl10);
            this.SOLDFPage.DescriptionText = "Seleccione las opciones para calcular la Longitud Metalurgica Calculada";
            this.SOLDFPage.Name = "SOLDFPage";
            this.SOLDFPage.Size = new System.Drawing.Size(662, 313);
            this.SOLDFPage.Text = "Longitud Metalurgica Calculada";
            // 
            // groupControl9
            // 
            this.groupControl9.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl9.AppearanceCaption.Options.UseFont = true;
            this.groupControl9.Controls.Add(this.FCLongitud_M_calculada);
            this.groupControl9.Location = new System.Drawing.Point(395, 3);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(264, 307);
            this.groupControl9.TabIndex = 9;
            this.groupControl9.Text = "Fórmula";
            // 
            // FCLongitud_M_calculada
            // 
            this.FCLongitud_M_calculada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCLongitud_M_calculada.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCLongitud_M_calculada.FontColor = System.Drawing.Color.Black;
            this.FCLongitud_M_calculada.Location = new System.Drawing.Point(2, 24);
            this.FCLongitud_M_calculada.Name = "FCLongitud_M_calculada";
            this.FCLongitud_M_calculada.Separator = 10;
            this.FCLongitud_M_calculada.Size = new System.Drawing.Size(260, 281);
            this.FCLongitud_M_calculada.TabIndex = 42;
            // 
            // groupControl10
            // 
            this.groupControl10.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl10.AppearanceCaption.Options.UseFont = true;
            this.groupControl10.Controls.Add(this.checkEdit_LMAC_2);
            this.groupControl10.Controls.Add(this.checkEdit_LMAC_1);
            this.groupControl10.Controls.Add(this.labelControl_LMAC_1);
            this.groupControl10.Controls.Add(this.gridLookUpEdit_LMAC);
            this.groupControl10.Location = new System.Drawing.Point(3, 3);
            this.groupControl10.Name = "groupControl10";
            this.groupControl10.Size = new System.Drawing.Size(386, 307);
            this.groupControl10.TabIndex = 8;
            this.groupControl10.Text = "Opciones";
            // 
            // checkEdit_LMAC_2
            // 
            this.checkEdit_LMAC_2.Location = new System.Drawing.Point(14, 164);
            this.checkEdit_LMAC_2.Name = "checkEdit_LMAC_2";
            this.checkEdit_LMAC_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEdit_LMAC_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_LMAC_2.Properties.Caption = "Tecnología Actual";
            this.checkEdit_LMAC_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_LMAC_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_LMAC_2.Properties.CheckedChanged += new System.EventHandler(this.gridLookUpEdi_Velc_Extr_Properties_EditValueChange);
            this.checkEdit_LMAC_2.Size = new System.Drawing.Size(179, 21);
            this.checkEdit_LMAC_2.TabIndex = 10;
            this.checkEdit_LMAC_2.TabStop = false;
            this.checkEdit_LMAC_2.Click += new System.EventHandler(this.checkEdit_LMAC_2_Click);
            // 
            // checkEdit_LMAC_1
            // 
            this.checkEdit_LMAC_1.EditValue = true;
            this.checkEdit_LMAC_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_LMAC_1.Name = "checkEdit_LMAC_1";
            this.checkEdit_LMAC_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_LMAC_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_LMAC_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_LMAC_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_LMAC_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_LMAC_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_LMAC_1.TabIndex = 8;
            this.checkEdit_LMAC_1.Click += new System.EventHandler(this.checkEdit_SOLDF_1_Click);
            // 
            // labelControl_LMAC_1
            // 
            this.labelControl_LMAC_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_LMAC_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_LMAC_1.Name = "labelControl_LMAC_1";
            this.labelControl_LMAC_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_LMAC_1.TabIndex = 1;
            this.labelControl_LMAC_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_LMAC
            // 
            this.gridLookUpEdit_LMAC.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_LMAC.Name = "gridLookUpEdit_LMAC";
            this.gridLookUpEdit_LMAC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_LMAC.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_LMAC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_LMAC.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_LMAC.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_LMAC.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_LMAC.Properties.View = this.gridView6;
            this.gridLookUpEdit_LMAC.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_LMAC_Properties_EditValueChanged);
            this.gridLookUpEdit_LMAC.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_LMAC.TabIndex = 0;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo6});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo6
            // 
            this.colcodigo6.Caption = "Código";
            this.colcodigo6.FieldName = "codigo";
            this.colcodigo6.Name = "colcodigo6";
            this.colcodigo6.Visible = true;
            this.colcodigo6.VisibleIndex = 0;
            // 
            // CTTPage
            // 
            this.CTTPage.Controls.Add(this.groupControl13);
            this.CTTPage.Controls.Add(this.groupControl14);
            this.CTTPage.DescriptionText = "Seleccione las opciones para calcular el Calor Total Transferido";
            this.CTTPage.Name = "CTTPage";
            this.CTTPage.Size = new System.Drawing.Size(662, 313);
            this.CTTPage.Text = "Calor Total Transferido";
            // 
            // groupControl13
            // 
            this.groupControl13.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl13.AppearanceCaption.Options.UseFont = true;
            this.groupControl13.Controls.Add(this.FCCalorTotalTransferido);
            this.groupControl13.Location = new System.Drawing.Point(395, 3);
            this.groupControl13.Name = "groupControl13";
            this.groupControl13.Size = new System.Drawing.Size(264, 307);
            this.groupControl13.TabIndex = 11;
            this.groupControl13.Text = "Fórmula";
            // 
            // FCCalorTotalTransferido
            // 
            this.FCCalorTotalTransferido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCCalorTotalTransferido.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCCalorTotalTransferido.FontColor = System.Drawing.Color.Black;
            this.FCCalorTotalTransferido.Location = new System.Drawing.Point(2, 24);
            this.FCCalorTotalTransferido.Name = "FCCalorTotalTransferido";
            this.FCCalorTotalTransferido.Separator = 10;
            this.FCCalorTotalTransferido.Size = new System.Drawing.Size(260, 281);
            this.FCCalorTotalTransferido.TabIndex = 41;
            // 
            // groupControl14
            // 
            this.groupControl14.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl14.AppearanceCaption.Options.UseFont = true;
            this.groupControl14.Controls.Add(this.textEdit_DT_CTT);
            this.groupControl14.Controls.Add(this.labelControl56);
            this.groupControl14.Controls.Add(this.checkEdit1);
            this.groupControl14.Controls.Add(this.checkEdit2);
            this.groupControl14.Controls.Add(this.textEdit_GAP_CTT);
            this.groupControl14.Controls.Add(this.textEdit_Esp_Mold_CTT);
            this.groupControl14.Controls.Add(this.labelControl52);
            this.groupControl14.Controls.Add(this.labelControl53);
            this.groupControl14.Controls.Add(this.labelControl54);
            this.groupControl14.Controls.Add(this.gridLookUpEdit4);
            this.groupControl14.Location = new System.Drawing.Point(3, 3);
            this.groupControl14.Name = "groupControl14";
            this.groupControl14.Size = new System.Drawing.Size(386, 307);
            this.groupControl14.TabIndex = 10;
            this.groupControl14.Text = "Opciones";
            // 
            // textEdit_DT_CTT
            // 
            this.textEdit_DT_CTT.EditValue = "0";
            this.textEdit_DT_CTT.Location = new System.Drawing.Point(233, 226);
            this.textEdit_DT_CTT.Name = "textEdit_DT_CTT";
            this.textEdit_DT_CTT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_DT_CTT.Properties.Appearance.Options.UseFont = true;
            this.textEdit_DT_CTT.Size = new System.Drawing.Size(120, 22);
            this.textEdit_DT_CTT.TabIndex = 12;
            this.textEdit_DT_CTT.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // labelControl56
            // 
            this.labelControl56.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl56.Location = new System.Drawing.Point(16, 229);
            this.labelControl56.Name = "labelControl56";
            this.labelControl56.Size = new System.Drawing.Size(194, 32);
            this.labelControl56.TabIndex = 10;
            this.labelControl56.Text = "ΔT entre cráter líquido e interface \r\nagua molde";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(14, 130);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit1.Properties.RadioGroupIndex = 0;
            this.checkEdit1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit1.TabIndex = 9;
            this.checkEdit1.TabStop = false;
            this.checkEdit1.Click += new System.EventHandler(this.checkEdit2_Click);
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(14, 37);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit2.Properties.RadioGroupIndex = 0;
            this.checkEdit2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit2.TabIndex = 8;
            this.checkEdit2.Click += new System.EventHandler(this.checkEdit2_Click);
            // 
            // textEdit_GAP_CTT
            // 
            this.textEdit_GAP_CTT.EditValue = "0";
            this.textEdit_GAP_CTT.Location = new System.Drawing.Point(233, 198);
            this.textEdit_GAP_CTT.Name = "textEdit_GAP_CTT";
            this.textEdit_GAP_CTT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_GAP_CTT.Properties.Appearance.Options.UseFont = true;
            this.textEdit_GAP_CTT.Size = new System.Drawing.Size(120, 22);
            this.textEdit_GAP_CTT.TabIndex = 7;
            this.textEdit_GAP_CTT.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // textEdit_Esp_Mold_CTT
            // 
            this.textEdit_Esp_Mold_CTT.EditValue = "0";
            this.textEdit_Esp_Mold_CTT.Location = new System.Drawing.Point(233, 167);
            this.textEdit_Esp_Mold_CTT.Name = "textEdit_Esp_Mold_CTT";
            this.textEdit_Esp_Mold_CTT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Esp_Mold_CTT.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Esp_Mold_CTT.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Esp_Mold_CTT.TabIndex = 6;
            this.textEdit_Esp_Mold_CTT.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // labelControl52
            // 
            this.labelControl52.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl52.Location = new System.Drawing.Point(16, 201);
            this.labelControl52.Name = "labelControl52";
            this.labelControl52.Size = new System.Drawing.Size(155, 16);
            this.labelControl52.TabIndex = 5;
            this.labelControl52.Text = "Gap aire entre molde y piel";
            // 
            // labelControl53
            // 
            this.labelControl53.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl53.Location = new System.Drawing.Point(16, 170);
            this.labelControl53.Name = "labelControl53";
            this.labelControl53.Size = new System.Drawing.Size(104, 16);
            this.labelControl53.TabIndex = 3;
            this.labelControl53.Text = "Espesor del Molde";
            // 
            // labelControl54
            // 
            this.labelControl54.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl54.Enabled = false;
            this.labelControl54.Location = new System.Drawing.Point(36, 76);
            this.labelControl54.Name = "labelControl54";
            this.labelControl54.Size = new System.Drawing.Size(73, 16);
            this.labelControl54.TabIndex = 1;
            this.labelControl54.Text = "Tecnologías:";
            // 
            // gridLookUpEdit4
            // 
            this.gridLookUpEdit4.Enabled = false;
            this.gridLookUpEdit4.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit4.Name = "gridLookUpEdit4";
            this.gridLookUpEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit4.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit4.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit4.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit4.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit4.Properties.View = this.gridView8;
            this.gridLookUpEdit4.Properties.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            this.gridLookUpEdit4.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit4.TabIndex = 0;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo7});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo7
            // 
            this.colcodigo7.FieldName = "codigo";
            this.colcodigo7.Name = "colcodigo7";
            this.colcodigo7.Visible = true;
            this.colcodigo7.VisibleIndex = 0;
            // 
            // CMAEPage
            // 
            this.CMAEPage.Controls.Add(this.groupControl15);
            this.CMAEPage.Controls.Add(this.groupControl16);
            this.CMAEPage.DescriptionText = "Seleccione las opciones para calcular la Cantidad Maxima de agua de Enfriamiento";
            this.CMAEPage.Name = "CMAEPage";
            this.CMAEPage.Size = new System.Drawing.Size(662, 313);
            this.CMAEPage.Text = "Cantidad Maxima de agua de Enfriamiento";
            // 
            // groupControl15
            // 
            this.groupControl15.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl15.AppearanceCaption.Options.UseFont = true;
            this.groupControl15.Controls.Add(this.FCCant_Max_AE);
            this.groupControl15.Location = new System.Drawing.Point(395, 3);
            this.groupControl15.Name = "groupControl15";
            this.groupControl15.Size = new System.Drawing.Size(264, 307);
            this.groupControl15.TabIndex = 13;
            this.groupControl15.Text = "Fórmula";
            // 
            // FCCant_Max_AE
            // 
            this.FCCant_Max_AE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCCant_Max_AE.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCCant_Max_AE.FontColor = System.Drawing.Color.Black;
            this.FCCant_Max_AE.Location = new System.Drawing.Point(2, 24);
            this.FCCant_Max_AE.Name = "FCCant_Max_AE";
            this.FCCant_Max_AE.Separator = 10;
            this.FCCant_Max_AE.Size = new System.Drawing.Size(260, 281);
            this.FCCant_Max_AE.TabIndex = 42;
            // 
            // groupControl16
            // 
            this.groupControl16.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl16.AppearanceCaption.Options.UseFont = true;
            this.groupControl16.Controls.Add(this.textEdit2);
            this.groupControl16.Controls.Add(this.labelControl2);
            this.groupControl16.Controls.Add(this.checkEdit_CAME_2);
            this.groupControl16.Controls.Add(this.checkEdit_CAME_1);
            this.groupControl16.Controls.Add(this.textEdit_Calor_Esp_Agu);
            this.groupControl16.Controls.Add(this.labelControl64);
            this.groupControl16.Controls.Add(this.labelControl65);
            this.groupControl16.Controls.Add(this.gridLookUpEdit_CMAE);
            this.groupControl16.Location = new System.Drawing.Point(3, 3);
            this.groupControl16.Name = "groupControl16";
            this.groupControl16.Size = new System.Drawing.Size(386, 307);
            this.groupControl16.TabIndex = 12;
            this.groupControl16.Text = "Opciones";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "0";
            this.textEdit2.Location = new System.Drawing.Point(233, 210);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(120, 22);
            this.textEdit2.TabIndex = 11;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 216);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Temperatura";
            // 
            // checkEdit_CAME_2
            // 
            this.checkEdit_CAME_2.Location = new System.Drawing.Point(14, 130);
            this.checkEdit_CAME_2.Name = "checkEdit_CAME_2";
            this.checkEdit_CAME_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_CAME_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_CAME_2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_CAME_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_CAME_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_CAME_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_CAME_2.TabIndex = 9;
            this.checkEdit_CAME_2.TabStop = false;
            this.checkEdit_CAME_2.Click += new System.EventHandler(this.checkEdit5_Click);
            // 
            // checkEdit_CAME_1
            // 
            this.checkEdit_CAME_1.EditValue = true;
            this.checkEdit_CAME_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_CAME_1.Name = "checkEdit_CAME_1";
            this.checkEdit_CAME_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_CAME_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_CAME_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_CAME_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_CAME_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_CAME_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_CAME_1.TabIndex = 8;
            this.checkEdit_CAME_1.Click += new System.EventHandler(this.checkEdit5_Click);
            // 
            // textEdit_Calor_Esp_Agu
            // 
            this.textEdit_Calor_Esp_Agu.EditValue = "0";
            this.textEdit_Calor_Esp_Agu.Location = new System.Drawing.Point(233, 167);
            this.textEdit_Calor_Esp_Agu.Name = "textEdit_Calor_Esp_Agu";
            this.textEdit_Calor_Esp_Agu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Calor_Esp_Agu.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Calor_Esp_Agu.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Calor_Esp_Agu.TabIndex = 6;
            this.textEdit_Calor_Esp_Agu.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // labelControl64
            // 
            this.labelControl64.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl64.Location = new System.Drawing.Point(16, 170);
            this.labelControl64.Name = "labelControl64";
            this.labelControl64.Size = new System.Drawing.Size(144, 16);
            this.labelControl64.TabIndex = 3;
            this.labelControl64.Text = "Calor Específico del Agua";
            // 
            // labelControl65
            // 
            this.labelControl65.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl65.Enabled = false;
            this.labelControl65.Location = new System.Drawing.Point(36, 76);
            this.labelControl65.Name = "labelControl65";
            this.labelControl65.Size = new System.Drawing.Size(73, 16);
            this.labelControl65.TabIndex = 1;
            this.labelControl65.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_CMAE
            // 
            this.gridLookUpEdit_CMAE.Enabled = false;
            this.gridLookUpEdit_CMAE.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_CMAE.Name = "gridLookUpEdit_CMAE";
            this.gridLookUpEdit_CMAE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_CMAE.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_CMAE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_CMAE.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_CMAE.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_CMAE.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_CMAE.Properties.View = this.gridView9;
            this.gridLookUpEdit_CMAE.Properties.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            this.gridLookUpEdit_CMAE.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_CMAE.TabIndex = 0;
            this.gridLookUpEdit_CMAE.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo8});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo8
            // 
            this.colcodigo8.FieldName = "codigo";
            this.colcodigo8.Name = "colcodigo8";
            this.colcodigo8.Visible = true;
            this.colcodigo8.VisibleIndex = 0;
            // 
            // TIPADPage
            // 
            this.TIPADPage.Controls.Add(this.groupControl11);
            this.TIPADPage.Controls.Add(this.groupControl12);
            this.TIPADPage.DescriptionText = "Seleccione las opciones para calcular el Tiempo de Permanencia del Acero en el Di" +
                "stribuidor";
            this.TIPADPage.Name = "TIPADPage";
            this.TIPADPage.Size = new System.Drawing.Size(662, 313);
            this.TIPADPage.Text = "Teimpo de Permanecia del Acero en el Distribuidor";
            // 
            // groupControl11
            // 
            this.groupControl11.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl11.AppearanceCaption.Options.UseFont = true;
            this.groupControl11.Controls.Add(this.FCTiempoRAD);
            this.groupControl11.Location = new System.Drawing.Point(395, 3);
            this.groupControl11.Name = "groupControl11";
            this.groupControl11.Size = new System.Drawing.Size(264, 307);
            this.groupControl11.TabIndex = 9;
            this.groupControl11.Text = "Fórmula";
            // 
            // FCTiempoRAD
            // 
            this.FCTiempoRAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCTiempoRAD.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCTiempoRAD.FontColor = System.Drawing.Color.Black;
            this.FCTiempoRAD.Location = new System.Drawing.Point(2, 24);
            this.FCTiempoRAD.Name = "FCTiempoRAD";
            this.FCTiempoRAD.Separator = 10;
            this.FCTiempoRAD.Size = new System.Drawing.Size(260, 281);
            this.FCTiempoRAD.TabIndex = 40;
            // 
            // groupControl12
            // 
            this.groupControl12.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl12.AppearanceCaption.Options.UseFont = true;
            this.groupControl12.Controls.Add(this.checkEdit_Calc_Pers5);
            this.groupControl12.Controls.Add(this.checkEdit__Calc_Anterior5);
            this.groupControl12.Controls.Add(this.textEdit_Num_L_D);
            this.groupControl12.Controls.Add(this.textEdit_Cant_AC_D);
            this.groupControl12.Controls.Add(this.labelContr_NLC2);
            this.groupControl12.Controls.Add(this.labelContr_CAD);
            this.groupControl12.Controls.Add(this.labelContr_Tecnologia5);
            this.groupControl12.Controls.Add(this.gridLookUpEdit_TPAD);
            this.groupControl12.Location = new System.Drawing.Point(3, 3);
            this.groupControl12.Name = "groupControl12";
            this.groupControl12.Size = new System.Drawing.Size(386, 307);
            this.groupControl12.TabIndex = 8;
            this.groupControl12.Text = "Opciones";
            // 
            // checkEdit_Calc_Pers5
            // 
            this.checkEdit_Calc_Pers5.Location = new System.Drawing.Point(14, 163);
            this.checkEdit_Calc_Pers5.Name = "checkEdit_Calc_Pers5";
            this.checkEdit_Calc_Pers5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_Calc_Pers5.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_Calc_Pers5.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_Calc_Pers5.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_Calc_Pers5.Properties.RadioGroupIndex = 0;
            this.checkEdit_Calc_Pers5.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_Calc_Pers5.TabIndex = 9;
            this.checkEdit_Calc_Pers5.TabStop = false;
            this.checkEdit_Calc_Pers5.Click += new System.EventHandler(this.checkEdit_Calc_Pers5_Click);
            // 
            // checkEdit__Calc_Anterior5
            // 
            this.checkEdit__Calc_Anterior5.EditValue = true;
            this.checkEdit__Calc_Anterior5.Location = new System.Drawing.Point(14, 37);
            this.checkEdit__Calc_Anterior5.Name = "checkEdit__Calc_Anterior5";
            this.checkEdit__Calc_Anterior5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit__Calc_Anterior5.Properties.Appearance.Options.UseFont = true;
            this.checkEdit__Calc_Anterior5.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit__Calc_Anterior5.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit__Calc_Anterior5.Properties.RadioGroupIndex = 0;
            this.checkEdit__Calc_Anterior5.Size = new System.Drawing.Size(171, 21);
            this.checkEdit__Calc_Anterior5.TabIndex = 8;
            this.checkEdit__Calc_Anterior5.Click += new System.EventHandler(this.checkEdit__Calc_Anterior5_Click);
            // 
            // textEdit_Num_L_D
            // 
            this.textEdit_Num_L_D.EditValue = "1";
            this.textEdit_Num_L_D.Location = new System.Drawing.Point(233, 250);
            this.textEdit_Num_L_D.Name = "textEdit_Num_L_D";
            this.textEdit_Num_L_D.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Num_L_D.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Num_L_D.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Num_L_D.TabIndex = 7;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.textEdit_Num_L_D, conditionValidationRule3);
            this.textEdit_Num_L_D.EditValueChanged += new System.EventHandler(this.textEdit_Cant_AC_D_EditValueChanged);
            // 
            // textEdit_Cant_AC_D
            // 
            this.textEdit_Cant_AC_D.EditValue = "0";
            this.textEdit_Cant_AC_D.Location = new System.Drawing.Point(233, 200);
            this.textEdit_Cant_AC_D.Name = "textEdit_Cant_AC_D";
            this.textEdit_Cant_AC_D.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Cant_AC_D.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Cant_AC_D.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Cant_AC_D.TabIndex = 6;
            this.textEdit_Cant_AC_D.EditValueChanged += new System.EventHandler(this.textEdit_Cant_AC_D_EditValueChanged);
            // 
            // labelContr_NLC2
            // 
            this.labelContr_NLC2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_NLC2.Location = new System.Drawing.Point(16, 256);
            this.labelContr_NLC2.Name = "labelContr_NLC2";
            this.labelContr_NLC2.Size = new System.Drawing.Size(160, 16);
            this.labelContr_NLC2.TabIndex = 5;
            this.labelContr_NLC2.Text = "Número de Líeneas Colando";
            // 
            // labelContr_CAD
            // 
            this.labelContr_CAD.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_CAD.Location = new System.Drawing.Point(16, 203);
            this.labelContr_CAD.Name = "labelContr_CAD";
            this.labelContr_CAD.Size = new System.Drawing.Size(211, 32);
            this.labelContr_CAD.TabIndex = 3;
            this.labelContr_CAD.Text = "Cantidad de Acero en el Distribiudor: \r\nen (T)";
            // 
            // labelContr_Tecnologia5
            // 
            this.labelContr_Tecnologia5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr_Tecnologia5.Enabled = false;
            this.labelContr_Tecnologia5.Location = new System.Drawing.Point(36, 76);
            this.labelContr_Tecnologia5.Name = "labelContr_Tecnologia5";
            this.labelContr_Tecnologia5.Size = new System.Drawing.Size(73, 16);
            this.labelContr_Tecnologia5.TabIndex = 1;
            this.labelContr_Tecnologia5.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_TPAD
            // 
            this.gridLookUpEdit_TPAD.Enabled = false;
            this.gridLookUpEdit_TPAD.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_TPAD.Name = "gridLookUpEdit_TPAD";
            this.gridLookUpEdit_TPAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_TPAD.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_TPAD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_TPAD.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_TPAD.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_TPAD.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_TPAD.Properties.View = this.gridView7;
            this.gridLookUpEdit_TPAD.Properties.EditValueChanged += new System.EventHandler(this.textEdit_Cant_AC_D_EditValueChanged);
            this.gridLookUpEdit_TPAD.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_TPAD.TabIndex = 0;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo5});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo5
            // 
            this.colcodigo5.Caption = "Código";
            this.colcodigo5.FieldName = "codigo";
            this.colcodigo5.Name = "colcodigo5";
            this.colcodigo5.Visible = true;
            this.colcodigo5.VisibleIndex = 0;
            // 
            // VMAPage
            // 
            this.VMAPage.Controls.Add(this.groupControl17);
            this.VMAPage.Controls.Add(this.groupControl18);
            this.VMAPage.DescriptionText = "Seleccione las opciones para calcular la Velocidad Máxima de Enfriamiento";
            this.VMAPage.Name = "VMAPage";
            this.VMAPage.Size = new System.Drawing.Size(662, 313);
            this.VMAPage.Text = "Velocidad Máxima de Enfriamiento";
            // 
            // groupControl17
            // 
            this.groupControl17.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl17.AppearanceCaption.Options.UseFont = true;
            this.groupControl17.Controls.Add(this.FCVMA);
            this.groupControl17.Location = new System.Drawing.Point(395, 3);
            this.groupControl17.Name = "groupControl17";
            this.groupControl17.Size = new System.Drawing.Size(264, 307);
            this.groupControl17.TabIndex = 15;
            this.groupControl17.Text = "Fórmula";
            // 
            // FCVMA
            // 
            this.FCVMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCVMA.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCVMA.FontColor = System.Drawing.Color.Black;
            this.FCVMA.Location = new System.Drawing.Point(2, 24);
            this.FCVMA.Name = "FCVMA";
            this.FCVMA.Separator = 10;
            this.FCVMA.Size = new System.Drawing.Size(260, 281);
            this.FCVMA.TabIndex = 42;
            // 
            // groupControl18
            // 
            this.groupControl18.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl18.AppearanceCaption.Options.UseFont = true;
            this.groupControl18.Controls.Add(this.gridLookUpEdit_Area_Circulacion);
            this.groupControl18.Controls.Add(this.labelControl_Area_Circulacion);
            this.groupControl18.Controls.Add(this.checkEdit_VMA_2);
            this.groupControl18.Controls.Add(this.checkEdit_VMA_1);
            this.groupControl18.Controls.Add(this.textEdit_Caudal_Agua);
            this.groupControl18.Controls.Add(this.labelControl_VMA_CA);
            this.groupControl18.Controls.Add(this.labelControl_Tecnologia_VMA);
            this.groupControl18.Controls.Add(this.gridLookUpEdit_VMA);
            this.groupControl18.Location = new System.Drawing.Point(3, 3);
            this.groupControl18.Name = "groupControl18";
            this.groupControl18.Size = new System.Drawing.Size(386, 307);
            this.groupControl18.TabIndex = 14;
            this.groupControl18.Text = "Opciones";
            // 
            // gridLookUpEdit_Area_Circulacion
            // 
            this.gridLookUpEdit_Area_Circulacion.EditValue = "0";
            this.gridLookUpEdit_Area_Circulacion.Location = new System.Drawing.Point(233, 215);
            this.gridLookUpEdit_Area_Circulacion.Name = "gridLookUpEdit_Area_Circulacion";
            this.gridLookUpEdit_Area_Circulacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_Area_Circulacion.Properties.DataSource = this.tCirculacionAMBindingSource;
            this.gridLookUpEdit_Area_Circulacion.Properties.DisplayMember = "area_circulacion";
            this.gridLookUpEdit_Area_Circulacion.Properties.NullText = "0";
            this.gridLookUpEdit_Area_Circulacion.Properties.ValueMember = "area_circulacion";
            this.gridLookUpEdit_Area_Circulacion.Properties.View = this.gridLookUpEdit8View;
            this.gridLookUpEdit_Area_Circulacion.Size = new System.Drawing.Size(120, 20);
            this.gridLookUpEdit_Area_Circulacion.TabIndex = 11;
            this.gridLookUpEdit_Area_Circulacion.EditValueChanged += new System.EventHandler(this.textEdit_Caudal_Agua_EditValueChanged);
            // 
            // tCirculacionAMBindingSource
            // 
            this.tCirculacionAMBindingSource.DataMember = "T_Circulacion_AM";
            this.tCirculacionAMBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit8View
            // 
            this.gridLookUpEdit8View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colarea_circulacion});
            this.gridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit8View.Name = "gridLookUpEdit8View";
            this.gridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit8View.OptionsView.ShowGroupPanel = false;
            // 
            // colarea_circulacion
            // 
            this.colarea_circulacion.Caption = "Area de Circulación";
            this.colarea_circulacion.FieldName = "area_circulacion";
            this.colarea_circulacion.Name = "colarea_circulacion";
            this.colarea_circulacion.Visible = true;
            this.colarea_circulacion.VisibleIndex = 0;
            // 
            // labelControl_Area_Circulacion
            // 
            this.labelControl_Area_Circulacion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Area_Circulacion.Location = new System.Drawing.Point(16, 216);
            this.labelControl_Area_Circulacion.Name = "labelControl_Area_Circulacion";
            this.labelControl_Area_Circulacion.Size = new System.Drawing.Size(143, 16);
            this.labelControl_Area_Circulacion.TabIndex = 10;
            this.labelControl_Area_Circulacion.Text = "Area de Circulación (m2)";
            // 
            // checkEdit_VMA_2
            // 
            this.checkEdit_VMA_2.Location = new System.Drawing.Point(14, 130);
            this.checkEdit_VMA_2.Name = "checkEdit_VMA_2";
            this.checkEdit_VMA_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_VMA_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_VMA_2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_VMA_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_VMA_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_VMA_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_VMA_2.TabIndex = 9;
            this.checkEdit_VMA_2.TabStop = false;
            this.checkEdit_VMA_2.Click += new System.EventHandler(this.checkEdit_VMA_1_Click);
            // 
            // checkEdit_VMA_1
            // 
            this.checkEdit_VMA_1.EditValue = true;
            this.checkEdit_VMA_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_VMA_1.Name = "checkEdit_VMA_1";
            this.checkEdit_VMA_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_VMA_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_VMA_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_VMA_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_VMA_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_VMA_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_VMA_1.TabIndex = 8;
            this.checkEdit_VMA_1.Click += new System.EventHandler(this.checkEdit_VMA_1_Click);
            // 
            // textEdit_Caudal_Agua
            // 
            this.textEdit_Caudal_Agua.EditValue = "0";
            this.textEdit_Caudal_Agua.Location = new System.Drawing.Point(233, 167);
            this.textEdit_Caudal_Agua.Name = "textEdit_Caudal_Agua";
            this.textEdit_Caudal_Agua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_Caudal_Agua.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Caudal_Agua.Size = new System.Drawing.Size(120, 22);
            this.textEdit_Caudal_Agua.TabIndex = 6;
            this.textEdit_Caudal_Agua.EditValueChanged += new System.EventHandler(this.textEdit_Caudal_Agua_EditValueChanged);
            // 
            // labelControl_VMA_CA
            // 
            this.labelControl_VMA_CA.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_VMA_CA.Location = new System.Drawing.Point(16, 170);
            this.labelControl_VMA_CA.Name = "labelControl_VMA_CA";
            this.labelControl_VMA_CA.Size = new System.Drawing.Size(93, 16);
            this.labelControl_VMA_CA.TabIndex = 3;
            this.labelControl_VMA_CA.Text = "Caudal del Agua";
            // 
            // labelControl_Tecnologia_VMA
            // 
            this.labelControl_Tecnologia_VMA.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Tecnologia_VMA.Enabled = false;
            this.labelControl_Tecnologia_VMA.Location = new System.Drawing.Point(36, 76);
            this.labelControl_Tecnologia_VMA.Name = "labelControl_Tecnologia_VMA";
            this.labelControl_Tecnologia_VMA.Size = new System.Drawing.Size(73, 16);
            this.labelControl_Tecnologia_VMA.TabIndex = 1;
            this.labelControl_Tecnologia_VMA.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_VMA
            // 
            this.gridLookUpEdit_VMA.Enabled = false;
            this.gridLookUpEdit_VMA.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_VMA.Name = "gridLookUpEdit_VMA";
            this.gridLookUpEdit_VMA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_VMA.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_VMA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_VMA.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_VMA.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_VMA.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_VMA.Properties.View = this.gridView10;
            this.gridLookUpEdit_VMA.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit6_Properties_EditValueChanged);
            this.gridLookUpEdit_VMA.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_VMA.TabIndex = 0;
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // EPPaje
            // 
            this.EPPaje.Controls.Add(this.groupControl19);
            this.EPPaje.Controls.Add(this.groupControl20);
            this.EPPaje.DescriptionText = "Seleccione las opciones para calcular el calor necesario para solidificar la capa" +
                "";
            this.EPPaje.Name = "EPPaje";
            this.EPPaje.Size = new System.Drawing.Size(662, 313);
            this.EPPaje.Text = "Espesor de la Piel";
            // 
            // groupControl19
            // 
            this.groupControl19.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl19.AppearanceCaption.Options.UseFont = true;
            this.groupControl19.Controls.Add(this.FCEP);
            this.groupControl19.Location = new System.Drawing.Point(395, 3);
            this.groupControl19.Name = "groupControl19";
            this.groupControl19.Size = new System.Drawing.Size(264, 307);
            this.groupControl19.TabIndex = 13;
            this.groupControl19.Text = "Fórmula";
            // 
            // FCEP
            // 
            this.FCEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCEP.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCEP.FontColor = System.Drawing.Color.Black;
            this.FCEP.Location = new System.Drawing.Point(2, 24);
            this.FCEP.Name = "FCEP";
            this.FCEP.Separator = 10;
            this.FCEP.Size = new System.Drawing.Size(260, 281);
            this.FCEP.TabIndex = 41;
            // 
            // groupControl20
            // 
            this.groupControl20.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl20.AppearanceCaption.Options.UseFont = true;
            this.groupControl20.Controls.Add(this.checkEdit_EP_2);
            this.groupControl20.Controls.Add(this.checkEdit_EP_1);
            this.groupControl20.Controls.Add(this.labelControl_EP_1);
            this.groupControl20.Controls.Add(this.gridLookUpEdit_EP);
            this.groupControl20.Location = new System.Drawing.Point(3, 3);
            this.groupControl20.Name = "groupControl20";
            this.groupControl20.Size = new System.Drawing.Size(386, 307);
            this.groupControl20.TabIndex = 12;
            this.groupControl20.Text = "Opciones";
            // 
            // checkEdit_EP_2
            // 
            this.checkEdit_EP_2.Location = new System.Drawing.Point(14, 143);
            this.checkEdit_EP_2.Name = "checkEdit_EP_2";
            this.checkEdit_EP_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_EP_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_EP_2.Properties.Caption = "Tecnológia Actual";
            this.checkEdit_EP_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_EP_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_EP_2.Properties.CheckedChanged += new System.EventHandler(this.gridLookUpEdit_EP_Properties_EditValueChanged);
            this.checkEdit_EP_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_EP_2.TabIndex = 9;
            this.checkEdit_EP_2.TabStop = false;
            this.checkEdit_EP_2.Click += new System.EventHandler(this.checkEdit_EP_2_Click);
            // 
            // checkEdit_EP_1
            // 
            this.checkEdit_EP_1.EditValue = true;
            this.checkEdit_EP_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_EP_1.Name = "checkEdit_EP_1";
            this.checkEdit_EP_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_EP_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_EP_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_EP_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_EP_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_EP_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_EP_1.TabIndex = 8;
            this.checkEdit_EP_1.Click += new System.EventHandler(this.checkEdit_EP_1_Click);
            // 
            // labelControl_EP_1
            // 
            this.labelControl_EP_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_EP_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_EP_1.Name = "labelControl_EP_1";
            this.labelControl_EP_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_EP_1.TabIndex = 1;
            this.labelControl_EP_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_EP
            // 
            this.gridLookUpEdit_EP.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_EP.Name = "gridLookUpEdit_EP";
            this.gridLookUpEdit_EP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_EP.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_EP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_EP.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_EP.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_EP.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_EP.Properties.View = this.gridView11;
            this.gridLookUpEdit_EP.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_EP_Properties_EditValueChanged);
            this.gridLookUpEdit_EP.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_EP.TabIndex = 0;
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "codigo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // OMPage
            // 
            this.OMPage.Controls.Add(this.groupControl21);
            this.OMPage.Controls.Add(this.groupControl22);
            this.OMPage.DescriptionText = "Seleccione las opciones para calcular la Oscilación del Molde";
            this.OMPage.Name = "OMPage";
            this.OMPage.Size = new System.Drawing.Size(662, 313);
            this.OMPage.Text = "Oscilación del Molde";
            // 
            // groupControl21
            // 
            this.groupControl21.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl21.AppearanceCaption.Options.UseFont = true;
            this.groupControl21.Controls.Add(this.FCOM);
            this.groupControl21.Location = new System.Drawing.Point(395, 3);
            this.groupControl21.Name = "groupControl21";
            this.groupControl21.Size = new System.Drawing.Size(264, 307);
            this.groupControl21.TabIndex = 17;
            this.groupControl21.Text = "Fórmula";
            // 
            // FCOM
            // 
            this.FCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCOM.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCOM.FontColor = System.Drawing.Color.Black;
            this.FCOM.Location = new System.Drawing.Point(2, 24);
            this.FCOM.Name = "FCOM";
            this.FCOM.Separator = 10;
            this.FCOM.Size = new System.Drawing.Size(260, 281);
            this.FCOM.TabIndex = 42;
            // 
            // groupControl22
            // 
            this.groupControl22.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl22.AppearanceCaption.Options.UseFont = true;
            this.groupControl22.Controls.Add(this.checkEdit_OM_2);
            this.groupControl22.Controls.Add(this.checkEdit_OM_1);
            this.groupControl22.Controls.Add(this.textEdit_OM);
            this.groupControl22.Controls.Add(this.labelControl_OM_2);
            this.groupControl22.Controls.Add(this.labelControl_OM_1);
            this.groupControl22.Controls.Add(this.gridLookUpEdit_OM_1);
            this.groupControl22.Location = new System.Drawing.Point(3, 3);
            this.groupControl22.Name = "groupControl22";
            this.groupControl22.Size = new System.Drawing.Size(386, 307);
            this.groupControl22.TabIndex = 16;
            this.groupControl22.Text = "Opciones";
            // 
            // checkEdit_OM_2
            // 
            this.checkEdit_OM_2.Location = new System.Drawing.Point(14, 130);
            this.checkEdit_OM_2.Name = "checkEdit_OM_2";
            this.checkEdit_OM_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_OM_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_OM_2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_OM_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_OM_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_OM_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_OM_2.TabIndex = 9;
            this.checkEdit_OM_2.TabStop = false;
            this.checkEdit_OM_2.Click += new System.EventHandler(this.checkEdit_OM_2_Click);
            // 
            // checkEdit_OM_1
            // 
            this.checkEdit_OM_1.EditValue = true;
            this.checkEdit_OM_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_OM_1.Name = "checkEdit_OM_1";
            this.checkEdit_OM_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_OM_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_OM_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_OM_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_OM_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_OM_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_OM_1.TabIndex = 8;
            this.checkEdit_OM_1.Click += new System.EventHandler(this.checkEdit_OM_1_Click);
            // 
            // textEdit_OM
            // 
            this.textEdit_OM.EditValue = "0";
            this.textEdit_OM.Location = new System.Drawing.Point(233, 167);
            this.textEdit_OM.Name = "textEdit_OM";
            this.textEdit_OM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_OM.Properties.Appearance.Options.UseFont = true;
            this.textEdit_OM.Size = new System.Drawing.Size(120, 22);
            this.textEdit_OM.TabIndex = 6;
            this.textEdit_OM.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_OM_1_Properties_EditValueChanged);
            // 
            // labelControl_OM_2
            // 
            this.labelControl_OM_2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_OM_2.Location = new System.Drawing.Point(36, 170);
            this.labelControl_OM_2.Name = "labelControl_OM_2";
            this.labelControl_OM_2.Size = new System.Drawing.Size(139, 16);
            this.labelControl_OM_2.TabIndex = 3;
            this.labelControl_OM_2.Text = "Carrera del Molde (mm)";
            // 
            // labelControl_OM_1
            // 
            this.labelControl_OM_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_OM_1.Enabled = false;
            this.labelControl_OM_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_OM_1.Name = "labelControl_OM_1";
            this.labelControl_OM_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_OM_1.TabIndex = 1;
            this.labelControl_OM_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_OM_1
            // 
            this.gridLookUpEdit_OM_1.Enabled = false;
            this.gridLookUpEdit_OM_1.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_OM_1.Name = "gridLookUpEdit_OM_1";
            this.gridLookUpEdit_OM_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_OM_1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_OM_1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_OM_1.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_OM_1.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_OM_1.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_OM_1.Properties.View = this.gridView13;
            this.gridLookUpEdit_OM_1.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_OM_1_Properties_EditValueChanged);
            this.gridLookUpEdit_OM_1.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_OM_1.TabIndex = 0;
            // 
            // gridView13
            // 
            this.gridView13.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.gridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView13.Name = "gridView13";
            this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView13.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "codigo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // TSPage
            // 
            this.TSPage.Controls.Add(this.groupControl23);
            this.TSPage.Controls.Add(this.groupControl24);
            this.TSPage.DescriptionText = "Seleccione las opciones para calcular el Tiempo de Sanado";
            this.TSPage.Name = "TSPage";
            this.TSPage.Size = new System.Drawing.Size(662, 313);
            this.TSPage.Text = "Tiempo de Sanado";
            // 
            // groupControl23
            // 
            this.groupControl23.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl23.AppearanceCaption.Options.UseFont = true;
            this.groupControl23.Controls.Add(this.FCTS);
            this.groupControl23.Location = new System.Drawing.Point(395, 3);
            this.groupControl23.Name = "groupControl23";
            this.groupControl23.Size = new System.Drawing.Size(264, 307);
            this.groupControl23.TabIndex = 19;
            this.groupControl23.Text = "Fórmula";
            // 
            // FCTS
            // 
            this.FCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCTS.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCTS.FontColor = System.Drawing.Color.Black;
            this.FCTS.Location = new System.Drawing.Point(2, 24);
            this.FCTS.Name = "FCTS";
            this.FCTS.Separator = 10;
            this.FCTS.Size = new System.Drawing.Size(260, 281);
            this.FCTS.TabIndex = 42;
            // 
            // groupControl24
            // 
            this.groupControl24.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl24.AppearanceCaption.Options.UseFont = true;
            this.groupControl24.Controls.Add(this.textEdit_TS_2);
            this.groupControl24.Controls.Add(this.labelControl_TS_3);
            this.groupControl24.Controls.Add(this.checkEdit_TS_2);
            this.groupControl24.Controls.Add(this.checkEdit_TS_1);
            this.groupControl24.Controls.Add(this.labelControl_TS_1);
            this.groupControl24.Controls.Add(this.gridLookUpEdit_TS);
            this.groupControl24.Location = new System.Drawing.Point(3, 3);
            this.groupControl24.Name = "groupControl24";
            this.groupControl24.Size = new System.Drawing.Size(386, 307);
            this.groupControl24.TabIndex = 18;
            this.groupControl24.Text = "Opciones";
            // 
            // textEdit_TS_2
            // 
            this.textEdit_TS_2.EditValue = "0";
            this.textEdit_TS_2.Location = new System.Drawing.Point(233, 167);
            this.textEdit_TS_2.Name = "textEdit_TS_2";
            this.textEdit_TS_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_TS_2.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TS_2.Size = new System.Drawing.Size(120, 22);
            this.textEdit_TS_2.TabIndex = 11;
            this.textEdit_TS_2.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_TS_Properties_EditValueChanged);
            // 
            // labelControl_TS_3
            // 
            this.labelControl_TS_3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_TS_3.Location = new System.Drawing.Point(36, 170);
            this.labelControl_TS_3.Name = "labelControl_TS_3";
            this.labelControl_TS_3.Size = new System.Drawing.Size(168, 16);
            this.labelControl_TS_3.TabIndex = 10;
            this.labelControl_TS_3.Text = "Carrera total del Molde (mm)";
            // 
            // checkEdit_TS_2
            // 
            this.checkEdit_TS_2.Location = new System.Drawing.Point(14, 130);
            this.checkEdit_TS_2.Name = "checkEdit_TS_2";
            this.checkEdit_TS_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_TS_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_TS_2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_TS_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_TS_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_TS_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_TS_2.TabIndex = 9;
            this.checkEdit_TS_2.TabStop = false;
            this.checkEdit_TS_2.Click += new System.EventHandler(this.checkEdit_TS_1_Click);
            // 
            // checkEdit_TS_1
            // 
            this.checkEdit_TS_1.EditValue = true;
            this.checkEdit_TS_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_TS_1.Name = "checkEdit_TS_1";
            this.checkEdit_TS_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_TS_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_TS_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_TS_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_TS_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_TS_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_TS_1.TabIndex = 8;
            this.checkEdit_TS_1.Click += new System.EventHandler(this.checkEdit_TS_1_Click);
            // 
            // labelControl_TS_1
            // 
            this.labelControl_TS_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_TS_1.Enabled = false;
            this.labelControl_TS_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_TS_1.Name = "labelControl_TS_1";
            this.labelControl_TS_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_TS_1.TabIndex = 1;
            this.labelControl_TS_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_TS
            // 
            this.gridLookUpEdit_TS.Enabled = false;
            this.gridLookUpEdit_TS.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_TS.Name = "gridLookUpEdit_TS";
            this.gridLookUpEdit_TS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_TS.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_TS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_TS.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_TS.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_TS.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_TS.Properties.View = this.gridView12;
            this.gridLookUpEdit_TS.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_TS_Properties_EditValueChanged);
            this.gridLookUpEdit_TS.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_TS.TabIndex = 0;
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // DMOPage
            // 
            this.DMOPage.Controls.Add(this.groupControl25);
            this.DMOPage.Controls.Add(this.groupControl26);
            this.DMOPage.DescriptionText = "Seleccione las opciones para calcular la  Distancia entre marcas de oscilación.";
            this.DMOPage.Name = "DMOPage";
            this.DMOPage.Size = new System.Drawing.Size(662, 313);
            this.DMOPage.Text = "Distancia entre marcas de oscilación.";
            // 
            // groupControl25
            // 
            this.groupControl25.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl25.AppearanceCaption.Options.UseFont = true;
            this.groupControl25.Controls.Add(this.FCDMO);
            this.groupControl25.Location = new System.Drawing.Point(395, 3);
            this.groupControl25.Name = "groupControl25";
            this.groupControl25.Size = new System.Drawing.Size(264, 307);
            this.groupControl25.TabIndex = 19;
            this.groupControl25.Text = "Fórmula";
            // 
            // FCDMO
            // 
            this.FCDMO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCDMO.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCDMO.FontColor = System.Drawing.Color.Black;
            this.FCDMO.Location = new System.Drawing.Point(2, 24);
            this.FCDMO.Name = "FCDMO";
            this.FCDMO.Separator = 10;
            this.FCDMO.Size = new System.Drawing.Size(260, 281);
            this.FCDMO.TabIndex = 42;
            // 
            // groupControl26
            // 
            this.groupControl26.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl26.AppearanceCaption.Options.UseFont = true;
            this.groupControl26.Controls.Add(this.checkEdit_DMO_2);
            this.groupControl26.Controls.Add(this.checkEdit_DMO_1);
            this.groupControl26.Controls.Add(this.labelControl_DMO_1);
            this.groupControl26.Controls.Add(this.gridLookUpEdit_DMO_1);
            this.groupControl26.Location = new System.Drawing.Point(3, 3);
            this.groupControl26.Name = "groupControl26";
            this.groupControl26.Size = new System.Drawing.Size(386, 307);
            this.groupControl26.TabIndex = 18;
            this.groupControl26.Text = "Opciones";
            // 
            // checkEdit_DMO_2
            // 
            this.checkEdit_DMO_2.Location = new System.Drawing.Point(14, 130);
            this.checkEdit_DMO_2.Name = "checkEdit_DMO_2";
            this.checkEdit_DMO_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_DMO_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_DMO_2.Properties.Caption = "Tecnología Actual:";
            this.checkEdit_DMO_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_DMO_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_DMO_2.Properties.CheckedChanged += new System.EventHandler(this.gridLookUpEdit_DMO_1_Properties_EditValueChanged);
            this.checkEdit_DMO_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_DMO_2.TabIndex = 9;
            this.checkEdit_DMO_2.TabStop = false;
            this.checkEdit_DMO_2.Click += new System.EventHandler(this.checkEdit_DMO_1_Click);
            // 
            // checkEdit_DMO_1
            // 
            this.checkEdit_DMO_1.EditValue = true;
            this.checkEdit_DMO_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_DMO_1.Name = "checkEdit_DMO_1";
            this.checkEdit_DMO_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_DMO_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_DMO_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_DMO_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_DMO_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_DMO_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_DMO_1.TabIndex = 8;
            this.checkEdit_DMO_1.Click += new System.EventHandler(this.checkEdit_DMO_1_Click);
            // 
            // labelControl_DMO_1
            // 
            this.labelControl_DMO_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_DMO_1.Enabled = false;
            this.labelControl_DMO_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_DMO_1.Name = "labelControl_DMO_1";
            this.labelControl_DMO_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_DMO_1.TabIndex = 1;
            this.labelControl_DMO_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_DMO_1
            // 
            this.gridLookUpEdit_DMO_1.Enabled = false;
            this.gridLookUpEdit_DMO_1.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_DMO_1.Name = "gridLookUpEdit_DMO_1";
            this.gridLookUpEdit_DMO_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_DMO_1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_DMO_1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_DMO_1.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_DMO_1.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_DMO_1.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_DMO_1.Properties.View = this.gridView14;
            this.gridLookUpEdit_DMO_1.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_DMO_1_Properties_EditValueChanged);
            this.gridLookUpEdit_DMO_1.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_DMO_1.TabIndex = 0;
            // 
            // gridView14
            // 
            this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5});
            this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView14.Name = "gridView14";
            this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView14.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "codigo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // ESPage
            // 
            this.ESPage.Controls.Add(this.groupControl27);
            this.ESPage.Controls.Add(this.groupControl28);
            this.ESPage.DescriptionText = "Seleccione las opciones para calcular el Enfriamiento Primario por zonas";
            this.ESPage.Name = "ESPage";
            this.ESPage.Size = new System.Drawing.Size(662, 313);
            this.ESPage.Text = "Enfriamiento Primario por zonas";
            // 
            // groupControl27
            // 
            this.groupControl27.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl27.AppearanceCaption.Options.UseFont = true;
            this.groupControl27.Controls.Add(this.FCES);
            this.groupControl27.Location = new System.Drawing.Point(364, 3);
            this.groupControl27.Name = "groupControl27";
            this.groupControl27.Size = new System.Drawing.Size(295, 307);
            this.groupControl27.TabIndex = 21;
            this.groupControl27.Text = "Fórmula";
            // 
            // FCES
            // 
            this.FCES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCES.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCES.FontColor = System.Drawing.Color.Black;
            this.FCES.Location = new System.Drawing.Point(2, 24);
            this.FCES.Name = "FCES";
            this.FCES.Separator = 10;
            this.FCES.Size = new System.Drawing.Size(291, 281);
            this.FCES.TabIndex = 42;
            // 
            // groupControl28
            // 
            this.groupControl28.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl28.AppearanceCaption.Options.UseFont = true;
            this.groupControl28.Controls.Add(this.labelControl6);
            this.groupControl28.Controls.Add(this.comboBoxEdit5);
            this.groupControl28.Controls.Add(this.labelControl5);
            this.groupControl28.Controls.Add(this.comboBoxEdit4);
            this.groupControl28.Controls.Add(this.comboBoxEdit2);
            this.groupControl28.Controls.Add(this.comboBoxEdit1);
            this.groupControl28.Controls.Add(this.labelControl_CAES_5);
            this.groupControl28.Controls.Add(this.labelControl_CAES_4);
            this.groupControl28.Controls.Add(this.labelControl_CAES_3);
            this.groupControl28.Controls.Add(this.labelControl_CAES_2);
            this.groupControl28.Controls.Add(this.checkEdit_ES_2);
            this.groupControl28.Controls.Add(this.checkEdit_ES_1);
            this.groupControl28.Controls.Add(this.labelControl4);
            this.groupControl28.Controls.Add(this.gridLookUpEdit_ES);
            this.groupControl28.Location = new System.Drawing.Point(3, 3);
            this.groupControl28.Name = "groupControl28";
            this.groupControl28.Size = new System.Drawing.Size(355, 307);
            this.groupControl28.TabIndex = 20;
            this.groupControl28.Text = "Opciones";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(223, 207);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 13);
            this.labelControl6.TabIndex = 34;
            // 
            // comboBoxEdit5
            // 
            this.comboBoxEdit5.Location = new System.Drawing.Point(223, 274);
            this.comboBoxEdit5.Name = "comboBoxEdit5";
            this.comboBoxEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit5.Properties.Items.AddRange(new object[] {
            "20",
            "0",
            "-10"});
            this.comboBoxEdit5.Properties.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_Properties_EditValueChanged);
            this.comboBoxEdit5.Size = new System.Drawing.Size(120, 20);
            this.comboBoxEdit5.TabIndex = 33;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(29, 278);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(183, 16);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Variación de Temperatura: (C°)";
            // 
            // comboBoxEdit4
            // 
            this.comboBoxEdit4.Location = new System.Drawing.Point(223, 239);
            this.comboBoxEdit4.Name = "comboBoxEdit4";
            this.comboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit4.Properties.Items.AddRange(new object[] {
            "1.65",
            "1.60",
            "1.55",
            "1.50",
            "1.45"});
            this.comboBoxEdit4.Properties.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_Properties_EditValueChanged);
            this.comboBoxEdit4.Size = new System.Drawing.Size(120, 20);
            this.comboBoxEdit4.TabIndex = 31;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(223, 166);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_Properties_EditValueChanged);
            this.comboBoxEdit2.Size = new System.Drawing.Size(120, 20);
            this.comboBoxEdit2.TabIndex = 29;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(223, 130);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBoxEdit1.Properties.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_Properties_EditValueChanged);
            this.comboBoxEdit1.Size = new System.Drawing.Size(120, 20);
            this.comboBoxEdit1.TabIndex = 28;
            // 
            // labelControl_CAES_5
            // 
            this.labelControl_CAES_5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CAES_5.Enabled = false;
            this.labelControl_CAES_5.Location = new System.Drawing.Point(30, 243);
            this.labelControl_CAES_5.Name = "labelControl_CAES_5";
            this.labelControl_CAES_5.Size = new System.Drawing.Size(94, 16);
            this.labelControl_CAES_5.TabIndex = 27;
            this.labelControl_CAES_5.Text = "Grupo de Acero:";
            // 
            // labelControl_CAES_4
            // 
            this.labelControl_CAES_4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CAES_4.Enabled = false;
            this.labelControl_CAES_4.Location = new System.Drawing.Point(30, 207);
            this.labelControl_CAES_4.Name = "labelControl_CAES_4";
            this.labelControl_CAES_4.Size = new System.Drawing.Size(87, 16);
            this.labelControl_CAES_4.TabIndex = 25;
            this.labelControl_CAES_4.Text = "Zona # 3:  (%)";
            // 
            // labelControl_CAES_3
            // 
            this.labelControl_CAES_3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CAES_3.Enabled = false;
            this.labelControl_CAES_3.Location = new System.Drawing.Point(30, 170);
            this.labelControl_CAES_3.Name = "labelControl_CAES_3";
            this.labelControl_CAES_3.Size = new System.Drawing.Size(87, 16);
            this.labelControl_CAES_3.TabIndex = 24;
            this.labelControl_CAES_3.Text = "Zona # 2:  (%)";
            // 
            // labelControl_CAES_2
            // 
            this.labelControl_CAES_2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CAES_2.Enabled = false;
            this.labelControl_CAES_2.Location = new System.Drawing.Point(30, 134);
            this.labelControl_CAES_2.Name = "labelControl_CAES_2";
            this.labelControl_CAES_2.Size = new System.Drawing.Size(87, 16);
            this.labelControl_CAES_2.TabIndex = 23;
            this.labelControl_CAES_2.Text = "Zona # 1:  (%)";
            // 
            // checkEdit_ES_2
            // 
            this.checkEdit_ES_2.Location = new System.Drawing.Point(8, 106);
            this.checkEdit_ES_2.Name = "checkEdit_ES_2";
            this.checkEdit_ES_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_ES_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_ES_2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_ES_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_ES_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_ES_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_ES_2.TabIndex = 19;
            this.checkEdit_ES_2.TabStop = false;
            // 
            // checkEdit_ES_1
            // 
            this.checkEdit_ES_1.EditValue = true;
            this.checkEdit_ES_1.Location = new System.Drawing.Point(8, 37);
            this.checkEdit_ES_1.Name = "checkEdit_ES_1";
            this.checkEdit_ES_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_ES_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_ES_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_ES_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_ES_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_ES_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_ES_1.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(30, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_ES
            // 
            this.gridLookUpEdit_ES.Enabled = false;
            this.gridLookUpEdit_ES.Location = new System.Drawing.Point(223, 66);
            this.gridLookUpEdit_ES.Name = "gridLookUpEdit_ES";
            this.gridLookUpEdit_ES.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_ES.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_ES.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_ES.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_ES.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_ES.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_ES.Properties.View = this.gridView15;
            this.gridLookUpEdit_ES.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_DMO_1_Properties_EditValueChanged);
            this.gridLookUpEdit_ES.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_ES.TabIndex = 0;
            // 
            // gridView15
            // 
            this.gridView15.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6});
            this.gridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView15.Name = "gridView15";
            this.gridView15.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView15.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "codigo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // ALPage
            // 
            this.ALPage.Controls.Add(this.groupControl29);
            this.ALPage.Controls.Add(this.groupControl30);
            this.ALPage.DescriptionText = "Seleccione las opciones para calcular  el Aceite de Lubricación";
            this.ALPage.Name = "ALPage";
            this.ALPage.Size = new System.Drawing.Size(662, 313);
            this.ALPage.Text = "Aceite de Lubricación";
            // 
            // groupControl29
            // 
            this.groupControl29.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl29.AppearanceCaption.Options.UseFont = true;
            this.groupControl29.Controls.Add(this.FCAL);
            this.groupControl29.Location = new System.Drawing.Point(395, 3);
            this.groupControl29.Name = "groupControl29";
            this.groupControl29.Size = new System.Drawing.Size(264, 307);
            this.groupControl29.TabIndex = 21;
            this.groupControl29.Text = "Fórmula";
            // 
            // FCAL
            // 
            this.FCAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCAL.Font = new System.Drawing.Font("Verdana", 10F);
            this.FCAL.FontColor = System.Drawing.Color.Black;
            this.FCAL.Location = new System.Drawing.Point(2, 24);
            this.FCAL.Name = "FCAL";
            this.FCAL.Separator = 10;
            this.FCAL.Size = new System.Drawing.Size(260, 281);
            this.FCAL.TabIndex = 42;
            // 
            // groupControl30
            // 
            this.groupControl30.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl30.AppearanceCaption.Options.UseFont = true;
            this.groupControl30.Controls.Add(this.textEdit_AL_2);
            this.groupControl30.Controls.Add(this.labelControl_AL_3);
            this.groupControl30.Controls.Add(this.textEdit_AL_1);
            this.groupControl30.Controls.Add(this.labelControl_AL_2);
            this.groupControl30.Controls.Add(this.checkEdit_AL_2);
            this.groupControl30.Controls.Add(this.checkEdit_AL_1);
            this.groupControl30.Controls.Add(this.labelControl_AL_1);
            this.groupControl30.Controls.Add(this.gridLookUpEdit_AL);
            this.groupControl30.Location = new System.Drawing.Point(3, 3);
            this.groupControl30.Name = "groupControl30";
            this.groupControl30.Size = new System.Drawing.Size(386, 307);
            this.groupControl30.TabIndex = 20;
            this.groupControl30.Text = "Opciones";
            // 
            // textEdit_AL_2
            // 
            this.textEdit_AL_2.EditValue = "0";
            this.textEdit_AL_2.Location = new System.Drawing.Point(233, 213);
            this.textEdit_AL_2.Name = "textEdit_AL_2";
            this.textEdit_AL_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_AL_2.Properties.Appearance.Options.UseFont = true;
            this.textEdit_AL_2.Size = new System.Drawing.Size(120, 22);
            this.textEdit_AL_2.TabIndex = 13;
            this.textEdit_AL_2.EditValueChanged += new System.EventHandler(this.textEdit_AL_1_EditValueChanged);
            // 
            // labelControl_AL_3
            // 
            this.labelControl_AL_3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_AL_3.Location = new System.Drawing.Point(36, 216);
            this.labelControl_AL_3.Name = "labelControl_AL_3";
            this.labelControl_AL_3.Size = new System.Drawing.Size(151, 16);
            this.labelControl_AL_3.TabIndex = 12;
            this.labelControl_AL_3.Text = "Perímetro del Molde (mm)";
            // 
            // textEdit_AL_1
            // 
            this.textEdit_AL_1.EditValue = "0";
            this.textEdit_AL_1.Location = new System.Drawing.Point(233, 167);
            this.textEdit_AL_1.Name = "textEdit_AL_1";
            this.textEdit_AL_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit_AL_1.Properties.Appearance.Options.UseFont = true;
            this.textEdit_AL_1.Size = new System.Drawing.Size(120, 22);
            this.textEdit_AL_1.TabIndex = 11;
            this.textEdit_AL_1.EditValueChanged += new System.EventHandler(this.textEdit_AL_1_EditValueChanged);
            // 
            // labelControl_AL_2
            // 
            this.labelControl_AL_2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_AL_2.Location = new System.Drawing.Point(36, 170);
            this.labelControl_AL_2.Name = "labelControl_AL_2";
            this.labelControl_AL_2.Size = new System.Drawing.Size(162, 16);
            this.labelControl_AL_2.TabIndex = 10;
            this.labelControl_AL_2.Text = "Constante de Flujo (ml/mm)";
            // 
            // checkEdit_AL_2
            // 
            this.checkEdit_AL_2.Location = new System.Drawing.Point(14, 130);
            this.checkEdit_AL_2.Name = "checkEdit_AL_2";
            this.checkEdit_AL_2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_AL_2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_AL_2.Properties.Caption = "Cálculo Personalizado:";
            this.checkEdit_AL_2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_AL_2.Properties.RadioGroupIndex = 0;
            this.checkEdit_AL_2.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_AL_2.TabIndex = 9;
            this.checkEdit_AL_2.TabStop = false;
            this.checkEdit_AL_2.Click += new System.EventHandler(this.checkEdit_AL_1_Click);
            // 
            // checkEdit_AL_1
            // 
            this.checkEdit_AL_1.EditValue = true;
            this.checkEdit_AL_1.Location = new System.Drawing.Point(14, 37);
            this.checkEdit_AL_1.Name = "checkEdit_AL_1";
            this.checkEdit_AL_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit_AL_1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit_AL_1.Properties.Caption = "Anteriormente Calculado:";
            this.checkEdit_AL_1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit_AL_1.Properties.RadioGroupIndex = 0;
            this.checkEdit_AL_1.Size = new System.Drawing.Size(171, 21);
            this.checkEdit_AL_1.TabIndex = 8;
            this.checkEdit_AL_1.Click += new System.EventHandler(this.checkEdit_AL_1_Click);
            // 
            // labelControl_AL_1
            // 
            this.labelControl_AL_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_AL_1.Enabled = false;
            this.labelControl_AL_1.Location = new System.Drawing.Point(36, 76);
            this.labelControl_AL_1.Name = "labelControl_AL_1";
            this.labelControl_AL_1.Size = new System.Drawing.Size(73, 16);
            this.labelControl_AL_1.TabIndex = 1;
            this.labelControl_AL_1.Text = "Tecnologías:";
            // 
            // gridLookUpEdit_AL
            // 
            this.gridLookUpEdit_AL.Enabled = false;
            this.gridLookUpEdit_AL.Location = new System.Drawing.Point(233, 70);
            this.gridLookUpEdit_AL.Name = "gridLookUpEdit_AL";
            this.gridLookUpEdit_AL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridLookUpEdit_AL.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_AL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_AL.Properties.DataSource = this.tTecnologiaBindingSource;
            this.gridLookUpEdit_AL.Properties.DisplayMember = "codigo";
            this.gridLookUpEdit_AL.Properties.ValueMember = "idtecnologia";
            this.gridLookUpEdit_AL.Properties.View = this.gridView16;
            this.gridLookUpEdit_AL.Properties.EditValueChanged += new System.EventHandler(this.textEdit_AL_1_EditValueChanged);
            this.gridLookUpEdit_AL.Size = new System.Drawing.Size(120, 22);
            this.gridLookUpEdit_AL.TabIndex = 0;
            // 
            // gridView16
            // 
            this.gridView16.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7});
            this.gridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView16.Name = "gridView16";
            this.gridView16.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView16.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "codigo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // tPalanquillaBindingSource
            // 
            this.tPalanquillaBindingSource.DataMember = "T_Palanquilla";
            this.tPalanquillaBindingSource.DataSource = this.dSDatos;
            // 
            // t_MaquinaTableAdapter
            // 
            this.t_MaquinaTableAdapter.ClearBeforeFill = true;
            // 
            // t_PalanquillaTableAdapter
            // 
            this.t_PalanquillaTableAdapter.ClearBeforeFill = true;
            // 
            // t_MarcaTableAdapter
            // 
            this.t_MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // t_MaquinaParametroTableAdapter1
            // 
            this.t_MaquinaParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ParametrosTableAdapter1
            // 
            this.t_ParametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 270);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(574, 23);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 111);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(574, 182);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // t_Circulacion_AMTableAdapter1
            // 
            this.t_Circulacion_AMTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TecnologiaTableAdapter
            // 
            this.t_TecnologiaTableAdapter.ClearBeforeFill = true;
            // 
            // t_AceroNormaTableAdapter1
            // 
            this.t_AceroNormaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ParametroValorTableAdapter1
            // 
            this.t_ParametroValorTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmSimulate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 458);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSimulate";
            this.ShowInTaskbar = false;
            this.Text = "Simular Técnologia";
            this.Load += new System.EventHandler(this.FrmSimulate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTPalanquillaTMaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.completionWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.LOPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupContr_Formula)).EndInit();
            this.groupContr_Formula.ResumeLayout(false);
            this.groupContr_Formula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupContr_Opciones)).EndInit();
            this.groupContr_Opciones.ResumeLayout(false);
            this.groupContr_Opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Anterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Larg_Maq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Radio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Tecnologia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTecnologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.VCPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Cal_Anterior2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Alt_Acero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Diam_Boq_Dist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Tecnol_VC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.VEPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VE_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VE_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdi_Velc_Extr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.VPPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Cal_Anterior3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_lineas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Dens_Ace_Sol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Velc_Prod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.TIPACPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Cal_Anterior4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Num_L_C.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Cant_AC_C.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_TPAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.SOLDFPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
            this.groupControl10.ResumeLayout(false);
            this.groupControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_LMAC_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_LMAC_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_LMAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.CTTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl13)).EndInit();
            this.groupControl13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl14)).EndInit();
            this.groupControl14.ResumeLayout(false);
            this.groupControl14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DT_CTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_GAP_CTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Esp_Mold_CTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.CMAEPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).EndInit();
            this.groupControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl16)).EndInit();
            this.groupControl16.ResumeLayout(false);
            this.groupControl16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_CAME_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_CAME_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Calor_Esp_Agu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_CMAE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.TIPADPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).EndInit();
            this.groupControl11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl12)).EndInit();
            this.groupControl12.ResumeLayout(false);
            this.groupControl12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_Calc_Pers5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit__Calc_Anterior5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Num_L_D.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Cant_AC_D.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_TPAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.VMAPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).EndInit();
            this.groupControl17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl18)).EndInit();
            this.groupControl18.ResumeLayout(false);
            this.groupControl18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Area_Circulacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCirculacionAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit8View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VMA_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_VMA_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Caudal_Agua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_VMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.EPPaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl19)).EndInit();
            this.groupControl19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl20)).EndInit();
            this.groupControl20.ResumeLayout(false);
            this.groupControl20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_EP_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_EP_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_EP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            this.OMPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl21)).EndInit();
            this.groupControl21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl22)).EndInit();
            this.groupControl22.ResumeLayout(false);
            this.groupControl22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_OM_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_OM_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_OM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_OM_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            this.TSPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl23)).EndInit();
            this.groupControl23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl24)).EndInit();
            this.groupControl24.ResumeLayout(false);
            this.groupControl24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TS_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_TS_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_TS_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_TS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            this.DMOPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl25)).EndInit();
            this.groupControl25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl26)).EndInit();
            this.groupControl26.ResumeLayout(false);
            this.groupControl26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DMO_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DMO_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_DMO_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            this.ESPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl27)).EndInit();
            this.groupControl27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl28)).EndInit();
            this.groupControl28.ResumeLayout(false);
            this.groupControl28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_ES_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_ES_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_ES.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            this.ALPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl29)).EndInit();
            this.groupControl29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl30)).EndInit();
            this.groupControl30.ResumeLayout(false);
            this.groupControl30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AL_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AL_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_AL_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_AL_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_AL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPalanquillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage LOPage;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DSMCC dSDatos;
        private System.Windows.Forms.BindingSource tMaquinaBindingSource;
        private T_MaquinaTableAdapter t_MaquinaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelomaquina;
        private DevExpress.XtraGrid.Columns.GridColumn colmarcamaquina;
        private System.Windows.Forms.BindingSource fKTPalanquillaTMaquinaBindingSource;
        private T_PalanquillaTableAdapter t_PalanquillaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coltipopalanquilla;
        private DevExpress.XtraGrid.Columns.GridColumn colareapalanquilla;
        private System.Windows.Forms.BindingSource tMarcaBindingSource;
        private T_AceroTableAdapter t_MarcaTableAdapter;
        private T_ParametroValorTableAdapter t_MaquinaParametroTableAdapter1;
        private T_ParametrosTableAdapter t_ParametrosTableAdapter1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraWizard.WizardPage VCPage;
        private DevExpress.XtraEditors.GroupControl groupContr_Formula;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupContr_Opciones;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Calc_Pers;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Calc_Anterior;
        private DevExpress.XtraEditors.TextEdit textEdit_Larg_Maq;
        private DevExpress.XtraEditors.TextEdit textEdit_Radio;
        private DevExpress.XtraEditors.LabelControl labelContr_Larg_Maq;
        private DevExpress.XtraEditors.LabelControl labelContr_Radio;
        private DevExpress.XtraEditors.LabelControl labelContr_Tecnologias;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_Tecnologia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Calc_Pers2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Cal_Anterior2;
        private DevExpress.XtraEditors.TextEdit textEdit_Alt_Acero;
        private DevExpress.XtraEditors.TextEdit textEdit_Diam_Boq_Dist;
        private DevExpress.XtraEditors.LabelControl labelContr_AA;
        private DevExpress.XtraEditors.LabelControl labelContr_DBD;
        private DevExpress.XtraEditors.LabelControl labelContr_Tecnologia2;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_Tecnol_VC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraWizard.WizardPage VEPage;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.CheckEdit checkEdit_VE_1;
        private DevExpress.XtraEditors.LabelControl labelControl_VE_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdi_Velc_Extr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource tPalanquillaBindingSource;
        private DevExpress.XtraWizard.WizardPage VPPage;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Calc_Pers3;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Cal_Anterior3;
        private DevExpress.XtraEditors.TextEdit textEdit_lineas;
        private DevExpress.XtraEditors.TextEdit textEdit_Dens_Ace_Sol;
        private DevExpress.XtraEditors.LabelControl labelControl_NL;
        private DevExpress.XtraEditors.LabelControl labelControl_DAS;
        private DevExpress.XtraEditors.LabelControl labelContr_Tecnologia3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_Velc_Prod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraWizard.WizardPage TIPACPage;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Calc_Pers4;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Cal_Anterior4;
        private DevExpress.XtraEditors.TextEdit textEdit_Num_L_C;
        private DevExpress.XtraEditors.TextEdit textEdit_Cant_AC_C;
        private DevExpress.XtraEditors.LabelControl labelContr_NLC;
        private DevExpress.XtraEditors.LabelControl labelContr_CAC;
        private DevExpress.XtraEditors.LabelControl labelContr_Tecnologia4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_TPAC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraWizard.WizardPage SOLDFPage;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraEditors.GroupControl groupControl10;
        private DevExpress.XtraEditors.CheckEdit checkEdit_LMAC_1;
        private DevExpress.XtraEditors.LabelControl labelControl_LMAC_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_LMAC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraWizard.WizardPage CTTPage;
        private DevExpress.XtraWizard.WizardPage CMAEPage;
        private DevExpress.XtraWizard.WizardPage TIPADPage;
        private DevExpress.XtraEditors.GroupControl groupControl11;
        private DevExpress.XtraEditors.GroupControl groupControl12;
        private DevExpress.XtraEditors.CheckEdit checkEdit_Calc_Pers5;
        private DevExpress.XtraEditors.CheckEdit checkEdit__Calc_Anterior5;
        private DevExpress.XtraEditors.TextEdit textEdit_Num_L_D;
        private DevExpress.XtraEditors.TextEdit textEdit_Cant_AC_D;
        private DevExpress.XtraEditors.LabelControl labelContr_NLC2;
        private DevExpress.XtraEditors.LabelControl labelContr_CAD;
        private DevExpress.XtraEditors.LabelControl labelContr_Tecnologia5;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_TPAD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private T_Circulacion_AMTableAdapter t_Circulacion_AMTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl13;
        private DevExpress.XtraEditors.GroupControl groupControl14;
        private DevExpress.XtraEditors.TextEdit textEdit_DT_CTT;
        private DevExpress.XtraEditors.LabelControl labelControl56;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit_GAP_CTT;
        private DevExpress.XtraEditors.TextEdit textEdit_Esp_Mold_CTT;
        private DevExpress.XtraEditors.LabelControl labelControl52;
        private DevExpress.XtraEditors.LabelControl labelControl53;
        private DevExpress.XtraEditors.LabelControl labelControl54;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.GroupControl groupControl15;
        private DevExpress.XtraEditors.GroupControl groupControl16;
        private DevExpress.XtraEditors.CheckEdit checkEdit_CAME_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_CAME_1;
        private DevExpress.XtraEditors.TextEdit textEdit_Calor_Esp_Agu;
        private DevExpress.XtraEditors.LabelControl labelControl64;
        private DevExpress.XtraEditors.LabelControl labelControl65;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_CMAE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraWizard.WizardPage VMAPage;
        private FormulateControl FCLargoMetal;
        private FormulateControl FCVelocidadColada;
        private FormulateControl FCVelocidadExtraccion;
        private FormulateControl FCVelocidadProduccion;
        private FormulateControl FCTiempoPAC;
        private FormulateControl FCTiempoRAD;
        private FormulateControl FCCalorTotalTransferido;
        private FormulateControl FCLongitud_M_calculada;
        private FormulateControl FCCant_Max_AE;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private T_TecnologiaTableAdapter t_TecnologiaTableAdapter;
        private System.Windows.Forms.BindingSource tTecnologiaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo2;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo3;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo4;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo5;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo6;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo7;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo8;
        private DevExpress.XtraEditors.GroupControl groupControl17;
        private FormulateControl FCVMA;
        private DevExpress.XtraEditors.GroupControl groupControl18;
        private DevExpress.XtraEditors.LabelControl labelControl_Area_Circulacion;
        private DevExpress.XtraEditors.CheckEdit checkEdit_VMA_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_VMA_1;
        private DevExpress.XtraEditors.TextEdit textEdit_Caudal_Agua;
        private DevExpress.XtraEditors.LabelControl labelControl_VMA_CA;
        private DevExpress.XtraEditors.LabelControl labelControl_Tecnologia_VMA;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_VMA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_Area_Circulacion;
        private System.Windows.Forms.BindingSource tCirculacionAMBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit8View;
        private DevExpress.XtraGrid.Columns.GridColumn colarea_circulacion;
        private DevExpress.XtraWizard.WizardPage EPPaje;
        private DevExpress.XtraEditors.GroupControl groupControl19;
        private FormulateControl FCEP;
        private DevExpress.XtraEditors.GroupControl groupControl20;
        private DevExpress.XtraEditors.CheckEdit checkEdit_EP_1;
        private DevExpress.XtraEditors.LabelControl labelControl_EP_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_EP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_VE_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_LMAC_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_EP_2;
        private DevExpress.XtraWizard.WizardPage OMPage;
        private DevExpress.XtraEditors.GroupControl groupControl21;
        private FormulateControl FCOM;
        private DevExpress.XtraEditors.GroupControl groupControl22;
        private DevExpress.XtraEditors.CheckEdit checkEdit_OM_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_OM_1;
        private DevExpress.XtraEditors.TextEdit textEdit_OM;
        private DevExpress.XtraEditors.LabelControl labelControl_OM_2;
        private DevExpress.XtraEditors.LabelControl labelControl_OM_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_OM_1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraWizard.WizardPage TSPage;
        private DevExpress.XtraEditors.GroupControl groupControl23;
        private FormulateControl FCTS;
        private DevExpress.XtraEditors.GroupControl groupControl24;
        private DevExpress.XtraEditors.CheckEdit checkEdit_TS_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_TS_1;
        private DevExpress.XtraEditors.LabelControl labelControl_TS_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_TS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.TextEdit textEdit_TS_2;
        private DevExpress.XtraEditors.LabelControl labelControl_TS_3;
        private DevExpress.XtraWizard.WizardPage DMOPage;
        private DevExpress.XtraEditors.GroupControl groupControl25;
        private FormulateControl FCDMO;
        private DevExpress.XtraEditors.GroupControl groupControl26;
        private DevExpress.XtraEditors.CheckEdit checkEdit_DMO_1;
        private DevExpress.XtraEditors.LabelControl labelControl_DMO_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_DMO_1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraWizard.WizardPage ESPage;
        private DevExpress.XtraEditors.CheckEdit checkEdit_DMO_2;
        private DevExpress.XtraEditors.GroupControl groupControl27;
        private FormulateControl FCES;
        private DevExpress.XtraEditors.GroupControl groupControl28;
        private DevExpress.XtraEditors.LabelControl labelControl_CAES_5;
        private DevExpress.XtraEditors.LabelControl labelControl_CAES_4;
        private DevExpress.XtraEditors.LabelControl labelControl_CAES_3;
        private DevExpress.XtraEditors.LabelControl labelControl_CAES_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_ES_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_ES_1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_ES;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraWizard.WizardPage ALPage;
        private DevExpress.XtraEditors.GroupControl groupControl29;
        private FormulateControl FCAL;
        private DevExpress.XtraEditors.GroupControl groupControl30;
        private DevExpress.XtraEditors.TextEdit textEdit_AL_2;
        private DevExpress.XtraEditors.LabelControl labelControl_AL_3;
        private DevExpress.XtraEditors.TextEdit textEdit_AL_1;
        private DevExpress.XtraEditors.LabelControl labelControl_AL_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_AL_2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_AL_1;
        private DevExpress.XtraEditors.LabelControl labelControl_AL_1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_AL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private T_AceroNormaTableAdapter t_AceroNormaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameacero;
        private T_ParametroValorTableAdapter t_ParametroValorTableAdapter1;
    }
}