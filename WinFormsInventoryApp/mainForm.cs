namespace WinFormsInventoryApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
            var addPartForm = new AddPart();
            addPartForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var modifyPartForm = new ModifyPart();
            modifyPartForm.ShowDialog();
        }
    }
}
// each button needs to do it's assigned function, namely addParts(), modifyParts(), deleteParts(), addProducts(), modifyProducts(), deleteProducts(), search() and exitProgram(). 
// the functions will open to the Add Part, Add Product, Modify Part, Modifiy Product app screens. 
// create a search function to search for parts in the List Table. 
// link the Table List somehow to items that will showup in the table. Not sure if this will require a .NET database or not. 