namespace TMC
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ACINOX.Components.ConnectionString connectionString1 = new ACINOX.Components.ConnectionString();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.ucUser1 = new ACINOX.Components.UCUser();
            this.SuspendLayout();
            // 
            // ucUser1
            // 
            connectionString1.Autologon = false;
            connectionString1.CDatabase = "";
            connectionString1.CDataSource = "";
            connectionString1.Connection = "";
            connectionString1.CPassword = "";
            connectionString1.CUser = "";
            connectionString1.RealConnection = "";
            this.ucUser1.Connection = connectionString1;
            this.ucUser1.FormName = null;
            this.ucUser1.HeadText = "TMC";
            this.ucUser1.Location = new System.Drawing.Point(0, 0);
            this.ucUser1.Logging = ACINOX.Components.LogType.Logging;
            this.ucUser1.Name = "ucUser1";
            this.ucUser1.Picture = null;
            this.ucUser1.ShowConnection = false;
            this.ucUser1.Size = new System.Drawing.Size(508, 205);
            this.ucUser1.TabIndex = 0;
            this.ucUser1.User = null;
            this.ucUser1.Versat = "";
            this.ucUser1.WindowsDefault = true;
            this.ucUser1.AceptarClick += new ACINOX.Components.UCUser.Aceptar(this.ucUser1_AceptarClick);
            this.ucUser1.Resize += new System.EventHandler(this.ucUser1_Resize);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 208);
            this.Controls.Add(this.ucUser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCUser ucUser1;
    }
}