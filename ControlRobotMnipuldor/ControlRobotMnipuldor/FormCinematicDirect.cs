using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRobotMnipuldor
{
    public partial class FormCinematicDirect : Form
    {
        public FormCinematicDirect()
        {
            InitializeComponent();
        }

        public int configurtion;
        private void FormCinematicDirect_Load(object sender, EventArgs e)
        {
            labelConfigurationChosen.Text = "La Cinematica Directa mediante el método DH";
            switch (configurtion)
            {
                case(1):
                    labelConfigurationChosen.Text = "Configuracion";
                    pictureBoxRobot.Image = Properties.Resources.DH_Cilindrica;
                    break;
                case (2):
                    labelConfigurationChosen.Text = "Configuracion";
                    pictureBoxRobot.Image = Properties.Resources.DH_Angular;
                    break;

                case (3):
                    labelConfigurationChosen.Text = "Configuracion";
                    pictureBoxRobot.Image = Properties.Resources.DH_Angular;
                    break;
                default:
                    labelConfigurationChosen.Text = "Método Devian Hattenberg (DH)";

                    break;
            }
                
        }

        private void pictureBoxRobot_Click(object sender, EventArgs e)
        {

        }
    }
            
}

