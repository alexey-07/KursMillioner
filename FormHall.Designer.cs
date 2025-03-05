namespace ElementsDock
{
    partial class FormHall
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timerHall = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(270, 237);
            label1.TabIndex = 0;
            label1.Text = "Данная подсказка, вам дает помощь зала.\r\nВ течение минуты вы можете получить ответ/подсказку\r\nиз зала.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // timerHall
            // 
            timerHall.Interval = 1000;
            timerHall.Tick += timerHall_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 275);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // FormHall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 331);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHall";
            Text = "FormHall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timerHall;
        private Label label2;
    }
}