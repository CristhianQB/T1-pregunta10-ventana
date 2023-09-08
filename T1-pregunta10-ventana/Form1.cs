using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_pregunta10_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kwh = float.Parse(txtb1.Text);

            if (kwh <= 100)
            {
                float kwh1 = 0.1f;
                float mensual = (kwh1 * 24f) * 30f;
                lbl.Text = mensual + " soles";
            }
            else if (kwh > 100 && kwh <= 300)
            {
                float kwh1 = 0.2f;
                float mensual = (kwh1 * 24f) * 30f;
                lbl.Text = mensual + " soles";
            }
            else
            {
                float kwh1 = 0.3f;
                float mensual = (kwh1 * 24f) * 30f;
                lbl.Text = mensual + " soles";
            }

        }
    }
}
