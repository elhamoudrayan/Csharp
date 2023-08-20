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
            if (trackBar1.Value == 1)
            {
                label1.Text = "Normal";
                label1.ForeColor = Color.Green;
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
                firsttime = false;
            }
            label2.Text = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Note.Text == "" || Note.Text == "Type Here!")
            {
                MessageBox.Show("There is nothing to add!");
            }
            else
            {
                StreamWriter sr2 = new StreamWriter(@"C:\Users\Admin\Documents\Note.txt",true);
                sr2.Write(label1.Text);
                sr2.Write(",");
                sr2.Write(AddingDate.Text);
                sr2.Write(",");
                sr2.WriteLine(Note.Text);
                sr2.Close();
            }
            label2.Text = "Added!";
            Note.Clear();

        }

        private void Note_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNS_Load(object sender, EventArgs e)
        {
            AddingDate.Value = DateTime.Now;

        }

    }
}