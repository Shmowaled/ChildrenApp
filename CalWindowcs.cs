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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ChildrenApp
{
    public partial class CalWindowcs : Form
    {
        double answer= 0;
        static Random random = new Random();   //Generate Random numbers
        double value1 = random.Next(1, 11);       // creates a number between 1 and 10
        double value2 = random.Next(1, 51);            // creates a number between 1 and 50
        double value3 = random.Next(1, 11);       // creates a number between 1 and 10
        double value4 = random.Next(1, 51);            // creates a number between 1 and 50
        public CalWindowcs()
        {
            InitializeComponent();}
        //================Default appearance..
        private void CalWindowcs_Load(object sender, EventArgs e)
        {
            Convert.ToInt32(value1);
            Convert.ToInt32(value2);
            lblresult1.Text = $"{value4} + {value2}  =";
            lblresult2.Text = $"{value2} - {value4}  =";
            lblresult3.Text = $"{value1} * {value3}  =";
            lblresult4.Text = $"{value3} / {value1}  =";
        }
//========================This method receive all buttons(work with any number and any operation)
        private void button_Click(object sender, EventArgs e)
        {
            // CheckForWinner();
        }
//=================================== Useless ================================
        private void btn1_Click(object sender, EventArgs e)
        {}
        private void btn2_Click(object sender, EventArgs e)
        {}
        private void btn3_Click(object sender, EventArgs e)
        {}
        private void btn4_Click(object sender, EventArgs e)
        { }
        private void btn5_Click(object sender, EventArgs e)
        {}
        private void btn6_Click(object sender, EventArgs e)
        {}
        private void btn7_Click(object sender, EventArgs e)
        {}
        private void btn8_Click(object sender, EventArgs e)
        {}
        private void btn9_Click(object sender, EventArgs e)
        {}
        private void button8_Click(object sender, EventArgs e)
        {}
        private void pictureBox1_Click(object sender, EventArgs e)
        {}
        private void btn1_Click_1(object sender, EventArgs e)
        {}
        private void label4_Click(object sender, EventArgs e)
        {}
        private void lblresult_Click(object sender, EventArgs e)
        {}
//================================= SUBMIT BUTTON ============================================
        private void button1_Click(object sender, EventArgs e)
        {
            answer = value1 + value2;
            double answer2 = value2 - value4;
            double answer3 = value1 * value3;
            double answer4 = value3 / value1;
            if (answer == Double.Parse(userChoice1.Text))
            {
                if (DialogResult.OK == MessageBox.Show("Good job kido, see you again", "Good job", MessageBoxButtons.OK))
                {
                    Application.Exit();
                }
            }

            else if (answer2 == Double.Parse(userChoice2.Text))
            {
                if (DialogResult.OK == MessageBox.Show("Good job kido, see you again", "Good job", MessageBoxButtons.OK))
                {
                    Application.Exit();
                }
            }
            else if (answer3 == Double.Parse(userChoice3.Text))
            {
                if (DialogResult.OK == MessageBox.Show("Good job kido, see you again", "Good job", MessageBoxButtons.OK))
                {
                    Application.Exit();
                }
            }
            else if (answer4 == Double.Parse(userChoice3.Text))
            {
                if (DialogResult.OK == MessageBox.Show("Good job kido, see you again", "Good job", MessageBoxButtons.OK))
                {
                    Application.Exit();
                }
            }
            else { 
                if (DialogResult.OK == MessageBox.Show("Wrong answer, try again. ", "Sorry", MessageBoxButtons.OKCancel))
                {
                    userChoice1.Clear();
                }
            }}
//================================= CLEAR BUTTON ============================================
        private void button2_Click(object sender, EventArgs e)
        {
            userChoice1.Text = "";
            userChoice2.Text = "";
            userChoice3.Text = "";
            userChoice4.Text = "";
        }
    }
}