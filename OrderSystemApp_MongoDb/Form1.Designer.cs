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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtOrderId = new TextBox();
            dataGridView1 = new DataGridView();
            txtCustomerName = new TextBox();
            label2 = new Label();
            txtDistrict = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtTotalPrice = new TextBox();
            label5 = new Label();
            btnList = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnGetById = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // txtOrderId
            // 
            txtOrderId.Font = new Font("Segoe UI", 10.8F);
            txtOrderId.Location = new Point(161, 15);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(309, 31);
            txtOrderId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 228);
            dataGridView1.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10.8F);
            txtCustomerName.Location = new Point(161, 52);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(309, 31);
            txtCustomerName.TabIndex = 5;
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
            // txtDistrict
            // 
            txtDistrict.Font = new Font("Segoe UI", 10.8F);
            txtDistrict.Location = new Point(161, 89);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(309, 31);
            txtDistrict.TabIndex = 7;
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
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10.8F);
            txtCity.Location = new Point(161, 126);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(309, 31);
            txtCity.TabIndex = 9;
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
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Segoe UI", 10.8F);
            txtTotalPrice.Location = new Point(161, 163);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(309, 31);
            txtTotalPrice.TabIndex = 11;
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
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 10.8F);
            btnList.Location = new Point(476, 15);
            btnList.Name = "btnList";
            btnList.Size = new Size(163, 31);
            btnList.TabIndex = 12;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F);
            btnAdd.Location = new Point(476, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 31);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F);
            btnDelete.Location = new Point(476, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F);
            btnUpdate.Location = new Point(476, 126);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 31);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGetById
            // 
            btnGetById.Font = new Font("Segoe UI", 10.8F);
            btnGetById.Location = new Point(476, 163);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(163, 31);
            btnGetById.TabIndex = 16;
            btnGetById.Text = "GetById";
            btnGetById.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(645, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnGetById);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Controls.Add(txtTotalPrice);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtDistrict);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtOrderId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderId;
        private DataGridView dataGridView1;
        private TextBox txtCustomerName;
        private Label label2;
        private TextBox txtDistrict;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtTotalPrice;
        private Label label5;
        private Button btnList;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnGetById;
        private PictureBox pictureBox1;
    }
}
