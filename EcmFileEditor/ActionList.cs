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
    public partial class ActionList : Form
    {
        Form1 main;
        Control parent;
        public ActionList(Control par, Form1 fm)
        {
            InitializeComponent();
            ObjectsGrid.Rows.Add("站立", "Нахождение на месте в неагриссивном состоянии");
            ObjectsGrid.Rows.Add("慢速移动", "Передвижение модели в неагрессивном состоянии");
            ObjectsGrid.Rows.Add("快速移动", "Передвижение модели в агрессивном состоянии");
            ObjectsGrid.Rows.Add("普攻1起","Тип атаки 1.Выбирается клиентом случайно");
            ObjectsGrid.Rows.Add("普攻2起", "Тип атаки 2.Выбирается клиентом случайно");
            ObjectsGrid.Rows.Add("技能施放起", "Использование скилла");
            ObjectsGrid.Rows.Add("普攻1落", "Действие происходит по окончанию атаки 1");
            ObjectsGrid.Rows.Add("普攻2落", "Действие происходит по окончанию атаки 2");
            ObjectsGrid.Rows.Add("技能施放落", "Действие происходит по окончанию использования скилла");
            ObjectsGrid.Rows.Add("戒备","Действие происходит в паузе между атаками");
            ObjectsGrid.Rows.Add("受伤", "Действие происходит во время каждого удара по модели");
            ObjectsGrid.Rows.Add("休闲","Происходит в неагриссивном состоянии,с интервалом +-30 секунд");
            ObjectsGrid.Rows.Add("愤怒施放起", "Использование скилла(2)");
            ObjectsGrid.Rows.Add("愤怒施放落", "Действие происходит по окончанию использования скилла(2)");
            parent = par;
            main = fm;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            parent.Text = ObjectsGrid.CurrentRow.Cells[0].Value.ToString();
            main.RaiseCombineTextBoxLeft(parent.Name);
        }
    }
}
