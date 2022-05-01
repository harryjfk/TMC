using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TMC.MCC.Codificadores;
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

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}