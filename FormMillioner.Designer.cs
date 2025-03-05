namespace ElementsDock
{
    partial class FormMillioner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelTitle = new Label();
            buttonRules = new Button();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonFifty = new Button();
            buttonHall = new Button();
            buttonCall = new Button();
            panel2 = new Panel();
            flowLayoutPanelCount = new FlowLayoutPanel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelMain = new Panel();
            labelResult = new Label();
            buttonRestart = new Button();
            buttonExit = new Button();
            button1 = new Button();
            tableLayoutPanelGame = new TableLayoutPanel();
            radioButtonA = new RadioButton();
            radioButtonB = new RadioButton();
            radioButtonC = new RadioButton();
            radioButtonD = new RadioButton();
            labelQuestion = new Label();
            panelTop.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanelCount.SuspendLayout();
            panelMain.SuspendLayout();
            tableLayoutPanelGame.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(buttonRules);
            panelTop.Controls.Add(flowLayoutPanelButtons);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(15);
            panelTop.Size = new Size(1031, 100);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(126, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(552, 70);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Кто хочет стать миллионером";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // buttonRules
            // 
            buttonRules.BackColor = Color.FromArgb(255, 208, 115);
            buttonRules.Dock = DockStyle.Left;
            buttonRules.Location = new Point(15, 15);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(111, 70);
            buttonRules.TabIndex = 2;
            buttonRules.Text = "Правила";
            buttonRules.UseVisualStyleBackColor = false;
            buttonRules.Click += buttonRules_Click;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(buttonFifty);
            flowLayoutPanelButtons.Controls.Add(buttonHall);
            flowLayoutPanelButtons.Controls.Add(buttonCall);
            flowLayoutPanelButtons.Dock = DockStyle.Right;
            flowLayoutPanelButtons.Location = new Point(678, 15);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(10);
            flowLayoutPanelButtons.Size = new Size(338, 70);
            flowLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonFifty
            // 
            buttonFifty.BackColor = Color.FromArgb(255, 208, 115);
            buttonFifty.Location = new Point(13, 13);
            buttonFifty.Name = "buttonFifty";
            buttonFifty.Size = new Size(100, 50);
            buttonFifty.TabIndex = 0;
            buttonFifty.Text = "50/50";
            buttonFifty.UseVisualStyleBackColor = false;
            buttonFifty.Click += buttonFifty_Click;
            // 
            // buttonHall
            // 
            buttonHall.BackColor = Color.FromArgb(255, 208, 115);
            buttonHall.Location = new Point(119, 13);
            buttonHall.Name = "buttonHall";
            buttonHall.Size = new Size(100, 50);
            buttonHall.TabIndex = 1;
            buttonHall.Text = "Зал";
            buttonHall.UseVisualStyleBackColor = false;
            buttonHall.Click += buttonHall_Click;
            // 
            // buttonCall
            // 
            buttonCall.BackColor = Color.FromArgb(255, 208, 115);
            buttonCall.Location = new Point(225, 13);
            buttonCall.Name = "buttonCall";
            buttonCall.Size = new Size(100, 50);
            buttonCall.TabIndex = 2;
            buttonCall.Text = "Звонок ";
            buttonCall.UseVisualStyleBackColor = false;
            buttonCall.Click += buttonCall_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanelCount);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(797, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 414);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanelCount
            // 
            flowLayoutPanelCount.Controls.Add(label15);
            flowLayoutPanelCount.Controls.Add(label14);
            flowLayoutPanelCount.Controls.Add(label13);
            flowLayoutPanelCount.Controls.Add(label12);
            flowLayoutPanelCount.Controls.Add(label11);
            flowLayoutPanelCount.Controls.Add(label10);
            flowLayoutPanelCount.Controls.Add(label9);
            flowLayoutPanelCount.Controls.Add(label8);
            flowLayoutPanelCount.Controls.Add(label7);
            flowLayoutPanelCount.Controls.Add(label6);
            flowLayoutPanelCount.Controls.Add(label5);
            flowLayoutPanelCount.Controls.Add(label4);
            flowLayoutPanelCount.Controls.Add(label3);
            flowLayoutPanelCount.Controls.Add(label2);
            flowLayoutPanelCount.Controls.Add(label1);
            flowLayoutPanelCount.Dock = DockStyle.Fill;
            flowLayoutPanelCount.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCount.ForeColor = Color.White;
            flowLayoutPanelCount.Location = new Point(0, 0);
            flowLayoutPanelCount.Name = "flowLayoutPanelCount";
            flowLayoutPanelCount.Padding = new Padding(15);
            flowLayoutPanelCount.Size = new Size(234, 414);
            flowLayoutPanelCount.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(18, 15);
            label15.Name = "label15";
            label15.Size = new Size(32, 25);
            label15.TabIndex = 0;
            label15.Text = "15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Yellow;
            label14.Location = new Point(18, 40);
            label14.Name = "label14";
            label14.Size = new Size(32, 25);
            label14.TabIndex = 1;
            label14.Text = "14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Yellow;
            label13.Location = new Point(18, 65);
            label13.Name = "label13";
            label13.Size = new Size(32, 25);
            label13.TabIndex = 2;
            label13.Text = "13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Yellow;
            label12.Location = new Point(18, 90);
            label12.Name = "label12";
            label12.Size = new Size(32, 25);
            label12.TabIndex = 3;
            label12.Text = "12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Yellow;
            label11.Location = new Point(18, 115);
            label11.Name = "label11";
            label11.Size = new Size(32, 25);
            label11.TabIndex = 4;
            label11.Text = "11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 140);
            label10.Name = "label10";
            label10.Size = new Size(32, 25);
            label10.TabIndex = 5;
            label10.Text = "10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Yellow;
            label9.Location = new Point(18, 165);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 6;
            label9.Text = "9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(18, 190);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 7;
            label8.Text = "8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(18, 215);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 8;
            label7.Text = "7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(18, 240);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 9;
            label6.Text = "6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 265);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 10;
            label5.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(18, 290);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 11;
            label4.Text = "4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(18, 315);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 12;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(18, 340);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 13;
            label2.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(18, 365);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 14;
            label1.Text = "1";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(labelResult);
            panelMain.Controls.Add(buttonRestart);
            panelMain.Controls.Add(buttonExit);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(tableLayoutPanelGame);
            panelMain.Controls.Add(labelQuestion);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(15);
            panelMain.Size = new Size(797, 414);
            panelMain.TabIndex = 2;
            panelMain.Paint += panel3_Paint;
            // 
            // labelResult
            // 
            labelResult.ForeColor = Color.White;
            labelResult.Location = new Point(126, 226);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(544, 89);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.FromArgb(255, 208, 115);
            buttonRestart.Location = new Point(137, 365);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(167, 42);
            buttonRestart.TabIndex = 4;
            buttonRestart.Text = "Играть заново";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(255, 208, 115);
            buttonExit.Location = new Point(21, 365);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(93, 42);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 208, 115);
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(15, 140);
            button1.Name = "button1";
            button1.Size = new Size(767, 50);
            button1.TabIndex = 2;
            button1.Text = "Ответить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanelGame
            // 
            tableLayoutPanelGame.ColumnCount = 2;
            tableLayoutPanelGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelGame.Controls.Add(radioButtonA, 0, 0);
            tableLayoutPanelGame.Controls.Add(radioButtonB, 1, 0);
            tableLayoutPanelGame.Controls.Add(radioButtonC, 0, 1);
            tableLayoutPanelGame.Controls.Add(radioButtonD, 1, 1);
            tableLayoutPanelGame.Dock = DockStyle.Top;
            tableLayoutPanelGame.Location = new Point(15, 40);
            tableLayoutPanelGame.Name = "tableLayoutPanelGame";
            tableLayoutPanelGame.RowCount = 2;
            tableLayoutPanelGame.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelGame.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelGame.Size = new Size(767, 100);
            tableLayoutPanelGame.TabIndex = 1;
            tableLayoutPanelGame.Paint += tableLayoutPanel1_Paint;
            // 
            // radioButtonA
            // 
            radioButtonA.AutoSize = true;
            radioButtonA.Dock = DockStyle.Fill;
            radioButtonA.ForeColor = SystemColors.ControlLightLight;
            radioButtonA.Location = new Point(3, 3);
            radioButtonA.Name = "radioButtonA";
            radioButtonA.Size = new Size(377, 44);
            radioButtonA.TabIndex = 2;
            radioButtonA.Text = "А: ";
            radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            radioButtonB.AutoSize = true;
            radioButtonB.Dock = DockStyle.Fill;
            radioButtonB.ForeColor = SystemColors.ControlLightLight;
            radioButtonB.Location = new Point(386, 3);
            radioButtonB.Name = "radioButtonB";
            radioButtonB.Size = new Size(378, 44);
            radioButtonB.TabIndex = 3;
            radioButtonB.Text = "B: ";
            radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            radioButtonC.AutoSize = true;
            radioButtonC.Dock = DockStyle.Fill;
            radioButtonC.ForeColor = SystemColors.ControlLightLight;
            radioButtonC.Location = new Point(3, 53);
            radioButtonC.Name = "radioButtonC";
            radioButtonC.Size = new Size(377, 44);
            radioButtonC.TabIndex = 4;
            radioButtonC.Text = "C:";
            radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            radioButtonD.AutoSize = true;
            radioButtonD.Dock = DockStyle.Fill;
            radioButtonD.ForeColor = SystemColors.ControlLightLight;
            radioButtonD.Location = new Point(386, 53);
            radioButtonD.Name = "radioButtonD";
            radioButtonD.Size = new Size(378, 44);
            radioButtonD.TabIndex = 5;
            radioButtonD.Text = "D:";
            radioButtonD.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            labelQuestion.BackColor = Color.FromArgb(6, 38, 111);
            labelQuestion.Dock = DockStyle.Top;
            labelQuestion.ForeColor = Color.White;
            labelQuestion.Location = new Point(15, 15);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(767, 25);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "Вопрос";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMillioner
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 68, 128);
            ClientSize = new Size(1031, 514);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FormMillioner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMillioner";
            Load += FormMillioner_Load;
            panelTop.ResumeLayout(false);
            flowLayoutPanelButtons.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanelCount.ResumeLayout(false);
            flowLayoutPanelCount.PerformLayout();
            panelMain.ResumeLayout(false);
            tableLayoutPanelGame.ResumeLayout(false);
            tableLayoutPanelGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelCount;
        private Label label15;
        private Panel panelMain;
        private Label labelQuestion;
        private Label labelTitle;
        private Button buttonRules;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button buttonFifty;
        private Button buttonHall;
        private Button buttonCall;
        private TableLayoutPanel tableLayoutPanelGame;
        private RadioButton radioButtonA;
        private RadioButton radioButtonB;
        private RadioButton radioButtonC;
        private RadioButton radioButtonD;
        private Button button1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonExit;
        private Button buttonRestart;
        private Label labelResult;
    }
}