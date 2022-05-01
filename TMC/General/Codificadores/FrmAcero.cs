using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.General.Codificadores
{
    public partial class FrmAcero : DevExpress.XtraEditors.XtraForm
    {
        public FrmAcero()
        {
            InitializeComponent();
        }

        private void t_AceroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_AceroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmAcero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Formula' Puede moverla o quitarla según sea necesario.
            this.t_FormulaTableAdapter.Fill(this.dSDatos.T_Formula);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AceroTipoPunto' Puede moverla o quitarla según sea necesario.
            this.t_AceroTipoPuntoTableAdapter.Fill(this.dSDatos.T_AceroTipoPunto);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_RegimenCalentamiento' Puede moverla o quitarla según sea necesario.
            this.t_RegimenCalentamientoTableAdapter.Fill(this.dSDatos.T_RegimenCalentamiento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPropiedadSol' Puede moverla o quitarla según sea necesario.
            this.t_TipoPropiedadSolTableAdapter.Fill(this.dSDatos.T_TipoPropiedadSol);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTratamiento' Puede moverla o quitarla según sea necesario.
            this.t_TipoTratamientoTableAdapter.Fill(this.dSDatos.T_TipoTratamiento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_MedioEnfriamiento' Puede moverla o quitarla según sea necesario.
            this.t_MedioEnfriamientoTableAdapter.Fill(this.dSDatos.T_MedioEnfriamiento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tratamiento' Puede moverla o quitarla según sea necesario.
            this.t_TratamientoTableAdapter.Fill(this.dSDatos.T_Tratamiento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoMaterial' Puede moverla o quitarla según sea necesario.
            this.t_TipoMaterialTableAdapter.Fill(this.dSDatos.T_TipoMaterial);
            tTipoMaterialBindingSource.Filter = "idmaterial = 2";
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Norma' Puede moverla o quitarla según sea necesario.
            this.t_NormaTableAdapter.Fill(this.dSDatos.T_Norma);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Elemento' Puede moverla o quitarla según sea necesario.
            this.t_ElementoTableAdapter.Fill(this.dSDatos.T_Elemento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            t_AceroTipoPuntoTableAdapter.Fill(dSDatos.T_AceroTipoPunto);
            t_AceroPuntoTableAdapter1.Fill(dSDatos.T_AceroPunto);
            t_AceroPuntoFormulaTableAdapter1.Fill(dSDatos.T_AceroPuntoFormula);

            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            t_TratamientoDeslozeTableAdapter1.Fill(dSDatos.T_TratamientoDesloze);
            t_AceroElementoTableAdapter1.Fill(dSDatos.T_AceroElemento);
           dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_ElementoTableAdapter.Update(dSDatos.T_Elemento);
        }

        private void FrmAcero_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_ElementoTableAdapter.Update(dSDatos.T_Elemento);
            t_NormaTableAdapter.Update(dSDatos.T_Norma);
            t_AceroTableAdapter.Update(dSDatos.T_Acero);
            t_AceroElementoTableAdapter1.Update(dSDatos.T_AceroElemento);
            t_AceroNormaTableAdapter1.Update(dSDatos.T_AceroNorma);
            t_RegimenCalentamientoTableAdapter.Update(dSDatos.T_RegimenCalentamiento);
            t_AceroPuntoTableAdapter1.Update(dSDatos.T_AceroPunto);
        }

        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_NormaTableAdapter.Update(dSDatos.T_Norma);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroTableAdapter.Update(dSDatos.T_Acero);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroElementoTableAdapter1.Update(dSDatos.T_AceroElemento);
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroNormaTableAdapter1.Update(dSDatos.T_AceroNorma);
        }

        private void gridView7_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TratamientoDeslozeTableAdapter1.Update(dSDatos.T_TratamientoDesloze);
        }

        private void gridView6_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TratamientoTableAdapter.Update(dSDatos.T_Tratamiento);
        }

        private void gridView8_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_RegimenCalentamientoTableAdapter.Update(dSDatos.T_RegimenCalentamiento);
        }

        private void gridView10_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroTipoPuntoTableAdapter.Update(dSDatos.T_AceroTipoPunto);
        }

        private void gridView9_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroPuntoTableAdapter1.Update(dSDatos.T_AceroPunto);
        }

        private void gridView11_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroPuntoFormulaTableAdapter1.Update(dSDatos.T_AceroPuntoFormula);
        }
    }
}