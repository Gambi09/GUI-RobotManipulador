
namespace ControlRobotMnipuldor
{
    partial class FormCinematicDirect
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
            this.labelConfiguracion = new System.Windows.Forms.Label();
            this.panelContainerDirectCinematic = new System.Windows.Forms.Panel();
            this.labelConfigurationChosen = new System.Windows.Forms.Label();
            this.pictureBoxRobot = new System.Windows.Forms.PictureBox();
            this.panelContainerDirectCinematic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConfiguracion
            // 
            this.labelConfiguracion.AutoSize = true;
            this.labelConfiguracion.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguracion.Location = new System.Drawing.Point(115, 67);
            this.labelConfiguracion.Name = "labelConfiguracion";
            this.labelConfiguracion.Size = new System.Drawing.Size(286, 46);
            this.labelConfiguracion.TabIndex = 0;
            this.labelConfiguracion.Text = "CinematicDirect";
            // 
            // panelContainerDirectCinematic
            // 
            this.panelContainerDirectCinematic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainerDirectCinematic.Controls.Add(this.pictureBoxRobot);
            this.panelContainerDirectCinematic.Controls.Add(this.labelConfigurationChosen);
            this.panelContainerDirectCinematic.Controls.Add(this.labelConfiguracion);
            this.panelContainerDirectCinematic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerDirectCinematic.Location = new System.Drawing.Point(0, 0);
            this.panelContainerDirectCinematic.Name = "panelContainerDirectCinematic";
            this.panelContainerDirectCinematic.Size = new System.Drawing.Size(800, 450);
            this.panelContainerDirectCinematic.TabIndex = 1;
            // 
            // labelConfigurationChosen
            // 
            this.labelConfigurationChosen.AutoSize = true;
            this.labelConfigurationChosen.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationChosen.Location = new System.Drawing.Point(47, 31);
            this.labelConfigurationChosen.Name = "labelConfigurationChosen";
            this.labelConfigurationChosen.Size = new System.Drawing.Size(217, 36);
            this.labelConfigurationChosen.TabIndex = 1;
            this.labelConfigurationChosen.Text = "Configuración ";
            // 
            // pictureBoxRobot
            // 
            this.pictureBoxRobot.Location = new System.Drawing.Point(482, 31);
            this.pictureBoxRobot.Name = "pictureBoxRobot";
            this.pictureBoxRobot.Size = new System.Drawing.Size(273, 377);
            this.pictureBoxRobot.TabIndex = 2;
            this.pictureBoxRobot.TabStop = false;
            // 
            // FormCinematicDirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainerDirectCinematic);
            this.Name = "FormCinematicDirect";
            this.Text = "FormCinematicDirect";
            this.Load += new System.EventHandler(this.FormCinematicDirect_Load);
            this.panelContainerDirectCinematic.ResumeLayout(false);
            this.panelContainerDirectCinematic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelConfiguracion;
        private System.Windows.Forms.Panel panelContainerDirectCinematic;
        private System.Windows.Forms.Label labelConfigurationChosen;
        private System.Windows.Forms.PictureBox pictureBoxRobot;
    }
}