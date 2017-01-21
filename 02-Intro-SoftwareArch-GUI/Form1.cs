using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_SoftwareArch_GUI
{
    public partial class uxForm : Form
    {
        int m;
        int n;
        int p;
        public uxForm()
        {
            InitializeComponent();
            uxLabelOne.Text = "Guess an int, M, in range 0..10:  M = ";
        }

        private void uxButtonOne_Click(object sender, EventArgs e)
        {

            uxLabelOne.Text = "Guess an int, M, in range 0..10:  M = ";
            m = Int32.Parse(uxTextOne.Text);

            if(m < 0 || m > 10)
            {

                MessageBox.Show("Only numbers between 1 and 10");
                m = Int32.Parse(uxTextOne.Text);

            }

            Random r = new Random();
            int min = 0;
            int max = 9;
            n = r.Next(min, max + 1);

            uxLabelTwo.Text = "I guess int, N, in range 0..10-M: N = ";

            uxTextTwo.Text = n.ToString();

            uxLabelThree.Text = "Now you type an int, P, such that M + N + P = 10:  P = ";

        }

        private void uxButtonThree_Click(object sender, EventArgs e)
        {
            
            p = Int32.Parse(uxTextThree.Text);

            if ((m + n + p) == 10)
            {
                uxResult.Text = "You win!";
            }
            else
            {
               uxResult.Text = "You lose!";
            }

           


        }

       
    }
}
