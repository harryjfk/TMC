using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace TMC.SIAR.Tareas
{
    public partial class FrmCreateProject : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreateProject()
        {
            InitializeComponent();
        }

        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSDatos);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }

        private void tipoparedSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private int _edit;
        public int edit { get { return _edit; }
            set { _edit = value;
            this.t_Tipo_ParedTableAdapter.Fill(this.dSDatos.T_Tipo_Pared);
            var t = "";
            if (edit == -1)
            {
                t = "Crear nuevo proyecto";
                dSDatosBindingSource.AddNew();
                dSDatosBindingSource.MoveLast();
            }
            else
            {
                t = "Modificar proyecto";
                this.t_ProjectTableAdapter.FillBy(this.dSDatos.T_Project, edit);
            }
            Text = t;
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Project' Puede moverla o quitarla según sea necesario.

                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Pared' Puede moverla o quitarla según sea necesario.

            }
        }

        private void FrmCreateProject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Degradee' Puede moverla o quitarla según sea necesario.
            this.t_DegradeeTableAdapter.Fill(this.dSDatos.T_Degradee);
            SetTrace();
        
        }

        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if( gridLookUpEdit1.EditValue is int)
            {
                switch ((int)gridLookUpEdit1.EditValue)
                {
                    case 1:
                        {
                            simpleLabelItem1.Visibility = LayoutVisibility.Never;
                            ItemForvaluepared.Visibility = LayoutVisibility.Never;
                            break;
                        }
                    case 4:
                        {
                            simpleLabelItem1.Visibility = LayoutVisibility.Never;
                            ItemForvaluepared.Visibility = LayoutVisibility.Never;
                            break;
                        }
                    case 5:
                        {
                            simpleLabelItem1.Visibility = LayoutVisibility.Always;
                            ItemForvaluepared.Visibility = LayoutVisibility.Always;
                            simpleLabelItem1.Text = @"Inclinación desde Vertical";
                            valueparedSpinEdit.Properties.Maximum = 45;
                            valueparedSpinEdit.Properties.Minimum = 0;
                            valueparedSpinEdit.EditValue = 0;
                            break;
                            
                        }
                    case 6:
                        {
                            simpleLabelItem1.Visibility = LayoutVisibility.Always;
                            ItemForvaluepared.Visibility = LayoutVisibility.Always;
                       
                            valueparedSpinEdit.Properties.Maximum = 50;
                            simpleLabelItem1.Text = @"Incidencia del viento";
                            valueparedSpinEdit.Properties.Minimum = 0;
                            valueparedSpinEdit.EditValue = 0;
                            break; 
                        }
                }
            }
            else
            {
                simpleLabelItem1.Visibility = LayoutVisibility.Never;
                ItemForvaluepared.Visibility = LayoutVisibility.Never;
            }
        }

       

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
                Project.coefinintercambio = DBNull.Value;
            else
                if (coefinintercambioSpinEdit.EditValue is Decimal)
                Project.coefinintercambio = double.Parse(coefinintercambioSpinEdit.EditValue.ToString()) ;
    
        }
        private DSRD.T_ProjectRow Project
        {
            get { return (DSRD.T_ProjectRow) ((DataRowView) dSDatosBindingSource.Current).Row; }

        }

        private void valueparedSpinEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void formulatTextEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                dSDatosBindingSource.EndEdit();
                t_ProjectTableAdapter.Update(dSDatos.T_Project);
                DialogResult = DialogResult.OK;
                edit = Project.idproject;
                Close();
            }
        }

        private void ucPieFormulario1_Load(object sender, EventArgs e)
        {

        }

        private void valueparedSpinEdit_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

            ItemForvaluepared.Text = valueparedSpinEdit.EditValue.ToString();
            int t = 0;
            if (!int.TryParse(ItemForvaluepared.Text, out t))
                ItemForvaluepared.Text =
                    t.ToString();

            if (gridLookUpEdit1.EditValue is int)
            {
                if (((int) gridLookUpEdit1.EditValue) == 5)
                    ItemForvaluepared.Text += "°";
                else if (((int) gridLookUpEdit1.EditValue) == 6)

                    ItemForvaluepared.Text += " m/s";
            }
        }
    }
}