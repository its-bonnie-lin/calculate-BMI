using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH1_1
{
    public partial class cal : Form
    {
        public cal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("開始計算BMI");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float H = Convert.ToSingle(txtCm.Text);
            float W = Convert.ToSingle(txtKg.Text);
            lblShow.Text = (W / ((H / 100) * (H / 100))).ToString();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            var Ans = MessageBox.Show("確定要結束程式?", "BMI計算" ,MessageBoxButtons.YesNo);
            if(Ans==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
