namespace OrderSystemApp_MongoDb
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
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(72, 18);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Order Id:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(161, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 31);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 228);
            dataGridView1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F);
            textBox2.Location = new Point(161, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 31);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(10, 55);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 4;
            label2.Text = "Customer Name:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F);
            textBox3.Location = new Point(161, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 31);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(84, 92);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "District:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.8F);
            textBox4.Location = new Point(161, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 31);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(109, 129);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 8;
            label4.Text = "City:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.8F);
            textBox5.Location = new Point(161, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(309, 31);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(60, 166);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 10;
            label5.Text = "Total Price:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F);
            button2.Location = new Point(476, 15);
            button2.Name = "button2";
            button2.Size = new Size(163, 31);
            button2.TabIndex = 12;
            button2.Text = "List";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F);
            button1.Location = new Point(476, 52);
            button1.Name = "button1";
            button1.Size = new Size(163, 31);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F);
            button3.Location = new Point(476, 89);
            button3.Name = "button3";
            button3.Size = new Size(163, 31);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F);
            button4.Location = new Point(476, 126);
            button4.Name = "button4";
            button4.Size = new Size(163, 31);
            button4.TabIndex = 15;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10.8F);
            button5.Location = new Point(476, 163);
            button5.Name = "button5";
            button5.Size = new Size(163, 31);
            button5.TabIndex = 16;
            button5.Text = "Get";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
