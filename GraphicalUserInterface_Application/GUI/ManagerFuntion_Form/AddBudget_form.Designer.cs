﻿namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    partial class AddBudget_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBudget_form));
            button1 = new Button();
            button12 = new Button();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(683, 305);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 64;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.FlatAppearance.BorderColor = Color.Red;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.Red;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(22, 30);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 13;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(609, 353);
            label8.Name = "label8";
            label8.Size = new Size(182, 19);
            label8.TabIndex = 65;
            label8.Text = "Budget Added Sucessfully";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(434, 46);
            label7.Name = "label7";
            label7.Size = new Size(198, 51);
            label7.TabIndex = 63;
            label7.Text = "Add Budget";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(159, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 43);
            panel2.TabIndex = 49;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(612, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 59;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(612, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(423, 276);
            label3.Name = "label3";
            label3.Size = new Size(147, 24);
            label3.TabIndex = 53;
            label3.Text = "Enter The date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(415, 216);
            label2.Name = "label2";
            label2.Size = new Size(155, 24);
            label2.TabIndex = 52;
            label2.Text = "Enter The Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(299, 152);
            label1.Name = "label1";
            label1.Size = new Size(271, 24);
            label1.TabIndex = 51;
            label1.Text = "Enter The Name Of The Item:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 552);
            panel1.TabIndex = 50;
            // 
            // AddBudget_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 553);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBudget_form";
            Text = "AddBudget_form";
            Load += AddBudget_form_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button12;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}