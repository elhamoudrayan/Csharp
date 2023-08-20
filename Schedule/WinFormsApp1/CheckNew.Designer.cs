namespace WinFormsApp1
{
    partial class CheckNew
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckNew));
            Notes = new DataGridView();
            Importance = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            ClearALL = new Button();
            clear1button = new Button();
            Del_row = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Notes).BeginInit();
            SuspendLayout();
            // 
            // Notes
            // 
            Notes.AllowUserToAddRows = false;
            Notes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Notes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Notes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Notes.Columns.AddRange(new DataGridViewColumn[] { Importance, Date, Note, Time });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Notes.DefaultCellStyle = dataGridViewCellStyle3;
            Notes.Location = new Point(12, 12);
            Notes.Name = "Notes";
            Notes.RowHeadersWidth = 51;
            Notes.RowTemplate.Height = 29;
            Notes.Size = new Size(1064, 413);
            Notes.TabIndex = 0;
            // 
            // Importance
            // 
            Importance.HeaderText = "Importance";
            Importance.MinimumWidth = 6;
            Importance.Name = "Importance";
            Importance.ReadOnly = true;
            Importance.Resizable = DataGridViewTriState.False;
            Importance.SortMode = DataGridViewColumnSortMode.NotSortable;
            Importance.Width = 130;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Resizable = DataGridViewTriState.False;
            Date.SortMode = DataGridViewColumnSortMode.NotSortable;
            Date.Width = 200;
            // 
            // Note
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            Note.DefaultCellStyle = dataGridViewCellStyle2;
            Note.HeaderText = "Note";
            Note.MinimumWidth = 60;
            Note.Name = "Note";
            Note.ReadOnly = true;
            Note.SortMode = DataGridViewColumnSortMode.NotSortable;
            Note.Width = 480;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.SortMode = DataGridViewColumnSortMode.NotSortable;
            Time.Width = 200;
            // 
            // ClearALL
            // 
            ClearALL.BackColor = Color.Silver;
            ClearALL.BackgroundImageLayout = ImageLayout.Center;
            ClearALL.FlatStyle = FlatStyle.Flat;
            ClearALL.Location = new Point(12, 431);
            ClearALL.Name = "ClearALL";
            ClearALL.Size = new Size(107, 40);
            ClearALL.TabIndex = 1;
            ClearALL.Text = "Clear All";
            ClearALL.UseVisualStyleBackColor = false;
            ClearALL.Click += ClearALL_Click;
            ClearALL.MouseLeave += leavehover;
            ClearALL.MouseHover += hover;
            // 
            // clear1button
            // 
            clear1button.BackColor = Color.Silver;
            clear1button.BackgroundImageLayout = ImageLayout.Center;
            clear1button.FlatStyle = FlatStyle.Flat;
            clear1button.Location = new Point(575, 431);
            clear1button.Name = "clear1button";
            clear1button.Size = new Size(107, 40);
            clear1button.TabIndex = 2;
            clear1button.Text = "Clear";
            clear1button.UseVisualStyleBackColor = false;
            clear1button.Click += clear1button_Click;
            // 
            // Del_row
            // 
            Del_row.Location = new Point(146, 431);
            Del_row.MaximumSize = new Size(414, 41);
            Del_row.MinimumSize = new Size(414, 40);
            Del_row.Multiline = true;
            Del_row.Name = "Del_row";
            Del_row.Size = new Size(414, 40);
            Del_row.TabIndex = 3;
            Del_row.Text = "Type the number of row starting from 0";
            Del_row.TextAlign = HorizontalAlignment.Center;
            Del_row.Click += clear1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(708, 441);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // CheckNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 480);
            Controls.Add(label1);
            Controls.Add(Del_row);
            Controls.Add(clear1button);
            Controls.Add(ClearALL);
            Controls.Add(Notes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CheckNew";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Notes";
            Load += Check_Load;
            ((System.ComponentModel.ISupportInitialize)Notes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Notes;
        private DataGridViewTextBoxColumn Importance;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Note;
        private DataGridViewTextBoxColumn Time;
        private Button ClearALL;
        private Button clear1button;
        private TextBox Del_row;
        private Label label1;
    }
}