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
            dataGridView1 = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Inventory = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.Silver;
            button7.Location = new Point(625, 502);
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
            button8.Location = new Point(684, 502);
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
            button9.Location = new Point(743, 502);
            button9.Name = "button9";
            button9.Size = new Size(53, 32);
            button9.TabIndex = 13;
            button9.Text = "Delete";
            button9.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1294, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 33);
            textBox2.TabIndex = 19;
            textBox2.Tag = "";
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, Name, Inventory, Price, Min, Max });
            dataGridView1.Location = new Point(40, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(723, 333);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PartID
            // 
            PartID.HeaderText = "PartID";
            PartID.Name = "PartID";
            PartID.Width = 110;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.Width = 110;
            // 
            // Inventory
            // 
            Inventory.HeaderText = "Inventory";
            Inventory.Name = "Inventory";
            Inventory.Width = 110;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.Width = 110;
            // 
            // Min
            // 
            Min.HeaderText = "Min";
            Min.Name = "Min";
            Min.Width = 110;
            // 
            // Max
            // 
            Max.HeaderText = "Max";
            Max.Name = "Max";
            Max.Width = 110;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(788, 142);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(723, 333);
            dataGridView2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "PartID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Min";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Max";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 110;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1559, 635);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
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
            this.Name.Name = "mainForm";
            Text = "Inventory App";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Inventory;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
