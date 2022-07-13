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
    public partial class UCQuiz2 : UserControl
    {
        public UCQuiz2()
        {
            InitializeComponent();
        }

        private void btnQ1Submit_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.true_in_square;
            }
            else if (radioButton1.Checked || radioButton3.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.false_in_square;
            }
        }
    }
}
