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
    public partial class authForm : Form
    {
        private DBManager dbmanager;
        private MainForm parent_form;
        private bool is_authed = false;

        public authForm(MainForm parent_form, DBManager dbmanager)
        {
            InitializeComponent();
            this.parent_form = parent_form;
            this.dbmanager = dbmanager;
        }

        private void authForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!is_authed)
            {
                Application.Exit();
            }
        }

        private void authLoginB_Click(object sender, EventArgs e)
        {
            string user = authLoginTB.Text;
            string password = authPwdTB.Text;

            if (dbmanager.CheckUser(user, password) == true)
            {
                //успешно прошли 
                is_authed = true;
                parent_form.UserAuthed();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void authGoReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regForm registration = new regForm(dbmanager);
            registration.ShowDialog();
        }
    }
}
