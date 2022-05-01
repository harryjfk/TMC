using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ACINOX.Components;
using ACINOX.Components.Forms;
using ACINOX.DBT;
using ACINOX.Functions;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using TMC.General;
using TMC.General.Codificadores;
using File = ACINOX.Components.File;


namespace TMC
{
    public partial class FrmMain : MasterForm
    {
        public FrmMain(){
            InitializeComponent();
            InitSkinGallery();

        }
         
        private DSDll.T_AccUsuarioRow user;
        public DSDll.T_AccUsuarioRow AuthenticatedUser
        {
            get { return user; }
            set
            {
                user = value;
                UserLabel.Caption = value.Nombre;
               // barStaticItem1.Caption = value.Nombre;
              //  UCRepManager.FillGroup(ribbonPageGroup14, Properties.Settings.Default.GMIConnectionString, value.idusuario,43,CustomReportClick);
                LoadModules(); new Controls.RestrictAccess(this, value.idusuario, Properties.Settings.Default.TMCConnectionString);
                traceComponent1.ConnectionString = Properties.Settings.Default.TMCConnectionString;
                traceComponent1.User = user.idusuario;
                traceComponent1.Acciones.Add(DataRowAction.Add, "Adicionó");
                traceComponent1.Acciones.Add(DataRowAction.Change, "Cambió");
                traceComponent1.Acciones.Add(DataRowAction.Delete, "Eliminó");
                traceComponent1.Tablas.Add("T_AccGrupoOperaciones", "grupo de operaciones");
                traceComponent1.Tablas.Add("T_AccOperaciones", "operación");
                traceComponent1.Tablas.Add("T_AccRol", "rol");
                traceComponent1.Tablas.Add("T_AccRolOperaciones", "operación de rol");
                traceComponent1.Tablas.Add("T_AccUsuario", "usuario");
                traceComponent1.Tablas.Add("T_AccUsuarioRol", "rol de usuario");
                traceComponent1.Tablas.Add("T_Acero", "acero");
                traceComponent1.Tablas.Add("T_AceroElemento", "Elemento del Acero");
                traceComponent1.Tablas.Add("T_AceroNorma", "Norma del Acero");
                traceComponent1.Tablas.Add("T_AceroPunto", "Puntos del Acero");
                traceComponent1.Tablas.Add("T_AceroPuntoFormula", "Puntos de la formula de acero");
                traceComponent1.Tablas.Add("T_AceroTipoPunto", "Tipo de Punto del Acero");
                traceComponent1.Tablas.Add("T_Balance_CompDefault", "Comportamiento de balance");
                traceComponent1.Tablas.Add("T_Balance_Ecuacion", "Ecuación del Balance");
                traceComponent1.Tablas.Add("T_Balance_Propiedad", "Propiedad del Balance");
                traceComponent1.Tablas.Add("T_CapacidadCalorifica", "Capacidad Calorífica");
                traceComponent1.Tablas.Add("T_CapacidadDesloze", "Capacidad de Desloze");
                traceComponent1.Tablas.Add("T_Circulacion_AM", "Circulacion del Area del Molde");
                traceComponent1.Tablas.Add("T_ColocacionPieza", "Colocación de la Pieza");
                traceComponent1.Tablas.Add("T_Constante", "Constante");
                traceComponent1.Tablas.Add("T_Curva", "Curva");
                traceComponent1.Tablas.Add("T_Degradee", "Degradado");
                traceComponent1.Tablas.Add("T_Elemento", "Elemento");
                traceComponent1.Tablas.Add("T_Elemento_Oxido", "Elemento Oxido");
                traceComponent1.Tablas.Add("T_Formato", "Formato");
                traceComponent1.Tablas.Add("T_Formula", "Formula");
                traceComponent1.Tablas.Add("T_Grado_PH", "Grado del ph");
                traceComponent1.Tablas.Add("T_Horno", "Horno");
                traceComponent1.Tablas.Add("T_Indice_Consumo", "Indice de Consumo");
                traceComponent1.Tablas.Add("T_Maquina", "Máquina");
                traceComponent1.Tablas.Add("T_Material", "Material");
                traceComponent1.Tablas.Add("T_MedioEnfriamiento", "Medio de Enfriamiento");
                traceComponent1.Tablas.Add("T_Norma", "Norma");
                traceComponent1.Tablas.Add("T_NormaTemperatura", "Norma de la Temperatura");
                traceComponent1.Tablas.Add("T_Palanquilla", "Palanquilla");
                traceComponent1.Tablas.Add("T_Parametros", "Parámetros");
                traceComponent1.Tablas.Add("T_ParametroValor", "Valor del parámetro");
                traceComponent1.Tablas.Add("T_Patron_Balance", "Balance del Patrón");
                traceComponent1.Tablas.Add("T_Patron_Balance_BC", "Balance del Patrón");
                traceComponent1.Tablas.Add("T_Project", "Proyecto");
                traceComponent1.Tablas.Add("T_Project_Balance", "Balance del Proyecto");
                traceComponent1.Tablas.Add("T_Propiedad_Fisica", "Propiedad Física");
                traceComponent1.Tablas.Add("T_Propiedad_Fisica_Elemento", "Propiedad Física del Elemento");
                traceComponent1.Tablas.Add("T_Propiedad_Producción", "Propiedad de la Producción");
                traceComponent1.Tablas.Add("T_Propiedad_Termodinamica", "Propiedad Termodinámica");
                traceComponent1.Tablas.Add("T_RegimenCalentamiento", "Régimen de Calentamiento");
                traceComponent1.Tablas.Add("T_SeparacionPieza", "Separación de la Pieza");
                traceComponent1.Tablas.Add("T_Tecnologia", "Tecnología");
                traceComponent1.Tablas.Add("T_Tipo_Formato", "Tipo de Formato");
                traceComponent1.Tablas.Add("T_Tipo_Pared", "Tipo de Pared");
                traceComponent1.Tablas.Add("T_Tipo_Propiedad_Balance", "Tipo de Propiedad de Balance");
                traceComponent1.Tablas.Add("T_TipoCurva", "Tipo de Curva");
                traceComponent1.Tablas.Add("T_TipoFundicion", "Tipo de Fundición");
                traceComponent1.Tablas.Add("T_TipoHorno", "Tipo de Horno");
                traceComponent1.Tablas.Add("T_TipoMaterial", "Tipo de Material");
                traceComponent1.Tablas.Add("T_TipoPieza", "Tipo de Pieza");
                traceComponent1.Tablas.Add("T_TipoPiezaGeometria", "Tipo de Geometria de la Pieza");
                traceComponent1.Tablas.Add("T_TipoPropiedadSol", "Tipo de Propiedad de Solidificación");
                traceComponent1.Tablas.Add("T_TipoTratamiento", "Tipo de Tratamiento");
                traceComponent1.Tablas.Add("T_Trace", "Traza");
                traceComponent1.Tablas.Add("T_Tratamiento", "Tratamiento");
                traceComponent1.Tablas.Add("T_TratamientoCurva", "Tratamiento de la Curva");
                traceComponent1.Tablas.Add("T_TratamientoDesloze", "Desloze del Tratamiento");


                foreach (RibbonPage page in ribbonControl.Pages)
                    if(page.Visible){
                        ribbonControl.SelectedPage = page;
                        break;
                    }
            
            
            
            
            
            }
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
//            LoadModules();
            //ribbonControl.SelectedPage = ribbonControl.Pages[0];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save(); traceComponent1.Update();
            Application.Exit();
        }private void barEditItem1_EditValueChanged(object sender, EventArgs e)
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

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  var conn = new ConnectionString(Properties.Settings.Default.GMIConnectionString);
            var frmuser = new FrmUserManager { ucUser1 = { /*User = AuthenticatedUser,*/  } };
            frmuser.ucUser1.FormName = Name;
            frmuser = ((FrmUserManager)CreateForm(frmuser));
            frmuser.ucUser1.Connection.Connection = Properties.Settings.Default.TMCConnectionString;
            frmuser.ucUser1.Logging = LogType.UsersMg;
            frmuser.Text = "Rol Usuario";
            frmuser.BringToFront();}

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  var conn = new ConnectionString();
            var frmuser = new FrmUserManager { ucUser1 = {  /*User = AuthenticatedUser,*/  } };
            //ACINOX.ConnectionUpdate.UpdateConnection(Properties.Settings.Default.GMIConnectionString);
            frmuser = ((FrmUserManager)CreateForm(frmuser));
            frmuser.ucUser1.FormName = Name;
            frmuser.ucUser1.Connection.Connection = Properties.Settings.Default.TMCConnectionString;
            frmuser.ucUser1.Logging = LogType.UserGroup;
            frmuser.Text = "Grupo de usuario";
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCUser.ChangePass(AuthenticatedUser, Properties.Settings.Default.TMCConnectionString);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var save = new FSave { Save = true, Connection = Properties.Settings.Default.TMCConnectionString };
            save.ShowDialog(this);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            var save = new FSave { Save = false, Connection = Properties.Settings.Default.TMCConnectionString };
            save.ShowDialog(this);
        }

        private void rgbiSkins_ItemClick(object sender, ItemClickEventArgs e)
        {
            Properties.Settings.Default.Skin = e.Item.Caption;
            Properties.Settings.Default.Save();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmTrazas());
        }
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Help\tmc_help_tmphhp\tmc_helper.chm");
        }

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            var about = new FrmAbout();
            about.ShowDialog(this);}

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();}

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            pictureBox1.Visible = MdiChildren.Length == 0;}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }}