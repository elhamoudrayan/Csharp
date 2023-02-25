using System.IO;
namespace WinFormsApp1
{
    public partial class AddNS : Form
    {
        bool firsttime = true;

        public AddNS()
        {
            InitializeComponent();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value==1)
            {
                label1.Text = "Normal";
                label1.ForeColor= Color.Green;
            }
            if (trackBar1.Value == 2)
            {
                label1.Text = "Important";
                label1.ForeColor = Color.BlueViolet;
            }
            if (trackBar1.Value == 3)
            {
                label1.Text = "Urgent";
                label1.ForeColor = Color.Red;
            }
        }

        private void Note_Click(object sender, EventArgs e)
        {
            if (firsttime)
            {
                Note.Clear();
                firsttime= false;
            }
            label2.Text = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(Note.Text=="" || Note.Text== "Type Here!")
            {
                MessageBox.Show("There is nothing to add!");
            }
            else
            {
                StreamWriter sr= new StreamWriter(@"C:\Users\Admin\Documents\Note.txt", true);
                sr.Write(label1.Text);
                sr.Write(",");
                sr.Write(dat.Text);
                sr.Write(",");
                sr.WriteLine(Note.Text);
                sr.Close();
            }
            label2.Text = "Added!";
            Note.Clear();
            
        }
    }
}