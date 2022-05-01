using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Charts.Native;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid;
using MCC;
using MCC.Codificadores;
using MCC.Tareas;
using DevExpress.XtraVerticalGrid.Rows;
using TMC.Components.TemperatureControl;
using TMC.RD;
using DevExpress.XtraBars.Ribbon;
using TMC.RD.Codificadores;
using TMC.RD.Tareas;


namespace TMC.RD
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        public void FrmMain_Load(object sender, EventArgs e)
        {
            dSDatos.T_Propiedad_Fisica.Clear();
            dSDatos.T_Material.Clear();
            
            
            t_MaterialTableAdapter1.Fill(dSDatos.T_Material);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Propiedad_Mecanica' Puede moverla o quitarla según sea necesario.
            t_Propiedad_FisicaTableAdapter1.Fill(dSDatos.T_Propiedad_Fisica);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Material' Puede moverla o quitarla según sea necesario.
            t_Grado_PHTableAdapter1.Fill(dSDatos.T_Grado_PH);

            t_FormulaTableAdapter1.Fill(dSDatos.T_Formula);
            t_Propiedad_TermodinamicaTableAdapter1.Fill(dSDatos.T_Propiedad_Termodinamica);
            t_Propiedad_Fisica_ElementoTableAdapter1.Fill(dSDatos.T_Propiedad_Fisica_Elemento);
            t_ElementoTableAdapter1.Fill(dSDatos.T_Elemento);
            t_Propiedad_ProduccionTableAdapter1.Fill(dSDatos.T_Propiedad_Produccion);
            t_FormatoTableAdapter1.Fill(dSDatos.T_Formato);
            t_Tipo_FormatoTableAdapter1.Fill(dSDatos.T_Tipo_Formato);
            t_DegradeeTableAdapter1.Fill(dSDatos.T_Degradee);
            t_Elemento_OxidoTableAdapter1.Fill(dSDatos.T_Elemento_Oxido);
            GetTreeMateriales();
            treeList1_FocusedNodeChanged(treeList1, null);
        }

        private String GetNextName()
        {
            var s = "Estudio";
            var i = 1;
            foreach (Form mdiChild in MdiChildren)
                if (mdiChild.Text == s + i)
                    i++;
            return s + i;
        }
        private Form CreateForm(Form form, bool dialog=false)
        {
            return ((MasterForm) Application.OpenForms[MasterForm.Index]).CreateForm(form, dialog);
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          ////  var f = new FrmCreateProject();
          ////  f.edit = -1;
          ////  if(f.ShowDialog(this)==DialogResult.OK)
          ////  {
          //      var w = CreateForm(new FrmEstudio(1/*f.edit*/,barButtonItem3,dSDatos), false);
         
          //// }

            Project.CreateFromFile(@"C:\a.t");
            //t_ProjectTableAdapter.Fill(dSRD.T_Project);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateForm(new FrmGrado_PH(), true);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateForm(new FrmTipo_Formato(), true);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

       

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmadd = new FrmGestor_Datos_MRA();
            frmadd.edit = -1;

            if (frmadd.ShowDialog(this) == DialogResult.OK)
                FrmMain_Load(sender, null);
        }

        public void GetTreeMateriales()
        {
            treeList1.ClearNodes();

            if (comboBoxEdit1.SelectedIndex == 0)
                foreach (var material in dSDatos.T_Material)
                {
                    var t = treeList1.AppendNode(material.namematerial, null);
                    t.Tag = material;
                    t.SetValue(0, material.namematerial);
                }

            if (comboBoxEdit1.SelectedIndex == 1)
            {
                var EXL = treeList1.AppendNode("Materiales Extralivianos (<800 KG/m³)", null);
                EXL.SetValue(0, "Materiales Extralivianos (<800 KG/m³)");
                var ML = treeList1.AppendNode("Materiales Medios Livianos (800-1100 KG/m³)", null);
                ML.SetValue(0,"Materiales Medios Livianos (800-1100 KG/m³)");
                var MP = treeList1.AppendNode("Materiales Medios Pesados (1100-1600 KG/m³)", null);
                MP.SetValue(0, "Materiales Medios Pesados (1100-1600 KG/m³)");
                var C = treeList1.AppendNode("Materiales Convencionales (1600-2500 KG/m³)", null);
                C.SetValue(0, "Materiales Convencionales (1600-2500 KG/m³)");
                var ED = treeList1.AppendNode("Materiales Extra Densos (>2500 KG/m³)", null);                
                ED.SetValue(0, "Materiales Extra Densos (>2500 KG/m³)");
                
                
                foreach (var material in dSDatos.T_Material)
                {
                    if (material.GetDensidadMaterial() == TipoDensidad.Materiales_Extralivianos)
                    {
                       var t  = treeList1.AppendNode(material.namematerial, EXL);
                        t.Tag = material;
                        t.SetValue(0, material.namematerial);
                    }
                    else
                    if (material.GetDensidadMaterial() == TipoDensidad.Materiales_Medios_Livianos)
                    {
                        var t = treeList1.AppendNode(material.namematerial, ML);
                        t.Tag = material.namematerial;
                        t.SetValue(0, material.namematerial);
                    }
                    else
                    if (material.GetDensidadMaterial() == TipoDensidad.Materiales_Medios_Pesados)
                    {
                        var t = treeList1.AppendNode(material.namematerial, MP);
                        t.Tag = material.namematerial;
                        t.SetValue(0, material.namematerial);
                    }
                    else
                    if (material.GetDensidadMaterial() == TipoDensidad.Materiales_Convencionales)
                    {
                        var t = treeList1.AppendNode(material.namematerial, C);
                        t.Tag = material.namematerial;
                        t.SetValue(0, material.namematerial);
                    }
                    else
                    if (material.GetDensidadMaterial() == TipoDensidad.Materiales_Extradensos)
                    {
                        var t = treeList1.AppendNode(material.namematerial, ED);
                        t.Tag = material.namematerial;
                        t.SetValue(0, material.namematerial);
                    }
                }
            }


            if (comboBoxEdit1.SelectedIndex == 2)
            {

            }

            if (comboBoxEdit1.SelectedIndex == 3)
            {

                foreach (var Grado_PH in dSDatos.T_Grado_PH)
                {
                    var ED = treeList1.AppendNode(Grado_PH.Nombre, null);
                    ED.Tag = Grado_PH.Nombre;
                    ED.SetValue(0,Grado_PH.Nombre);
                    foreach (var Propiedad_Fisica in Grado_PH.GetT_Propiedad_FisicaRows())
                    {
                      var t = treeList1.AppendNode(Propiedad_Fisica.T_MaterialRow.namematerial, ED);
                        t.Tag = Propiedad_Fisica.T_MaterialRow;
                        t.SetValue(0, Propiedad_Fisica.T_MaterialRow.namematerial);
                    }

                }
            }


            
        }


        public void ActualizarGridControl(DSRD.T_MaterialRow materialRow)
        {
            vGridControl1.Rows.Clear();
            var categoryRow = new CategoryRow();
            var categoryRow2 = new CategoryRow();
            var editorRow = new EditorRow();

            categoryRow.Properties.Caption = "Propiedad Fisica";
            vGridControl1.Rows.Add(categoryRow);


            editorRow.Properties.Caption = "Densidad (Kg/m³)";
            editorRow.Properties.Value = materialRow.GetT_Propiedad_FisicaRows()[0].Densidad.ToString();
            categoryRow.ChildRows.Add(editorRow);
            editorRow = new EditorRow();
            editorRow.Properties.Caption = "Porocidad";
            editorRow.Properties.Value = materialRow.GetT_Propiedad_FisicaRows()[0].Porocidad.ToString();
            categoryRow.ChildRows.Add(editorRow);
            editorRow = new EditorRow();
            editorRow.Properties.Caption = "M";
            editorRow.Properties.Value = materialRow.GetFormula("M");
            categoryRow.ChildRows.Add(editorRow);

            editorRow = new EditorRow();            
            categoryRow2.Properties.Caption = "Composición Química";
            categoryRow.ChildRows.Add(categoryRow2);
            foreach (var PFE in materialRow.GetT_Propiedad_FisicaRows()[0].GetT_Propiedad_Fisica_ElementoRows())
            {
                editorRow = new EditorRow();
                editorRow.Properties.Value = PFE.Porciento ;
                editorRow.Properties.Caption = PFE.T_Elemento_OxidoRow.T_ElementoRow.nameelemento + "%";
                categoryRow2.ChildRows.Add(editorRow);
            }
            editorRow = new EditorRow();
            editorRow.Properties.Caption = "Grado PH";
            editorRow.Properties.Value = materialRow.GetT_Propiedad_FisicaRows()[0].T_Grado_PHRow.Nombre;
            categoryRow.ChildRows.Add(editorRow);

            categoryRow = new CategoryRow();
            
            
            categoryRow.Properties.Caption = "Propiedad Mecanica";
            vGridControl1.Rows.Add(categoryRow);

            
            editorRow = new EditorRow();
            editorRow.Properties.Value = materialRow.GetFormula("P");
            editorRow.Properties.Caption = "P";
            categoryRow.ChildRows.Add(editorRow);
            editorRow = new EditorRow();
            editorRow.Properties.Value = materialRow.GetFormula("E");
            editorRow.Properties.Caption = "E (MPa)";
            categoryRow.ChildRows.Add(editorRow);

            categoryRow = new CategoryRow();
            categoryRow.Properties.Caption = "Propiedad Termodinamica";
            vGridControl1.Rows.Add(categoryRow);


            editorRow = new EditorRow();
            editorRow.Properties.Value = materialRow.GetT_Propiedad_TermodinamicaRows()[0].Temperatura;
            editorRow.Properties.Caption = "Temperatura de Trabajo";
            categoryRow.ChildRows.Add(editorRow);
            editorRow = new EditorRow();
            editorRow.Properties.Value = materialRow.GetFormula("A");
            editorRow.Properties.Caption = "A (x10^-6 °C^-1)";
            categoryRow.ChildRows.Add(editorRow);
            editorRow = new EditorRow();
            editorRow.Properties.Value = materialRow.GetFormula("K");
            editorRow.Properties.Caption = "K (W/m°C)";
            categoryRow.ChildRows.Add(editorRow);
            editorRow = new EditorRow();
            editorRow.Properties.Value = materialRow.GetFormula("Cp");
            editorRow.Properties.Caption = "Cp (J/Kg°C)";
            categoryRow.ChildRows.Add(editorRow);

            categoryRow = new CategoryRow();
            categoryRow2 = new CategoryRow();

            categoryRow.Properties.Caption = "Propiedad Produccion";
            vGridControl1.Rows.Add(categoryRow);


            editorRow.Properties.Caption = "Costo / Precio de Compra (UM/m³)";
            editorRow.Properties.Value = materialRow.GetT_Propiedad_ProduccionRows()[0].Costo;
            categoryRow.ChildRows.Add(editorRow);;

       
            //editorRow.Properties.Value = PFE.GetType().GetProperty("altura").GetValue(;  VER ESTO DESPUES

            var i = 1;
            foreach (var Formato in materialRow.GetT_Propiedad_ProduccionRows()[0].GetT_FormatoRows())
            {

                categoryRow2  = new CategoryRow();
                categoryRow2.Expanded = false;
                categoryRow2.Properties.Caption = "Formato " +i;
                i++;
                categoryRow.ChildRows.Add(categoryRow2);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.Nombre;
                editorRow.Properties.Caption = "Nombre";
                categoryRow2.ChildRows.Add(editorRow);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.altura.ToString();
                editorRow.Properties.Caption = "Altura (mm)";
                categoryRow2.ChildRows.Add(editorRow);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.Espesor.ToString();
                editorRow.Properties.Caption = "Espesor (mm)";
                categoryRow2.ChildRows.Add(editorRow);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.Largo1.ToString();
                editorRow.Properties.Caption = "Largo1 (mm)";
                categoryRow2.ChildRows.Add(editorRow);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.Largo2.ToString();
                editorRow.Properties.Caption = "Largo2 (mm)";
                categoryRow2.ChildRows.Add(editorRow);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.Radio.ToString();
                editorRow.Properties.Caption = "Radio (mm)";
                categoryRow2.ChildRows.Add(editorRow);
                editorRow = new EditorRow();
                editorRow.Properties.Value = Formato.T_Tipo_FormatoRow.Nombre;
                editorRow.Properties.Caption = "Tipo Formato";
                categoryRow2.ChildRows.Add(editorRow);
            }
            
        }

        private void comboBoxEdit1_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTreeMateriales();
        }



        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el Materia?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                var material = treeList1.FocusedNode;
                
                if (material.Tag is DSRD.T_MaterialRow)
                {
                    tMaterialBindingSource.Position = tMaterialBindingSource.Find("idmaterial",
                                                                                  ((DSRD.T_MaterialRow) material.Tag)
                                                                                      .idmaterial);
                    tMaterialBindingSource.RemoveCurrent();
                    t_MaterialTableAdapter1.Update(dSDatos.T_Material);
                }
                GetTreeMateriales();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmadd = new FrmGestor_Datos_MRA();
            var material = treeList1.FocusedNode;
            frmadd.edit = ((DSRD.T_MaterialRow)material.Tag).idmaterial;

            if (frmadd.ShowDialog(this) == DialogResult.OK)
                FrmMain_Load(sender, null);
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if(treeList1.FocusedNode!=null)
            if (treeList1.FocusedNode.Tag is DSRD.T_MaterialRow)
            {
            ActualizarGridControl((DSRD.T_MaterialRow)treeList1.FocusedNode.Tag);
            }
            barButtonItem10.Enabled = treeList1.FocusedNode != null;
            barButtonItem5.Enabled = treeList1.FocusedNode != null;

        }

        private void vGridControl1_Resize(object sender, EventArgs e)
        {
           // vGridControl1.Rows[0].
        }

        public void barButtonItem6_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           ((DockPanel) ((BarButtonItem)sender).Tag).Visible = ((BarButtonItem) sender).Down;
        }

    
        public void dockPanel1_VisibilityChanged(object sender, DevExpress.XtraBars.Docking.VisibilityChangedEventArgs e)
        {
            ((BarButtonItem) ((DockPanel)sender).Tag).Down = e.Visibility == DockVisibility.Visible;
            
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmSettings = new FrmSettings();

            frmSettings.ShowDialog(this);
        }

        public void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            barButtonItem13.Enabled = ((Form) sender).ActiveMdiChild is FrmEstudio;
            barButtonItem3.Enabled = barButtonItem13.Enabled ;
     
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new FrmCreateProject();
            f.edit = ((FrmEstudio)Application.OpenForms[MasterForm.Index].ActiveMdiChild).Project.idproject;
            if (f.ShowDialog(this) == DialogResult.OK)
                ((FrmEstudio)Application.OpenForms[MasterForm.Index].ActiveMdiChild).Recalculate();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((FrmEstudio)Application.OpenForms[MasterForm.Index].ActiveMdiChild).Save();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new FrmOpenProject();
            if (f.ShowDialog(this) == DialogResult.OK)
                CreateForm(new FrmEstudio(f.idProject,barButtonItem3,dSDatos), false);
        }

 
       

       
    }
}