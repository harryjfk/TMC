namespace TMC.Components.TemperatureControl
{
    partial class UCTemperatureControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UCTemperatureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCTemperatureControl";
            this.Size = new System.Drawing.Size(328, 467);
            this.Click += new System.EventHandler(this.UCTemperatureControl_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCTemperatureControl_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCTemperatureControl_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCTemperatureControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UCTemperatureControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UCTemperatureControl_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
