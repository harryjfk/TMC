using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TMC.Components.TemperatureControl;

namespace TMC.SIAR.Tareas
{
    public partial class FrmOpenProject : DevExpress.XtraEditors.XtraForm
    {
        public FrmOpenProject()
        {
            InitializeComponent();
        }

        public int idProject
        {
            get { return ((DSRD.T_ProjectRow)((DataRowView)tProjectBindingSource.Current).Row).idproject; }
        
        }

        private void FrmOpenProject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRD.T_Project' Puede moverla o quitarla según sea necesario.
            this.t_ProjectTableAdapter.Fill(this.dSRD.T_Project);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            if (Project.CreateFromFile(openFileDialog1.FileName))
                t_ProjectTableAdapter.Fill(dSRD.T_Project);
        }
    }
}