namespace TMC.General
{
    partial class FrmUserManager
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
            this.ucUser1 = new ACINOX.Components.UCUser();
            this.SuspendLayout();
            // 
            // ucUser1
            // 
            connectionString1.Autologon = false;
            connectionString1.CDatabase = "";
            connectionString1.CDataSource = "";
            connectionString1.Connection = null;
            connectionString1.CPassword = "";
            connectionString1.CUser = "";
            connectionString1.RealConnection = null;
            this.ucUser1.Connection = connectionString1;
            this.ucUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUser1.FormName = null;
            this.ucUser1.HeadText = "label2";
            this.ucUser1.Location = new System.Drawing.Point(0, 0);
            this.ucUser1.Logging = ACINOX.Components.LogType.UserGroup;
            this.ucUser1.Name = "ucUser1";
            this.ucUser1.Picture = null;
            this.ucUser1.ShowConnection = true;
            this.ucUser1.Size = new System.Drawing.Size(599, 417);
            this.ucUser1.TabIndex = 0;
            this.ucUser1.User = null;
            this.ucUser1.Versat = "";
            this.ucUser1.WindowsDefault = false;
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.ucUser1);
            this.Name = "FrmUserManager";
            this.Text = "FrmUserManager";
            this.ResumeLayout(false);

        }

        #endregion

        public ACINOX.Components.UCUser ucUser1;
    }
}