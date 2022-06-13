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
    public partial class ComboType3 : MetroFramework.Controls.MetroUserControl, Interface1
    {
        public ComboType3()
        {
            InitializeComponent();
        }

        public string getType()
        {
            return "복수선택형";
        }

        public Dictionary<string, string> getTypeData()
        {
            var to_return = new Dictionary<String, String>();
            to_return.Add("type", getType());
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is MetroFramework.Controls.MetroTextBox)
                {
                    to_return.Add("Q" + i.ToString(), Controls[i].Text);
                }
            }

            return to_return;
        }
    }
}
