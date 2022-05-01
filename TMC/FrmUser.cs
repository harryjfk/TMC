using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        public FrmUser()
        {
            InitializeComponent();
        }
        private void UpdateConnect()
        {

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder(ucUser1.Connection);

                ConfigurationSection section = config.GetSection("connectionStrings");
                ConfigurationSection section1 = config.GetSection("TMCConnectionString");
                config.ConnectionStrings.ConnectionStrings["TMC.Properties.Settings.TMCConnectionString"
                    ].ConnectionString = ucUser1.Connection;
                //   Properties.Settings.Default.VersatDB = ucUser1.Versat;

                config.Save(ConfigurationSaveMode.Modified, true);
                Properties.Settings.Default.Save();
                ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
                Properties.Settings.Default.Reload();

                //this.Close();
            }
            catch (System.Data.DataException exec)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exec.Message, "Error", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error);
            }
            catch (Exception exec)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exec.Message, "Error", MessageBoxButtons.OK,

                    MessageBoxIcon.Error);

            }

        }

        private void ucUser1_AceptarClick(object sender)
        {
            UpdateConnect();
            FrmMain main = new FrmMain();
            Hide();
            main.AuthenticatedUser = ucUser1.User;
            main.Show();

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            var s = Properties.Settings.Default.Skin;
            if (Properties.Settings.Default.Skin != "Ninguno")
                ACINOX.Functions.Skins.SetSkin(Properties.Settings.Default.Skin);
            ucUser1.Connection.RealConnection = Properties.Settings.Default.TMCConnectionString;
            //ucUser1.Versat = Properties.Settings.Default.VersatDB;
        }

        private void ucUser1_Resize(object sender, EventArgs e)
        {
            Height = ucUser1.Height + 40;
        }
    }
}