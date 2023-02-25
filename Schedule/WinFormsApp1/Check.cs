using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;

namespace WinFormsApp1
{
    public partial class Check : Form
    {
        bool firsttime=true;
        public Check()
        {
            InitializeComponent();
        }

        private void Check_Load(object sender, EventArgs e)
        {
            if (!(File.Exists(@"C:\Users\Admin\Documents\Note.txt")))
            {
                MessageBox.Show("File Doesn't Exist Yet, Add Something First");
                this.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\Note.txt");

                if (sr.Peek() != -1)
                {
                    string all = sr.ReadToEnd();
                    string[] splited = all.Split("\n");
                    for (int i = 0; i < splited.Length - 1; i++)
                    {
                        string[] idn = splited[i].Split(",");

                        this.Notes.Rows.Add(idn[0], idn[1], idn[2], (Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days.ToString() + "days");
                        if (this.Notes.Rows[Notes.RowCount - 1].Cells[0].Value.ToString() == "Urgent")
                        {
                            this.Notes.Rows[Notes.RowCount - 1].Cells[0].Style.ForeColor = Color.Red;
                        }
                        if (this.Notes.Rows[Notes.RowCount - 1].Cells[0].Value.ToString() == "Important")
                        {
                            this.Notes.Rows[Notes.RowCount - 1].Cells[0].Style.ForeColor = Color.BlueViolet;
                        }
                        if (this.Notes.Rows[Notes.RowCount - 1].Cells[0].Value.ToString() == "Normal")
                            this.Notes.Rows[Notes.RowCount - 1].Cells[0].Style.ForeColor = Color.Green;



                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days>40)
                            this.Notes.Rows[Notes.RowCount - 1].Cells[3].Style.ForeColor = Color.Green;
                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days < 10)
                        {
                            this.Notes.Rows[Notes.RowCount - 1].Cells[3].Style.ForeColor = Color.Red;
                        }
                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days <40 && (Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days > 10)
                        {
                            this.Notes.Rows[Notes.RowCount - 1].Cells[3].Style.ForeColor = Color.BlueViolet;
                        }


                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Your Notes Are Empty");
                    this.Close();
                }
            }
            //int Top = 10;
            //int Left = 15;
            //for (int i=0; i<splited.Length;i++)
            //{
            //    Label lbl = new Label();
            //    this.Controls.Add(lbl);
            //    lbl.Top = Top;
            //    lbl.Left = Left;
            //    string[] importance = splited[i].Split(',');
            //    if (importance[0] == "Urgent")
            //    {
            //        lbl.ForeColor = Color.Red;
            //        lbl.BackColor = Color.White;
            //        lbl.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            //        lbl.AutoSize = true;
            //        lbl.Text = splited[i];
            //    }
            //    if (importance[0] == "Important")
            //    {
            //        lbl.ForeColor = Color.IndianRed;
            //        lbl.BackColor = Color.White;
            //        lbl.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            //        lbl.AutoSize = true;
            //        lbl.Text = splited[i];
            //    }
            //    if (importance[0] == "Normal")
            //    {
            //        lbl.ForeColor = Color.Green;
            //        lbl.BackColor = Color.White;
            //        lbl.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            //        lbl.AutoSize = true;
            //        lbl.Text = splited[i];
            //    }
            //    sr.Close();
            //    Top += 40;

            //}

        }

        private void dragover(object sender, DragEventArgs e)
        {
            
        }

        private void hover(object sender, EventArgs e)
        {
            ClearALL.BackColor = Color.Red;
            ClearALL.Font = new Font(ClearALL.Font, FontStyle.Bold); 
        }

        private void leavehover(object sender, EventArgs e)
        {
            ClearALL.BackColor = Color.Silver;
            ClearALL.Font = new Font(ClearALL.Font, FontStyle.Regular);
        }

        private void ClearALL_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\Admin\Documents\Note.txt");
            this.Close();
            
        }

        private void clear1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clear1button_Click(object sender, EventArgs e)
        {
            if (clear1.Text == "" || clear1.Text == "Fill here Importance,Date,Note separated by a comma")
            {
                label1.Text = "Nothing to delete";
            }
            else
            {
                StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\Note.txt");
                StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Documents\Note1.txt");
                while (sr.Peek() != -1) {
                    string line = sr.ReadLine();
                    if (!(line==clear1.Text))
                        sw.WriteLine(line);
                }
                sr.Close();
                sw.Close();
                File.Copy(@"C:\Users\Admin\Documents\Note1.txt", @"C:\Users\Admin\Documents\Note.txt", true);
                File.Delete(@"C:\Users\Admin\Documents\Note1.txt");
                //label1.Text= "Cleared!";
                //File.Delete(@"C:\Users\Admin\Documents\Note1.txt");
                

            }
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            if (firsttime)
            {
                clear1.Clear();
                firsttime = false;
            }
        }

    }
}
