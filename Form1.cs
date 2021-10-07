using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_project
{
    public partial class rockPaperScissors : Form
    {
        Random generator = new Random();
        public rockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int cpuChoice = generator.Next(1,4);
            int wins = 0;
            int losses = 0;

            if (cpuChoice == 3)
            {
                wins += 1;
                picBlocker.Visible = false;
                picPaper.Visible = false;
                picRock.Visible = false;
                picScissors.Visible = true;
                
            }
            
            if (cpuChoice == 2)
            {
                losses += 1;
                picBlocker.Visible = false;
                picScissors.Visible = false;
                picRock.Visible = false;
                picPaper.Visible = true;
                
            }
            
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int cpuChoice = generator.Next(1, 4);
            int wins = 0;
            int losses = 0;

            if (cpuChoice == 1)
            {
                wins += 1;
                picBlocker.Visible = false;
                picPaper.Visible = false;
                picScissors.Visible = false;
                picRock.Visible = true;
                
            }
            
            if (cpuChoice == 3)
            {
                losses += 1;
                picBlocker.Visible = false;
                picRock.Visible = false;
                picPaper.Visible = false;
                picScissors.Visible = true;
                
            }
            
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int cpuChoice = generator.Next(1, 4);
            int wins = 0;
            int losses = 0;

            if (cpuChoice == 2)
            {
                wins += 1;
                picBlocker.Visible = false;
                picScissors.Visible = false;
                picRock.Visible = false;
                picPaper.Visible = true;
                
            }
            
            if (cpuChoice == 1)
            {
                losses += 1;
                picBlocker.Visible = false;
                picScissors.Visible = false;
                picPaper.Visible = false;
                picRock.Visible = true;
                
            }
            
        }
    }

}
