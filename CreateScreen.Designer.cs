namespace CustomersManagement
{
    partial class CreateScreen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            titleInput = new TextBox();
            genreInput = new TextBox();
            yearInput = new TextBox();
            ratingInput = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 0;
            label1.Text = "🎬 Add Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(212, 175, 55);
            label2.Location = new Point(47, 123);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(212, 175, 55);
            label3.Location = new Point(47, 171);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(212, 175, 55);
            label4.Location = new Point(47, 221);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(212, 175, 55);
            label5.Location = new Point(47, 268);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 4;
            label5.Text = "Rating";
            // 
            // titleInput
            // 
            titleInput.BackColor = Color.FromArgb(40, 40, 40);
            titleInput.BorderStyle = BorderStyle.FixedSingle;
            titleInput.Font = new Font("Segoe UI", 10F);
            titleInput.ForeColor = Color.White;
            titleInput.Location = new Point(152, 119);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(259, 34);
            titleInput.TabIndex = 5;
            // 
            // genreInput
            // 
            genreInput.BackColor = Color.FromArgb(40, 40, 40);
            genreInput.BorderStyle = BorderStyle.FixedSingle;
            genreInput.Font = new Font("Segoe UI", 10F);
            genreInput.ForeColor = Color.White;
            genreInput.Location = new Point(152, 171);
            genreInput.Name = "genreInput";
            genreInput.Size = new Size(259, 34);
            genreInput.TabIndex = 6;
            genreInput.TextChanged += lastNameInput_TextChanged;
            // 
            // yearInput
            // 
            yearInput.BackColor = Color.FromArgb(40, 40, 40);
            yearInput.BorderStyle = BorderStyle.FixedSingle;
            yearInput.Font = new Font("Segoe UI", 10F);
            yearInput.ForeColor = Color.White;
            yearInput.Location = new Point(152, 221);
            yearInput.Name = "yearInput";
            yearInput.Size = new Size(259, 34);
            yearInput.TabIndex = 7;
            // 
            // ratingInput
            // 
            ratingInput.BackColor = Color.FromArgb(40, 40, 40);
            ratingInput.BorderStyle = BorderStyle.FixedSingle;
            ratingInput.Font = new Font("Segoe UI", 10F);
            ratingInput.ForeColor = Color.White;
            ratingInput.Location = new Point(152, 268);
            ratingInput.Name = "ratingInput";
            ratingInput.Size = new Size(259, 34);
            ratingInput.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(212, 175, 55);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(298, 376);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(111, 35);
            saveButton.TabIndex = 9;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // CreateScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(490, 472);
            Controls.Add(saveButton);
            Controls.Add(ratingInput);
            Controls.Add(yearInput);
            Controls.Add(genreInput);
            Controls.Add(titleInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateScreen";
            Text = "Add Movie";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox titleInput;
        private TextBox genreInput;
        private TextBox yearInput;
        private TextBox ratingInput;
        private Button saveButton;
    }
}