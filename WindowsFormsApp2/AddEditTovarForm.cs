using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddEditTovarForm : Form
    {
        public AddEditTovarForm()
        {
            InitializeComponent();
            this.Name = "AddEditTovarForm";
            this.Text = "Добавление нового товара";
        }

        private void AddEditTovarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnaddtotable_Click(object sender, EventArgs e)
        {
            string article = txtarticle.Text;
            string name = txtname.Text;
            string price1 = txtprice.Text;
            string cnt1 = txtcnt.Text;
            string postavshik = txtpostavshik.Text;
            string creator = txtcreator.Text;
            string discount1 = txtdiscount.Text;
            string description = txtdesc.Text;
            int price = int.Parse(txtprice.Text);
            int cnt = int.Parse(txtcnt.Text);
            int discount = int.Parse(txtdiscount.Text);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test4;");
            sqlConnection.Open();
            try
            {
                string query = "INSERT INTO Tovar (Article, ProductName, Unit, Price, Postavshik, Creator, Category, Discount, cnt, Description) VALUES (@article, @name, N'шт.', @price, @postavshik, @creator, N'test', @discount, @cnt, @description);";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@article", article);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@cnt", cnt);
                cmd.Parameters.AddWithValue("@postavshik", postavshik);
                cmd.Parameters.AddWithValue("@creator", creator);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар добавлен");
                sqlConnection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
