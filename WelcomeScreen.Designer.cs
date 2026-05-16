namespace CustomersManagement
{
    partial class WelcomeScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 26F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(144, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 60);
            label1.TabIndex = 0;
            label1.Text = "🎬 Movie List";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(212, 175, 55);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(252, 179);
            loginButton.Margin = new Padding(2, 2, 2, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(125, 59);
            loginButton.TabIndex = 1;
            loginButton.Text = "▶  Enter";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(635, 352);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WelcomeScreen";
            Text = "Movie List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginButton;
    }
}