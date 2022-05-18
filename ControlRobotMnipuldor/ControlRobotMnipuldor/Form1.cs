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

namespace ControlRobotMnipuldor
{
    public partial class FormRobot : Form
    {
        public FormRobot()
        {
            InitializeComponent();
        }

        private void FormRobot_Load(object sender, EventArgs e)
        {
            progressBar_CON_ARD.Value = 0;
            CONNECT.Enabled = true;
            toggleButtonConnection.Enabled = false;
            
            button_on_robot.Enabled = false;
            pictureBox_connect.Image = Properties.Resources.green_led_off_md;
            pictureBox_robot.Image = Properties.Resources.red_led_off_md;
            rjDropdownMenu1.IsMainMenu = true;

        }

        private void CONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                string[] listPuertos = SerialPort.GetPortNames();
                comboBox_COM.Items.Clear();

                foreach(string puerto in listPuertos)
                {
                    comboBox_COM.Items.Add(puerto);
                }

                if (comboBox_COM.Items.Count > 0)
                {
                    comboBox_COM.SelectedIndex = 0;
                    MessageBox.Show("Selecciona el puerto");

                    toggleButtonConnection.Enabled = true;
                    labelConnection.Text = "ON"; 
                    labelConnection.Location = new Point(262, 459);

                    
                }

                else 
                {

                    comboBox_COM.Items.Clear(); 
                    MessageBox.Show("Ningun puerto detectdo");
                    comboBox_COM.Text = "                ";
                    progressBar_CON_ARD.Value = 0;

                    toggleButtonConnection.Enabled = false;
                    labelConnection.Text = "OFF";
                    labelConnection.Location = new Point(212, 459);

                    CONNECT.Enabled = true;
                    button_on_robot.Enabled = false;
                    pictureBox_connect.Image = Properties.Resources.green_led_off_md;
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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

        private void button_on_robot_Click(object sender, EventArgs e)
        {
            try
            {

                if (button_on_robot.Text == "ON")
                {
                    button_on_robot.Text = "OFF";
                    pictureBox_robot.Image = Properties.Resources.red_led_on_md;

                }
                else if (button_on_robot.Text == "OFF")
                {
                    button_on_robot.Text = "ON";
                    pictureBox_robot.Image = Properties.Resources.red_led_off_md;
                }
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }

        }

        private void toggleButtonConnection_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (labelConnection.Text == "ON")
                {
                    serialPort1.PortName = comboBox_COM.Text;
                    try
                    {
                        serialPort1.Open();
                        labelConnection.Location = new Point(212, 459);
                        labelConnection.Text = "OFF";

                        button_on_robot.Text = "ON";
                        button_on_robot.Enabled = true;
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
                    serialPort1.Close();
                    labelConnection.Location = new Point(262, 459);
                    labelConnection.Text= "ON";

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

        private void checkAngular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonMovement_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(buttonMovement, buttonMovement.Width, 0);
            //rjDropdownMenu1(buttonMovement, buttonMovement, Width.Equals);
        }

        private void buttonMovement_MouseHover(object sender, EventArgs e)
        {
            //buttonMovement.BackColor = Color.Aqua;
            //buttonMovement.ForeColor = Color.Black;
        }

        private void buttonMovement_MouseLeave(object sender, EventArgs e)
        {
           // buttonMovement.BackColor = Color.FromArgb(50, 50, 54);
           // buttonMovement.ForeColor = Color.White;
        }
    }
}
