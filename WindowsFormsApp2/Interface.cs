using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Interface : Form
    {
        public Interface(string sqlFio, string sqlRole)
        {
            InitializeComponent();
            lblFio.Text = ($"Добро пожаловать, {sqlFio}");
            lblRole.Text = ($"Вы вошли как {sqlRole}");
        }
        private void LoadTable(string query)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test4;");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btntovar_Click(object sender, EventArgs e)
        {
            LoadTable("SELECT * FROM Tovar");
            currentQ = "SELECT * FROM Tovar";
        }

        private void btnPVZ_Click(object sender, EventArgs e)
        {
            LoadTable("SELECT * FROM PVZ");
            currentQ = "SELECT * FROM PVZ";
        }

        private string currentQ = " ";

        private void btnOrder_Click(object sender, EventArgs e)
        {
            LoadTable("SELECT * FROM Orders");
            currentQ = "SELECT * FROM Orders";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddEditTovarForm add = new AddEditTovarForm();
            add.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadTable(currentQ);

        }
    }
}
