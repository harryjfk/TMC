namespace TMC.Components.TemperatureControl
{
    partial class UCPropertyTempControl
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
            // UCPropertyTempControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCPropertyTempControl";
            this.Size = new System.Drawing.Size(363, 276);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCPropertyTempControl_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.UCPropertyTempControl_DragOver);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCPropertyTempControl_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UCPropertyTempControl_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
