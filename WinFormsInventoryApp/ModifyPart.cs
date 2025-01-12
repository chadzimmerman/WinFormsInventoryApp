using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInventoryApp
{
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOutsourced.Checked)
            {
                labelDynamicField.Text = "Company Name";
            }
        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInHouse.Checked)
            {
                labelDynamicField.Text = "Machine ID";
            }
        }
    }
}
