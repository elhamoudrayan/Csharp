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
    public partial class CheckNew : Form
    {
        bool firsttime = true;
        public CheckNew()
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



                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days > 40)
                            this.Notes.Rows[Notes.RowCount - 1].Cells[3].Style.ForeColor = Color.Green;
                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days < 10)
                        {
                            this.Notes.Rows[Notes.RowCount - 1].Cells[3].Style.ForeColor = Color.Red;
                        }
                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days < 40 && (Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days > 10)
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

        private void clear1button_Click(object sender, EventArgs e)
        {

            StreamReader Read_Note = new StreamReader(@"C:\Users\Admin\Documents\Note.txt");
            StreamWriter Write_needed = new StreamWriter(@"C:\Users\Admin\Documents\Note1.txt");
            int stoping_index = 0;
            while (Read_Note.Peek() != -1)
            {
                if (stoping_index == int.Parse(Del_row.Text))
                {
                    Read_Note.ReadLine();
                }
                else
                {
                    Write_needed.WriteLine(Read_Note.ReadLine());
                }
                stoping_index++;
            }
            Read_Note.Close();
            Write_needed.Close();
            File.Copy(@"C:\Users\Admin\Documents\Note1.txt", @"C:\Users\Admin\Documents\Note.txt", true);
            File.Delete(@"C:\Users\Admin\Documents\Note1.txt");
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            if (firsttime)
            {
                Del_row.Clear();
                firsttime = false;
            }
        }

        private void clear1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
