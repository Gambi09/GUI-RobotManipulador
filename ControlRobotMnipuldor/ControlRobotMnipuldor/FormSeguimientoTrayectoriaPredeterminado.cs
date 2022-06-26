using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRobotMnipuldor
{
    public partial class FormSeguimientoTrayectoriaPredeterminado : Form
    {
        
        public FormSeguimientoTrayectoriaPredeterminado()
        {
            InitializeComponent();
        }

        private void pictureBoxTrayectoria_Click(object sender, EventArgs e)
        {

        }

        private void chartMotorEstatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonComienzaSeguir_Click(object sender, EventArgs e)
        {
            string scriptPath = @"C:\Users\Hp\Desktop\GUI-TT\Untitled.py";
            ScriptRuntime progam = Python.CreateRuntime();
            dynamic pyProgram = progam.UseFile(scriptPath);

            //pyProgram.function_doSeguimiento(1);



        }

        private void circularProgressBarQ1_Click(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
