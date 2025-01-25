namespace WinFormsInventoryApp
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            associatedPartsModifyProductDataGrid = new DataGridView();
            allCandidatePartsDataGrid = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)associatedPartsModifyProductDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allCandidatePartsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // associatedPartsModifyProductDataGrid
            // 
            associatedPartsModifyProductDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsModifyProductDataGrid.Location = new Point(577, 377);
            associatedPartsModifyProductDataGrid.Name = "associatedPartsModifyProductDataGrid";
            associatedPartsModifyProductDataGrid.RowHeadersVisible = false;
            associatedPartsModifyProductDataGrid.Size = new Size(391, 169);
            associatedPartsModifyProductDataGrid.TabIndex = 49;
            // 
            // allCandidatePartsDataGrid
            // 
            allCandidatePartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allCandidatePartsDataGrid.Location = new Point(577, 114);
            allCandidatePartsDataGrid.Name = "allCandidatePartsDataGrid";
            allCandidatePartsDataGrid.RowHeadersVisible = false;
            allCandidatePartsDataGrid.Size = new Size(391, 169);
            allCandidatePartsDataGrid.TabIndex = 48;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Location = new Point(816, 613);
            button5.Name = "button5";
            button5.Size = new Size(54, 37);
            button5.TabIndex = 47;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(891, 613);
            button4.Name = "button4";
            button4.Size = new Size(54, 37);
            button4.TabIndex = 46;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(891, 552);
            button3.Name = "button3";
            button3.Size = new Size(54, 37);
            button3.TabIndex = 45;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(891, 289);
            button2.Name = "button2";
            button2.Size = new Size(54, 37);
            button2.TabIndex = 44;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(577, 352);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 43;
            label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 92);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 42;
            label8.Text = "All Candidate Parts";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(749, 43);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(216, 23);
            textBox7.TabIndex = 41;
            // 
            // button1
            // 
            button1.Location = new Point(679, 43);
            button1.Name = "button1";
            button1.Size = new Size(55, 23);
            button1.TabIndex = 40;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Salmon;
            textBox6.Location = new Point(329, 424);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(80, 23);
            textBox6.TabIndex = 39;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox6.KeyPress += NumericTextBox_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 427);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 38;
            label7.Text = "Mn";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Salmon;
            textBox5.Location = new Point(163, 421);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(85, 23);
            textBox5.TabIndex = 37;
            textBox5.KeyPress += NumericTextBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 424);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 36;
            label6.Text = "Max";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Salmon;
            textBox3.Location = new Point(163, 370);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 35;
            textBox3.KeyPress += NumericTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 373);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 34;
            label4.Text = "Price";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Salmon;
            textBox4.Location = new Point(163, 325);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 23);
            textBox4.TabIndex = 33;
            textBox4.KeyPress += NumericTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 328);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 32;
            label5.Text = "Inventory";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Salmon;
            textBox2.Location = new Point(163, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 31;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 289);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 30;
            label3.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 241);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 29;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 245);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 28;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(55, 25);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 27;
            label1.Text = "Modify Product";
            label1.Click += label1_Click;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1023, 675);
            Controls.Add(associatedPartsModifyProductDataGrid);
            Controls.Add(allCandidatePartsDataGrid);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)associatedPartsModifyProductDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)allCandidatePartsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView associatedPartsModifyProductDataGrid;
        private DataGridView allCandidatePartsDataGrid;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label9;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}