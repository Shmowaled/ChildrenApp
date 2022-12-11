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
    public partial class starting : Form
    {
        public starting()
        {
            InitializeComponent();
        }
        public string Name
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        private void starting_Load(object sender, EventArgs e)
        {
            label4.Text = String.Format("{0} {1} {2}", "Hi, ", Name, " !");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void pictureBox4_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Calculate the given equation, then enter the number keys from your own keyboard.",
                                                    "Instructions", MessageBoxButtons.OK)){
                // Transfering to the next form
                CalWindowcs frm3 = new CalWindowcs();
                frm3.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {}


    }
}
