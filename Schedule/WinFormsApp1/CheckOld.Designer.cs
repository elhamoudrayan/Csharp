namespace Schedule
{
    partial class CheckOld
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
            ONotes = new DataGridView();
            Importance = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            ClearALL = new Button();
            Clear = new Button();
            Del_row = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ONotes).BeginInit();
            SuspendLayout();
            // 
            // ONotes
            // 
            ONotes.AllowUserToAddRows = false;
            ONotes.AllowUserToDeleteRows = false;
            ONotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ONotes.Columns.AddRange(new DataGridViewColumn[] { Importance, Date, Notes, Time });
            ONotes.Location = new Point(12, 12);
            ONotes.Name = "ONotes";
            ONotes.ReadOnly = true;
            ONotes.RowHeadersWidth = 51;
            ONotes.RowTemplate.Height = 29;
            ONotes.Size = new Size(1064, 413);
            ONotes.TabIndex = 0;
            // 
            // Importance
            // 
            Importance.HeaderText = "Importance";
            Importance.MinimumWidth = 6;
            Importance.Name = "Importance";
            Importance.ReadOnly = true;
            Importance.Width = 130;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 200;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.MinimumWidth = 60;
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Width = 480;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
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
            ClearALL.TabIndex = 2;
            ClearALL.Text = "Clear All";
            ClearALL.UseVisualStyleBackColor = false;
            ClearALL.Click += ClearALL_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Silver;
            Clear.BackgroundImageLayout = ImageLayout.Center;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Location = new Point(575, 431);
            Clear.Name = "Clear";
            Clear.Size = new Size(107, 40);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Del_row
            // 
            Del_row.Location = new Point(146, 431);
            Del_row.MaximumSize = new Size(414, 41);
            Del_row.MinimumSize = new Size(414, 40);
            Del_row.Multiline = true;
            Del_row.Name = "Del_row";
            Del_row.Size = new Size(414, 40);
            Del_row.TabIndex = 4;
            Del_row.Text = "Type the number of row starting from zero";
            Del_row.TextAlign = HorizontalAlignment.Center;
            Del_row.Click += Del_row_Click;
            // 
            // CheckOld
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 480);
            Controls.Add(Del_row);
            Controls.Add(Clear);
            Controls.Add(ClearALL);
            Controls.Add(ONotes);
            Name = "CheckOld";
            Text = "Outdated";
            Load += CheckOld_Load;
            ((System.ComponentModel.ISupportInitialize)ONotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ONotes;
        private DataGridViewTextBoxColumn Importance;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Notes;
        private DataGridViewTextBoxColumn Time;
        private Button ClearALL;
        private Button Clear;
        private TextBox Del_row;
    }
}