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
    public partial class Level6View : Form
    {
        ChooseLevel chooseLevelView;

        public Level6View()
        {
            InitializeComponent();
        }

        private void backButon_Click(object sender, EventArgs e)
        {
            chooseLevelView = new ChooseLevel();
            chooseLevelView.Activate();
            chooseLevelView.Show();
            Close();
        }
    }
}
