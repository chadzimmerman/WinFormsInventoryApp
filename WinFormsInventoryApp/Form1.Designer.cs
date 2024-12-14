namespace WinFormsInventoryApp
{
    partial class Form1
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
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ProdutTableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Location = new Point(1455, 671);
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
            button2.Location = new Point(1455, 600);
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
            button3.Location = new Point(1396, 600);
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
            button4.Location = new Point(1337, 600);
            button4.Name = "button4";
            button4.Size = new Size(53, 32);
            button4.TabIndex = 3;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.Silver;
            button5.Location = new Point(1215, 95);
            button5.Name = "button5";
            button5.Size = new Size(53, 25);
            button5.TabIndex = 4;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.Silver;
            button6.Location = new Point(427, 89);
            button6.Name = "button6";
            button6.Size = new Size(53, 25);
            button6.TabIndex = 5;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(273, 28);
            label1.TabIndex = 6;
            label1.Text = "Inventory Mangement System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(21, 97);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 7;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(852, 103);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 8;
            label3.Text = "Products";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1274, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 23);
            textBox2.TabIndex = 10;
            // 
            // ProdutTableLayoutPanel1
            // 
            ProdutTableLayoutPanel1.BackColor = Color.White;
            ProdutTableLayoutPanel1.ColumnCount = 6;
            ProdutTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.1176453F));
            ProdutTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8823547F));
            ProdutTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            ProdutTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            ProdutTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            ProdutTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            ProdutTableLayoutPanel1.Enabled = false;
            ProdutTableLayoutPanel1.Location = new Point(852, 135);
            ProdutTableLayoutPanel1.Name = "ProdutTableLayoutPanel1";
            ProdutTableLayoutPanel1.RowCount = 4;
            ProdutTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            ProdutTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            ProdutTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            ProdutTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 271F));
            ProdutTableLayoutPanel1.Size = new Size(656, 435);
            ProdutTableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.1176453F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8823547F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.Enabled = false;
            tableLayoutPanel1.Location = new Point(21, 135);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 271F));
            tableLayoutPanel1.Size = new Size(795, 435);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.Silver;
            button7.Location = new Point(645, 600);
            button7.Name = "button7";
            button7.Size = new Size(53, 32);
            button7.TabIndex = 15;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.Silver;
            button8.Location = new Point(704, 600);
            button8.Name = "button8";
            button8.Size = new Size(53, 32);
            button8.TabIndex = 14;
            button8.Text = "Modify";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.Silver;
            button9.Location = new Point(763, 600);
            button9.Name = "button9";
            button9.Size = new Size(53, 32);
            button9.TabIndex = 13;
            button9.Text = "Delete";
            button9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1559, 738);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ProdutTableLayoutPanel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Main Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TableLayoutPanel ProdutTableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
