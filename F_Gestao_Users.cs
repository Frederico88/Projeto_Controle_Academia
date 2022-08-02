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
    public partial class F_Gestao_Users : Form
    {
        public F_Gestao_Users()
        {
            InitializeComponent();
        }

        private void F_Gestao_Users_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = Banco.ObterUserIdNome();
            dgv_users.Columns[0].Width = 110;
            dgv_users.Columns[1].Width = 160;


        }

        private void dgv_users_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlines = dgv.SelectedRows.Count;
            if(contlines > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString(); //seleciona os valores das linhas e das colunas no qual o cursor vai estar
                dt = Banco.ObterDataUser(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_ID_USER").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NAME_USER").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_password.Text = dt.Rows[0].Field<string>("T_PASSWORD").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_USER_STATE").ToString();
                nud_level.Value = dt.Rows[0].Field<Int64>("N_USER_LEVEL");

            }
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            F_New_User f_New_User = new F_New_User();
            f_New_User.ShowDialog();
            dgv_users.DataSource = Banco.ObterUserIdNome();
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            int line = dgv_users.SelectedRows[0].Index;
            User u = new User();
            u.id = Convert.ToInt32(tb_id.Text);
            u.name = tb_nome.Text;
            u.status = cb_status.Text;
            u.username = tb_username.Text;
            u.level = Convert.ToInt32(Math.Round(nud_level.Value));
            u.password = tb_password.Text;
            Banco.UserUpdate(u);

            dgv_users[1, line].Value = tb_nome.Text;
        }

        private void btn_exclude_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Você confirma a exclusão?","Excluir Usuário", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                Banco.UserDelete(tb_id.Text);
                dgv_users.Rows.Remove(dgv_users.CurrentRow);
            }
        }
    }
}
