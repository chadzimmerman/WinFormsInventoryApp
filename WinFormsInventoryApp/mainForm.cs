using System.ComponentModel;
using System.Drawing.Text;
using System.IO;
using System.Linq;

namespace WinFormsInventoryApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Parts = new BindingList<Part>();
            Products = new BindingList<Product>();
            mainFormDataGridParts.DataSource = Parts;
            mainFormDataGridProducts.DataSource = Products;

            mainFormDataGridParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainFormDataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        internal BindingList<Part> Parts { get; set; }
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        private DataGridView associatePartsDataGrid;

        private int _productCounter = 1;
        private int _partCounter = 1000;

        internal void AddPartToDataGrid(Part newPart)
        {
            Parts.Add(newPart);
            mainFormDataGridParts.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainFormDataGridProducts.SelectedRows.Count > 0)
            {
                var selectedRows = mainFormDataGridProducts.SelectedRows[0];
                Product selectedProduct = (Product)selectedRows.DataBoundItem;
                var modifyProductForm = new ModifyProduct(this, selectedProduct, mainFormDataGridParts, Products, associatePartsDataGrid);
                if (modifyProductForm.ShowDialog() == DialogResult.OK)
                {
                    mainFormDataGridProducts.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var addPartForm = new AddPart(this, _partCounter++);
            addPartForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mainFormDataGridParts.SelectedRows.Count > 0)
            {
                var selectedRows = mainFormDataGridParts.SelectedRows[0];
                Part selectedPart = (Part)selectedRows.DataBoundItem;
                var modifyPartForm = new ModifyPart(selectedPart, mainFormDataGridParts);
                if (modifyPartForm.ShowDialog() == DialogResult.OK)
                {
                    mainFormDataGridParts.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mainFormDataGridParts.SelectedRows.Count > 0)
            {
                var selectedRow = mainFormDataGridParts.SelectedRows[0];
                Part itemToBeRemoved = (Part)selectedRow.DataBoundItem;

                if (Products.Any(p => p.AssociatedParts.Contains(itemToBeRemoved)))
                {
                    MessageBox.Show("You cannot delete parts that are associated with a product.");
                } 
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) 
                    {
                        Parts.Remove(itemToBeRemoved);
                        mainFormDataGridParts.Refresh();
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct(this, _productCounter++);
            addProductForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                mainFormDataGridParts.DataSource = Parts;
                mainFormDataGridParts.Refresh();
                return;
            }

            var filteredParts = Parts
                .Where(part => part.Name.ToLower().Contains(searchTerm) || part.PartID.ToString() == searchTerm)
                .ToList();

            mainFormDataGridParts.DataSource = new BindingList<Part>(filteredParts);
            mainFormDataGridParts.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower();
            var filteredParts = Parts.Where(propa => propa.Name.ToLower().Contains(searchTerm)).ToList();
            mainFormDataGridParts.DataSource = new BindingList<Part>(filteredParts);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                mainFormDataGridProducts.DataSource = Products;
                mainFormDataGridProducts.Refresh();
                return;
            }

            var filteredProducts = Products
                .Where(product => product.Name.ToLower().Contains(searchTerm) || product.ProductID.ToString() == searchTerm)
                .ToList();

            mainFormDataGridProducts.DataSource = new BindingList<Product>(filteredProducts);
            mainFormDataGridProducts.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainFormDataGridProducts.SelectedRows.Count > 0)
            {
                var selectedRow = mainFormDataGridProducts.SelectedRows[0];
                Product itemToBeRemoved = (Product)selectedRow.DataBoundItem;
                Products.Remove(itemToBeRemoved);
                mainFormDataGridProducts.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox2.Text.ToLower();
            var filteredProducts = Products.Where(propa => propa.Name.ToLower().Contains(searchTerm)).ToList();
            mainFormDataGridProducts.DataSource = new BindingList<Product>(filteredProducts);
        }

        private void mainFormDataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}