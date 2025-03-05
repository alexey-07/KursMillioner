namespace ElementsDock
{
    partial class FormCallOfFriend
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
            timerCallOfFriend = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuBar;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(270, 345);
            label1.TabIndex = 0;
            label1.Text = "Пока идет таймер,\r\n вы можете позвонить другу/знакомому";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // timerCallOfFriend
            // 
            timerCallOfFriend.Interval = 1000;
            timerCallOfFriend.Tick += timerCallOfFriend_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 354);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // FormCallOfFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 408);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCallOfFriend";
            Text = "FormCallOfFriend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timerCallOfFriend;
        private Label label2;
    }
}