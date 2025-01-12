namespace WinFormsInventoryApp
{
    partial class AddPart
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelDynamicField = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButtonInHouse = new RadioButton();
            radioButtonOutsourced = new RadioButton();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            radioDynamicTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(193, 84);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(168, 137);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(147, 190);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(133, 241);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Price / Cost";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(180, 293);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "Max";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(388, 293);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 6;
            label7.Text = "Min";
            label7.Click += label7_Click;
            // 
            // labelDynamicField
            // 
            labelDynamicField.AutoSize = true;
            labelDynamicField.Font = new Font("Segoe UI", 11F);
            labelDynamicField.Location = new Point(102, 343);
            labelDynamicField.Name = "labelDynamicField";
            labelDynamicField.Size = new Size(84, 20);
            labelDynamicField.TabIndex = 7;
            labelDynamicField.Text = "Machine ID";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(457, 499);
            button1.Name = "button1";
            button1.Size = new Size(69, 44);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(549, 499);
            button2.Name = "button2";
            button2.Size = new Size(69, 44);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 32);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Salmon;
            textBox2.Location = new Point(242, 138);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 33);
            textBox2.TabIndex = 11;
            // 
            // radioButtonInHouse
            // 
            radioButtonInHouse.AutoSize = true;
            radioButtonInHouse.Checked = true;
            radioButtonInHouse.Font = new Font("Segoe UI", 11F);
            radioButtonInHouse.Location = new Point(185, 16);
            radioButtonInHouse.Name = "radioButtonInHouse";
            radioButtonInHouse.Size = new Size(87, 24);
            radioButtonInHouse.TabIndex = 17;
            radioButtonInHouse.TabStop = true;
            radioButtonInHouse.Text = "In-House";
            radioButtonInHouse.UseVisualStyleBackColor = true;
            radioButtonInHouse.CheckedChanged += radioButtonInHouse_CheckedChanged;
            // 
            // radioButtonOutsourced
            // 
            radioButtonOutsourced.AutoSize = true;
            radioButtonOutsourced.Font = new Font("Segoe UI", 11F);
            radioButtonOutsourced.Location = new Point(348, 16);
            radioButtonOutsourced.Name = "radioButtonOutsourced";
            radioButtonOutsourced.Size = new Size(103, 24);
            radioButtonOutsourced.TabIndex = 18;
            radioButtonOutsourced.TabStop = true;
            radioButtonOutsourced.Text = "Outsourced";
            radioButtonOutsourced.UseVisualStyleBackColor = true;
            radioButtonOutsourced.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Salmon;
            textBox8.Location = new Point(242, 191);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(180, 33);
            textBox8.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Salmon;
            textBox3.Location = new Point(242, 241);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 33);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Salmon;
            textBox4.Location = new Point(242, 293);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 33);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Salmon;
            textBox5.Location = new Point(444, 294);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 33);
            textBox5.TabIndex = 22;
            // 
            // radioDynamicTextbox
            // 
            radioDynamicTextbox.BackColor = Color.Salmon;
            radioDynamicTextbox.Location = new Point(242, 343);
            radioDynamicTextbox.Multiline = true;
            radioDynamicTextbox.Name = "radioDynamicTextbox";
            radioDynamicTextbox.Size = new Size(180, 33);
            radioDynamicTextbox.TabIndex = 23;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(640, 570);
            Controls.Add(radioDynamicTextbox);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox8);
            Controls.Add(radioButtonOutsourced);
            Controls.Add(radioButtonInHouse);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelDynamicField);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPart";
            Text = "AddPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelDynamicField;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButtonInHouse;
        private RadioButton radioButtonOutsourced;
        private TextBox textBox8;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox radioDynamicTextbox;
    }
}