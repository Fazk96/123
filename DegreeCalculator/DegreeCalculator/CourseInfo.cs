using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreeCalculator
{
    public partial class StartScreen : Form
    {

        ChooseLevel chooseLevelView;


        public StartScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameText.Text == string.Empty)
            {
                MessageBox.Show("Please enter your course name");
                return;
            }
            chooseLevelView = new ChooseLevel();
            chooseLevelView.Activate();
            chooseLevelView.Show();
            this.Hide();
        }
    }
}
