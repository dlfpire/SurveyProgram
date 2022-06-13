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

    public partial class NewForm : MetroForm, NewFolder1.Interface1
    {
        public delegate void FormSendDataHandler(string data);
        public NewForm()
        {
            InitializeComponent();
            
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            string data = Newtonsoft.Json.JsonConvert.SerializeObject(getTypeData(), Newtonsoft.Json.Formatting.None);

            MakeForms frm = new MakeForms((int)numericUpDown1.Value, TitleText.Text, getType(), data);
            frm.Show();
            this.Hide();
        }

        public string getType()
        {
            string type = "제목";
            return type;
        }

        public Dictionary<string, string> getTypeData()
        {
            var to_return = new Dictionary<String, String>();
            to_return.Add("type", getType());
            to_return.Add("FormTitle", TitleText.Text);
            return to_return;
        }
    }
}
