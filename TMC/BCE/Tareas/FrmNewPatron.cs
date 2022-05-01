using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace TMC.BCE.Tareas
{
    public partial class FrmNewPatron : DevExpress.XtraEditors.XtraForm
    {
        private bool _edit;
        public FrmNewPatron()
        {
            InitializeComponent();
        }
        public bool edit { get { return _edit; } set { _edit = value;


            t_Tipo_Propiedad_BalanceTableAdapter.Fill(dSBCE.T_Tipo_Propiedad_Balance);
            t_Balance_PropiedadTableAdapter.Fill(dSBCE.T_Balance_Propiedad);
            t_ElementoTableAdapter.Fill(dSBCE.T_Elemento);
        if (value)
        {
            t_Patron_BalanceTableAdapter.Fill(dSBCE.T_Patron_Balance);
            
            Text = "Seleccionar Patrón";
            layoutControlItem1.Visibility = LayoutVisibility.Always;
            layoutControlItem2.Visibility = LayoutVisibility.Never;
        }
            
        else
        {
            textEdit1.Properties.ValueMember = "namepatron";
            textEdit1.Properties.Buttons.Clear();
            tPatronBalanceBindingSource.AddNew();
            tPatronBalanceBindingSource.MoveLast();
            dSBCE.T_Patron_Balance_BC.idpatronColumn.DefaultValue = -1;
            Text = "Nuevo Patrón";
            layoutControlItem2.Visibility = LayoutVisibility.Always;
            layoutControlItem1.Visibility = LayoutVisibility.Never;
            t_Proyecto_Balance_BCGridControl.Enabled = true;
        }
        } }

        public int idpatron
        {
            get { return ((DSBCE.T_Patron_BalanceRow) ((DataRowView)tPatronBalanceBindingSource.Current).Row ).idpatron; }
          
        }

        private void FrmNewPatron_Load(object sender, EventArgs e)
        {
         
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                if (!edit)
                {
                    tPatronBalanceBindingSource.EndEdit();
                    t_Patron_BalanceTableAdapter.Update(dSBCE.T_Patron_Balance);
                    var l = (int)t_Patron_BalanceTableAdapter.Last();
                    foreach (var VARIABLE in dSBCE.T_Patron_Balance_BC)
                        VARIABLE.idpatron = l;
                }
                t_Proyecto_Balance_BCTableAdapter.Update(dSBCE.T_Patron_Balance_BC);
                    
                DialogResult = DialogResult.OK;
                Close();
            }
          
        }

        private void textEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(textEdit1.EditValue is int)
            {
                tPatronBalanceBindingSource.Position = tPatronBalanceBindingSource.Find("idpatron", textEdit1.EditValue);
                t_Proyecto_Balance_BCTableAdapter.FillBy(dSBCE.T_Patron_Balance_BC, idpatron);
                dSBCE.T_Patron_Balance_BC.idpatronColumn.DefaultValue = idpatron;
                t_Proyecto_Balance_BCGridControl.Enabled = true;
            }
            
        }
    }
}