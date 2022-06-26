using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRobotMnipuldor
{
    public partial class FormArticulacion : Form
    {
        public Interface1 pasa;
        public float minQ2;
        public int minQ3;
        public float maxQ2;
        public int maxQ3;
        public int configuracion;
        public string AQ;
        

        private float count1;
        private float count2;
        private float count3;
        public FormArticulacion(Interface1 padre)
        {
            InitializeComponent();
            pasa = padre;
        }

        private void trackBarQ1_Scroll(object sender, EventArgs e)
        {

        }

        

        private void FormArticulacion_Load(object sender, EventArgs e)
        {
            labelMinQ1.Text = "Min:  0 °";
            labelMaxQ1.Text = "Max:  330 °";
            
            
            count1 = 0;
            count2 = minQ2;
            count3 = minQ3;

            labelValueQ1.Text = "" + count1;
            labelValueQ2.Text = "" + count2;
            labelValueQ3.Text = "" + count3;

            if (configuracion == 1) 
            {
                pictureBoxArtQ2.Image = Properties.Resources.Prismatica;
                pictureBoxArtQ3.Image = Properties.Resources.Prismatica;
                labelMinQ2.Text = "Min: " + minQ2;
                labelMinQ3.Text = "Min: " + minQ3;
                labelMaxQ2.Text = "Max: " + maxQ2;
                labelMaxQ3.Text = "Max: " + maxQ3;
            }

            if (configuracion == 2)
            {
                pictureBoxArtQ2.Image = Properties.Resources.Rotacional;
                pictureBoxArtQ3.Image = Properties.Resources.Rotacional;
                labelMinQ2.Text = "Min: " + minQ2 + " °";
                labelMinQ3.Text = "Min: " + minQ3 + " °";
                labelMaxQ2.Text = "Max: " + maxQ2 + " °";
                labelMaxQ3.Text = "Max: " + maxQ3 + " °";
            }
            if (configuracion == 3)
            {
                pictureBoxArtQ2.Image = Properties.Resources.Rotacional;
                pictureBoxArtQ3.Image = Properties.Resources.Prismatica;
                labelMinQ2.Text = "Min: " + minQ2 + " °";
                labelMinQ3.Text = "Min: " + minQ3 + " °";
                labelMaxQ2.Text = "Max: " + maxQ2;
                labelMaxQ3.Text = "Max: " + maxQ3;
            }
        }

        

        private void rjButtonMenosQ1_Click(object sender, EventArgs e)
        {

            if (trackBarQ1.Value > 0)
            {
                count1 = trackBarQ1.Value;
                count1--;
                trackBarQ1.Value = (int)count1;
                AQ = "A1M";
                pasa.TrasladoInfo(AQ);
            }


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            int x = 330;
            if (trackBarQ1.Value < x) {

                count1 = trackBarQ1.Value;
                count1++;
                trackBarQ1.Value = (int)count1;
                AQ = "A1P";
                pasa.TrasladoInfo(AQ);

            }
        }

        private void rjButtonMinusQ2_Click(object sender, EventArgs e)
        {
            if (trackBarQ2.Value > minQ2)
            {
                count2 = trackBarQ2.Value;
                count2--;
                trackBarQ2.Value = (int)count2;
                AQ = "A2M";
                pasa.TrasladoInfo(AQ);
            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            if (trackBarQ2.Value < (int)maxQ2)
            {

                count2 = trackBarQ2.Value;
                count2++;
                trackBarQ2.Value = (int)count2;
                AQ = "A2P";
                pasa.TrasladoInfo(AQ);
            }
        }
        private void rjButtonMinusQ3_Click(object sender, EventArgs e)
        {
            if (trackBarQ3.Value > minQ3)
            {
                count3 = trackBarQ3.Value;
                count3--;
                trackBarQ3.Value = (int)count3;
                AQ = "A3M";
                pasa.TrasladoInfo(AQ);
            }
        }
        private void rjButton6_Click(object sender, EventArgs e)
        {
            if (trackBarQ3.Value < maxQ3)
            {

                count3 = trackBarQ3.Value;
                count3++;
                trackBarQ3.Value = (int)count3;
                AQ = "A3P";
                pasa.TrasladoInfo(AQ);

            }
        }

        private void trackBarQ1_ValueChanged(object sender, EventArgs e)
        {
            labelValueQ1.Text = ""+trackBarQ1.Value;
        }

        private void trackBarQ2_ValueChanged(object sender, EventArgs e)
        {
            count2 = trackBarQ2.Value+ 0.3f;
            labelValueQ2.Text = "" + count2;
        }

        private void trackBarQ3_ValueChanged(object sender, EventArgs e)
        {
            labelValueQ3.Text = "" + trackBarQ3.Value;
        }

        private void panelContenedorArticulacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
