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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("fon.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            FormMillioner form = new FormMillioner();   
            form.ShowDialog();
            this.Hide();
        }
    }
}
