
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
            this.progressBar_CON_ARD = new System.Windows.Forms.ProgressBar();
            this.CONNECT = new System.Windows.Forms.Button();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_on_robot = new System.Windows.Forms.Button();
            this.label_estatus_conection = new System.Windows.Forms.Label();
            this.label_robot_estatus = new System.Windows.Forms.Label();
            this.groupBox_CONF = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelConnection = new System.Windows.Forms.Label();
            this.buttonMovement = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonInverseCinematic = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkEsferica = new ControlRobotMnipuldor.Resources.RJControllers.RJRadioButton.RJRadioButton();
            this.checkAngular = new ControlRobotMnipuldor.Resources.RJControllers.RJRadioButton.RJRadioButton();
            this.checkCilindrica = new ControlRobotMnipuldor.Resources.RJControllers.RJRadioButton.RJRadioButton();
            this.toggleButtonConnection = new ControlRobotMnipuldor.Resources.RJControllers.RJSlideSwitch.RJToogleButton();
            this.rjDropdownMenu1 = new ControlRobotMnipuldor.Resources.RJDropdownMenu(this.components);
            this.trayectoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predeteminadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usurioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.boxMinimizeWindow = new System.Windows.Forms.PictureBox();
            this.boxCloseWindow = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDirectCinematic = new System.Windows.Forms.Button();
            this.pictureBox_connect = new System.Windows.Forms.PictureBox();
            this.pictureBox_robot = new System.Windows.Forms.PictureBox();
            this.groupBox_CONF.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_robot)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_CON_ARD
            // 
            this.progressBar_CON_ARD.Location = new System.Drawing.Point(184, 513);
            this.progressBar_CON_ARD.Name = "progressBar_CON_ARD";
            this.progressBar_CON_ARD.Size = new System.Drawing.Size(151, 10);
            this.progressBar_CON_ARD.TabIndex = 0;
            // 
            // CONNECT
            // 
            this.CONNECT.BackColor = System.Drawing.Color.RosyBrown;
            this.CONNECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONNECT.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECT.Location = new System.Drawing.Point(12, 30);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(118, 52);
            this.CONNECT.TabIndex = 1;
            this.CONNECT.Text = "SEARCH COM";
            this.CONNECT.UseVisualStyleBackColor = false;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(157, 48);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(120, 21);
            this.comboBox_COM.TabIndex = 2;
            // 
            // button_on_robot
            // 
            this.button_on_robot.Location = new System.Drawing.Point(172, 572);
            this.button_on_robot.Name = "button_on_robot";
            this.button_on_robot.Size = new System.Drawing.Size(96, 61);
            this.button_on_robot.TabIndex = 4;
            this.button_on_robot.Text = " ";
            this.button_on_robot.UseVisualStyleBackColor = true;
            this.button_on_robot.Click += new System.EventHandler(this.button_on_robot_Click);
            // 
            // label_estatus_conection
            // 
            this.label_estatus_conection.AutoSize = true;
            this.label_estatus_conection.BackColor = System.Drawing.Color.Transparent;
            this.label_estatus_conection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_estatus_conection.Location = new System.Drawing.Point(29, 510);
            this.label_estatus_conection.Name = "label_estatus_conection";
            this.label_estatus_conection.Size = new System.Drawing.Size(103, 13);
            this.label_estatus_conection.TabIndex = 6;
            this.label_estatus_conection.Text = "USB CONNECTION";
            // 
            // label_robot_estatus
            // 
            this.label_robot_estatus.AutoSize = true;
            this.label_robot_estatus.BackColor = System.Drawing.Color.Transparent;
            this.label_robot_estatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_robot_estatus.Location = new System.Drawing.Point(36, 654);
            this.label_robot_estatus.Name = "label_robot_estatus";
            this.label_robot_estatus.Size = new System.Drawing.Size(91, 13);
            this.label_robot_estatus.TabIndex = 7;
            this.label_robot_estatus.Text = "ROBOT STATUS";
            // 
            // groupBox_CONF
            // 
            this.groupBox_CONF.BackColor = System.Drawing.Color.Gray;
            this.groupBox_CONF.Controls.Add(this.checkEsferica);
            this.groupBox_CONF.Controls.Add(this.checkAngular);
            this.groupBox_CONF.Controls.Add(this.checkCilindrica);
            this.groupBox_CONF.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CONF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_CONF.Location = new System.Drawing.Point(816, 142);
            this.groupBox_CONF.Name = "groupBox_CONF";
            this.groupBox_CONF.Size = new System.Drawing.Size(323, 226);
            this.groupBox_CONF.TabIndex = 10;
            this.groupBox_CONF.TabStop = false;
            this.groupBox_CONF.Text = "CONFIGURACION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.boxMinimizeWindow);
            this.panel1.Controls.Add(this.boxCloseWindow);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(356, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 47);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.labelConnection);
            this.panel2.Controls.Add(this.toggleButtonConnection);
            this.panel2.Controls.Add(this.progressBar_CON_ARD);
            this.panel2.Controls.Add(this.buttonMovement);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.buttonInverseCinematic);
            this.panel2.Controls.Add(this.label_estatus_conection);
            this.panel2.Controls.Add(this.buttonDirectCinematic);
            this.panel2.Controls.Add(this.pictureBox_connect);
            this.panel2.Controls.Add(this.pictureBox_robot);
            this.panel2.Controls.Add(this.label_robot_estatus);
            this.panel2.Controls.Add(this.button_on_robot);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 700);
            this.panel2.TabIndex = 12;
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelConnection.Location = new System.Drawing.Point(262, 459);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(33, 18);
            this.labelConnection.TabIndex = 17;
            this.labelConnection.Text = "ON";
            // 
            // buttonMovement
            // 
            this.buttonMovement.FlatAppearance.BorderSize = 0;
            this.buttonMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovement.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMovement.Location = new System.Drawing.Point(0, 265);
            this.buttonMovement.Name = "buttonMovement";
            this.buttonMovement.Size = new System.Drawing.Size(357, 73);
            this.buttonMovement.TabIndex = 19;
            this.buttonMovement.Text = "ACTIONS MOVEMENT";
            this.buttonMovement.UseVisualStyleBackColor = true;
            this.buttonMovement.Click += new System.EventHandler(this.buttonMovement_Click);
            this.buttonMovement.MouseLeave += new System.EventHandler(this.buttonMovement_MouseLeave);
            this.buttonMovement.MouseHover += new System.EventHandler(this.buttonMovement_MouseHover);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.AliceBlue;
            this.button6.Location = new System.Drawing.Point(0, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(357, 73);
            this.button6.TabIndex = 20;
            this.button6.Text = "CONNECTION";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonInverseCinematic
            // 
            this.buttonInverseCinematic.FlatAppearance.BorderSize = 0;
            this.buttonInverseCinematic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInverseCinematic.Font = new System.Drawing.Font("SansSerif", 14.25F);
            this.buttonInverseCinematic.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonInverseCinematic.Location = new System.Drawing.Point(0, 194);
            this.buttonInverseCinematic.Name = "buttonInverseCinematic";
            this.buttonInverseCinematic.Size = new System.Drawing.Size(357, 73);
            this.buttonInverseCinematic.TabIndex = 18;
            this.buttonInverseCinematic.Text = "Inverse Cinematic";
            this.buttonInverseCinematic.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.groupBox_CONF);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 700);
            this.panel4.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBox_COM);
            this.panel6.Controls.Add(this.CONNECT);
            this.panel6.Location = new System.Drawing.Point(363, 336);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 117);
            this.panel6.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 73);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 73);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // toggleButtonConnection
            // 
            this.toggleButtonConnection.Location = new System.Drawing.Point(184, 440);
            this.toggleButtonConnection.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonConnection.Name = "toggleButtonConnection";
            this.toggleButtonConnection.OffBackColor = System.Drawing.Color.White;
            this.toggleButtonConnection.OffToggleColor = System.Drawing.Color.Silver;
            this.toggleButtonConnection.OnBackColor = System.Drawing.Color.Goldenrod;
            this.toggleButtonConnection.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonConnection.Size = new System.Drawing.Size(143, 60);
            this.toggleButtonConnection.SolidStyle = false;
            this.toggleButtonConnection.TabIndex = 16;
            this.toggleButtonConnection.UseVisualStyleBackColor = true;
            this.toggleButtonConnection.CheckedChanged += new System.EventHandler(this.toggleButtonConnection_CheckedChanged);
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
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlRobotMnipuldor.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(34, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // boxMinimizeWindow
            // 
            this.boxMinimizeWindow.Image = global::ControlRobotMnipuldor.Properties.Resources.minimize_icon_12;
            this.boxMinimizeWindow.Location = new System.Drawing.Point(716, 0);
            this.boxMinimizeWindow.Name = "boxMinimizeWindow";
            this.boxMinimizeWindow.Size = new System.Drawing.Size(50, 50);
            this.boxMinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxMinimizeWindow.TabIndex = 3;
            this.boxMinimizeWindow.TabStop = false;
            // 
            // boxCloseWindow
            // 
            this.boxCloseWindow.Image = global::ControlRobotMnipuldor.Properties.Resources.black_close_icon1;
            this.boxCloseWindow.Location = new System.Drawing.Point(782, 0);
            this.boxCloseWindow.Name = "boxCloseWindow";
            this.boxCloseWindow.Size = new System.Drawing.Size(50, 50);
            this.boxCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxCloseWindow.TabIndex = 2;
            this.boxCloseWindow.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlRobotMnipuldor.Properties.Resources.black_close_icon1;
            this.pictureBox2.Location = new System.Drawing.Point(908, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlRobotMnipuldor.Properties.Resources.minimize_icon_12;
            this.pictureBox1.Location = new System.Drawing.Point(855, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDirectCinematic
            // 
            this.buttonDirectCinematic.FlatAppearance.BorderSize = 0;
            this.buttonDirectCinematic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirectCinematic.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonDirectCinematic.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonDirectCinematic.Image = global::ControlRobotMnipuldor.Properties.Resources.imgonline_com_ua_resize_YJh3l4omlL7;
            this.buttonDirectCinematic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDirectCinematic.Location = new System.Drawing.Point(0, 124);
            this.buttonDirectCinematic.Name = "buttonDirectCinematic";
            this.buttonDirectCinematic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDirectCinematic.Size = new System.Drawing.Size(357, 73);
            this.buttonDirectCinematic.TabIndex = 17;
            this.buttonDirectCinematic.Text = "Direct Cinematic";
            this.buttonDirectCinematic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDirectCinematic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDirectCinematic.UseVisualStyleBackColor = true;
            // 
            // pictureBox_connect
            // 
            this.pictureBox_connect.Image = global::ControlRobotMnipuldor.Properties.Resources.green_led_off_md;
            this.pictureBox_connect.Location = new System.Drawing.Point(39, 426);
            this.pictureBox_connect.Name = "pictureBox_connect";
            this.pictureBox_connect.Size = new System.Drawing.Size(81, 81);
            this.pictureBox_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_connect.TabIndex = 5;
            this.pictureBox_connect.TabStop = false;
            // 
            // pictureBox_robot
            // 
            this.pictureBox_robot.Image = global::ControlRobotMnipuldor.Properties.Resources.red_led_off_md;
            this.pictureBox_robot.Location = new System.Drawing.Point(39, 552);
            this.pictureBox_robot.Name = "pictureBox_robot";
            this.pictureBox_robot.Size = new System.Drawing.Size(81, 81);
            this.pictureBox_robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_robot.TabIndex = 8;
            this.pictureBox_robot.TabStop = false;
            // 
            // FormRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "FormRobot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Manipulador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRobot_FormClosing);
            this.Load += new System.EventHandler(this.FormRobot_Load);
            this.groupBox_CONF.ResumeLayout(false);
            this.groupBox_CONF.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_robot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_CON_ARD;
        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_on_robot;
        private System.Windows.Forms.PictureBox pictureBox_connect;
        private System.Windows.Forms.Label label_estatus_conection;
        private System.Windows.Forms.Label label_robot_estatus;
        private System.Windows.Forms.PictureBox pictureBox_robot;
        private System.Windows.Forms.GroupBox groupBox_CONF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private Resources.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem trayectoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predeteminadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usurioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulacionToolStripMenuItem;
        private Resources.RJControllers.RJSlideSwitch.RJToogleButton toggleButtonConnection;
        private Resources.RJControllers.RJRadioButton.RJRadioButton checkEsferica;
        private Resources.RJControllers.RJRadioButton.RJRadioButton checkAngular;
        private Resources.RJControllers.RJRadioButton.RJRadioButton checkCilindrica;
        private System.Windows.Forms.Button buttonDirectCinematic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.PictureBox boxMinimizeWindow;
        private System.Windows.Forms.PictureBox boxCloseWindow;
        private System.Windows.Forms.Button buttonMovement;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonInverseCinematic;
        private System.Windows.Forms.Panel panel6;
    }
}

