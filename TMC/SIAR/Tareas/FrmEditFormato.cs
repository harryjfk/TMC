using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMC.SIAR.Tareas
{
    public partial class FrmEditFormato : Form
    {
        private int _edit;
        public FrmEditFormato()
        {
            InitializeComponent();
        }

        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSDatos);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }

        public int edit
        {
            get { return _edit; }
            set { _edit = value;


            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Formato' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_FormatoTableAdapter.Fill(this.dSDatos.T_Tipo_Formato);
                SetTrace();
            if (edit != -1)
            {
                tFormatoBindingSource.Position = edit;
                //gridLookUpEdit1.EditValue = Formato.idTipo_Formato;
                //gridLookUpEdit1_Properties_EditValueChanged(gridLookUpEdit1, null);
            }
            else
            {
                tFormatoBindingSource.AddNew();
                tFormatoBindingSource.MoveLast();
            }
            
            
            }
        }

        public BindingSource bindingformato
        {
            get { return tFormatoBindingSource; }
            set { tFormatoBindingSource.DataSource = value.DataSource; }
        }

        private void FrmEditFormato_Load(object sender, EventArgs e)
        {
            
       
        }
        private DSRD.T_FormatoRow Formato { get { return (DSRD.T_FormatoRow)((DataRowView)tFormatoBindingSource.Current).Row; } }

        

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                Formato.idTipo_Formato = int.Parse(gridLookUpEdit1.EditValue.ToString());
                tFormatoBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEdit1.EditValue is int)
                tTipoFormatoBindingSource.Position = tTipoFormatoBindingSource.Find("idTipo_Formato",
                                                                                    gridLookUpEdit1.EditValue);
        }



        
    }
}
