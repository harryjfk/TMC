using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TMC.RD;

namespace TMC.Components.TemperatureControl
{
    public partial class FrmAddMaterial : DevExpress.XtraEditors.XtraForm
    {
        public FrmAddMaterial()
        {
            InitializeComponent();
        }

        private DSRD.T_MaterialRow material;
        public DSRD.T_MaterialRow Material { get { return material; } set { material = value;

            simpleLabelItem1.Text = material.namematerial;
           
            for (int i = 0; i < ListaMaterial.Count - 1; i++)
               comboBoxEdit1.Properties.Items.Add((i + 1).ToString());
            comboBoxEdit2.Properties.Items.AddRange(comboBoxEdit1.Properties.Items);
            checkEdit2.Enabled = ListaMaterial.Count > 0;
            comboBoxEdit1.Enabled = checkEdit2.Enabled;
            checkEdit3.Enabled = ListaMaterial.Count > 0;
            comboBoxEdit2.Enabled = checkEdit3.Enabled;

        } }

        public List<DSRD.T_MaterialRow> ListaMaterial { get; set; }

        private void FrmAddMaterial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Formato' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_FormatoTableAdapter.Fill(this.dSDatos.T_Tipo_Formato);

        }
        public DSRD.T_Tipo_FormatoRow Formato { get { return (DSRD.T_Tipo_FormatoRow) ((DataRowView) tTipoFormatoBindingSource.Current).Row; } }

        private void comboBoxEdit3_Properties_EditValueChanged(object sender, EventArgs e)
        {
            tTipoFormatoBindingSource.Position = tTipoFormatoBindingSource.Find("idTipo_Formato",
                                                                                comboBoxEdit3.EditValue);
            comboBoxEdit4.Properties.Items.Clear();
            
            var t= Material.GetEspesoresAll(Formato.idTipo_Formato);
            foreach (var w in t)
                comboBoxEdit4.Properties.Items.Add(w);
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public int Espesor { get /* { return int.Parse(comboBoxEdit4.Text.ToString()); }*/; set; }
    }
}