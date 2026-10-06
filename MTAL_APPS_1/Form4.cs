using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTAL_APPS_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlis = Convert.ToDouble(textBox3.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            textBox5.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(textBox2.Text);
            matYanlis = Convert.ToDouble(textBox4.Text);
            matNet = (matDogru - (matYanlis / 4));
            textBox6.Text = matNet.ToString();
        }
    }
}
