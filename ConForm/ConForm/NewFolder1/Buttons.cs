using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ConForm.NewFolder1
{
    public partial class Buttons : MetroFramework.Controls.MetroUserControl
    {
        MakeForms y;
        public Buttons(MakeForms mf)
        {
            y = mf;
            InitializeComponent();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            NewForm frm = new NewForm();
            frm.Show();
            y.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            y.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Headers[System.Net.HttpRequestHeader.ContentType] = "application/json";
            wc.UploadData("http://localhost:3001/data", "POST", System.Text.Encoding.UTF8.GetBytes(y.createJSON()));
            System.Diagnostics.Process.Start("http://localhost:3000");
            Application.Exit();
            //y.Hide();
        }

    }
}
