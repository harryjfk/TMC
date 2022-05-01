using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using TMC.Components;
using TMC.Components.TemperatureControl;
using SelectableObject = TMC.Components.SelectableObject;
using UCSelectableControl = TMC.Components.UCSelectableControl;
using DevExpress.XtraTreeList;


namespace TMC.RD.Tareas
{
    public partial class FrmEstudio : DevExpress.XtraEditors.XtraForm
    {
        public FrmEstudio()
        {
            InitializeComponent();
            t_Tipo_ParedTableAdapter1.Fill(dSDatos.T_Tipo_Pared);
        }
        public FrmEstudio(int project,BarButtonItem t,DSRD dsrd)
        {
            InitializeComponent();
            SaveIitem = t;
            _dsest = dsrd;
            t_Tipo_ParedTableAdapter1.Fill(dSDatos.T_Tipo_Pared);
            t_DegradeeTableAdapter1.Fill(dSDatos.T_Degradee);
            this.t_ProjectTableAdapter.FillBy(this.dSDatos.T_Project,project);
            Text = Project.nameproject;
            ucCompleteProperty1.InnerControl.Algorithm.TDataSet = DSExt;
            ucCompleteProperty1.InnerControl.Algorithm.Project = Project;
          
            ucCompleteProperty1.TempInterna = Project.tempdise;
            ucCompleteProperty1.TempAmbiente = Project.tempamb;
            ucCompleteProperty1.InnerControl.OnSelectedChanged += new UCSelectableControl.SelectedEvent(InnerControl_OnSelectedChanged);
            ucCompleteProperty1.InnerControl.OnSelectedResize += new UCSelectableControl.SelectedEvent(InnerControl_OnSelectedResize);
            chartControl1.Series.Clear();
            //src = TMC.Components.TemperatureControl.Project.ConvertFromDataSet(ucCompleteProperty1.InnerControl);
           ucCompleteProperty1.InnerControl.LoadFromProject();
            foreach (DSRD.T_MaterialRow materialRow in ucCompleteProperty1.InnerControl.Algorithm.Materiales)
            UpdateMaterial(materialRow);
        }

        private DSRD _dsest;
        public DSRD DSExt { get { return _dsest; } }
  
        private void RefreshGraph()
        {
            double w = 0;
            double l = 0;

            for (int index = 0; index < ucCompleteProperty1.InnerControl.Algorithm.Spesor.Count; index++)
                if ( index * 2<chartControl1.Series.Count)
                {

                    Series series = chartControl1.Series[index * 2];
                    series.Points.Clear();

                    if (index == 0)
                        series.Points.Add(
                        new SeriesPoint(
                             0, Project.tempdise));
                    else
                        series.Points.Add(
                        new SeriesPoint(
                             w, l));
                    w += ucCompleteProperty1.InnerControl.Algorithm.Spesor[index];

                    l = ((List<double>)ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial["TEXP"])[index + 1];
                    series.Points.Add(
                        new SeriesPoint(
                             w, l));
                    series.Label.Text = "aaa";


                }
            ////for (int index = 0; index < chartControl1.Series.Count; index++)
            ////{
            ////    Series series = chartControl1.Series[index];
            ////    series.Points.Clear();
            ////    series.Points.Add(new SeriesPoint(10, 20));
            ////}
        }

        void InnerControl_OnSelectedResize(SelectableObject SelectableObject)
        {
            foreach(var t in ucCompleteProperty1.InnerControl.Algorithm.Materiales)
                UpdateMaterial(t);
            UpdateTree();
            CheckChanged();
        }
        private void AddTree(string name, string value)
        {
            var s = DesignTree.AppendNode(null, null);
            s.SetValue(0,name);
            s.SetValue(1,value);
        }
        private void UpdateTree()
        {
            DesignTree.ClearNodes();
            AddTree("Espesor Total (mm)",ucCompleteProperty1.InnerControl.Espesor.ToString());
            AddTree("Volumen (m^3)", ucCompleteProperty1.InnerControl.Volumen.ToString());
            AddTree("Peso (kg)", ucCompleteProperty1.InnerControl.Peso.ToString());
            AddTree("Costo (UM)", ucCompleteProperty1.InnerControl.Costo.ToString());
                 AddTree("Area Externa (m^2)", Project.area.ToString());
                 AddTree("Perdida Total (m^3)", ucCompleteProperty1.InnerControl.PerdidaTotal.ToString());
            AddTree("Flujo Calorico (W/m^2)",ucCompleteProperty1.InnerControl.FlujoCalorico.ToString());
            if (ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial != null)
            {
                var t = (List<double>) ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial["TEXP"];
                AddTree("Temperatura Externa (C)", t[t.Count - 1].ToString());
            }
            else
                AddTree("Temperatura Externa (C)", 0.ToString());
        }

        public BarButtonItem SaveIitem { get; set; }
        void InnerControl_OnSelectedChanged(SelectableObject selectableObject)
        {
            if (selectableObject != null)
                if (selectableObject.Selected)
                {
                    var t = (PropertyTempItem) selectableObject;
                    UpdateMaterial(t.Material);
                }

            CheckChanged();
        }
        public bool Changed()
        {
            return !ucCompleteProperty1.InnerControl.Algorithm.ProjectObject.IsEqual(Components.TemperatureControl.Project.ConvertFromDataSet(ucCompleteProperty1.InnerControl));
    
        }
        private void CheckChanged()
        {
            Text = Project.nameproject;
            var s = Changed();
            if (SaveIitem != null)
                SaveIitem.Enabled = s;
            if (s)
                Text+= '*';

        }
        public void Save()
        {
            ucCompleteProperty1.InnerControl.Algorithm.ProjectObject = Components.TemperatureControl.Project.ConvertFromDataSet(ucCompleteProperty1.InnerControl);
            var t = ucCompleteProperty1.InnerControl.Algorithm.ProjectObject.AsStream();
            Project.dataproject = ACINOX.Functions.File.MemToArray(t);
            t_ProjectTableAdapter.Update(dSDatos.T_Project);
            CheckChanged();

        }
        private int IndexOf(DSRD.T_MaterialRow materialRow)
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
                if (treeList1.Nodes[i].Tag == materialRow)
                    return i;
            return -1;
        }
        private void UpdateMaterial(DSRD.T_MaterialRow material)
        {
            var i = IndexOf(material);
            double esp = ucCompleteProperty1.InnerControl.GetSpesor(material);
            TreeListNode node = null;
            if (i == -1)
            {
                node = treeList1.AppendNode(material, null);
                chartControl1.Series.Add(material.namematerial, ViewType.Line);
                chartControl1.Series[chartControl1.Series.Count - 1].Tag = material;
                chartControl1.Series[chartControl1.Series.Count - 1].LabelsVisibility = DefaultBoolean.True;


                   chartControl1.Series.Add("", ViewType.StackedLine3D);

            }
            else
                node = treeList1.Nodes[i];
            node.Tag = material;
            node.SetValue(0, material.namematerial);
            node.SetValue(1, esp);
            if (ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial != null)
            {
                //   if(i==-1)
                i = ucCompleteProperty1.InnerControl.Algorithm.Materiales.IndexOf(material) + 1;
                var ts = ((List<double>)ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial["TMTP"])[i];

                var l = new Dictionary<String, String>();
                l.Add("T", ts.ToString());
                node.SetValue(2, new Ecuation(material.GetFormula("K"), "", l).RightSide.Parameters.AsDouble());
                node.SetValue(3, ts);
                node.SetValue(4, material.Estres(esp, (double)ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial["QPAR"], ((List<double>)ucCompleteProperty1.InnerControl.Algorithm.LastSisParcial["LP"])[i], ts));
            }
            node.SetValue(5, material.GetT_Propiedad_ProduccionRows()[0].getCostoProm());
            node.SetValue(6, ucCompleteProperty1.InnerControl.GetSpesor(material) * material.GetT_Propiedad_FisicaRows()[0].Densidad * Project.area);
            node.SetValue(7, ucCompleteProperty1.InnerControl.GetSpesor(material) * Project.area);
            RefreshGraph();
      }
        private void FrmEstudio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Project' Puede moverla o quitarla según sea necesario.
            
        }

        public DSRD.T_ProjectRow Project
        {
            get { return (DSRD.T_ProjectRow)((DataRowView)bindingSource1.Current).Row; }

        }
        public void Recalculate()
        {
            this.t_ProjectTableAdapter.FillBy(this.dSDatos.T_Project, Project.idproject);
            Text = Project.nameproject;
            ucCompleteProperty1.InnerControl.Algorithm.Project = Project;
            ucCompleteProperty1.InnerControl.ReCalculateAll();
            CheckChanged();
        }
        public TreeList DesignTree{get { var m = (MasterForm) Application.OpenForms[MasterForm.Index];

            var s = "Indicadores de Diseño";
            DockPanel w=null ;
            foreach (DockPanel panel in m.DockManager.Panels)
                if(panel.Text ==s)
                {
                    w = panel;
                    break;
                }
            if(w!=null)
                return (TreeList)w.Controls[0].Controls[0];
            return null;

        }}

   
        private void ucCompleteProperty1_DragDrop(object sender, DragEventArgs e)
        {
            //ucCompleteProperty1.InnerControl.ReCalculateAll();
            Recalculate();
              var t = (TreeListNode)e.Data.GetData("DevExpress.XtraTreeList.Nodes.TreeListNode");
        UpdateMaterial((DSRD.T_MaterialRow) t.Data);
            CheckChanged();
          
        }

        private void ucCompleteProperty1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void ucCompleteProperty1_DragOver(object sender, DragEventArgs e)
        {
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var FrmIni = new FrmTempInicial();
            FrmIni.Algorithm = ucCompleteProperty1.InnerControl.Algorithm;
           if( FrmIni.ShowDialog(this)==DialogResult.OK)
               return;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ucCompleteProperty1.InnerControl.SaveToFile(@"c:\a.t");
        }
    }
}