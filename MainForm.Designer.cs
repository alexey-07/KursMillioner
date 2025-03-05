namespace ElementsDock
{
    partial class MainForm
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
            buttonOpen = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.Lime;
            buttonOpen.FlatAppearance.BorderSize = 0;
            buttonOpen.FlatStyle = FlatStyle.Flat;
            buttonOpen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpen.ForeColor = SystemColors.Control;
            buttonOpen.Location = new Point(173, 419);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(136, 43);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Играть";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Crimson;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose.ForeColor = SystemColors.Control;
            buttonClose.Location = new Point(12, 419);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(136, 43);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Выход";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(815, 474);
            Controls.Add(buttonClose);
            Controls.Add(buttonOpen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private Button buttonClose;
    }
}