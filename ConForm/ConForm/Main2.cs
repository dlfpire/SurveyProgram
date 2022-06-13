using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConForm
{
    public partial class Main2 : MetroForm
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void newForm_Click(object sender, EventArgs e)
        {
            NewForm frm = new NewForm();
            frm.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void anotherForm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:3000");
        }
    }
}
