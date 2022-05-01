namespace TMC.BCE.Tareas
{
    partial class FrmNewPatron
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
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.t_Proyecto_Balance_BCGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_Proyecto_Balance_BCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBCE = new TMC.BCE.DSBCE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidpropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tBalancePropiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname_Balance_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipopropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tElementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodelemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.tPatronBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamepatron = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.t_Patron_BalanceTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Patron_BalanceTableAdapter();
            this.tTipoPropiedadBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Proyecto_Balance_BCTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Patron_Balance_BCTableAdapter();
            this.t_Balance_PropiedadTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Balance_PropiedadTableAdapter();
            this.t_Tipo_Propiedad_BalanceTableAdapter = new TMC.BCE.DSBCETableAdapters.T_Tipo_Propiedad_BalanceTableAdapter();
            this.t_ElementoTableAdapter = new TMC.BCE.DSBCETableAdapters.T_ElementoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBalancePropiedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPatronBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadBalanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 287);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(513, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 0;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.t_Proyecto_Balance_BCGridControl);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(513, 287);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // t_Proyecto_Balance_BCGridControl
            // 
            this.t_Proyecto_Balance_BCGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_Proyecto_Balance_BCGridControl.DataSource = this.t_Proyecto_Balance_BCBindingSource;
            this.t_Proyecto_Balance_BCGridControl.Enabled = false;
            this.t_Proyecto_Balance_BCGridControl.Location = new System.Drawing.Point(12, 60);
            this.t_Proyecto_Balance_BCGridControl.MainView = this.gridView1;
            this.t_Proyecto_Balance_BCGridControl.Name = "t_Proyecto_Balance_BCGridControl";
            this.t_Proyecto_Balance_BCGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit3});
            this.t_Proyecto_Balance_BCGridControl.Size = new System.Drawing.Size(489, 215);
            this.t_Proyecto_Balance_BCGridControl.TabIndex = 6;
            this.t_Proyecto_Balance_BCGridControl.UseEmbeddedNavigator = true;
            this.t_Proyecto_Balance_BCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // t_Proyecto_Balance_BCBindingSource
            // 
            this.t_Proyecto_Balance_BCBindingSource.DataMember = "T_Patron_Balance_BC";
            this.t_Proyecto_Balance_BCBindingSource.DataSource = this.dSBCE;
            // 
            // dSBCE
            // 
            this.dSBCE.DataSetName = "DSBCE";
            this.dSBCE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidpropiedad,
            this.colidelemento,
            this.colvalor});
            this.gridView1.GridControl = this.t_Proyecto_Balance_BCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colidpropiedad
            // 
            this.colidpropiedad.Caption = "Propiedad";
            this.colidpropiedad.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidpropiedad.FieldName = "idpropiedad";
            this.colidpropiedad.Name = "colidpropiedad";
            this.colidpropiedad.Visible = true;
            this.colidpropiedad.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tBalancePropiedadBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "name_Balance_P";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idBalance_Propiedad";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // tBalancePropiedadBindingSource
            // 
            this.tBalancePropiedadBindingSource.DataMember = "T_Balance_Propiedad";
            this.tBalancePropiedadBindingSource.DataSource = this.dSBCE;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname_Balance_P,
            this.colidtipopropiedad});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colname_Balance_P
            // 
            this.colname_Balance_P.Caption = "Nombre";
            this.colname_Balance_P.FieldName = "name_Balance_P";
            this.colname_Balance_P.Name = "colname_Balance_P";
            this.colname_Balance_P.Visible = true;
            this.colname_Balance_P.VisibleIndex = 0;
            // 
            // colidtipopropiedad
            // 
            this.colidtipopropiedad.Caption = "Tipo de Propiedad";
            this.colidtipopropiedad.FieldName = "idtipopropiedad";
            this.colidtipopropiedad.Name = "colidtipopropiedad";
            this.colidtipopropiedad.Visible = true;
            this.colidtipopropiedad.VisibleIndex = 1;
            // 
            // colidelemento
            // 
            this.colidelemento.Caption = "Elemento";
            this.colidelemento.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colidelemento.FieldName = "idelemento";
            this.colidelemento.Name = "colidelemento";
            this.colidelemento.Visible = true;
            this.colidelemento.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tElementoBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "nameelemento";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "idelemento";
            this.repositoryItemGridLookUpEdit3.View = this.gridView3;
            // 
            // tElementoBindingSource
            // 
            this.tElementoBindingSource.DataMember = "T_Elemento";
            this.tElementoBindingSource.DataSource = this.dSBCE;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameelemento,
            this.colcodelemento});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colnameelemento
            // 
            this.colnameelemento.Caption = "Nombre";
            this.colnameelemento.FieldName = "nameelemento";
            this.colnameelemento.Name = "colnameelemento";
            this.colnameelemento.Visible = true;
            this.colnameelemento.VisibleIndex = 0;
            // 
            // colcodelemento
            // 
            this.colcodelemento.Caption = "Codigo";
            this.colcodelemento.FieldName = "codelemento";
            this.colcodelemento.Name = "colcodelemento";
            this.colcodelemento.Visible = true;
            this.colcodelemento.VisibleIndex = 1;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tPatronBalanceBindingSource, "namepatron", true));
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tPatronBalanceBindingSource, "namepatron", true));
            this.textEdit2.Location = new System.Drawing.Point(57, 36);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(444, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.textEdit2, conditionValidationRule1);
            // 
            // tPatronBalanceBindingSource
            // 
            this.tPatronBalanceBindingSource.DataMember = "T_Patron_Balance";
            this.tPatronBalanceBindingSource.DataSource = this.dSBCE;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(57, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.DataSource = this.tPatronBalanceBindingSource;
            this.textEdit1.Properties.DisplayMember = "namepatron";
            this.textEdit1.Properties.NullText = "";
            this.textEdit1.Properties.ValueMember = "idpatron";
            this.textEdit1.Properties.View = this.gridLookUpEdit1View;
            this.textEdit1.Properties.EditValueChanged += new System.EventHandler(this.textEdit1_Properties_EditValueChanged);
            this.textEdit1.Size = new System.Drawing.Size(444, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.textEdit1, conditionValidationRule2);
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
            this.colnamepatron.Caption = "Nombre";
            this.colnamepatron.FieldName = "namepatron";
            this.colnamepatron.Name = "colnamepatron";
            this.colnamepatron.Visible = true;
            this.colnamepatron.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(513, 287);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.CustomizationFormText = "Nombre:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(493, 24);
            this.layoutControlItem1.Text = "Nombre:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.CustomizationFormText = "Nombre:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(493, 24);
            this.layoutControlItem2.Text = "Nombre:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.t_Proyecto_Balance_BCGridControl;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(493, 219);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidateHiddenControls = false;
            // 
            // t_Patron_BalanceTableAdapter
            // 
            this.t_Patron_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // tTipoPropiedadBalanceBindingSource
            // 
            this.tTipoPropiedadBalanceBindingSource.DataMember = "T_Tipo_Propiedad_Balance";
            this.tTipoPropiedadBalanceBindingSource.DataSource = this.dSBCE;
            // 
            // t_Proyecto_Balance_BCTableAdapter
            // 
            this.t_Proyecto_Balance_BCTableAdapter.ClearBeforeFill = true;
            // 
            // t_Balance_PropiedadTableAdapter
            // 
            this.t_Balance_PropiedadTableAdapter.ClearBeforeFill = true;
            // 
            // t_Tipo_Propiedad_BalanceTableAdapter
            // 
            this.t_Tipo_Propiedad_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // t_ElementoTableAdapter
            // 
            this.t_ElementoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNewPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 317);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewPatron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Patron";
            this.Load += new System.EventHandler(this.FrmNewPatron_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Proyecto_Balance_BCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBalancePropiedadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tElementoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPatronBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoPropiedadBalanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GridLookUpEdit textEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DSBCE dSBCE;
        private System.Windows.Forms.BindingSource tPatronBalanceBindingSource;
        private DSBCETableAdapters.T_Patron_BalanceTableAdapter t_Patron_BalanceTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colnamepatron;
        private System.Windows.Forms.BindingSource t_Proyecto_Balance_BCBindingSource;
        private System.Windows.Forms.BindingSource tBalancePropiedadBindingSource;
        private System.Windows.Forms.BindingSource tTipoPropiedadBalanceBindingSource;
        private System.Windows.Forms.BindingSource tElementoBindingSource;
        private DSBCETableAdapters.T_Patron_Balance_BCTableAdapter t_Proyecto_Balance_BCTableAdapter;
        private DSBCETableAdapters.T_Balance_PropiedadTableAdapter t_Balance_PropiedadTableAdapter;
        private DSBCETableAdapters.T_Tipo_Propiedad_BalanceTableAdapter t_Tipo_Propiedad_BalanceTableAdapter;
        private DSBCETableAdapters.T_ElementoTableAdapter t_ElementoTableAdapter;
        private DevExpress.XtraGrid.GridControl t_Proyecto_Balance_BCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidpropiedad;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colname_Balance_P;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipopropiedad;
        private DevExpress.XtraGrid.Columns.GridColumn colidelemento;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnameelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colcodelemento;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}