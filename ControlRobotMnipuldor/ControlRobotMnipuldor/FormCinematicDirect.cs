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
                    
                    break;
                case (2):
                    labelConfigurationChosen.Text = "Configuracion";
                    break;

                case (3):
                    labelConfigurationChosen.Text = "Configuracion";
                    break;
                default:
                    labelConfigurationChosen.Text = "Configuracion";
                    break;
            }
                
        }

    }
            
}

