using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleLayer;
using Factory;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private CustomerBase cust = new Customer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomerType_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = Factory.Factory.Create(CustomerType_comboBox1.Text);
        }
        private void setCustomer()
        {
            cust.CustomerName = textBox2.Text;//date
            cust.PhoneNumber = textBox4.Text;//name
            cust.BillDate = Convert.ToDateTime(textBox1.Text);//amnt
            cust.BillAmount =Convert.ToDecimal(textBox3.Text);//ph
            cust.Address = textBox5.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                setCustomer();
                cust.Validate();
        }
    }
}
