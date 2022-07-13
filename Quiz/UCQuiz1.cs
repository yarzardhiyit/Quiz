using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class UCQuiz1 : UserControl
    {
        public UCQuiz1()
        {
            InitializeComponent();
        }

        private void btnQ1Submit_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.true_in_square;
            }
            else if(radioButton2.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.false_in_square;
            }
            else if(radioButton3.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.false_in_square;
            }
        }
    }
}
