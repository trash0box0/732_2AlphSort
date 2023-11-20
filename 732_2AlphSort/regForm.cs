using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _732_2AlphSort
{
    public partial class regForm : Form
    {
        private DBManager dbmanager;
        public regForm(DBManager dbmanager)
        {
            InitializeComponent();
            this.dbmanager = dbmanager;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string login = regLoginTB.Text;
            string pwd1 = regPwd1TB.Text;
            string pwd2 = regPwd2TB.Text;

            if (pwd1.Equals(pwd2))
            {
                if (dbmanager.AddUser(login, pwd1) == true)
                {
                    MessageBox.Show("Успешная регистрация");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }

        }
    }
}
