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
            double kisaKenar, uzunKenar;
            double alan, cevre;

            kisaKenar = Convert.ToDouble(kisa.Text);
            uzunKenar = Convert.ToDouble(uzun.Text);

            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);

            aln.Text = alan.ToString();
            cvr.Text = cevre.ToString();
        }
    }
}
