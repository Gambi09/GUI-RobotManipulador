using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ControlRobotMnipuldor
{
    public partial class FormRobot : Form
    {


        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        private int valueEncoderQ1;
        private int valueEncoderQ2;
        private int valueEncoderQ3;
        private int valueConfiguration;
        private string serialData;
        //Constructor
        public FormRobot()
        {
            InitializeComponent();
            customizeDesing();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor; 
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }


        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }


        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }


        private void FormRobot_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);

        }
       

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }


        private void FormRobot_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void FormRobot_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void FormRobot_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void FormRobot_Load(object sender, EventArgs e)
        {
            progressBar_CON_ARD.Value = 0;
            button_SerchConecction.Enabled = true;
            toggleButtonConnection.Enabled = false;
            predeteminadaToolStripMenuItem.Enabled = false;
            usurioToolStripMenuItem.Enabled = false;
            

            
            button_on_robot.Enabled = false;
            pictureBox_connect.Image = Properties.Resources.green_led_off_md;
            pictureBox_robot.Image = Properties.Resources.red_led_off_md;
            rjDropdownMenu1.IsMainMenu = true;

        }

        private void FormRobot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        //Bar Menu
        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Seleccion de la configurcion
        private void changeConfiguration() {

            try 
            {
                if (configuration == valueConfiguration)
                {
                    MessageBox.Show("Si quieres cambiar primero debes apagar al robot");
                }

                else 
                {
                    string[] formularios = { "FormCinematicDirect", "CinemticInverse" };

                    for (int i = 0; i < formularios.Length; i++)
                    {
                        Form existe = Application.OpenForms.OfType<Form>().Where
                       (pre => pre.Name == formularios[i]).SingleOrDefault<Form>();
                        if (existe != null)
                            existe.Close();
                    }
                }
            } 
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
            
        }
        private int configuration = 0;
        
        private void checkCilindrica_CheckedChanged(object sender, EventArgs e)
        {
            configuracion = "Cilindrica";
            configuration = 1;
            changeConfiguration();
            if (valueConfiguration == configuration) 
            {
                predeteminadaToolStripMenuItem.Enabled = true;
            }
        }

        private void checkAngular_CheckedChanged(object sender, EventArgs e)
        {
            configuracion = "Angular";
            configuration = 2;
            changeConfiguration();
        }

        private void checkEsferica_CheckedChanged(object sender, EventArgs e)
        {
            configuracion = "Esferica";
            configuration = 3;
            changeConfiguration();
        }

        private void customizeDesing() 
        {
            panelSubMenuConnection.Visible = false;

        }


        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        private string configuracion= "NO";

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //Open Child Form
        private Form activeForm = null;
        private void AbrirFormEnPanel (Form childForm)
        {
            activeForm = childForm;
            Form existe = Application.OpenForms.OfType<Form>().Where
                (pre => pre.Name == childForm.Name).SingleOrDefault<Form>();

            if (existe != null)
                {
                    existe.BringToFront();
                }
            else
                {
                    activeForm = null;
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    //childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panelShow.Controls.Add(childForm);
                    panelShow.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }

            

           
            
        }

    
        // LATERL MENU BUTTONS
        // 
        private void hideSubMenu()
        {
            if (panelSubMenuConnection.Visible == true)
            {
                panelSubMenuConnection.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }
        }
        
        private void articulacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormArticulacion());
        }

        private void buttonCinematicDirect_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            buttonCinematicDirect.BackgroundColor = Color.DarkViolet;
            //buttonCinemticInverse.BackColor = Color.FromArgb(24, 30, 54);
            FormCinematicDirect cinemticirecta = new FormCinematicDirect();
            cinemticirecta.labelConfiguracion.Text = configuracion;
            cinemticirecta.configurtion = this.configuration;
            AbrirFormEnPanel(cinemticirecta);
        }

        private void button_SerchConecction_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] listPuertos = SerialPort.GetPortNames();
                comboBox_COM.Items.Clear();

                foreach (string puerto in listPuertos)
                {
                    comboBox_COM.Items.Add(puerto);
                }

                if (comboBox_COM.Items.Count > 0)
                {
                    comboBox_COM.SelectedIndex = 0;
                    MessageBox.Show("Selecciona el puerto");

                    toggleButtonConnection.Enabled = true;
                    labelConnection.Text = "ON";
                    labelConnection.Location = new Point(214, 39);


                }

                else
                {

                    comboBox_COM.Items.Clear();
                    MessageBox.Show("Ningun puerto detectdo");
                    comboBox_COM.Text = "                ";
                    progressBar_CON_ARD.Value = 0;

                    toggleButtonConnection.Enabled = false;
                    labelConnection.Visible = false;

                    button_SerchConecction.Enabled = true;
                    button_on_robot.Enabled = false;
                    pictureBox_connect.Image = Properties.Resources.green_led_off_md;
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonConnection_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuConnection);
        }

        private void toggleButtonConnection_CheckedChanged_1(object sender, EventArgs e)
        {
            hideSubMenu();
            try
            {
                if (labelConnection.Text == "ON")
                {
                    serialPort1.PortName = comboBox_COM.Text;
                    try
                    {
                        serialPort1.Open();
                        labelConnection.Location = new Point(161, 39);
                        labelConnection.Text = "OFF";

                        button_on_robot.Text = "ON";

                        if (valueConfiguration == configuration)
                        {
                            button_on_robot.Enabled = true;
                        }
                        else button_on_robot.Enabled = false;
                        pictureBox_connect.Image = Properties.Resources.green_led_on_md;
                        progressBar_CON_ARD.Value = 100;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }

                }

                else if (labelConnection.Text == "OFF")
                {
                    serialPort1.Write("0");
                    serialPort1.Close();
                    labelConnection.Location = new Point(214, 39);
                    labelConnection.Text = "ON";

                    button_on_robot.Enabled = false;
                    pictureBox_connect.Image = Properties.Resources.green_led_off_md;
                    pictureBox_robot.Image = Properties.Resources.red_led_off_md;
                    progressBar_CON_ARD.Value = 0;
                }




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_on_robot_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            try
            {

                if (button_on_robot.Text == "ON")
                {
                    serialPort1.Write("1");
                    button_on_robot.Text = "OFF";
                    pictureBox_robot.Image = Properties.Resources.red_led_on_md;
                    predeteminadaToolStripMenuItem.Enabled = true;
                    rjDropdownMenu1.Enabled = true;

                }
                else if (button_on_robot.Text == "OFF")
                {
                    serialPort1.Write("0");
                    button_on_robot.Text = "ON";
                    pictureBox_robot.Image = Properties.Resources.red_led_off_md;
                    predeteminadaToolStripMenuItem.Enabled = false;
                    rjDropdownMenu1.Enabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonCinemticInverse_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new CinemticInverse());
        }

        private void buttonMovement_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            rjDropdownMenu1.Show(buttonMovement, buttonMovement.Width, 0);
        }

        private void buttonCinemticInverse_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonCinematicDirect_MouseHover(object sender, EventArgs e)
        {
            buttonCinematicDirect.BackgroundColor = Color.DarkViolet;
        }

        private void ChangeColorsMenuBar(Button boton) 
        {
            Button bt = boton;
            buttonCinematicDirect.BackgroundColor = Color.DarkViolet;
            buttonCinemticInverse.BackgroundColor = Color.DarkViolet;
            buttonConnection.BackgroundColor = Color.DarkViolet; 
            buttonMovement.BackgroundColor = Color.DarkViolet;
        }

       

        private void predeteminadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeguimientoTrayectoriaPredeterminado trayectoria = new FormSeguimientoTrayectoriaPredeterminado();
            //trayectoria.labelConfiguracion.Text = configuracion;
            //trayectoria.configurtion = this.configuration;
            AbrirFormEnPanel(trayectoria);
            //AbrirFormEnPanel(new FormSeguimientoTrayectoriaPredeterminado());
            trayectoria.circularProgressBarQ1.Value = valueEncoderQ1;
            trayectoria.circularProgressBarQ1.Text = Convert.ToString(valueEncoderQ1);

            trayectoria.circularProgressBarQ2.Value = valueEncoderQ2;
            trayectoria.circularProgressBarQ2.Text = Convert.ToString(valueEncoderQ2);

            trayectoria.circularProgressBarQ1.Value = valueEncoderQ3;
            trayectoria.circularProgressBarQ1.Text = Convert.ToString(valueEncoderQ3);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0 ) 
            {

                serialData = serialPort1.ReadLine();

                string[] data = serialData.Split('*');


                valueConfiguration = Convert.ToInt32(data [0]);
                valueEncoderQ1 = Convert.ToInt32(data[1]);
                valueEncoderQ1 = Convert.ToInt32(data[2]);
                valueEncoderQ1 = Convert.ToInt32(data[3]);


            }
        }

        private void panelTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
