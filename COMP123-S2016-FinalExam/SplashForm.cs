using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }

        // timer 
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // move to GenerateNameForm 
            Program.generateNameForm.Show();
            // let this form not to be seen
            this.Hide();
            // turn of the timer
            SplashFormTimer.Enabled = false;
        }
    }
}
