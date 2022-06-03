
namespace ControlRobotMnipuldor
{
    partial class FormArticulacion
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
            this.panelContenedorArticulacion = new System.Windows.Forms.Panel();
            this.trackBarQ1 = new System.Windows.Forms.TrackBar();
            this.panelContenedorArticulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQ1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorArticulacion
            // 
            this.panelContenedorArticulacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorArticulacion.Controls.Add(this.trackBarQ1);
            this.panelContenedorArticulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorArticulacion.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorArticulacion.Name = "panelContenedorArticulacion";
            this.panelContenedorArticulacion.Size = new System.Drawing.Size(800, 450);
            this.panelContenedorArticulacion.TabIndex = 0;
            // 
            // trackBarQ1
            // 
            this.trackBarQ1.LargeChange = 1;
            this.trackBarQ1.Location = new System.Drawing.Point(80, 101);
            this.trackBarQ1.Maximum = 360;
            this.trackBarQ1.Name = "trackBarQ1";
            this.trackBarQ1.Size = new System.Drawing.Size(413, 45);
            this.trackBarQ1.TabIndex = 0;
            // 
            // FormArticulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorArticulacion);
            this.Name = "FormArticulacion";
            this.Text = "FormArticulacion";
            this.panelContenedorArticulacion.ResumeLayout(false);
            this.panelContenedorArticulacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQ1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorArticulacion;
        private System.Windows.Forms.TrackBar trackBarQ1;
    }
}