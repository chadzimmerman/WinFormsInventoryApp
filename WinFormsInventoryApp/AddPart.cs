using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsInventoryApp
{
    public partial class AddPart : Form
    {
        private mainForm _mainForm;
        private int _partId;

        public AddPart(mainForm mainForm, int partId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _partId = partId;

            textBox1.Text = _partId.ToString();

            textBox8.KeyPress += TextBoxForNumericOnly_KeyPress;
            textBox3.KeyPress += TextBoxForNumericOnly_KeyPress;
            textBox4.KeyPress += TextBoxForNumericOnly_KeyPress;
            textBox5.KeyPress += TextBoxForNumericOnly_KeyPress;
            textBox3.KeyPress += TextBoxForNumericOnly_KeyPress;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOutsourced.Checked)
            {
                labelDynamicField.Text = "Company Name";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInHouse.Checked)
            {
                labelDynamicField.Text = "Machine ID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Part newPart;
            if (radioButtonInHouse.Checked)
            {
                newPart = new inhouseClass()
                {
                    PartID = int.Parse(textBox1.Text),
                    Name = textBox2.Text,
                    Price = decimal.Parse(textBox3.Text),
                    Inventory = int.Parse(textBox8.Text),
                    Min = int.Parse(textBox5.Text),
                    Max = int.Parse(textBox4.Text),
                    MachineID = int.Parse(radioDynamicTextbox.Text)

                };
            }
            else if (radioButtonOutsourced.Checked)
            {
                newPart = new outsourcedClass()
                {
                    PartID = int.Parse(textBox1.Text),
                    Name = textBox2.Text,
                    Price = decimal.Parse(textBox3.Text),
                    Inventory = int.Parse(textBox8.Text),
                    Min = int.Parse(textBox5.Text),
                    Max = int.Parse(textBox4.Text),
                    CompanyName = radioDynamicTextbox.Text

                };
            }
            else
            {
                MessageBox.Show("Please select whether the part is In-House or Outsourced.");
                return;
            }

            if (ValidatePart())
            {
                _mainForm.AddPartToDataGrid(newPart);
                this.Close();
            } 
            else
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxForNumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || textBox.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidatePart()
        {
            int min = int.Parse(textBox5.Text);
            int max = int.Parse(textBox4.Text);
            int inventory = int.Parse(textBox8.Text);

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return false;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be within the Min and Max values.");
                return false;
            }

            return true;
        }
    }
}