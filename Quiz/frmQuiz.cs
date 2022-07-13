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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
            Load += FrmQuiz_Load;
        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucHome1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucHome1.Visible = false;
            ucQuiz11.Visible = false;
            ucQuiz21.Visible = false;
            ucQuiz31.Visible = false;

            control.Visible = true; 
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by yarzardhiyit.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ucHome1.Visible == true)
            {
                SetActivePanel(ucQuiz11);
            }
            else if (ucQuiz11.Visible == true)
            {
                SetActivePanel(ucQuiz21);
            }
            else if (ucQuiz21.Visible == true)
            {
                SetActivePanel(ucQuiz31);
            }
            else if (ucQuiz31.Visible == true)
            {
                MessageBox.Show("Please come back later, We'll update very soon.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ucQuiz31.Visible == true)
            {
                SetActivePanel(ucQuiz21);
            }
            else if(ucQuiz21.Visible == true)
            {
                SetActivePanel(ucQuiz11);
            }
            else if(ucQuiz11.Visible == true)
            {
                SetActivePanel(ucHome1);
            }
        }
    }
}
