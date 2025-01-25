using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsInventoryApp
{
    public partial class AddProduct : Form
    {
        private mainForm _mainForm;
        internal BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int _productId;

        public AddProduct(mainForm mainForm, int productId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _productId = productId;
            allCandidatePartsDataGrid.DataSource = _mainForm.Parts;
            AssociatedParts = new BindingList<Part>();
            associatePartsDataGrid.DataSource = AssociatedParts;
            textBox1.Text = _productId.ToString();

            allCandidatePartsDataGrid.Invalidate();
        }



        internal void AddProductToDataGrid(Product newProduct)
        {
            _mainForm.Products.Add(newProduct);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newProduct = new Product
            {
                ProductID = int.Parse(textBox1.Text),
                Name = textBox2.Text,
                Price = decimal.Parse(textBox3.Text),
                Inventory = int.Parse(textBox4.Text),
                Min = int.Parse(textBox6.Text),
                Max = int.Parse(textBox5.Text),
                AssociatedParts = new BindingList<Part>(AssociatedParts.ToList())
            };

            if (ValidatePart())
            {
                _mainForm.Products.Add(newProduct);
                this.DialogResult = DialogResult.OK;
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (associatePartsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = associatePartsDataGrid.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;
                AssociatedParts.Remove(selectedPart);
                associatePartsDataGrid.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (allCandidatePartsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = allCandidatePartsDataGrid.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;
                AssociatedParts.Add(selectedPart);
                associatePartsDataGrid.Refresh();
            }
        }

        private void allCandidatePartsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (allCandidatePartsDataGrid.SelectedRows.Count > 0 && allCandidatePartsDataGrid.SelectedRows[0].Index == e.RowIndex)
            {
                allCandidatePartsDataGrid.ClearSelection();
            }
        }

        private void dataGridAddProduct2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private bool ValidatePart()
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
    }
}