using System;
using System.Windows.Forms;

namespace Biy_Daalt___huh_tenger__
{
    public partial class CateringForm : Form
    {
        public CateringForm()
        {
            InitializeComponent();
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnMenuServices_Click(object sender, EventArgs e)
        {
            ServicesForm form = new ServicesForm();
            form.Show();
            this.Hide();
        }

        private void CateringForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
