namespace CustomersManagement
{
    partial class DashboardScreen
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
            addButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 22, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "🎬 Movie List";

            // dataGridView1 - sus, lățime mare
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 25);
            dataGridView1.GridColor = Color.FromArgb(60, 60, 60);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 175, 55);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(212, 175, 55);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 130);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1600, 600);
            dataGridView1.TabIndex = 4;

            // addButton - sub tabel, stânga
            addButton.BackColor = Color.FromArgb(212, 175, 55);
            addButton.ForeColor = Color.Black;
            addButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.Cursor = Cursors.Hand;
            addButton.Location = new Point(56, 760);
            addButton.Name = "addButton";
            addButton.Size = new Size(180, 50);
            addButton.TabIndex = 1;
            addButton.Text = "＋ ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;

            // updateButton - sub tabel, mijloc
            updateButton.BackColor = Color.FromArgb(40, 40, 40);
            updateButton.ForeColor = Color.FromArgb(212, 175, 55);
            updateButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            updateButton.FlatAppearance.BorderSize = 1;
            updateButton.Cursor = Cursors.Hand;
            updateButton.Location = new Point(280, 760);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(180, 50);
            updateButton.TabIndex = 3;
            updateButton.Text = "✎ UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;

            // deleteButton - sub tabel, dreapta
            deleteButton.BackColor = Color.FromArgb(180, 40, 40);
            deleteButton.ForeColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Location = new Point(504, 760);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(180, 50);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "✕ DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;

            // DashboardScreen
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1748, 850);
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Name = "DashboardScreen";
            Text = "Movie List";
            Load += DashboardScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
        private DataGridView dataGridView1;
    }
}