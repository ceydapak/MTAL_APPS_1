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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double yazili1, yazili2, performans;
            double ortalama;

            yazili1 = Convert.ToDouble(ilkNot.Text);
            yazili2 = Convert.ToDouble(ikinciNot.Text);
            performans = Convert.ToDouble(per.Text);

            ortalama = (yazili1 + yazili2 + performans) / 3;

            ort.Text = ortalama.ToString();
        }
    }
}
