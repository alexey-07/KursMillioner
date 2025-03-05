using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementsDock
{
    public partial class FormCallOfFriend : Form
    {
        public int time = 60;//2
        public FormCallOfFriend()
        {
            InitializeComponent();//,mkm
            timerCallOfFriend.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1 = new System.Windows.Forms.Label();
            label1.Text = "Пока идет таймер, вы можете позвонить другу/знакомому";
        }
        

        private void timerCallOfFriend_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = "00:" + time;
            if (time == 0)
            {
                timerCallOfFriend.Stop();
                this.Hide();
            }
        }
    }
}
