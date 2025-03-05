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
using static System.Net.Mime.MediaTypeNames;

namespace ElementsDock
{
    public partial class FormMillioner : Form
    {
        private int currentAnswer;
        private int answer;
        private int count = 1;
        private int kol = 1;
        private int sum;
        private int mainSum = 0;
        private int staticSum = 0;
        private int useButtonFifty = 0;
        private int verBut1 = -1;
        private int verBut2 = -1;
        private int verBut3 = -1;
        public FormMillioner()
        {
            InitializeComponent();
            labelResult.Visible = false;
            buttonRestart.Visible = false;
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMillioner_Load(object sender, EventArgs e)
        {
            labelQuestion.Text = "Какой цвет получается при смешивании синего и желтого?";
            radioButtonA.Text = "Красный";
            radioButtonB.Text = "Зеленый ";
            radioButtonC.Text = "Фиолетовый";
            radioButtonD.Text = "Оранжевый";
            currentAnswer = 2;
            sum = 100;



        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            FormRulees rulees = new FormRulees();
            rulees.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Visible = false;
            if (verBut1 < 0)
            {
                buttonCall.Enabled = true;
            }
            if (verBut2 < 0)
            {
                buttonHall.Enabled = true;
            }
            if (verBut3 < 0)
            {
                buttonFifty.Enabled = true;
            }
            if (!radioButtonA.Checked && !radioButtonB.Checked && !radioButtonC.Checked && !radioButtonD.Checked)
            {
                labelResult.Visible = true;
                labelResult.Text = "Пожалуйста, выберите ответ!";
                return; // Завершаем выполнение метода, если ответ не выбран
            }
            if (useButtonFifty != 0)
            {
                radioButtonA.Visible = true;
                radioButtonB.Visible = true;
                radioButtonC.Visible = true;
                radioButtonD.Visible = true;
                radioButtonA.Enabled = true;
                radioButtonB.Enabled = true;
                radioButtonC.Enabled = true;
                radioButtonD.Enabled = true;

            }
            if (radioButtonA.Checked) answer = 1;
            else if (radioButtonB.Checked) answer = 2;
            else if (radioButtonC.Checked) answer = 3;
            else if (radioButtonD.Checked) answer = 4;
            mainSum += sum;
            if (currentAnswer == answer)
            {
                flowLayoutPanelCount.Controls.Find(("label" + kol), true)[0].Text += " " + mainSum;
                kol++;
                if (count == 5 || count == 10)
                {
                    staticSum = mainSum;
                }
                count++;
                NextQuestion(count);

                if (count == 16)
                {
                    labelResult.Visible = true;
                    labelResult.Text = "Поздравляем! Ваш выигрыш составляет 1 000 000₽!";

                }
                else
                {
                    NextQuestion(count);
                }
            }
            else
            {

                /*labelQuestion.Text = "К сожалению, вы проиграли :)";*/
                labelResult.Visible = true;
                labelResult.Text = $"К сожалению, вы проиграли! Ваш выигрыш составляет {staticSum}₽.";
                radioButtonA.Enabled = false;
                radioButtonB.Enabled = false;
                radioButtonC.Enabled = false;
                radioButtonD.Enabled = false;
                buttonRestart.Visible = true; // Показываем кнопку "Начать заново"

            }

        }
        private void NextQuestion(int count)
        {

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            switch (count)
            {
                case 2:
                    labelQuestion.Text = "Какой континент является самым большим по площади?";
                    radioButtonA.Text = "Африка";
                    radioButtonB.Text = "Азия";
                    radioButtonC.Text = "Европа";
                    radioButtonD.Text = "Северная Америка";
                    currentAnswer = 2;
                    sum = 100;
                    break;
                case 3:
                    labelQuestion.Text = "Какой элемент имеет химический символ \"O\"?";
                    radioButtonA.Text = "Золото";
                    radioButtonB.Text = "Углерод";
                    radioButtonC.Text = "Кислород";
                    radioButtonD.Text = "Азот";
                    currentAnswer = 3;
                    sum = 100;
                    break;
                case 4:
                    labelQuestion.Text = "В каком году началась Вторая мировая война?";
                    radioButtonA.Text = "1935";
                    radioButtonB.Text = "1939";
                    radioButtonC.Text = "1941";
                    radioButtonD.Text = "1945";
                    currentAnswer = 2;
                    sum = 200;
                    break;
                case 5:
                    labelQuestion.Text = "Какой композитор написал \"Лунную сонату\"?";
                    radioButtonA.Text = "Иоганн Себастьян Бах";
                    radioButtonB.Text = "Вольфганг Амадей Моцарт";
                    radioButtonC.Text = "Фредерик Шопен";
                    radioButtonD.Text = "Людвиг ван Бетховен";
                    currentAnswer = 4;
                    sum = 500;
                    break;
                case 6:
                    labelQuestion.Text = "Какой газ составляет основную часть атмосферы Земли?";
                    radioButtonA.Text = "Азот";
                    radioButtonB.Text = "Кислород";
                    radioButtonC.Text = "Углекислый газ";
                    radioButtonD.Text = "Аргон";
                    currentAnswer = 1;
                    sum = 1000;
                    break;
                case 7:
                    labelQuestion.Text = "Какой элемент периодической таблицы имеет атомный номер 79?";
                    radioButtonA.Text = "Платина";
                    radioButtonB.Text = "Серебро";
                    radioButtonC.Text = "Ртуть";
                    radioButtonD.Text = "Золото ";
                    currentAnswer = 4;
                    sum = 2000;
                    break;
                case 8:
                    labelQuestion.Text = "Какой роман написал Федор Достоевский?";
                    radioButtonA.Text = "Анна Каренина";
                    radioButtonB.Text = "Преступление и наказание";
                    radioButtonC.Text = "Мастер и Маргарита";
                    radioButtonD.Text = "Война и мир";
                    currentAnswer = 2;
                    sum = 4000;
                    break;
                case 9:
                    labelQuestion.Text = "Какой физик предложил теорию относительности?";
                    radioButtonA.Text = "Исаак Ньютон";
                    radioButtonB.Text = "Никола Тесла";
                    radioButtonC.Text = "Альберт Эйнштейн";
                    radioButtonD.Text = "Галилео Галилей";
                    currentAnswer = 3;
                    sum = 8000;
                    break;
                case 10:
                    labelQuestion.Text = "Какой язык является официальным в Бразилии?";
                    radioButtonA.Text = "Испанский";
                    radioButtonB.Text = "Французский";
                    radioButtonC.Text = "Итальянский";
                    radioButtonD.Text = "Португальский";
                    currentAnswer = 4;
                    sum = 16000;
                    break;
                case 11:
                    labelQuestion.Text = "Какой художник создал \"Сикстинскую капеллу\"?";
                    radioButtonA.Text = "Рафаэль";
                    radioButtonB.Text = "Микеланджело";
                    radioButtonC.Text = "Леонардо да Винчи";
                    radioButtonD.Text = "Ван Гог";
                    currentAnswer = 2;
                    sum = 32000;
                    break;
                case 12:
                    labelQuestion.Text = "Какой элемент является самым легким в периодической таблице?";
                    radioButtonA.Text = "Водород";
                    radioButtonB.Text = "Гелий";
                    radioButtonC.Text = "Литий";
                    radioButtonD.Text = "Бериллий";
                    currentAnswer = 1;
                    sum = 64000;
                    break;
                case 13:
                    labelQuestion.Text = "Какой физический закон описывает закон сохранения энергии?";
                    radioButtonA.Text = "Закон Ньютона";
                    radioButtonB.Text = "Закон сохранения импульса";
                    radioButtonC.Text = "Закон термодинамики";
                    radioButtonD.Text = "Закон сохранения массы";
                    currentAnswer = 3;
                    sum = 122000;
                    break;
                case 14:
                    labelQuestion.Text = "Кто был противником русских во время битвы на Куликовском поле?";
                    radioButtonA.Text = "Печенеги";
                    radioButtonB.Text = "Золотая орда";
                    radioButtonC.Text = "Шведы";
                    radioButtonD.Text = "Куликовцы";
                    currentAnswer = 2;
                    sum = 250000;
                    break;
                case 15:
                    labelQuestion.Text = "Какой древнегреческий философ был учеником Платона?";
                    radioButtonA.Text = "Сократ";
                    radioButtonB.Text = "Эпикур";
                    radioButtonC.Text = "Пифагор";
                    radioButtonD.Text = "Аристотель";
                    currentAnswer = 4;
                    sum = 500000;
                    break;

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            /*labelResult.Visible = false;
            currentAnswer = 0;
            answer = 0;
            count = 1;
            kol = 1;
            mainSum = 0;
            staticSum = 0;
            for (int i = 1; i <= 15; i++)
            {
                flowLayoutPanelCount.Controls.Find(("label" + i), true)[0].Text = " " + i;
            }

            // Сбрасываем текст вопросов и ответов
            FormMillioner_Load(sender, e);

            // Включаем кнопки ответов
            radioButtonA.Enabled = true;
            radioButtonB.Enabled = true;
            radioButtonC.Enabled = true;
            radioButtonD.Enabled = true;

            buttonCall.Enabled = true;
            buttonHall.Enabled = true;
            buttonFifty.Enabled = true;

            this.buttonRestart.Visible = false;*/

            FormMillioner form = new FormMillioner();
            this.Hide();
            form.ShowDialog();
            


        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            verBut1 = 1;
            buttonHall.Enabled = false;
            buttonFifty.Enabled= false;
            buttonCall.Enabled = false;
            FormCallOfFriend callOfFriend = new FormCallOfFriend();
            callOfFriend.Show();
            
        }

        private void buttonHall_Click(object sender, EventArgs e)
        {
            verBut2 = 1;
            buttonHall.Enabled = false;//ей
            buttonFifty.Enabled = false;
            buttonCall.Enabled = false;
            FormHall callHall = new FormHall();
            callHall.Show();
        }
        // Остальная логика...

        private void buttonFifty_Click(object sender, EventArgs e)
        {
            verBut3 = 1;
            
            // Проверяем, была ли уже использована подсказка 50/50
            if (buttonFifty.Enabled)
            {
                buttonHall.Enabled = false;
                buttonFifty.Enabled = false;
                buttonCall.Enabled = false;
                // Список всех радиокнопок
                RadioButton[] radioButtons = { radioButtonA, radioButtonB, radioButtonC, radioButtonD };

                // Сначала отключаем все радиокнопки
                foreach (var rb in radioButtons)
                {
                    rb.Enabled = false;
                }

                // Включаем правильный ответ
                switch (currentAnswer)
                {
                    case 1:
                        radioButtonA.Enabled = true;
                        break;
                    case 2:
                        radioButtonB.Enabled = true;
                        break;
                    case 3:
                        radioButtonC.Enabled = true;
                        break;
                    case 4:
                        radioButtonD.Enabled = true;
                        break;
                }

                // Случайным образом выбираем два неверных варианта и отключаем их
                Random random = new Random();
                int incorrectCount = 0;

                foreach (var rb in radioButtons)
                {
                    if (!rb.Enabled) // Если это не правильный ответ
                    {
                        if (incorrectCount < 2) // Удаляем только два неверных ответа
                        {
                            rb.Visible = false; // Скрываем радиокнопку
                            incorrectCount++;
                        }
                    }
                }

                // Делаем кнопку 50/50 неактивной после использования
                useButtonFifty++;

                // Включаем все радиокнопки после использования подсказки
                foreach (var rb in radioButtons)
                {
                    rb.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Вы уже использовали подсказку 50/50!");
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
