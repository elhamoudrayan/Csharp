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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            AddNS fr = new AddNS();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check ck =new Check();
            ck.Show();
        }
    }

}
