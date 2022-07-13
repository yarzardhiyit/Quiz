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
    public partial class UCQuiz3 : UserControl
    {
        public UCQuiz3()
        {
            InitializeComponent();
        }

        private void btnQ1Submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.true_in_square;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.false_in_square;
            }
        }
    }
}
