namespace WinFormsApp1
{
    partial class Check
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.Notes = new System.Windows.Forms.DataGridView();
            this.Importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearALL = new System.Windows.Forms.Button();
            this.clear1button = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).BeginInit();
            this.SuspendLayout();
            // 
            // Notes
            // 
            this.Notes.AllowUserToAddRows = false;
            this.Notes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Notes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Importance,
            this.Date,
            this.Note,
            this.Time});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Notes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Notes.Location = new System.Drawing.Point(12, 12);
            this.Notes.Name = "Notes";
            this.Notes.RowHeadersWidth = 51;
            this.Notes.RowTemplate.Height = 29;
            this.Notes.Size = new System.Drawing.Size(1064, 413);
            this.Notes.TabIndex = 0;
            // 
            // Importance
            // 
            this.Importance.HeaderText = "Importance";
            this.Importance.MinimumWidth = 6;
            this.Importance.Name = "Importance";
            this.Importance.ReadOnly = true;
            this.Importance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Importance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Importance.Width = 130;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 200;
            // 
            // Note
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Note.DefaultCellStyle = dataGridViewCellStyle2;
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 60;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Note.Width = 480;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 200;
            // 
            // ClearALL
            // 
            this.ClearALL.BackColor = System.Drawing.Color.Silver;
            this.ClearALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearALL.Location = new System.Drawing.Point(12, 431);
            this.ClearALL.Name = "ClearALL";
            this.ClearALL.Size = new System.Drawing.Size(107, 40);
            this.ClearALL.TabIndex = 1;
            this.ClearALL.Text = "Clear All";
            this.ClearALL.UseVisualStyleBackColor = false;
            this.ClearALL.Click += new System.EventHandler(this.ClearALL_Click);
            this.ClearALL.MouseLeave += new System.EventHandler(this.leavehover);
            this.ClearALL.MouseHover += new System.EventHandler(this.hover);
            // 
            // clear1button
            // 
            this.clear1button.BackColor = System.Drawing.Color.Silver;
            this.clear1button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear1button.Location = new System.Drawing.Point(575, 431);
            this.clear1button.Name = "clear1button";
            this.clear1button.Size = new System.Drawing.Size(107, 40);
            this.clear1button.TabIndex = 2;
            this.clear1button.Text = "Clear";
            this.clear1button.UseVisualStyleBackColor = false;
            this.clear1button.Click += new System.EventHandler(this.clear1button_Click);
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(146, 431);
            this.clear1.MaximumSize = new System.Drawing.Size(414, 41);
            this.clear1.MinimumSize = new System.Drawing.Size(414, 40);
            this.clear1.Multiline = true;
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(414, 40);
            this.clear1.TabIndex = 3;
            this.clear1.Text = "Fill here Importance,Date,Note separated by a comma";
            this.clear1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.clear1button);
            this.Controls.Add(this.ClearALL);
            this.Controls.Add(this.Notes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Check";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Notes;
        private DataGridViewTextBoxColumn Importance;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Note;
        private DataGridViewTextBoxColumn Time;
        private Button ClearALL;
        private Button clear1button;
        private TextBox clear1;
        private Label label1;
    }
}