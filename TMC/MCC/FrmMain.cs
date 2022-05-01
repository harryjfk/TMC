using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TMC.MCC.Codificadores;
using TMC.MCC.DSMCCTableAdapters;
using TMC.MCC.Tareas;

namespace TMC.MCC
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void CreateForm(Form form,bool dialog)
        {
            ((MasterForm)Application.OpenForms[MasterForm.Index]).CreateForm(form, dialog);
        }


        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmParametros(), true);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmMaquina(), false);
        }

   

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCreate(), true);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmSimulate(), true);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCirculacion_AM(), true);
        }

       
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmExploracion(), false);
        }

        public  void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMCC.T_ParametroValor' Puede moverla o quitarla según sea necesario.
            this.t_ParametroValorTableAdapter.Fill(this.dSMCC.T_ParametroValor);
            // TODO: esta línea de código carga datos en la tabla 'dSMCC.T_Tecnologia' Puede moverla o quitarla según sea necesario.
            this.t_TecnologiaTableAdapter.Fill(this.dSMCC.T_Tecnologia);

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var t = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
            int? w = null;
            var s = int.Parse(((BarButtonItemLink) popupControlContainer1.Activator).Item.Tag.ToString());
            if (s != 0)
                w = s - 1;


            popupControlContainer1.HidePopup();
            var tec = new P_ReporteTecnologiaTableAdapter();
            tec.Fill(dSMCC.P_ReporteTecnologia, Tecnologia.idtecnologia, w);

            t.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\MCC\RepTecnologia.repx",dSMCC.P_ReporteTecnologia,null);
            t.ShowDialog(this);

        }
        public DSMCC.T_TecnologiaRow Tecnologia { get { return (DSMCC.T_TecnologiaRow) ((DataRowView) tTecnologiaBindingSource.Current).Row; } }

        

       
    }
}