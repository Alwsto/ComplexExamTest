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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string login = txtboxLogin.Text;
            string pass = txtboxpass.Text;
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test4;");
            connection.Open();
            string queryRole = "SELECT Role FROM Users WHERE login = @login AND pass = @pass";
            string queryFio = "SELECT FullName FROM Users WHERE login = @login AND pass = @pass";
            SqlCommand cmdRole = new SqlCommand(queryRole, connection);
            SqlCommand cmdFio = new SqlCommand(queryFio, connection);
            cmdRole.Parameters.AddWithValue("@login", login);
            cmdRole.Parameters.AddWithValue("@pass",  pass);
            cmdFio.Parameters.AddWithValue("@login", login);
            cmdFio.Parameters.AddWithValue("@pass", pass);
            object resultRole = cmdRole.ExecuteScalar();
            object resultFio = cmdFio.ExecuteScalar();
            if (resultRole != null)
            {
                string sqlRole = resultRole.ToString();
                string sqlFio = resultFio.ToString();
                if (sqlRole == "Администратор")
                {
                    this.Hide();
                    Interface admin = new Interface(sqlFio, sqlRole);
                    admin.Show();

                }
                else if (sqlRole == "Менеджер")
                {
                    this.Hide();
                    ManagerForm manager = new ManagerForm(sqlFio, sqlRole);
                    manager.Show();

                }
                else
                {
                    this.Hide();
                    Interface client = new Interface(sqlFio, sqlRole);
                    client.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            connection.Close();



        }
    }
}
