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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        private void GenerateNames()
        {
            Random random = new Random();

            int generate = random.Next(0, 49);

            FirstNameT

            
        }
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
    }
}
