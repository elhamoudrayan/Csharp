namespace WinFormsApp1
{
    partial class AddNS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNS));
            AddingDate = new DateTimePicker();
            Add = new Button();
            Note = new TextBox();
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // AddingDate
            // 
            AddingDate.CalendarMonthBackground = SystemColors.MenuHighlight;
            AddingDate.Format = DateTimePickerFormat.Time;
            AddingDate.Location = new Point(359, 344);
            AddingDate.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            AddingDate.Name = "AddingDate";
            AddingDate.Size = new Size(106, 27);
            AddingDate.TabIndex = 0;
            AddingDate.Value = new DateTime(2023, 2, 2, 21, 1, 55, 0);
            // 
            // Add
            // 
            Add.Location = new Point(364, 392);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Note
            // 
            Note.Location = new Point(287, 59);
            Note.Multiline = true;
            Note.Name = "Note";
            Note.Size = new Size(250, 198);
            Note.TabIndex = 2;
            Note.Text = "Type Here!";
            Note.TextAlign = HorizontalAlignment.Center;
            Note.Click += Note_Click;
            Note.TextChanged += Note_TextChanged;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.None;
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(287, 279);
            trackBar1.Maximum = 3;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(250, 56);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(352, 313);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 4;
            label1.Text = "Important";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(384, 10);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 5;
            // 
            // AddNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(Note);
            Controls.Add(Add);
            Controls.Add(AddingDate);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNS";
            Text = "Schedule-Add";
            Load += AddNS_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker AddingDate;
        private Button Add;
        private TextBox Note;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
    }
}