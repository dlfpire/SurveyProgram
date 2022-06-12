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
    
    public partial class MakeForms : MetroForm
    {
        int cnt;
        string Text_title;
        string type;
        string data;
        DateTime date;

        public MakeForms(int number, string title, string t, string d, DateTime dt)
        {
            InitializeComponent();
            cnt = number;
            Text_title = title;
            type = t;
            data = d;
            date = dt;
        }

        private void MakeForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void MakeForms_Load(object sender, EventArgs e)
        {
            Label title = new System.Windows.Forms.Label();
            title.Size = new System.Drawing.Size(287, 28);
            title.Location = new System.Drawing.Point(23, 28);
            title.Text = Text_title;
            title.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
            this.Controls.Add(title);

            for (int i = 0; i < cnt; i++)
            {
                this.Controls.Add(new NewFolder1.UserControl1(i+1));
                var loc = this.Controls[this.Controls.Count - 1].Location;
                loc.X = 10;
                loc.Y = 50 + i*250;
                this.Controls[this.Controls.Count - 1].Location = loc;
            }
            this.Controls.Add(new NewFolder1.Buttons(this));
            this.Controls[Controls.Count - 1].Location = new System.Drawing.Point(20, 50 + cnt*250);
            
        }
        
       public String createJSON()
        {
            string jsonfile = "";
            jsonfile += "[";
            jsonfile += data;
            jsonfile += ",";
            foreach (Control item in this.Controls)
            {
                if (item is NewFolder1.Interface1 == false) continue;
                var c = (NewFolder1.Interface1)(item);
                jsonfile += Newtonsoft.Json.JsonConvert.SerializeObject(c.getTypeData(), Newtonsoft.Json.Formatting.None);
                jsonfile += ",";
            }
            jsonfile = jsonfile.Remove(jsonfile.Length - 1, 1);
            jsonfile += "]";

            return jsonfile;
        }
    }
}
