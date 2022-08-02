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
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }

        private void F_Professores_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_ID_PROF as 'ID', T_NOME_PROFESSOR as 'Professor', T_TELEFONE as 'Telefone' FROM Professores ORDER BY N_ID_PROF";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 80;
            dgv_professores.Columns[1].Width = 200;
            dgv_professores.Columns[2].Width = 130;

        }

        private void dgv_horario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_professor.Clear();
            mtb_professores.Clear();
            tb_professor.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string vquery = "";
            if(tb_id.Text == "")
            {
                vquery = "INSERT INTO Professores (T_NOME_PROFESSOR, T_TELEFONE) VALUES  ('"+ tb_professor.Text +"','" + mtb_professores.Text + "')";
            }
            else
            {
                vquery = "UPDATE Professores SET T_NOME_PROFESSOR='" + tb_professor.Text + "', T_TELEFONE='" + mtb_professores.Text + "' WHERE N_ID_PROF=" + tb_id.Text;
            }
            Banco.dml(vquery);
            vquery = "SELECT N_ID_PROF as 'ID', T_NOME_PROFESSOR as 'Professor', T_TELEFONE as 'Telefone' FROM Professores ORDER BY N_ID_PROF";
            dgv_professores.DataSource = Banco.dql(vquery);
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv =(DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = "SELECT * FROM Professores WHERE N_ID_PROF=" + vid;
                dt = Banco.dql(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_ID_PROF").ToString();
                tb_professor.Text = dt.Rows[0].Field<string>("T_NOME_PROFESSOR");
                mtb_professores.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }  
        }

        private void btn_exclude_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                string vquery = "DELETE FROM Professores WHERE N_ID_PROF=" + tb_id.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }
    }
}
