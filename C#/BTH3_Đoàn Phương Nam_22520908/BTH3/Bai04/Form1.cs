using System.Numerics;
using System.Linq;
namespace Bai04
{
    public partial class Form1 : Form
    {
        float data = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(data);
            textBox1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.BackColor == Color.White)
            {
                button1.BackColor = Color.Blue;
                data += 5000;
            }
            else if (button1.BackColor == Color.Blue)
            {
                button1.BackColor = Color.White;
                data -= 5000;
            }
            textBox1.Text = Convert.ToString(data);
            
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}