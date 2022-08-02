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
    public partial class F_SQLite : Form
    {
        public F_SQLite()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void OpenForm(int level, Form f)
        {
            if (Globais.log)
            {
                if (Globais.level >= level)
                {
                    //se o funcionario que estiver logado tiver nivel acima do level especificado, ou seja, é um adm, ele pode entrar
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void logINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_usuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.png_transparent_light_emitting_diode_computer_icons_light_camera_lens_light_led_thumbnail;
            Globais.level = 0;
            Globais.log = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.log)
            {
                if(Globais.level >=2)
                {
                    //se o funcionario que estiver logado tiver nivel acima do 2, ou seja, é um adm, ele pode entrar

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_New_User f_New_User = new F_New_User();
            OpenForm(1, f_New_User);
        }

        private void gestãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Gestao_Users f_Gestao_Users = new F_Gestao_Users();
            OpenForm(1, f_Gestao_Users);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Novo_Aluno f_Novo_Aluno = new F_Novo_Aluno();
            if (Globais.log)
            {
               OpenForm(1, f_Novo_Aluno);
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            OpenForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professores f_Professores = new F_Professores();
            OpenForm(2, f_Professores);
        }

        private void gestãoDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmar f_GestaoTurmar = new F_GestaoTurmar();
            OpenForm(2, f_GestaoTurmar);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Gestao_Alunos f_Gestao_Alunos = new F_Gestao_Alunos();
            OpenForm(2, f_Gestao_Alunos);
        }
    }
    
    
    
}
