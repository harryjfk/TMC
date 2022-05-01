using TMC.Components.GraphControl;
namespace TMC.ACATTA.Prediccion
{
    partial class FrmCurveEdit
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
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.ucGraphDesigner1 = new UCGraphDesigner();
            this.SuspendLayout();
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 428);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(649, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 0;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // ucGraphDesigner1
            // 
            this.ucGraphDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGraphDesigner1.Location = new System.Drawing.Point(0, 0);
            this.ucGraphDesigner1.Name = "ucGraphDesigner1";
            this.ucGraphDesigner1.Size = new System.Drawing.Size(649, 428);
            this.ucGraphDesigner1.TabIndex = 1;
            // 
            // FrmCurveEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 458);
            this.Controls.Add(this.ucGraphDesigner1);
            this.Controls.Add(this.ucPieFormulario1);
            this.Name = "FrmCurveEdit";
            this.Text = "Editar Curva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private UCGraphDesigner ucGraphDesigner1;
    }
}