namespace _20261120_CSE1322_Registration
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
            email_tb = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            text_label = new Label();
            register_bt = new Button();
            SuspendLayout();
            // 
            // email_tb
            // 
            email_tb.Location = new Point(211, 183);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(358, 27);
            email_tb.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 367);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(358, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 467);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(358, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(211, 567);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(358, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 151);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 246);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 344);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 444);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 544);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Last Name";
            // 
            // text_label
            // 
            text_label.AutoSize = true;
            text_label.Location = new Point(813, 205);
            text_label.Name = "text_label";
            text_label.Size = new Size(50, 20);
            text_label.TabIndex = 10;
            text_label.Text = "label6";
            // 
            // register_bt
            // 
            register_bt.Location = new Point(838, 645);
            register_bt.Name = "register_bt";
            register_bt.Size = new Size(94, 29);
            register_bt.TabIndex = 11;
            register_bt.Text = "Register";
            register_bt.UseVisualStyleBackColor = true;
            register_bt.Click += register_bt_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 809);
            Controls.Add(register_bt);
            Controls.Add(text_label);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(email_tb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_tb;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label text_label;
        private Button register_bt;
    }
}
