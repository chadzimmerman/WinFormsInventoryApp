using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsInventoryApp
{
    public partial class ModifyPart : Form
    {
        private DataGridView _dataGridView;
        private Part _partToModify;

        public ModifyPart(Part partToModify, DataGridView dataGridView)
        {
            InitializeComponent();
            _partToModify = partToModify;
            _dataGridView = dataGridView;

            textBox1.Text = _partToModify.PartID.ToString();
            textBox2.Text = _partToModify.Name;
            textBox8.Text = _partToModify.Inventory.ToString();
            textBox3.Text = _partToModify.Price.ToString();
            textBox5.Text = _partToModify.Min.ToString();
            textBox4.Text = _partToModify.Max.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidatePart())
            {
                _partToModify.Name = textBox2.Text;
                _partToModify.Inventory = int.Parse(textBox8.Text);
                _partToModify.Price = decimal.Parse(textBox3.Text);
                _partToModify.Min = int.Parse(textBox5.Text);
                _partToModify.Max = int.Parse(textBox4.Text);

                _dataGridView.Refresh();

                this.DialogResult = DialogResult.OK;
            } 
            else
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || textBox.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
