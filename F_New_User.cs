using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_Project
{
    public partial class F_New_User : Form
    {
        public F_New_User()
        {
            InitializeComponent();
        }

        private void F_New_User_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = tb_nome.Text;
            user.username = tb_username.Text;
            user.password = tb_password.Text;
            user.status = cb_status.Text;
            user.level = Convert.ToInt32(Math.Round(nud_level.Value,0));

            Banco.NewUser(user);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_password.Clear();
            tb_username.Clear();
            cb_status.Text = "";
            nud_level.Value = 0;
            tb_nome.Focus();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_password.Clear();
            tb_username.Clear();
            cb_status.Text = "";
            nud_level.Value = 0;
            tb_nome.Focus();
        }
    }
}
