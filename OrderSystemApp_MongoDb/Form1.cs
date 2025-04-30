using OrderSystemApp_MongoDb.Entities;
using OrderSystemApp_MongoDb.Services;

namespace OrderSystemApp_MongoDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                OrderId = txtOrderId.Text,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                City = txtCity.Text,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text)
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Order added successfully!");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Order deleted successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            var order = new Order
            {
                OrderId = orderId,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                City = txtCity.Text,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text)
            };

            orderOperation.UpdateOrder(orderId,order);
            MessageBox.Show("Order updated successfully!");
        }
    }
}
