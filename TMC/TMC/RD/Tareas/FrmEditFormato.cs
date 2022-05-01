using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMC.RD.Tareas
{
    public partial class FrmEditFormato : Form
    {
        private int _edit;
        public FrmEditFormato()
        {
            InitializeComponent();
        }

        public int edit
        {
            get { return _edit; }
            set { _edit = value;


            if (edit != -1)
            {
                tFormatoBindingSource.Position = edit;
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
            
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Formato' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_FormatoTableAdapter.Fill(this.dSDatos.T_Tipo_Formato);

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



        
    }
}
