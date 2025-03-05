namespace ElementsDock
{
    partial class FormRulees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRulees));
            panelRules = new Panel();
            buttonExit = new Button();
            label1 = new Label();
            panelRules.SuspendLayout();
            SuspendLayout();
            // 
            // panelRules
            // 
            panelRules.BackColor = Color.FromArgb(103, 134, 205);
            panelRules.Controls.Add(buttonExit);
            panelRules.Controls.Add(label1);
            panelRules.Dock = DockStyle.Fill;
            panelRules.Location = new Point(0, 0);
            panelRules.Name = "panelRules";
            panelRules.Padding = new Padding(10);
            panelRules.Size = new Size(336, 438);
            panelRules.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(255, 208, 115);
            buttonExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(10, 360);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(311, 54);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Назад";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(316, 418);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FormRulees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 68, 128);
            ClientSize = new Size(336, 438);
            Controls.Add(panelRules);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRulees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRulees";
            panelRules.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRules;
        private Label label1;
        private Button buttonExit;
    }
}