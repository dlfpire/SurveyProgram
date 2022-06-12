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

namespace ConForm.NewFolder1
{
    public partial class UserControl1 : MetroFramework.Controls.MetroUserControl,Interface1
    {
        int x;

        public UserControl1(int cnt)
        {
            x = cnt;
            InitializeComponent();
            label3.Text = cnt.ToString() + "번 항목";
           
        }

        public string getType()
        {
            return "항목";
        }

        public Dictionary<string, string> getTypeData()
        {
            if (this.Controls.Count > 5)
            {
                Interface1 i = (Interface1)this.Controls[5];
                var to_return = i.getTypeData();

                //to_return.Add("type2", getType());
                to_return.Add("Qtitle", metroTextBox1.Text);
                return to_return;
            }
            else
            {
                var to_return = new Dictionary<String, String>();
                to_return.Add("type", "주관식형");
                to_return.Add("Qtitle", metroTextBox1.Text);
                return to_return;
            }
        }

        
        private void Combo_AnswerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Controls.Count > 5)
            {
                Controls.RemoveAt(Controls.Count - 1);
            }
            if (Combo_AnswerType.SelectedIndex == 1)
            {
                this.Controls.Add(new ComboType2());
                this.Controls[Controls.Count - 1].Location = new System.Drawing.Point(160, 135);
            }
            else if (Combo_AnswerType.SelectedIndex == 2)
            {
                this.Controls.Add(new ComboType3());
                this.Controls[Controls.Count - 1].Location = new System.Drawing.Point(160, 135);
            }
            else
            {
                return;
            }
        }
    }
}
