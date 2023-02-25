using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM_M07_Act_1_Eje2_Alberto_Pérez_del_Río
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Length == 0)
            {
                lblErrorNombre.Visible = true; 
            }
        }
    }
}
