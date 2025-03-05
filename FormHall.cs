using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementsDock
{
    public partial class FormHall : Form
    {
        public int time = 60;//2
        public FormHall()
        {
            InitializeComponent();
            timerHall.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.Text = "Данная подсказка, вам дает помощь зала, в течение минуты вы можете получить ответ/подсказку из зала.";
        }

        private void timerHall_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = "00:"+time;
            if (time == 0)
            {
                timerHall.Stop();
                this.Hide();
            }
        }
    }
}
