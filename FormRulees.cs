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
    public partial class FormRulees : Form
    {
        public FormRulees()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.Text = "Игра Кто хочет стать миллионером?" +
                " - это конкурс викторина, в котором участники должны правильно ответить" +
                " на ряд вопросов с несколькими вариантами ответов, чтобы перейти на следующий уровень." +
                " Всего 15 вопросов, каждый вопрос стоит определенной суммы денег, участники не имеют никаких временных ограничений" +
                " для предоставления ответа. Участники также получают три вида подсказок," +
                " чтобы помочь себе, если они застряли на конкретном вопросе.";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
