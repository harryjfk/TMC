using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;


namespace TMC.SIAR.Tareas
{
    public partial class FrmGestor_Datos_MRA : Form
    {
        private int _edit;
        public FrmGestor_Datos_MRA()
        {
            InitializeComponent();
        }
        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSDatos);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }
        
        private void SetFormula(String frm, String value)
        {
            var s = Material.GetT_FormulaRows();
            var t = false;
            foreach (var formulaRow in s)
                if (formulaRow.mi == frm)
                {
                    formulaRow.md = value;
                    t = true;
                    break;
                }
            if (!t)
            {
                var f = dSDatos.T_Formula.NewT_FormulaRow();
                f.mi = frm;
                f.md = value;
                f.idmaterial = Material.idmaterial;
                dSDatos.T_Formula.AddT_FormulaRow(f);
            }
        }

        public int edit { get { return _edit; }
            set
            {
                _edit = value;
                t_FormulaTableAdapter1.Fill(dSDatos.T_Formula);
                string t = "";
                if (edit != -1)
                {
                    //t_Propiedad_TermodinamicaTableAdapter1.Fill(dSDatos.T_Propiedad_Termodinamica);
                   
                    t_MaterialTableAdapter1.FillBy(dSDatos.T_Material, edit);
                    t_Propiedad_FisicaTableAdapter.FillBy(dSDatos.T_Propiedad_Fisica, edit);
                    t_Propiedad_TermodinamicaTableAdapter1.FillBy(dSDatos.T_Propiedad_Termodinamica, edit);
                    t_Propiedad_ProduccionTableAdapter.FillBy(dSDatos.T_Propiedad_Produccion, edit);
                    t_Propiedad_Fisica_ElementoTableAdapter.FillBy(dSDatos.T_Propiedad_Fisica_Elemento, edit);
                    t_FormatoTableAdapter.FillBy(dSDatos.T_Formato, edit);
                    textEdit2.EditValue = Propiedad_Termodinamica.Temperatura;
                    textEdit9.EditValue = Propiedad.Densidad;
                    textEdit4.EditValue = Propiedad.Porocidad;
                    textEdit6.EditValue = Propiedad.Indice_Silicatacion;
                    gridLookUpEdit1.EditValue = Propiedad.idGradoPH;
                    textEdit7.EditValue = Produccion.Costo;
                }
                else
                {
                    t_MaterialBindingSource.AddNew();
                    t_MaterialBindingSource.MoveLast();
                    dSDatos.T_Propiedad_Fisica.idMaterialColumn.DefaultValue = Material.idmaterial;
                    dSDatos.T_Propiedad_Termodinamica.idMaterialColumn.DefaultValue = Material.idmaterial;
                    dSDatos.T_Propiedad_Produccion.idMateriaColumn.DefaultValue = Material.idmaterial;
                
                    fKTPropiedadFisicaTMaterialBindingSource.AddNew();
                    fKTPropiedadFisicaTMaterialBindingSource.MoveLast();
                    TPropiedad_TermodinamicabindingSource.AddNew();
                    TPropiedad_TermodinamicabindingSource.MoveLast();
                    //TPropiedades_MecanicasbindingSource.AddNew();
                    //TPropiedades_MecanicasbindingSource.MoveLast();

                   

                    bindingSource_Produccion.AddNew();
                    bindingSource_Produccion.MoveLast();
               



                }
                dSDatos.T_Formato.idPropiedad_ProduccionColumn.DefaultValue = Produccion.idPropiedad_Produccion;
                dSDatos.T_Propiedad_Fisica_Elemento.idPropiedad_FisicaColumn.DefaultValue =
                    Propiedad.idPropiedad_Fisica;
                t = edit == -1 ? "Añadir nuevo material" : "Editar material";

               textEdit3.EditValue = Material.GetFormula("A");

                textEdit8.EditValue = Material.GetFormula("K");

                textEdit11.EditValue = Material.GetFormula("Cp");

                textEdit14.EditValue = Material.GetFormula("P");

                textEdit17.EditValue = Material.GetFormula("E");

                textEdit5.EditValue = Material.GetFormula("M");

                Text = t;

            }
        }
        private DSRD.T_MaterialRow Material { get { return (DSRD.T_MaterialRow)((DataRowView)t_MaterialBindingSource.Current).Row; } }
        private DSRD.T_Propiedad_ProduccionRow Produccion { get { return (DSRD.T_Propiedad_ProduccionRow)((DataRowView)bindingSource_Produccion.Current).Row; } }
        private DSRD.T_Propiedad_FisicaRow Propiedad { get { return (DSRD.T_Propiedad_FisicaRow)((DataRowView)fKTPropiedadFisicaTMaterialBindingSource.Current).Row; } }
        private DSRD.T_Propiedad_TermodinamicaRow Propiedad_Termodinamica { get { return (DSRD.T_Propiedad_TermodinamicaRow)((DataRowView)TPropiedad_TermodinamicabindingSource.Current).Row; } }

        //private DSDatos.T_Propiedad_MecaniacaRow Propiedad_Mecanica { get { return (DSDatos.T_Propiedad_MecanicaRow)((DataRowView)TPropiedades_MecanicasbindingSource.Current).Row; } }
        private void FrmGestor_Datos_MRA_Load(object sender, EventArgs e)
        {
            t_ElementoTableAdapter.Fill(dSDatos.T_Elemento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Elemento_Oxido' Puede moverla o quitarla según sea necesario.)
            this.t_Elemento_OxidoTableAdapter.Fill(this.dSDatos.T_Elemento_Oxido);
            dSDatos.T_Elemento_Oxido.FillNames();
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Grado_PH' Puede moverla o quitarla según sea necesario.
            this.t_Grado_PHTableAdapter.Fill(this.dSDatos.T_Grado_PH);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Formato' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_FormatoTableAdapter.Fill(this.dSDatos.T_Tipo_Formato);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Propiedad_Produccion' Puede moverla o quitarla según sea necesario.
            //this.t_Propiedad_ProduccionTableAdapter.Fill(this.dSDatos.T_Propiedad_Produccion);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Elemento' Puede moverla o quitarla según sea necesario.
            this.t_ElementoTableAdapter.Fill(this.dSDatos.T_Elemento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Propiedad_Fisica' Puede moverla o quitarla según sea necesario.
            //this.t_Propiedad_FisicaTableAdapter.Fill(this.dSDatos.T_Propiedad_Fisica);
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Propiedad_Fisica_Elemento' Puede moverla o quitarla según sea necesario.
            //this.t_Propiedad_Fisica_ElementoTableAdapter.Fill(this.dSDatos.T_Propiedad_Fisica_Elemento);
            // TODO: esta línea de código cara datos en la tabl.DefaultView.Count>0P
            t_FormulaTableAdapter1.Fill(dSDatos.T_Formula);
            
            SetTrace();





        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            if (dxValidationProvider1.Validate())
            {
            t_MaterialBindingSource.EndEdit();


            //bindingSource_Produccion.EndEdit();
            //t_Propiedad_ProduccionTableAdapter.Update(dSDatos.T_Propiedad_Produccion);


            t_MaterialTableAdapter1.Update(dSDatos.T_Material);
            var t = Propiedad.idPropiedad_Fisica;

            if (edit == -1) Propiedad.idMaterial = Material.idmaterial;

            fKTPropiedadFisicaTMaterialBindingSource.EndEdit();

            t_Propiedad_FisicaTableAdapter.Update(dSDatos.T_Propiedad_Fisica);
            if (edit == -1)
                foreach (DataRowView dataRowView in fKTPropiedadFisiscaElementoTPropiedadFisicaBindingSource)
                {
                    var row = (DSRD.T_Propiedad_Fisica_ElementoRow)dataRowView.Row;
                    if (row.idPropiedad_Fisica == t)
                        row.idPropiedad_Fisica = Propiedad.idPropiedad_Fisica;
                    fKTPropiedadFisiscaElementoTPropiedadFisicaBindingSource.EndEdit();
                }


            t_Propiedad_Fisica_ElementoTableAdapter.Update(dSDatos.T_Propiedad_Fisica_Elemento);

            //////////////////////////////////////////////////////////////////////////////////

            var Pt = Propiedad_Termodinamica.idPropiedad_Termica;
            if (edit == -1)
                Propiedad_Termodinamica.idMaterial = Material.idmaterial;
            TPropiedad_TermodinamicabindingSource.EndEdit();
            t_Propiedad_TermodinamicaTableAdapter1.Update(dSDatos.T_Propiedad_Termodinamica);

            
            ///////////////////////////////////////////////////////////////////////

            //var Pm = Propiedad_Mecanica.idPropiedad_Mecanica;
            //if (edit == -1)
            //    Propiedad_Mecanica.idMateria = Material.idMaterial;

            //TPropiedades_MecanicasbindingSource.EndEdit();
            //t_Propiedad_MecanicaTableAdapter1.Update(dSDatos.T_Propiedad_Mecanica);

            ///////////////////////////////////////////////////////////////////////
            var p = Produccion.idPropiedad_Produccion;
            if (edit == -1)
               Produccion.idMateria = Material.idmaterial;
            
            bindingSource_Produccion.EndEdit();
            t_Propiedad_ProduccionTableAdapter.Update(dSDatos.T_Propiedad_Produccion);

            if (edit == -1)

                foreach (DataRowView dataRowView in tFormatoBindingSource)
                {
                    var row = (DSRD.T_FormatoRow)dataRowView.Row;
                    if (row.idPropiedad_Produccion == p)
                        row.idPropiedad_Produccion = Produccion.idPropiedad_Produccion;
               
                }
            tFormatoBindingSource.EndEdit();
            t_FormatoTableAdapter.Update(dSDatos.T_Formato);

            SetFormula("A", textEdit3.Text);
            SetFormula("Cp", textEdit11.Text);
            SetFormula("K", textEdit8.Text);
            SetFormula("P", textEdit14.Text);
            SetFormula("E", textEdit17.Text);
            SetFormula("M", textEdit5.Text);


            t_FormulaTableAdapter1.Update(dSDatos.T_Formula);
            DialogResult = DialogResult.OK;
            if (edit != -1)
            {
                MessageBox.Show("El material fue editado con éxito.", "Guardado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            
                
            }
            else

                MessageBox.Show("El material fue guardado con éxito.", "Guardado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            Close();

            }
            else
            {
                MessageBox.Show("Existen campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


         
        }

        private void bindingSource_Produccion_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                FrmEditFormato formato = new FrmEditFormato();
                formato.bindingformato = tFormatoBindingSource;
                formato.edit = tFormatoBindingSource.Position;
                if (formato.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    
                }
            }

            else if (
                MessageBox.Show("Desea eliminar este formato?", "Eliminar", MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                tFormatoBindingSource.RemoveCurrent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmEditFormato formato = new FrmEditFormato();
            formato.bindingformato = tFormatoBindingSource;
            formato.edit = -1;
            formato.ShowDialog();

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textEdit7.EditValue =  Produccion.getCostoProm();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
