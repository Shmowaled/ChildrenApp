using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChildrenApp{
    public partial class Form1 : Form
    {
        starting f2 = new starting();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            //Passing Data to between multiple forms..
            f2.Name = textBox1.Text;
            f2.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
