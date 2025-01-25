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
    public partial class ModifyProduct : Form
    {
        private mainForm _mainForm;
        private BindingList<Product> _products;
        internal BindingList<Part> AssociatedParts = new BindingList<Part>();
        private Product _productToModify;
        private DataGridView _dataGridView;
        private DataGridView associatePartsDataGrid;
        public ModifyProduct(mainForm mainForm, Product productToModify, DataGridView dataGridView, BindingList<Product> products, DataGridView associatePartsDataGrid)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _productToModify = productToModify;
            _products = products;
            _dataGridView = dataGridView;
            this.associatePartsDataGrid = associatePartsDataGrid;
            AssociatedParts = new BindingList<Part>(_productToModify.AssociatedParts.ToList());
            associatedPartsModifyProductDataGrid.DataSource = AssociatedParts;
            allCandidatePartsDataGrid.DataSource = _mainForm.Parts;

            allCandidatePartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsModifyProductDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            textBox1.Text = _productToModify.ProductID.ToString();
            textBox2.Text = _productToModify.Name;
            textBox4.Text = _productToModify.Inventory.ToString();
            textBox3.Text = _productToModify.Price.ToString();
            textBox6.Text = _productToModify.Min.ToString();
            textBox5.Text = _productToModify.Max.ToString();

            allCandidatePartsDataGrid.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (allCandidatePartsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = allCandidatePartsDataGrid.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;
                AssociatedParts.Add(selectedPart);

                _productToModify.AssociatedParts.Add(selectedPart);
                associatedPartsModifyProductDataGrid.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (associatedPartsModifyProductDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = associatedPartsModifyProductDataGrid.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;
                DeletePart();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ValidateProduct()) 
            {
                _productToModify.Name = textBox2.Text;
                _productToModify.Inventory = int.Parse(textBox4.Text);
                _productToModify.Price = decimal.Parse(textBox3.Text);
                _productToModify.Min = int.Parse(textBox5.Text);
                _productToModify.Max = int.Parse(textBox4.Text);

                _productToModify.AssociatedParts = new BindingList<Part>(AssociatedParts.ToList());
                _products.ResetBindings();

                this.DialogResult = DialogResult.OK;
            } 
            else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateProduct()
        {
            int min = int.Parse(textBox6.Text);
            int max = int.Parse(textBox5.Text);
            int inventory = int.Parse(textBox4.Text);

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

        private void DeletePart()
        {
            if (associatedPartsModifyProductDataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Part selectedPart = (Part)associatedPartsModifyProductDataGrid.SelectedRows[0].DataBoundItem;
                    AssociatedParts.Remove(selectedPart);
                    associatedPartsModifyProductDataGrid.Refresh();
                } 
                else
                {

                }
            }
        }
    }
}
