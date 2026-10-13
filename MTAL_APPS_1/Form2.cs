using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MTAL_APPS_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double yariCap;
            double alan, cevre;
            double pi = 3.14; 

            yariCap = Convert.ToDouble(yaricap.Text);

            alan = pi * yariCap * yariCap;
            cevre = 2 * pi * yariCap;

            aln.Text = alan.ToString();
            cvr.Text = cevre.ToString();
        }

        
    }
}
