using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInput
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {

        }

        private void InputAgeChnage(object sender, EventArgs e)
        {

        }
        private void ClickSave(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void ClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
