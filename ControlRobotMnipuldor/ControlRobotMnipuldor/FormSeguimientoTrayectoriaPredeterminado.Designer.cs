
namespace ControlRobotMnipuldor
{
    partial class FormSeguimientoTrayectoriaPredeterminado
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
            this.panelContainerSeguirTrayecctoriaPredeterminada = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularProgressBarQ3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarQ2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarQ1 = new CircularProgressBar.CircularProgressBar();
            this.labelTrayectoria = new System.Windows.Forms.Label();
            this.rjComboBox1 = new ControlRobotMnipuldor.Resources.RJControllers.RJComboBox.RJComboBox();
            this.pictureBoxTrayectoria = new System.Windows.Forms.PictureBox();
            this.buttonComienzaSeguir = new ControlRobotMnipuldor.Resources.RJControllers.RJButton.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainerSeguirTrayecctoriaPredeterminada.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrayectoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainerSeguirTrayecctoriaPredeterminada
            // 
            this.panelContainerSeguirTrayecctoriaPredeterminada.BackColor = System.Drawing.Color.DimGray;
            this.panelContainerSeguirTrayecctoriaPredeterminada.Controls.Add(this.label1);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Controls.Add(this.panel1);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Controls.Add(this.labelTrayectoria);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Controls.Add(this.rjComboBox1);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Controls.Add(this.pictureBoxTrayectoria);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Controls.Add(this.buttonComienzaSeguir);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerSeguirTrayecctoriaPredeterminada.Location = new System.Drawing.Point(0, 0);
            this.panelContainerSeguirTrayecctoriaPredeterminada.Name = "panelContainerSeguirTrayecctoriaPredeterminada";
            this.panelContainerSeguirTrayecctoriaPredeterminada.Size = new System.Drawing.Size(871, 512);
            this.panelContainerSeguirTrayecctoriaPredeterminada.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.circularProgressBarQ3);
            this.panel1.Controls.Add(this.circularProgressBarQ2);
            this.panel1.Controls.Add(this.circularProgressBarQ1);
            this.panel1.Location = new System.Drawing.Point(372, 211);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(487, 211);
            this.panel1.TabIndex = 4;
            // 
            // circularProgressBarQ3
            // 
            this.circularProgressBarQ3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarQ3.AnimationSpeed = 500;
            this.circularProgressBarQ3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarQ3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarQ3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarQ3.InnerMargin = 2;
            this.circularProgressBarQ3.InnerWidth = -1;
            this.circularProgressBarQ3.Location = new System.Drawing.Point(319, 12);
            this.circularProgressBarQ3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarQ3.Maximum = 360;
            this.circularProgressBarQ3.Name = "circularProgressBarQ3";
            this.circularProgressBarQ3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarQ3.OuterMargin = -25;
            this.circularProgressBarQ3.OuterWidth = 26;
            this.circularProgressBarQ3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarQ3.ProgressWidth = 25;
            this.circularProgressBarQ3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarQ3.Size = new System.Drawing.Size(142, 138);
            this.circularProgressBarQ3.StartAngle = 270;
            this.circularProgressBarQ3.Step = 1;
            this.circularProgressBarQ3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarQ3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarQ3.SubscriptText = "";
            this.circularProgressBarQ3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarQ3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarQ3.SuperscriptText = "°";
            this.circularProgressBarQ3.TabIndex = 7;
            this.circularProgressBarQ3.Text = "23";
            this.circularProgressBarQ3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarQ3.Value = 34;
            // 
            // circularProgressBarQ2
            // 
            this.circularProgressBarQ2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarQ2.AnimationSpeed = 500;
            this.circularProgressBarQ2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarQ2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarQ2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarQ2.InnerMargin = 2;
            this.circularProgressBarQ2.InnerWidth = -1;
            this.circularProgressBarQ2.Location = new System.Drawing.Point(171, 12);
            this.circularProgressBarQ2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarQ2.Maximum = 360;
            this.circularProgressBarQ2.Name = "circularProgressBarQ2";
            this.circularProgressBarQ2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarQ2.OuterMargin = -25;
            this.circularProgressBarQ2.OuterWidth = 26;
            this.circularProgressBarQ2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarQ2.ProgressWidth = 25;
            this.circularProgressBarQ2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarQ2.Size = new System.Drawing.Size(142, 138);
            this.circularProgressBarQ2.StartAngle = 270;
            this.circularProgressBarQ2.Step = 1;
            this.circularProgressBarQ2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarQ2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarQ2.SubscriptText = "";
            this.circularProgressBarQ2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarQ2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarQ2.SuperscriptText = "°";
            this.circularProgressBarQ2.TabIndex = 6;
            this.circularProgressBarQ2.Text = "23";
            this.circularProgressBarQ2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarQ2.Value = 34;
            // 
            // circularProgressBarQ1
            // 
            this.circularProgressBarQ1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarQ1.AnimationSpeed = 500;
            this.circularProgressBarQ1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarQ1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarQ1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarQ1.InnerMargin = 2;
            this.circularProgressBarQ1.InnerWidth = -1;
            this.circularProgressBarQ1.Location = new System.Drawing.Point(23, 12);
            this.circularProgressBarQ1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarQ1.Maximum = 360;
            this.circularProgressBarQ1.Name = "circularProgressBarQ1";
            this.circularProgressBarQ1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarQ1.OuterMargin = -25;
            this.circularProgressBarQ1.OuterWidth = 26;
            this.circularProgressBarQ1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarQ1.ProgressWidth = 25;
            this.circularProgressBarQ1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarQ1.Size = new System.Drawing.Size(142, 138);
            this.circularProgressBarQ1.StartAngle = 270;
            this.circularProgressBarQ1.Step = 1;
            this.circularProgressBarQ1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarQ1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarQ1.SubscriptText = "";
            this.circularProgressBarQ1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarQ1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarQ1.SuperscriptText = "°";
            this.circularProgressBarQ1.TabIndex = 5;
            this.circularProgressBarQ1.Text = "23";
            this.circularProgressBarQ1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarQ1.Value = 34;
            this.circularProgressBarQ1.Click += new System.EventHandler(this.circularProgressBarQ1_Click);
            // 
            // labelTrayectoria
            // 
            this.labelTrayectoria.AutoSize = true;
            this.labelTrayectoria.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrayectoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTrayectoria.Location = new System.Drawing.Point(12, 28);
            this.labelTrayectoria.Name = "labelTrayectoria";
            this.labelTrayectoria.Size = new System.Drawing.Size(215, 30);
            this.labelTrayectoria.TabIndex = 3;
            this.labelTrayectoria.Text = "Trayectoria a seguir:";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.rjComboBox1.BorderColor = System.Drawing.Color.Goldenrod;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjComboBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.Goldenrod;
            this.rjComboBox1.Items.AddRange(new object[] {
            "circulo",
            "logo Upiita",
            "caracol de Pitagoras",
            ""});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.NavajoWhite;
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(245, 28);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 2;
            this.rjComboBox1.Texts = "";
            this.rjComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // pictureBoxTrayectoria
            // 
            this.pictureBoxTrayectoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTrayectoria.Image = global::ControlRobotMnipuldor.Properties.Resources.CaracolPascalTrayec;
            this.pictureBoxTrayectoria.Location = new System.Drawing.Point(36, 183);
            this.pictureBoxTrayectoria.Name = "pictureBoxTrayectoria";
            this.pictureBoxTrayectoria.Size = new System.Drawing.Size(304, 239);
            this.pictureBoxTrayectoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrayectoria.TabIndex = 1;
            this.pictureBoxTrayectoria.TabStop = false;
            this.pictureBoxTrayectoria.Click += new System.EventHandler(this.pictureBoxTrayectoria_Click);
            // 
            // buttonComienzaSeguir
            // 
            this.buttonComienzaSeguir.AutoScaleImage = null;
            this.buttonComienzaSeguir.BackColor = System.Drawing.Color.Orange;
            this.buttonComienzaSeguir.BackgroundColor = System.Drawing.Color.Orange;
            this.buttonComienzaSeguir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonComienzaSeguir.BorderRadius = 20;
            this.buttonComienzaSeguir.BorderSize = 0;
            this.buttonComienzaSeguir.FlatAppearance.BorderSize = 0;
            this.buttonComienzaSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComienzaSeguir.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComienzaSeguir.ForeColor = System.Drawing.Color.White;
            this.buttonComienzaSeguir.Image = global::ControlRobotMnipuldor.Properties.Resources._1200px_HD_transparent_picture;
            this.buttonComienzaSeguir.ImageHeight = 60;
            this.buttonComienzaSeguir.ImageWidht = 60;
            this.buttonComienzaSeguir.Location = new System.Drawing.Point(505, 23);
            this.buttonComienzaSeguir.Name = "buttonComienzaSeguir";
            this.buttonComienzaSeguir.Size = new System.Drawing.Size(169, 50);
            this.buttonComienzaSeguir.TabIndex = 0;
            this.buttonComienzaSeguir.Text = "Comienza";
            this.buttonComienzaSeguir.TextColor = System.Drawing.Color.White;
            this.buttonComienzaSeguir.UseVisualStyleBackColor = false;
            this.buttonComienzaSeguir.Click += new System.EventHandler(this.buttonComienzaSeguir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trayectoria a seguir:";
            // 
            // FormSeguimientoTrayectoriaPredeterminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 512);
            this.Controls.Add(this.panelContainerSeguirTrayecctoriaPredeterminada);
            this.Name = "FormSeguimientoTrayectoriaPredeterminado";
            this.Text = "FormSeguimientoTrayectoriaPredeterminado";
            this.panelContainerSeguirTrayecctoriaPredeterminada.ResumeLayout(false);
            this.panelContainerSeguirTrayecctoriaPredeterminada.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrayectoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerSeguirTrayecctoriaPredeterminada;
        private Resources.RJControllers.RJButton.RJButton buttonComienzaSeguir;
        private System.Windows.Forms.PictureBox pictureBoxTrayectoria;
        private System.Windows.Forms.Label labelTrayectoria;
        private Resources.RJControllers.RJComboBox.RJComboBox rjComboBox1;
        private System.Windows.Forms.Panel panel1;
        public CircularProgressBar.CircularProgressBar circularProgressBarQ1;
        public CircularProgressBar.CircularProgressBar circularProgressBarQ3;
        public CircularProgressBar.CircularProgressBar circularProgressBarQ2;
        public System.Windows.Forms.Label label1;
    }
}