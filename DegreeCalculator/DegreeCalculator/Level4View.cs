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
    public partial class Level4View : Form
    {
        ChooseLevel chooseLevelView;

        public Level4View()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            chooseLevelView = new ChooseLevel();
            chooseLevelView.Activate();
            chooseLevelView.Show();
            Close();
        }

        private void Level4View_Load(object sender, EventArgs e)
        {

        }
    }
}
