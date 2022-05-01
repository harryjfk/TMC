using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using TMC.ACATTA.Codificadores;
using TMC.ACATTA.Prediccion;
using TMC.ACATTA.Tareas;


namespace TMC.ACATTA
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }


        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private Form CreateForm(Form form, bool dialog=false)
        {
            return ((MasterForm) Application.OpenForms[MasterForm.Index]).CreateForm(form, dialog);


        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmTanque(),true);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCalculoTT(),true);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmDeterminarTT(),true);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmHornos());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Norma' Puede moverla o quitarla según sea necesario.
            this.t_NormaTableAdapter.Fill(this.dSDatos.T_Norma);

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmEvalHorno(),true);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmHornos(), true);
        }

        private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmPredecir());
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCurveManager(),true);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
      
        }

    }
}