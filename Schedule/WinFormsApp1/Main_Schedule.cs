using Microsoft.VisualBasic;
using Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main_Schedule : Form
    {
        public Main_Schedule()
        {
            InitializeComponent();
        }
        public int Number_of_lines()
        {
            int lines = 0;
            if (!(File.Exists(@"C:\Users\Admin\Documents\deleted.txt")))
                return 0;
            StreamReader Line_counter = new StreamReader(@"C:\Users\Admin\Documents\deleted.txt");
            while (Line_counter.Peek() != -1)
            {
                Line_counter.ReadLine();
                lines++;
            }
            Line_counter.Close();
            return lines;
        }
        private void Cbutton_Click(object sender, EventArgs e)
        {
            //To Reveal the form that let you add notes
            AddNS fr = new AddNS();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //To reveal the form that lets you check upcoming notes
            CheckNew ck = new CheckNew();
            ck.Show();
        }

        private void refresh(object sender, EventArgs e)
        {
            
            Main_Schedule ms = new Main_Schedule();
            ms.Show();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            //This chunk of code here is to check the schedule delete what is passed and put them in the deleted section
            if (!(File.Exists(@"C:\Users\Admin\Documents\Note.txt")))
            {
                StreamWriter sw1 = new StreamWriter(@"C:\Users\Admin\Documents\Note.txt", true);
                sw1.Close();
            }

            StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\Note.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Documents\deleted.txt", true);
            StreamWriter sa = new StreamWriter(@"C:\Users\Admin\Documents\Note1.txt", true);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] splited = line.Split(",");
                if ((Convert.ToDateTime(splited[1]) - DateAndTime.Now).Seconds <= 0)
                {
                    sw.WriteLine(line);

                }
                else
                {
                    sa.WriteLine(line);
                }
            }
            sr.Close();
            sw.Close();
            sa.Close();
            File.Copy(@"C:\Users\Admin\Documents\Note1.txt", @"C:\Users\Admin\Documents\Note.txt", true);
            File.Delete(@"C:\Users\Admin\Documents\Note1.txt");
            Outdated_label.ForeColor = Color.Red;
            Outdated_label.Text = $"You have {Number_of_lines()} Outdated Tasks";

        }

        private void OldTasks_click(object sender, EventArgs e)
        {
            //This Chunk of code to show the form containing outdated tasks or notes
            CheckOld cko = new CheckOld();
            cko.Show();
        }
    }

}
