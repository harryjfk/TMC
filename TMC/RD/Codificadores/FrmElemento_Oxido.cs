using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMC.RD.Codificadores
{
    public partial class FrmElemento_Oxido : Form
    {
        public FrmElemento_Oxido()
        {
            InitializeComponent();
        }

        private void FrmElemento_Oxido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Elemento' Puede moverla o quitarla según sea necesario.
            this.t_ElementoTableAdapter.Fill(this.dSDatos.T_Elemento);

        }
    }
}
