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
    public partial class ABC : UserControl
    {
        public ABC()
        {
            InitializeComponent();
        }

        private void Check_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckCLick_Click(object sender, EventArgs e)
        {
            Regex Reg = new Regex(Check.Text);
            bool Result = Reg.IsMatch(txt_text.Text);
            ABResult.Text = Result.ToString();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
