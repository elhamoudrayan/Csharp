using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Schedule
{
    public partial class CheckOld : Form
    {
        bool firsttime = true;
        public CheckOld()
        {
            InitializeComponent();
        }

        private void CheckOld_Load(object sender, EventArgs e)
        {
            if (!(File.Exists(@"C:\Users\Admin\Documents\deleted.txt")))
            {
                MessageBox.Show("Nothing outdated to show");
                this.Close();
            }
            else
            {
                StreamReader Reader_for_Grid = new StreamReader(@"C:\Users\Admin\Documents\deleted.txt");

                if (Reader_for_Grid.Peek() != -1)
                {
                    string all = Reader_for_Grid.ReadToEnd();
                    string[] splited = all.Split("\n");
                    for (int i = 0; i < splited.Length - 1; i++)
                    {
                        string[] idn = splited[i].Split(",");

                        this.ONotes.Rows.Add(idn[0], idn[1], idn[2], (Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days.ToString() + "days");
                        if (this.ONotes.Rows[ONotes.RowCount - 1].Cells[0].Value.ToString() == "Urgent")
                        {
                            this.ONotes.Rows[ONotes.RowCount - 1].Cells[0].Style.ForeColor = Color.Red;
                        }
                        if (this.ONotes.Rows[ONotes.RowCount - 1].Cells[0].Value.ToString() == "Important")
                        {
                            this.ONotes.Rows[ONotes.RowCount - 1].Cells[0].Style.ForeColor = Color.BlueViolet;
                        }
                        if (this.ONotes.Rows[ONotes.RowCount - 1].Cells[0].Value.ToString() == "Normal")
                            this.ONotes.Rows[ONotes.RowCount - 1].Cells[0].Style.ForeColor = Color.Green;



                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days > 40)
                            this.ONotes.Rows[ONotes.RowCount - 1].Cells[3].Style.ForeColor = Color.Green;
                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days < 10)
                        {
                            this.ONotes.Rows[ONotes.RowCount - 1].Cells[3].Style.ForeColor = Color.Red;
                        }
                        if ((Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days < 40 && (Convert.ToDateTime(idn[1]) - DateAndTime.Now).Days > 10)
                        {
                            this.ONotes.Rows[ONotes.RowCount - 1].Cells[3].Style.ForeColor = Color.BlueViolet;
                        }


                    }
                    Reader_for_Grid.Close();
                }
                else
                {
                    MessageBox.Show("There is nothing out of date");
                    this.Close();
                }
            }

        }

        private void ClearALL_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\Admin\Documents\deleted.txt");
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StreamReader Read_Delete = new StreamReader(@"C:\Users\Admin\Documents\deleted.txt");
            StreamWriter Write_needed = new StreamWriter(@"C:\Users\Admin\Documents\deleted1.txt");
            int stoping_index = 0;
            while (Read_Delete.Peek() != -1)
            {
                if (stoping_index == int.Parse(Del_row.Text))
                {
                    Read_Delete.ReadLine();
                }
                else
                {
                    Write_needed.WriteLine(Read_Delete.ReadLine());
                }
                stoping_index++;
            }
            Read_Delete.Close();
            Write_needed.Close();
            File.Copy(@"C:\Users\Admin\Documents\deleted1.txt", @"C:\Users\Admin\Documents\deleted.txt", true);
            File.Delete(@"C:\Users\Admin\Documents\deleted1.txt");


        }

        private void Del_row_TextChanged(object sender, EventArgs e)
        {

        }

        private void Del_row_Click(object sender, EventArgs e)
        {
            Del_row.Text = null;
            if (firsttime)
            {
                Del_row.Clear();
                firsttime = false;
            }
        }
    }

}
