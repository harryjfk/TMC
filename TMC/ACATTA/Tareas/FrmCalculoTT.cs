using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TMC.ACATTA.Codificadores;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using TMC.ACATTA;
using TMC.General.Codificadores;

namespace TMC.ACATTA.Tareas
{
    public partial class FrmCalculoTT : DevExpress.XtraEditors.XtraForm
    {
        public FrmCalculoTT()
        {
            InitializeComponent();
        }

        private void propsolSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmCalculoTT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_RegimenCalentamiento' Puede moverla o quitarla según sea necesario.
            this.t_RegimenCalentamientoTableAdapter.Fill(this.dSDatos.T_RegimenCalentamiento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ColocacionPieza' Puede moverla o quitarla según sea necesario.
            this.t_ColocacionPiezaTableAdapter.Fill(this.dSDatos.T_ColocacionPieza);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPiezaGeometria' Puede moverla o quitarla según sea necesario.
            this.t_TipoPiezaGeometriaTableAdapter.Fill(this.dSDatos.T_TipoPiezaGeometria);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_SeparacionPieza' Puede moverla o quitarla según sea necesario.
            this.t_SeparacionPiezaTableAdapter.Fill(this.dSDatos.T_SeparacionPieza);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPieza' Puede moverla o quitarla según sea necesario.
            this.t_TipoPiezaTableAdapter.Fill(this.dSDatos.T_TipoPieza);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tratamiento' Puede moverla o quitarla según sea necesario.
            this.t_TratamientoTableAdapter.Fill(this.dSDatos.T_Tratamiento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoMaterial' Puede moverla o quitarla según sea necesario.
            this.t_TipoMaterialTableAdapter.Fill(this.dSDatos.T_TipoMaterial);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Horno' Puede moverla o quitarla según sea necesario.
            this.t_HornoTableAdapter.Fill(this.dSDatos.T_Horno);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPropiedadSol' Puede moverla o quitarla según sea necesario.
            this.t_TipoPropiedadSolTableAdapter.Fill(this.dSDatos.T_TipoPropiedadSol);
            t_ElementoTableAdapter1.Fill(dSDatos.T_Elemento);
            t_AceroElementoTableAdapter1.Fill(dSDatos.T_AceroElemento);
            t_NormaTableAdapter1.Fill(dSDatos.T_Norma);
            t_TipoHornoTableAdapter1.Fill(dSDatos.T_TipoHorno);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            t_TipoTratamientoTableAdapter1.Fill(dSDatos.T_TipoTratamiento);
            dSDatos.T_Acero.FillName(TMC.Properties.Settings.Default.Norma);

        }

        private void idtipopropsolSpinEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind==ButtonPredefines.Ellipsis)
            {
                var frmtipopieza = new FrmTipoPieza();
                frmtipopieza.ShowDialog();
                t_TipoPropiedadSolTableAdapter.Fill(dSDatos.T_TipoPropiedadSol);
                t_TipoPiezaGeometriaTableAdapter.Fill(dSDatos.T_TipoPiezaGeometria);
                t_TipoPiezaTableAdapter.Fill(dSDatos.T_TipoPieza);
                t_ColocacionPiezaTableAdapter.Fill(dSDatos.T_ColocacionPieza);
                t_SeparacionPiezaTableAdapter.Fill(dSDatos.T_SeparacionPieza);
            }
        }

        private void idhornoSpinEdit_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var frmhorno = new FrmHornos();
                frmhorno.ShowDialog();
                t_HornoTableAdapter.Fill(dSDatos.T_Horno);
            }
        }

        private void idtipomaterialSpinEdit_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var frmmaterial = new FrmAcero();
                frmmaterial.ShowDialog();
                t_AceroTableAdapter.Fill(dSDatos.T_Acero);
                dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
            }
        }

        private void idtratamientoSpinEdit_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var frmtratemiento = new FrmTratamiento();
                frmtratemiento.ShowDialog();
                t_TratamientoTableAdapter.Fill(dSDatos.T_Tratamiento);
            }
        }
        private void UpdateUI()
        {
            if (PiezaGeo == null)
                return;
            switch (PiezaGeo.idtipopiezageo)
            {
                case 1:
                    {
                        ItemForancho.Text = "Ancho(mm):";
                        ItemForaltura.Text = "Altura(mm):";
                        break;
                    }
                case 2:
                    {
                        ItemForancho.Text = "Ancho(mm):";
                        ItemForaltura.Text = "Altura(mm):";
                        break;
                    }
                case 3:
                    {

                        ItemForancho.Text = "Diámetro(mm):";
                        ItemForlargo.Text = "Largo(mm):";
                        ItemForaltura.Text = "Altura(mm):";
                        break;
                    }
                case 4:
                    {

                        ItemForancho.Text = "Diámetro Exterior(mm):";
                        ItemForaltura.Text = "Diámetro Interior(mm):";
                        ItemForlargo.Text = "Largo(mm):";
                        break;
                    }
                case 5:
                    {

                        ItemForancho.Text = "Diámetro(mm):";
                        ItemForaltura.Text = "Altura(mm):";
                        ItemForlargo.Text = "Largo(mm):";
                        break;
                    }
                         case 6:
                    {

                        ItemForancho.Text = "Diámetro(mm):";
                        ItemForaltura.Text = "Espesor(mm):";
                        ItemForlargo.Text = "Largo(mm):";
                        break;
                    }
                         case 7:
                    {

                        ItemForancho.Text = "Espesor(mm):";
                        ItemForaltura.Text = "Diámetro Exterior(mm):";
                        ItemForlargo.Text = "Diámetro Interior(mm):";
                        break;
                    }
           
            }
            idcolocacionSpinEdit.Enabled = PiezaGeo.idtipopiezageo != 1 && PiezaGeo.idtipopiezageo != 5;
            largoSpinEdit.Enabled = PiezaGeo.idtipopiezageo != 1 && PiezaGeo.idtipopiezageo != 5 && PiezaGeo.idtipopiezageo != 6;
            alturaSpinEdit.Enabled = PiezaGeo.idtipopiezageo != 1 && PiezaGeo.idtipopiezageo != 3 && PiezaGeo.idtipopiezageo != 5; 
        }
        private void idtipopiezageoSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            idtratamientoSpinEdit_EditValueChanged(sender, e);
            UpdateUI();
           
        }
        private DSACATTA.T_TipoPiezaGeometriaRow PiezaGeo { get {
            if (tTipoPiezaGeometriaBindingSource.Current == null)
                return null;
            return (DSACATTA.T_TipoPiezaGeometriaRow)((DataRowView)tTipoPiezaGeometriaBindingSource.Current).Row;
        }
        }

        public DSACATTA.T_AceroRow Acero
        {
            get
            {

                return (DSACATTA.T_AceroRow)((DataRowView)tAceroBindingSource.Current).Row;
        } }
        public DSACATTA.T_ColocacionPiezaRow ColPieza
        {
            get
            {
                if (tColocacionPiezaBindingSource.Current == null)
                    return null;
                return (DSACATTA.T_ColocacionPiezaRow)((DataRowView)tColocacionPiezaBindingSource.Current).Row;
            }
        }
        public DSACATTA.T_TipoPropiedadSolRow PropiedadSol
        {
            get
            {
                if (tTipoPropiedadSolBindingSource.Current == null)
                    return null;
                return (DSACATTA.T_TipoPropiedadSolRow)((DataRowView)tTipoPropiedadSolBindingSource.Current).Row;
            }
        }
        public DSACATTA.T_HornoRow Horno
        {
            get
            {
                return (DSACATTA.T_HornoRow)((DataRowView)tHornoBindingSource.Current).Row;
            }
        }
        public DSACATTA.T_TipoPiezaRow TipoPieza
        {
            get
            {
                return (DSACATTA.T_TipoPiezaRow)((DataRowView)tTipoPiezaBindingSource.Current).Row;
            }
        }
        public DSACATTA.T_TipoTratamientoRow Tratamiento
        {
            get
            {
                return (DSACATTA.T_TipoTratamientoRow)((DataRowView)tTipoTratamientoBindingSource.Current).Row;
            }
        }
        public MedioCalentamiento MedioCalentador { get { return ((MedioCalentamiento)int.Parse(imageComboBoxEdit1.EditValue.ToString()));} }
        public DSACATTA.T_RegimenCalentamientoRow Regimen
        {
            get
            {
                return (DSACATTA.T_RegimenCalentamientoRow)((DataRowView)tRegimenCalentamientoBindingSource.Current).Row;
            }
        }
        public DSACATTA.T_SeparacionPiezaRow Separacion
        {
            get
            {
                return (DSACATTA.T_SeparacionPiezaRow)((DataRowView)tSeparacionPiezaBindingSource.Current).Row;
            }
        }
   
        private double GetEditAsDouble(SpinEdit edit)
        {
            double s = 0;
            if(edit.EditValue!=null)
            double.TryParse(edit.EditValue.ToString(), out s);

            return s;
        }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                var r = Acero.Calculate(Horno, GetEditAsDouble(textEdit1), TipoPieza, PiezaGeo, Tratamiento, MedioCalentador, ColPieza, Separacion, GetEditAsDouble(largoSpinEdit), GetEditAsDouble(anchoSpinEdit), GetEditAsDouble(alturaSpinEdit), GetEditAsDouble(valorxSpinEdit), GetEditAsDouble(seph), Regimen);
                 
                r.Add("ps", PropiedadSol.nametipopropiedad);
                r.Add("psi", propiniSpinEdit.EditValue.ToString());
                r.Add("psv", propsolSpinEdit.EditValue.ToString());
                r.Add("rc", Regimen.imgregcalent);
                r.Add("cp", cantpiezasSpinEdit.EditValue.ToString());
                r.Add("tempmax", Acero.GetTempMax(Tratamiento));
                r.Add("rgcn",Regimen.nameregcalent);
                r.Add("m", Acero.nameacero);
                r.Add("parameter1",Regimen.imgregcalent);
                dSDatos.AceroElemento.Clear();
                var t = Acero.GetT_AceroElementoRows();
                foreach (DSACATTA.T_AceroElementoRow aelem in t)
                {
                    var elem = aelem.T_ElementoRow;
                    var s = dSDatos.AceroElemento.NewAceroElementoRow();
                    s.elemento = elem.nameelemento;
                    s.valorini = aelem.valorinicial.ToString();
                    s.valorfin = aelem.valorfinal.ToString();
                    dSDatos.AceroElemento.AddAceroElementoRow(s);
                }
                dSDatos.AceroElemento.AcceptChanges();
                var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
                frmreport.Text = @"Reporte de cálculo de tratamiento térmico";
                frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\ACATTA\CalculoTT.repx", r, dSDatos.AceroElemento);
                frmreport.ShowDialog(this);
                Close();
            }
        }
        private void imageComboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idtratamientoSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ((System.Windows.Forms.BindingSource)((DevExpress.XtraEditors.GridLookUpEdit)sender).Properties.DataSource).Position = ((System.Windows.Forms.BindingSource)((DevExpress.XtraEditors.GridLookUpEdit)sender).Properties.DataSource).Find(((DevExpress.XtraEditors.GridLookUpEdit)sender).Properties.ValueMember, ((DevExpress.XtraEditors.GridLookUpEdit)sender).EditValue);
            }
            catch
            {}
        }

       
    }
}