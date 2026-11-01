using System;
using System.Windows.Forms;

namespace Biy_Daalt___huh_tenger__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenuServices_Click(object sender, EventArgs e)
        {
            ServicesForm form = new ServicesForm();
            form.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHeroTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
