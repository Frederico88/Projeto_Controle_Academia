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
    public partial class F_Login : Form
    {
        F_SQLite formSQ;
        DataTable dt = new DataTable();
        public F_Login(F_SQLite f)
        {
            InitializeComponent();
            formSQ = f; //a partir dos elementos de f_login eu consigo manipular os elementos de form1 pois eles estão conectados pelo construtor que foi criado, no caso, buscara informações da classe sql e colocara no form1, no usuario e tipo de acesso
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_usuario.Text;
            string password = tb_senha.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("Usuário e/ou senha inválidos!!");
                tb_usuario.Focus();
                return;
            }

            string sql = "SELECT * FROM Users WHERE T_USERNAME = '" + username + "' AND T_PASSWORD ='" + password + "'";
            dt = Banco.dql(sql); //executa a consulta e retorna um datatable para ca
            if(dt.Rows.Count == 1 )
            {
                formSQ.lb_acesso.Text = dt.Rows[0].ItemArray[4].ToString(); //tranforma o label acesso no formsql de acordo com o valor da consulta feita
                formSQ.lb_usuario.Text = dt.Rows[0].Field<string>("T_NAME_USER"); //ele faz a mesma coisa que o metodo de cima, mas dessa vez ele pega pelo campo(field) e não por posição do array
                formSQ.pb_ledLogado.Image = Properties.Resources.png_transparent_green_font_design_led_art_circle_thumbnail;
                Globais.level =int.Parse(dt.Rows[0].Field<Int64>("N_USER_LEVEL").ToString());
                Globais.log = true;
                this.Close();
            }
            else
            {

                MessageBox.Show("Usuário não encontrado ou senha incorreta");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
