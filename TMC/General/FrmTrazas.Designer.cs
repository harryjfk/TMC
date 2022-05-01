namespace TMC.General
{
    partial class FrmTrazas
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
            this.ucTraceControl1 = new ACINOX.Components.UCTraceControl();
            this.SuspendLayout();
            // 
            // ucTraceControl1
            // 
            this.ucTraceControl1.ConnectionString = "Data Source=.\\SQL2008;Initial Catalog=TMC;Persist Security Info=True;User ID=sa;P" +
                "assword=123456";
            this.ucTraceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTraceControl1.Location = new System.Drawing.Point(0, 0);
            this.ucTraceControl1.Name = "ucTraceControl1";
            this.ucTraceControl1.Size = new System.Drawing.Size(412, 345);
            this.ucTraceControl1.TabIndex = 3;
            // 
            // FrmTrazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 345);
            this.Controls.Add(this.ucTraceControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrazas";
            this.Text = "Trazas";
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCTraceControl ucTraceControl1;
    }
}