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

        int wins = 0;
        int losses = 0;
        int ties = 0;
      


        private void btnRock_Click(object sender, EventArgs e)
        {
            int cpuChoice = generator.Next(1,4);
            
            

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

            if (cpuChoice == 1)
            {
                ties += 1;
                picBlocker.Visible = false;
                picScissors.Visible = false;
                picRock.Visible = true;
                picPaper.Visible = false;
            }
            UpdateStats();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int cpuChoice = generator.Next(1, 4);
            

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

            if (cpuChoice == 2)
            {
                ties += 1;
                picBlocker.Visible = false;
                picScissors.Visible = false;
                picRock.Visible = false;
                picPaper.Visible = true;
            }
            UpdateStats();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int cpuChoice = generator.Next(1, 4);
            

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
            
            if (cpuChoice == 3)
            {
                ties += 1;
                picBlocker.Visible = false;
                picScissors.Visible = true;
                picRock.Visible = false;
                picPaper.Visible = false;
            }
            UpdateStats();
        }

        void UpdateStats()
        {
            lblStats.Text = ($"Wins:{wins} losses:{losses} ties:{ties}");
        }

        
    }

}
