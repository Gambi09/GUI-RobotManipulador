
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
            this.pictureBoxTableDH = new System.Windows.Forms.PictureBox();
            this.panelContainerDirectCinematic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTableDH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConfiguracion
            // 
            this.labelConfiguracion.AutoSize = true;
            this.labelConfiguracion.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguracion.Location = new System.Drawing.Point(121, 67);
            this.labelConfiguracion.Name = "labelConfiguracion";
            this.labelConfiguracion.Size = new System.Drawing.Size(286, 46);
            this.labelConfiguracion.TabIndex = 0;
            this.labelConfiguracion.Text = "CinematicDirect";
            // 
            // panelContainerDirectCinematic
            // 
            this.panelContainerDirectCinematic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainerDirectCinematic.Controls.Add(this.pictureBoxTableDH);
            this.panelContainerDirectCinematic.Controls.Add(this.pictureBoxRobot);
            this.panelContainerDirectCinematic.Controls.Add(this.labelConfigurationChosen);
            this.panelContainerDirectCinematic.Controls.Add(this.labelConfiguracion);
            this.panelContainerDirectCinematic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerDirectCinematic.Location = new System.Drawing.Point(0, 0);
            this.panelContainerDirectCinematic.Name = "panelContainerDirectCinematic";
            this.panelContainerDirectCinematic.Size = new System.Drawing.Size(878, 503);
            this.panelContainerDirectCinematic.TabIndex = 1;
            // 
            // labelConfigurationChosen
            // 
            this.labelConfigurationChosen.AutoSize = true;
            this.labelConfigurationChosen.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationChosen.Location = new System.Drawing.Point(81, 31);
            this.labelConfigurationChosen.Name = "labelConfigurationChosen";
            this.labelConfigurationChosen.Size = new System.Drawing.Size(217, 36);
            this.labelConfigurationChosen.TabIndex = 1;
            this.labelConfigurationChosen.Text = "Configuración ";
            // 
            // pictureBoxRobot
            // 
            this.pictureBoxRobot.Image = global::ControlRobotMnipuldor.Properties.Resources.CI;
            this.pictureBoxRobot.Location = new System.Drawing.Point(450, 46);
            this.pictureBoxRobot.Name = "pictureBoxRobot";
            this.pictureBoxRobot.Size = new System.Drawing.Size(336, 416);
            this.pictureBoxRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRobot.TabIndex = 2;
            this.pictureBoxRobot.TabStop = false;
            this.pictureBoxRobot.Click += new System.EventHandler(this.pictureBoxRobot_Click);
            // 
            // pictureBoxTableDH
            // 
            this.pictureBoxTableDH.Location = new System.Drawing.Point(31, 238);
            this.pictureBoxTableDH.Name = "pictureBoxTableDH";
            this.pictureBoxTableDH.Size = new System.Drawing.Size(398, 224);
            this.pictureBoxTableDH.TabIndex = 3;
            this.pictureBoxTableDH.TabStop = false;
            // 
            // FormCinematicDirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 503);
            this.Controls.Add(this.panelContainerDirectCinematic);
            this.Name = "FormCinematicDirect";
            this.Text = "FormCinematicDirect";
            this.Load += new System.EventHandler(this.FormCinematicDirect_Load);
            this.panelContainerDirectCinematic.ResumeLayout(false);
            this.panelContainerDirectCinematic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTableDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelConfiguracion;
        private System.Windows.Forms.Panel panelContainerDirectCinematic;
        private System.Windows.Forms.Label labelConfigurationChosen;
        private System.Windows.Forms.PictureBox pictureBoxRobot;
        private System.Windows.Forms.PictureBox pictureBoxTableDH;
    }
}