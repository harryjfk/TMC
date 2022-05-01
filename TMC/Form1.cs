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
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using TMC.General.Codificadores;


namespace TMC
{
    public partial class Form1 : MasterForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();

        }

        protected override DevExpress.XtraBars.Docking.DockManager GetDockManager()
        {
            return dockManager1;
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSGeneral.T_Norma' Puede moverla o quitarla según sea necesario.
            this.t_NormaTableAdapter.Fill(this.dSGeneral.T_Norma);
            barEditItem1.EditValue = Properties.Settings.Default.Norma;
            LoadModules();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
           Properties.Settings.Default.Norma = (int )barEditItem1.EditValue;
            UpdateChildsNormas();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmMaterial(), true);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmAcero(), true);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmFormula(), true);
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            ChildChanged();
        }

    }
}