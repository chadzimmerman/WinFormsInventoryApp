namespace WinFormsInventoryApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            mainFormDataGridParts = new DataGridView();
            mainFormDataGridProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)mainFormDataGridParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainFormDataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Location = new Point(1455, 571);
            button1.Name = "button1";
            button1.Size = new Size(53, 32);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Silver;
            button2.Location = new Point(1455, 502);
            button2.Name = "button2";
            button2.Size = new Size(53, 32);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Silver;
            button3.Location = new Point(1396, 502);
            button3.Name = "button3";
            button3.Size = new Size(53, 32);
            button3.TabIndex = 2;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.Silver;
            button4.Location = new Point(1337, 502);
            button4.Name = "button4";
            button4.Size = new Size(53, 32);
            button4.TabIndex = 3;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.Silver;
            button6.Location = new Point(479, 83);
            button6.Name = "button6";
            button6.Size = new Size(54, 25);
            button6.TabIndex = 5;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 6;
            label1.Text = "Inventory Mangement System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 7;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(788, 97);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 8;
            label3.Text = "Products";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(549, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 33);
            textBox1.TabIndex = 9;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.Silver;
            button7.Location = new Point(591, 502);
            button7.Name = "button7";
            button7.Size = new Size(53, 32);
            button7.TabIndex = 15;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            button7.MouseClick += button7_MouseClick;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.Silver;
            button8.Location = new Point(650, 502);
            button8.Name = "button8";
            button8.Size = new Size(53, 32);
            button8.TabIndex = 14;
            button8.Text = "Modify";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.Silver;
            button9.Location = new Point(709, 502);
            button9.Name = "button9";
            button9.Size = new Size(53, 32);
            button9.TabIndex = 13;
            button9.Text = "Delete";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1294, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 33);
            textBox2.TabIndex = 19;
            textBox2.Tag = "";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.Silver;
            button5.Location = new Point(1224, 87);
            button5.Name = "button5";
            button5.Size = new Size(54, 25);
            button5.TabIndex = 18;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // mainFormDataGridParts
            // 
            mainFormDataGridParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainFormDataGridParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainFormDataGridParts.Location = new Point(40, 142);
            mainFormDataGridParts.Name = "mainFormDataGridParts";
            mainFormDataGridParts.RowHeadersVisible = false;
            mainFormDataGridParts.Size = new Size(723, 333);
            mainFormDataGridParts.TabIndex = 20;
            mainFormDataGridParts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mainFormDataGridProducts
            // 
            mainFormDataGridProducts.AllowUserToAddRows = false;
            mainFormDataGridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainFormDataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainFormDataGridProducts.Location = new Point(788, 142);
            mainFormDataGridProducts.Name = "mainFormDataGridProducts";
            mainFormDataGridProducts.RowHeadersVisible = false;
            mainFormDataGridProducts.Size = new Size(723, 333);
            mainFormDataGridProducts.TabIndex = 21;
            mainFormDataGridProducts.CellContentClick += mainFormDataGridProducts_CellContentClick;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1559, 635);
            Controls.Add(mainFormDataGridProducts);
            Controls.Add(mainFormDataGridParts);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "mainForm";
            Text = "Inventory App";
            ((System.ComponentModel.ISupportInitialize)mainFormDataGridParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormDataGridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox2;
        private Button button5;
        private DataGridView mainFormDataGridParts;
        private DataGridView mainFormDataGridProducts;
    }
}
