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

    public partial class ChooseLevel : Form
    {
        Level4View level4View;
        Level5View level5View;
        Level6View level6View;
        StartScreen courseInfo;



        public ChooseLevel()
        {
            InitializeComponent();
        }

        private void ChooseLevel_Load(object sender, EventArgs e)
        {

        }

        private void level4Button_Click(object sender, EventArgs e)
        {
            level4View = new Level4View();
            level4View.Activate();
            level4View.Show();
            Close();
        }

        private void lvl5Button_Click(object sender, EventArgs e)
        {
            level5View = new Level5View();
            level5View.Activate();
            level5View.Show();
            Close();
        }

        private void lvl6Button_Click(object sender, EventArgs e)
        {
            level6View = new Level6View();
            level6View.Activate();
            level6View.Show();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            courseInfo = new StartScreen();
            courseInfo.Activate();
            courseInfo.Show();
            Close();
        }
    }
}
