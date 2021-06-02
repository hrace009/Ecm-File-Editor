using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcmFileEditor
{
    public partial class LCombobox : Form
    {
        Form1 main;
        public LCombobox(Dictionary<string,string> Dict,Control par,Form1 fm)
        {
            InitializeComponent();
            for (int i = 0; i < Dict.Count; i++)
            {
                listBox1.Items.Add(Dict.ElementAt(i).Key + " - " + Dict.ElementAt(i).Value);
                this.Location = new Point(4, 4);
            }
            parent = par;
            main = fm;
        }
        Control parent;
        public LCombobox(Control par,Form1 fm)
        {
            InitializeComponent();
            listBox1.Items.Add("站立 - Стоять");
            listBox1.Items.Add("慢速移动 - Ходьба");
            listBox1.Items.Add("快速移动 - бег");
            listBox1.Items.Add("普攻1起 - Атака 1");
            listBox1.Items.Add("普攻2起 - Атака 2");
            listBox1.Items.Add("普攻1落 - Ярость 1");
            listBox1.Items.Add("普攻2落 - Ярость 2");
            listBox1.Items.Add("戒备 - В битве");
            listBox1.Items.Add("受伤 - Получил удар");
            listBox1.Items.Add("休闲 - Досуг");
            parent = par;
            main = fm;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            parent.Text = listBox1.SelectedItem.ToString().Split('-')[0].Replace(" ", "");
            main.RaiseCombineTextBoxLeft(parent.Name);
        }
    }
}
