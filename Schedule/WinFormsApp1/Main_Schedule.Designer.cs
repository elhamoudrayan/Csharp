namespace WinFormsApp1
{
    partial class Main_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Schedule));
            label1 = new Label();
            Cbutton = new Button();
            button2 = new Button();
            Refresh = new Button();
            OldTasks = new Button();
            Outdated_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(387, 45);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome !";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cbutton
            // 
            Cbutton.Location = new Point(250, 297);
            Cbutton.Name = "Cbutton";
            Cbutton.Size = new Size(181, 93);
            Cbutton.TabIndex = 1;
            Cbutton.Text = "Create Task";
            Cbutton.UseVisualStyleBackColor = true;
            Cbutton.Click += Cbutton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(250, 135);
            button2.Name = "button2";
            button2.Size = new Size(181, 93);
            button2.TabIndex = 2;
            button2.Text = "Check Tasks";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(487, 135);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(181, 93);
            Refresh.TabIndex = 3;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += refresh;
            // 
            // OldTasks
            // 
            OldTasks.Location = new Point(487, 297);
            OldTasks.Name = "OldTasks";
            OldTasks.Size = new Size(181, 93);
            OldTasks.TabIndex = 4;
            OldTasks.Text = "Old Tasks";
            OldTasks.UseVisualStyleBackColor = true;
            OldTasks.Click += OldTasks_click;
            // 
            // Outdated_label
            // 
            Outdated_label.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Outdated_label.Location = new Point(292, 458);
            Outdated_label.Name = "Outdated_label";
            Outdated_label.Size = new Size(347, 40);
            Outdated_label.TabIndex = 5;
            Outdated_label.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 572);
            Controls.Add(Outdated_label);
            Controls.Add(OldTasks);
            Controls.Add(Refresh);
            Controls.Add(button2);
            Controls.Add(Cbutton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Cbutton;
        private Button button2;
        private Button Refresh;
        private Button OldTasks;
        private Label Outdated_label;
    }
}