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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDHORARIO as 'ID', T_DESC_HORARIO 'Horário' FROM Horarios ORDER BY T_DESC_HORARIO";
            dgv_horario.DataSource = Banco.dql(vquery);
            dgv_horario.Columns[0].Width = 100;
            dgv_horario.Columns[1].Width = 200;


        }

        private void dgv_horario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = "SELECT * FROM Horarios WHERE N_IDHORARIO=" + vid;
                dt = Banco.dql(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_Horario.Text = dt.Rows[0].Field<string>("T_DESC_HORARIO");
            }
        }

        private void btn_newHorario_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            mtb_Horario.Clear();
            mtb_Horario.Focus();
        }

        private void btn_saveHorario_Click(object sender, EventArgs e)
        {
            string vquery = "";
            if(tb_id.Text == "")
            {
                if (mtb_Horario.Text != "  :  -  :  ")
                {
                    vquery = "INSERT INTO Horarios (T_DESC_HORARIO) VALUES ('" + mtb_Horario.Text + "')";
                }else
                {
                    MessageBox.Show("É precico preencher o horário!");
                }
            }
            else
            {
                vquery = "UPDATE Horarios SET T_DESC_HORARIO='" + mtb_Horario.Text + "' WHERE N_IDHORARIO="+tb_id.Text;
            }
            Banco.dml(vquery);
            vquery = "SELECT N_IDHORARIO as 'ID', T_DESC_HORARIO 'Horário' FROM Horarios ORDER BY T_DESC_HORARIO";
            dgv_horario.DataSource = Banco.dql(vquery);
        }

        private void btn_excluiHorario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.OKCancel);
            if(res== DialogResult.OK)
            {
                string vquery = "DELETE FROM Horarios WHERE N_IDHORARIO=" + tb_id.Text;
                Banco.dml(vquery);
                dgv_horario.Rows.Remove(dgv_horario.CurrentRow); 
            }
        }
    }
}
