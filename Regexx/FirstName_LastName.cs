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
    public partial class FirstName_LastName : UserControl
    {
        public FirstName_LastName()
        {
            InitializeComponent();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\D{2,18} \D{2,18}");
            bool result = regex.IsMatch(FullName.Text);
            NameResult.Text = result.ToString();

        }
    }
}
