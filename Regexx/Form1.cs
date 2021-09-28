using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regexx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            BackButton.Visible = false;
        }

        private void CheckCLick_Click(object sender, EventArgs e)
        {

        }

        private void NextPage_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BackButton.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(new ABC());
            
        }

        private void num2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BackButton.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(new FirstName_LastName());
            


        }

        private void num3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BackButton.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(new int_Number());
            

        }

        private void num4_Click(object sender, EventArgs e)
        {
            BackButton.Visible = true;
            panel1.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Float_Number());
         

        }

        private void num5_Click(object sender, EventArgs e)
        {
            BackButton.Visible = true;
            panel1.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Email());
           

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BackButton.Visible = false;
        }
    }
}
