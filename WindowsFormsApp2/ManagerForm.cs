using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ManagerForm : Form
    {
        public ManagerForm(string sqlFio, string sqlRole)
        {
            InitializeComponent();
            lblFio.Text = ($"Добро пожаловать, {sqlFio}");
            lblRole.Text = ($"Вы вошли как {sqlRole}");
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }
    }
}
