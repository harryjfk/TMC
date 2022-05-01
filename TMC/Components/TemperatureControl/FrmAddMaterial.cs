using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using TMC.SIAR;
using ComboBox = DevExpress.XtraEditors.ComboBox;

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
           
            for (int i = 0; i <= ListaMaterial.Count - 1; i++)
               comboBoxEdit1.Properties.Items.Add((i + 1).ToString());
            
            comboBoxEdit2.Properties.Items.AddRange(comboBoxEdit1.Properties.Items);
            checkEdit2.Tag = comboBoxEdit1;
            comboBoxEdit1.Tag = dxValidationProvider1.GetValidationRule(comboBoxEdit1);
            checkEdit2.Enabled = ListaMaterial.Count > 0;
            comboBoxEdit1.Enabled = false;
            checkEdit3.Tag = comboBoxEdit2;
            comboBoxEdit2.Tag = dxValidationProvider1.GetValidationRule(comboBoxEdit2);
            checkEdit3.Enabled = ListaMaterial.Count > 0;
            comboBoxEdit2.Enabled = false;
            dxValidationProvider1.SetValidationRule(comboBoxEdit1, null);
            dxValidationProvider1.SetValidationRule(comboBoxEdit2, null);
            this.t_Tipo_FormatoTableAdapter.FillBy(this.dSDatos.T_Tipo_Formato, material.idmaterial);
        } }

        public List<DSRD.T_MaterialRow> ListaMaterial { get; set; }


        private void FrmAddMaterial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Formato' Puede moverla o quitarla según sea necesario.
          

        }
        public DSRD.T_Tipo_FormatoRow Formato { get { return (DSRD.T_Tipo_FormatoRow) ((DataRowView) tTipoFormatoBindingSource.Current).Row; } }

        private void comboBoxEdit3_Properties_EditValueChanged(object sender, EventArgs e)
        {
            tTipoFormatoBindingSource.Position = tTipoFormatoBindingSource.Find("idTipo_Formato",
                                                                                comboBoxEdit3.EditValue);
            comboBoxEdit4.Properties.Items.Clear();
            var t = Material.GetEspesoresAll(Formato.idTipo_Formato);
            foreach (var w in t)
                comboBoxEdit4.Properties.Items.Add(w);
        }
        private DSRD.T_Tipo_FormatoRow TipoFormato { get { return (DSRD.T_Tipo_FormatoRow) ((DataRowView) tTipoFormatoBindingSource.Current).Row; } }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                DialogResult = DialogResult.OK;
                Close();    
            }
            
        }

        public int Espesor
        {
            get { return int.Parse(comboBoxEdit4.Text.ToString()); }
            
        }
        public int Position
        {
            get
            {
                if (checkEdit1.Checked)
                    return -1;
                else
                    if (checkEdit2.Checked)
                        return 0;
                    else
                        return 1;
      
            }
        }
        public int Value
        {

            get
            {
                if (checkEdit2.Checked)
                    return int.Parse(comboBoxEdit1.EditValue.ToString());
                else
                    return int.Parse(comboBoxEdit2.EditValue.ToString());
            }
        }
        private void FrmAddMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(DialogResult!=DialogResult.OK)
            DialogResult = DialogResult.Cancel;
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            ((ComboBoxEdit) ((CheckEdit) sender).Tag).Enabled = ((CheckEdit) sender).Checked;
            if (((CheckEdit)sender).Checked)
                dxValidationProvider1.SetValidationRule(((ComboBoxEdit)((CheckEdit)sender).Tag), (ValidationRuleBase) ((ComboBoxEdit)((CheckEdit)sender).Tag).Tag);
            else
                dxValidationProvider1.SetValidationRule(((ComboBoxEdit)((CheckEdit)sender).Tag),null);
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}