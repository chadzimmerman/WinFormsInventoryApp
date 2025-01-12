namespace WinFormsInventoryApp
{
    partial class ModifyPart
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
            radioButtonInHouse = new RadioButton();
            radioButtonOutsourced = new RadioButton();
            modifyPartLabel = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            radioDynamicTextbox = new TextBox();
            labelDynamicField = new Label();
            SuspendLayout();
            // 
            // radioButtonInHouse
            // 
            radioButtonInHouse.AutoSize = true;
            radioButtonInHouse.Checked = true;
            radioButtonInHouse.Font = new Font("Segoe UI", 11F);
            radioButtonInHouse.Location = new Point(194, 14);
            radioButtonInHouse.Name = "radioButtonInHouse";
            radioButtonInHouse.Size = new Size(87, 24);
            radioButtonInHouse.TabIndex = 0;
            radioButtonInHouse.TabStop = true;
            radioButtonInHouse.Text = "In-House";
            radioButtonInHouse.UseVisualStyleBackColor = true;
            radioButtonInHouse.CheckedChanged += radioButtonInHouse_CheckedChanged;
            // 
            // radioButtonOutsourced
            // 
            radioButtonOutsourced.AutoSize = true;
            radioButtonOutsourced.Font = new Font("Segoe UI", 11F);
            radioButtonOutsourced.Location = new Point(336, 14);
            radioButtonOutsourced.Name = "radioButtonOutsourced";
            radioButtonOutsourced.Size = new Size(103, 24);
            radioButtonOutsourced.TabIndex = 1;
            radioButtonOutsourced.TabStop = true;
            radioButtonOutsourced.Text = "Outsourced";
            radioButtonOutsourced.UseVisualStyleBackColor = true;
            radioButtonOutsourced.CheckedChanged += radioButtonOutsourced_CheckedChanged;
            // 
            // modifyPartLabel
            // 
            modifyPartLabel.AutoSize = true;
            modifyPartLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyPartLabel.Location = new Point(3, 9);
            modifyPartLabel.Name = "modifyPartLabel";
            modifyPartLabel.Size = new Size(118, 28);
            modifyPartLabel.TabIndex = 2;
            modifyPartLabel.Text = "Modify Part";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Salmon;
            textBox5.Location = new Point(445, 295);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 33);
            textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Salmon;
            textBox4.Location = new Point(243, 294);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 33);
            textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Salmon;
            textBox3.Location = new Point(243, 242);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 33);
            textBox3.TabIndex = 32;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Salmon;
            textBox8.Location = new Point(243, 192);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(180, 33);
            textBox8.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Salmon;
            textBox2.Location = new Point(243, 139);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 33);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 86);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 32);
            textBox1.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(389, 294);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 28;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(181, 294);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 27;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(134, 242);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 26;
            label5.Text = "Price / Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(148, 191);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 25;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(169, 138);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 24;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(194, 85);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 23;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // radioDynamicTextbox
            // 
            radioDynamicTextbox.BackColor = Color.Salmon;
            radioDynamicTextbox.Location = new Point(243, 346);
            radioDynamicTextbox.Multiline = true;
            radioDynamicTextbox.Name = "radioDynamicTextbox";
            radioDynamicTextbox.Size = new Size(180, 33);
            radioDynamicTextbox.TabIndex = 36;
            // 
            // labelDynamicField
            // 
            labelDynamicField.AutoSize = true;
            labelDynamicField.Font = new Font("Segoe UI", 11F);
            labelDynamicField.Location = new Point(103, 346);
            labelDynamicField.Name = "labelDynamicField";
            labelDynamicField.Size = new Size(84, 20);
            labelDynamicField.TabIndex = 35;
            labelDynamicField.Text = "Machine ID";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(643, 564);
            Controls.Add(radioDynamicTextbox);
            Controls.Add(labelDynamicField);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modifyPartLabel);
            Controls.Add(radioButtonOutsourced);
            Controls.Add(radioButtonInHouse);
            Name = "ModifyPart";
            Text = "ModifyPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonInHouse;
        private RadioButton radioButtonOutsourced;
        private Label modifyPartLabel;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox radioDynamicTextbox;
        private Label labelDynamicField;
    }
}