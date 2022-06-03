
namespace ControlRobotMnipuldor
{
    partial class FormRobot
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRobot));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.groupBox_CONF = new System.Windows.Forms.GroupBox();
            this.checkEsferica = new ControlRobotMnipuldor.Resources.RJControllers.RJRadioButton.RJRadioButton();
            this.checkAngular = new ControlRobotMnipuldor.Resources.RJControllers.RJRadioButton.RJRadioButton();
            this.checkCilindrica = new ControlRobotMnipuldor.Resources.RJControllers.RJRadioButton.RJRadioButton();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelConnection = new System.Windows.Forms.Label();
            this.toggleButtonConnection = new ControlRobotMnipuldor.Resources.RJControllers.RJSlideSwitch.RJToogleButton();
            this.pictureBox_robot = new System.Windows.Forms.PictureBox();
            this.progressBar_CON_ARD = new System.Windows.Forms.ProgressBar();
            this.pictureBox_connect = new System.Windows.Forms.PictureBox();
            this.button_on_robot = new System.Windows.Forms.Button();
            this.label_robot_estatus = new System.Windows.Forms.Label();
            this.label_estatus_conection = new System.Windows.Forms.Label();
            this.panelSubMenuConnection = new System.Windows.Forms.Panel();
            this.button_SerchConecction = new ControlRobotMnipuldor.Resources.RJControllers.RJButton.RJButton();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.buttonConnection = new ControlRobotMnipuldor.Resources.RJControllers.RJButton.RJButton();
            this.buttonMovement = new ControlRobotMnipuldor.Resources.RJControllers.RJButton.RJButton();
            this.buttonCinemticInverse = new ControlRobotMnipuldor.Resources.RJControllers.RJButton.RJButton();
            this.buttonCinematicDirect = new ControlRobotMnipuldor.Resources.RJControllers.RJButton.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjDropdownMenu1 = new ControlRobotMnipuldor.Resources.RJDropdownMenu(this.components);
            this.trayectoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predeteminadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usurioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.groupBox_CONF.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_robot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_connect)).BeginInit();
            this.panelSubMenuConnection.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 

            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelShow);
            this.panelContainer.Controls.Add(this.panelTopMenu);
            this.panelContainer.Controls.Add(this.panelMenuLateral);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1191, 670);
            this.panelContainer.TabIndex = 15;
            // 
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.Controls.Add(this.groupBox_CONF);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(303, 54);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(888, 616);
            this.panelShow.TabIndex = 21;
            // 
            // groupBox_CONF
            // 
            this.groupBox_CONF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CONF.BackColor = System.Drawing.Color.Gray;
            this.groupBox_CONF.Controls.Add(this.checkEsferica);
            this.groupBox_CONF.Controls.Add(this.checkAngular);
            this.groupBox_CONF.Controls.Add(this.checkCilindrica);
            this.groupBox_CONF.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CONF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_CONF.Location = new System.Drawing.Point(485, 38);
            this.groupBox_CONF.Name = "groupBox_CONF";
            this.groupBox_CONF.Size = new System.Drawing.Size(323, 226);
            this.groupBox_CONF.TabIndex = 10;
            this.groupBox_CONF.TabStop = false;
            this.groupBox_CONF.Text = "CONFIGURACION";
            // 
            // checkEsferica
            // 
            this.checkEsferica.AutoSize = true;
            this.checkEsferica.CheckedColor = System.Drawing.Color.Violet;
            this.checkEsferica.Location = new System.Drawing.Point(87, 173);
            this.checkEsferica.MinimumSize = new System.Drawing.Size(0, 21);
            this.checkEsferica.Name = "checkEsferica";
            this.checkEsferica.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkEsferica.Size = new System.Drawing.Size(108, 23);
            this.checkEsferica.TabIndex = 2;
            this.checkEsferica.TabStop = true;
            this.checkEsferica.Text = "Esferica";
            this.checkEsferica.UnCheckedColor = System.Drawing.Color.Black;
            this.checkEsferica.UseVisualStyleBackColor = true;
            this.checkEsferica.CheckedChanged += new System.EventHandler(this.checkEsferica_CheckedChanged);
            // 
            // checkAngular
            // 
            this.checkAngular.AutoSize = true;
            this.checkAngular.CheckedColor = System.Drawing.Color.GreenYellow;
            this.checkAngular.Location = new System.Drawing.Point(87, 115);
            this.checkAngular.MinimumSize = new System.Drawing.Size(0, 21);
            this.checkAngular.Name = "checkAngular";
            this.checkAngular.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkAngular.Size = new System.Drawing.Size(105, 23);
            this.checkAngular.TabIndex = 1;
            this.checkAngular.TabStop = true;
            this.checkAngular.Text = "Angular";
            this.checkAngular.UnCheckedColor = System.Drawing.Color.Black;
            this.checkAngular.UseVisualStyleBackColor = true;
            this.checkAngular.CheckedChanged += new System.EventHandler(this.checkAngular_CheckedChanged);
            // 
            // checkCilindrica
            // 
            this.checkCilindrica.CheckedColor = System.Drawing.Color.LightSeaGreen;
            this.checkCilindrica.Location = new System.Drawing.Point(87, 52);
            this.checkCilindrica.MinimumSize = new System.Drawing.Size(0, 21);
            this.checkCilindrica.Name = "checkCilindrica";
            this.checkCilindrica.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkCilindrica.Size = new System.Drawing.Size(169, 34);
            this.checkCilindrica.TabIndex = 0;
            this.checkCilindrica.TabStop = true;
            this.checkCilindrica.Text = "Cilindrica";
            this.checkCilindrica.UnCheckedColor = System.Drawing.Color.Black;
            this.checkCilindrica.UseVisualStyleBackColor = true;
            this.checkCilindrica.CheckedChanged += new System.EventHandler(this.checkCilindrica_CheckedChanged);
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.Orange;
            this.panelTopMenu.Controls.Add(this.pictureMinimize);
            this.panelTopMenu.Controls.Add(this.pictureBox1);
            this.panelTopMenu.Controls.Add(this.pictureBox3);
            this.panelTopMenu.Controls.Add(this.pictureClose);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(303, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(888, 54);
            this.panelTopMenu.TabIndex = 20;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Image = global::ControlRobotMnipuldor.Properties.Resources.minimize_icon_12;
            this.pictureMinimize.Location = new System.Drawing.Point(780, 3);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(28, 28);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 6;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ControlRobotMnipuldor.Properties.Resources.black_close_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(814, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlRobotMnipuldor.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(6, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = global::ControlRobotMnipuldor.Properties.Resources.black_close_icon1;
            this.pictureClose.Location = new System.Drawing.Point(848, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(28, 28);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 4;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click_1);
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.panelMenuLateral.Controls.Add(this.panelStatus);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuConnection);
            this.panelMenuLateral.Controls.Add(this.buttonConnection);
            this.panelMenuLateral.Controls.Add(this.buttonMovement);
            this.panelMenuLateral.Controls.Add(this.buttonCinemticInverse);
            this.panelMenuLateral.Controls.Add(this.buttonCinematicDirect);
            this.panelMenuLateral.Controls.Add(this.panel2);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(303, 670);
            this.panelMenuLateral.TabIndex = 12;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.labelConnection);
            this.panelStatus.Controls.Add(this.toggleButtonConnection);
            this.panelStatus.Controls.Add(this.pictureBox_robot);
            this.panelStatus.Controls.Add(this.progressBar_CON_ARD);
            this.panelStatus.Controls.Add(this.pictureBox_connect);
            this.panelStatus.Controls.Add(this.button_on_robot);
            this.panelStatus.Controls.Add(this.label_robot_estatus);
            this.panelStatus.Controls.Add(this.label_estatus_conection);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 438);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(303, 221);
            this.panelStatus.TabIndex = 33;
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelConnection.Location = new System.Drawing.Point(214, 39);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(33, 18);
            this.labelConnection.TabIndex = 17;
            this.labelConnection.Text = "ON";
            // 
            // toggleButtonConnection
            // 
            this.toggleButtonConnection.Location = new System.Drawing.Point(149, 22);
            this.toggleButtonConnection.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonConnection.Name = "toggleButtonConnection";
            this.toggleButtonConnection.OffBackColor = System.Drawing.Color.White;
            this.toggleButtonConnection.OffToggleColor = System.Drawing.Color.Silver;
            this.toggleButtonConnection.OnBackColor = System.Drawing.Color.Goldenrod;
            this.toggleButtonConnection.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonConnection.Size = new System.Drawing.Size(117, 56);
            this.toggleButtonConnection.SolidStyle = false;
            this.toggleButtonConnection.TabIndex = 16;
            this.toggleButtonConnection.UseVisualStyleBackColor = true;
            this.toggleButtonConnection.CheckedChanged += new System.EventHandler(this.toggleButtonConnection_CheckedChanged_1);
            // 
            // pictureBox_robot
            // 
            this.pictureBox_robot.Image = global::ControlRobotMnipuldor.Properties.Resources.red_led_off_md;
            this.pictureBox_robot.Location = new System.Drawing.Point(31, 118);
            this.pictureBox_robot.Name = "pictureBox_robot";
            this.pictureBox_robot.Size = new System.Drawing.Size(81, 81);
            this.pictureBox_robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_robot.TabIndex = 8;
            this.pictureBox_robot.TabStop = false;
            // 
            // progressBar_CON_ARD
            // 
            this.progressBar_CON_ARD.Location = new System.Drawing.Point(149, 95);
            this.progressBar_CON_ARD.Name = "progressBar_CON_ARD";
            this.progressBar_CON_ARD.Size = new System.Drawing.Size(121, 10);
            this.progressBar_CON_ARD.TabIndex = 0;
            // 
            // pictureBox_connect
            // 
            this.pictureBox_connect.Image = global::ControlRobotMnipuldor.Properties.Resources.green_led_off_md;
            this.pictureBox_connect.Location = new System.Drawing.Point(27, 8);
            this.pictureBox_connect.Name = "pictureBox_connect";
            this.pictureBox_connect.Size = new System.Drawing.Size(81, 81);
            this.pictureBox_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_connect.TabIndex = 5;
            this.pictureBox_connect.TabStop = false;
            // 
            // button_on_robot
            // 
            this.button_on_robot.Location = new System.Drawing.Point(164, 138);
            this.button_on_robot.Name = "button_on_robot";
            this.button_on_robot.Size = new System.Drawing.Size(96, 61);
            this.button_on_robot.TabIndex = 4;
            this.button_on_robot.Text = " ";
            this.button_on_robot.UseVisualStyleBackColor = true;
            this.button_on_robot.Click += new System.EventHandler(this.button_on_robot_Click_1);
            // 
            // label_robot_estatus
            // 
            this.label_robot_estatus.AutoSize = true;
            this.label_robot_estatus.BackColor = System.Drawing.Color.Transparent;
            this.label_robot_estatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_robot_estatus.Location = new System.Drawing.Point(28, 202);
            this.label_robot_estatus.Name = "label_robot_estatus";
            this.label_robot_estatus.Size = new System.Drawing.Size(91, 13);
            this.label_robot_estatus.TabIndex = 7;
            this.label_robot_estatus.Text = "ROBOT STATUS";
            // 
            // label_estatus_conection
            // 
            this.label_estatus_conection.AutoSize = true;
            this.label_estatus_conection.BackColor = System.Drawing.Color.Transparent;
            this.label_estatus_conection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_estatus_conection.Location = new System.Drawing.Point(12, 92);
            this.label_estatus_conection.Name = "label_estatus_conection";
            this.label_estatus_conection.Size = new System.Drawing.Size(103, 13);
            this.label_estatus_conection.TabIndex = 6;
            this.label_estatus_conection.Text = "USB CONNECTION";
            // 
            // panelSubMenuConnection
            // 
            this.panelSubMenuConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSubMenuConnection.Controls.Add(this.button_SerchConecction);
            this.panelSubMenuConnection.Controls.Add(this.comboBox_COM);
            this.panelSubMenuConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuConnection.Location = new System.Drawing.Point(0, 362);
            this.panelSubMenuConnection.Name = "panelSubMenuConnection";
            this.panelSubMenuConnection.Size = new System.Drawing.Size(303, 76);
            this.panelSubMenuConnection.TabIndex = 32;
            // 
            // button_SerchConecction
            // 
            this.button_SerchConecction.AutoScaleImage = null;
            this.button_SerchConecction.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_SerchConecction.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_SerchConecction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_SerchConecction.BorderRadius = 20;
            this.button_SerchConecction.BorderSize = 0;
            this.button_SerchConecction.FlatAppearance.BorderSize = 0;
            this.button_SerchConecction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SerchConecction.ForeColor = System.Drawing.Color.White;
            this.button_SerchConecction.Image = ((System.Drawing.Image)(resources.GetObject("button_SerchConecction.Image")));
            this.button_SerchConecction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerchConecction.ImageHeight = 50;
            this.button_SerchConecction.ImageWidht = 50;
            this.button_SerchConecction.Location = new System.Drawing.Point(15, 7);
            this.button_SerchConecction.Name = "button_SerchConecction";
            this.button_SerchConecction.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_SerchConecction.Size = new System.Drawing.Size(137, 58);
            this.button_SerchConecction.TabIndex = 11;
            this.button_SerchConecction.TextColor = System.Drawing.Color.White;
            this.button_SerchConecction.UseVisualStyleBackColor = false;
            this.button_SerchConecction.Click += new System.EventHandler(this.button_SerchConecction_Click_1);
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(164, 24);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(120, 21);
            this.comboBox_COM.TabIndex = 2;
            // 
            // buttonConnection
            // 
            this.buttonConnection.AutoScaleImage = null;
            this.buttonConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonConnection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonConnection.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonConnection.BorderRadius = 0;
            this.buttonConnection.BorderSize = 0;
            this.buttonConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConnection.FlatAppearance.BorderSize = 0;
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnection.ForeColor = System.Drawing.Color.White;
            this.buttonConnection.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnection.Image")));
            this.buttonConnection.ImageHeight = 60;
            this.buttonConnection.ImageWidht = 60;
            this.buttonConnection.Location = new System.Drawing.Point(0, 295);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(303, 67);
            this.buttonConnection.TabIndex = 31;
            this.buttonConnection.Text = "Conexión";
            this.buttonConnection.TextColor = System.Drawing.Color.White;
            this.buttonConnection.UseVisualStyleBackColor = false;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click_1);
            // 
            // buttonMovement
            // 
            this.buttonMovement.AutoScaleImage = null;
            this.buttonMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonMovement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonMovement.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonMovement.BorderRadius = 0;
            this.buttonMovement.BorderSize = 0;
            this.buttonMovement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMovement.FlatAppearance.BorderSize = 0;
            this.buttonMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovement.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovement.ForeColor = System.Drawing.Color.White;
            this.buttonMovement.Image = ((System.Drawing.Image)(resources.GetObject("buttonMovement.Image")));
            this.buttonMovement.ImageHeight = 60;
            this.buttonMovement.ImageWidht = 60;
            this.buttonMovement.Location = new System.Drawing.Point(0, 228);
            this.buttonMovement.Name = "buttonMovement";
            this.buttonMovement.Size = new System.Drawing.Size(303, 67);
            this.buttonMovement.TabIndex = 30;
            this.buttonMovement.Text = "Movimiento";
            this.buttonMovement.TextColor = System.Drawing.Color.White;
            this.buttonMovement.UseVisualStyleBackColor = false;
            this.buttonMovement.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonCinemticInverse
            // 
            this.buttonCinemticInverse.AutoScaleImage = null;
            this.buttonCinemticInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonCinemticInverse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonCinemticInverse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCinemticInverse.BorderRadius = 0;
            this.buttonCinemticInverse.BorderSize = 0;
            this.buttonCinemticInverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCinemticInverse.FlatAppearance.BorderSize = 0;
            this.buttonCinemticInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCinemticInverse.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinemticInverse.ForeColor = System.Drawing.Color.White;
            this.buttonCinemticInverse.Image = ((System.Drawing.Image)(resources.GetObject("buttonCinemticInverse.Image")));
            this.buttonCinemticInverse.ImageHeight = 60;
            this.buttonCinemticInverse.ImageWidht = 60;
            this.buttonCinemticInverse.Location = new System.Drawing.Point(0, 161);
            this.buttonCinemticInverse.Name = "buttonCinemticInverse";
            this.buttonCinemticInverse.Size = new System.Drawing.Size(303, 67);
            this.buttonCinemticInverse.TabIndex = 29;
            this.buttonCinemticInverse.Text = "Cinematica Inversa";
            this.buttonCinemticInverse.TextColor = System.Drawing.Color.White;
            this.buttonCinemticInverse.UseVisualStyleBackColor = false;
            this.buttonCinemticInverse.Click += new System.EventHandler(this.buttonCinemticInverse_Click_1);
            // 
            // buttonCinematicDirect
            // 
            this.buttonCinematicDirect.AutoScaleImage = null;
            this.buttonCinematicDirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonCinematicDirect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.buttonCinematicDirect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCinematicDirect.BorderRadius = 0;
            this.buttonCinematicDirect.BorderSize = 0;
            this.buttonCinematicDirect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCinematicDirect.FlatAppearance.BorderSize = 0;
            this.buttonCinematicDirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCinematicDirect.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinematicDirect.ForeColor = System.Drawing.Color.White;
            this.buttonCinematicDirect.Image = ((System.Drawing.Image)(resources.GetObject("buttonCinematicDirect.Image")));
            this.buttonCinematicDirect.ImageHeight = 60;
            this.buttonCinematicDirect.ImageWidht = 60;
            this.buttonCinematicDirect.Location = new System.Drawing.Point(0, 94);
            this.buttonCinematicDirect.Name = "buttonCinematicDirect";
            this.buttonCinematicDirect.Size = new System.Drawing.Size(303, 67);
            this.buttonCinematicDirect.TabIndex = 28;
            this.buttonCinematicDirect.Text = "Cinematica Directa";
            this.buttonCinematicDirect.TextColor = System.Drawing.Color.White;
            this.buttonCinematicDirect.UseVisualStyleBackColor = false;
            this.buttonCinematicDirect.Click += new System.EventHandler(this.buttonCinematicDirect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 94);
            this.panel2.TabIndex = 27;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayectoriaToolStripMenuItem,
            this.articulacionToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimryColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(139, 48);
            // 
            // trayectoriaToolStripMenuItem
            // 
            this.trayectoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predeteminadaToolStripMenuItem,
            this.usurioToolStripMenuItem});
            this.trayectoriaToolStripMenuItem.Name = "trayectoriaToolStripMenuItem";
            this.trayectoriaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.trayectoriaToolStripMenuItem.Text = "Trayectoria";
            // 
            // predeteminadaToolStripMenuItem
            // 
            this.predeteminadaToolStripMenuItem.Name = "predeteminadaToolStripMenuItem";
            this.predeteminadaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.predeteminadaToolStripMenuItem.Text = "Predeteminada";
            this.predeteminadaToolStripMenuItem.Click += new System.EventHandler(this.predeteminadaToolStripMenuItem_Click);
            // 
            // usurioToolStripMenuItem
            // 
            this.usurioToolStripMenuItem.Name = "usurioToolStripMenuItem";
            this.usurioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.usurioToolStripMenuItem.Text = "Usurio";
            // 
            // articulacionToolStripMenuItem
            // 
            this.articulacionToolStripMenuItem.Name = "articulacionToolStripMenuItem";
            this.articulacionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.articulacionToolStripMenuItem.Text = "Articulacion";
            this.articulacionToolStripMenuItem.Click += new System.EventHandler(this.articulacionToolStripMenuItem_Click);
            // 
            // FormRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1191, 670);
            this.Controls.Add(this.panelContainer);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "FormRobot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRobot_FormClosing);
            this.Load += new System.EventHandler(this.FormRobot_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.groupBox_CONF.ResumeLayout(false);
            this.groupBox_CONF.PerformLayout();
            this.panelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_robot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_connect)).EndInit();
            this.panelSubMenuConnection.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private Resources.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem trayectoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predeteminadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usurioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulacionToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupBox_CONF;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShow;
        private Resources.RJControllers.RJRadioButton.RJRadioButton checkEsferica;
        private Resources.RJControllers.RJRadioButton.RJRadioButton checkAngular;
        private Resources.RJControllers.RJRadioButton.RJRadioButton checkCilindrica;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelConnection;
        private Resources.RJControllers.RJSlideSwitch.RJToogleButton toggleButtonConnection;
        private System.Windows.Forms.PictureBox pictureBox_robot;
        private System.Windows.Forms.ProgressBar progressBar_CON_ARD;
        private System.Windows.Forms.Label label_robot_estatus;
        private System.Windows.Forms.PictureBox pictureBox_connect;
        private System.Windows.Forms.Button button_on_robot;
        private System.Windows.Forms.Label label_estatus_conection;
        private System.Windows.Forms.Panel panelSubMenuConnection;
        private Resources.RJControllers.RJButton.RJButton button_SerchConecction;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private Resources.RJControllers.RJButton.RJButton buttonConnection;
        private Resources.RJControllers.RJButton.RJButton buttonMovement;
        private Resources.RJControllers.RJButton.RJButton buttonCinemticInverse;
        private Resources.RJControllers.RJButton.RJButton buttonCinematicDirect;
        private System.Windows.Forms.Panel panel2;
    }
}

