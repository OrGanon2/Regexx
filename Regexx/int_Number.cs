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
    public partial class int_Number : UserControl
    {
        public int_Number()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            bool result = regex.IsMatch(Number.Text);
            NameResult.Text = result.ToString();
        }
    }
}
