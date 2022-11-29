namespace Proiect_PCLP_42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int label2 = int.Parse(textBox1.Text);
            label7.Text = Convert.ToString(label2, 2);
            label8.Text = label2.ToString();
            label9.Text = Convert.ToString(label2, 16);
            label10.Text = Convert.ToString(label2, 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}