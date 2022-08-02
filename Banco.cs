using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SQLite_Project
{
    internal class Banco
    {
        //Funções genéricas
        private static SQLiteConnection connection;
        private static SQLiteConnection DataConnection()
        {
            connection = new SQLiteConnection("Data Source ="+Globais.caminhoBanco + Globais.nomeBanco);
            connection.Open();
            return connection;
        }

        public static DataTable dql(string sql) //Data Query Language (select)
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    da.Fill(dt); //passou todos os dados do dataadapter para o data table, ja que nesse caso é uma tabela
                    vcon.Close();
                    return dt; //para o metodo do tipo datatable, retorna um datatable
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK=null, string msgErro=null) //Data Manipulation Language (insert, delete, update)
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = q;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    if(msgOK!=null)
                    {
                        MessageBox.Show(msgOK);
                    }
                }
            }
            catch (Exception ex)
            {
                if(msgErro!=null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
                throw ex;
            }
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    da.Fill(dt); //passou todos os dados do dataadapter para o data table, ja que nesse caso é uma tabela
                    vcon.Close();
                    return dt; //para o metodo do tipo datatable, retorna um datatable
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        //Funções do formulário do Form F_New_User

        public static void NewUser(User u)
        {
            if(UserExist(u))
            {
                MessageBox.Show("Esse usuário ja exsite");
                return;
            }
            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO Users (T_NAME_USER, T_PASSWORD, T_USER_STATE, N_USER_LEVEL, T_USERNAME) VALUES (@name, @password, @state, @level, @username)";
                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@state", u.status);
                cmd.Parameters.AddWithValue("@level", u.level);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");
                vcon.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: {0}", ex.Message);
            }

        }

        //Fim das funções do Form F_New_User
        //inicio das funções para F_Gestao_Users

        public static DataTable ObterUserIdNome()
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT N_ID_USER as 'ID Usuário', T_NAME_USER as 'Nome' FROM Users";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    da.Fill(dt); //passou todos os dados do dataadapter para o data table, ja que nesse caso é uma tabela
                    vcon.Close();
                    return dt; //para o metodo do tipo datatable, retorna um datatable
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDataUser(string id)
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE N_ID_USER = " + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    da.Fill(dt); //passou todos os dados do dataadapter para o data table, ja que nesse caso é uma tabela
                    vcon.Close();
                    return dt; //para o metodo do tipo datatable, retorna um datatable
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UserUpdate(User u)
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "UPDATE Users SET T_NAME_USER='" +u.name+ "', T_USERNAME = '" + u.username + "', T_PASSWORD = '" + u.password + "', T_USER_STATE = '" + u.status + "', N_USER_LEVEL=" +u.level+ " WHERE N_ID_USER=" +u.id; 
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UserDelete(string id)
        {
            SQLiteDataAdapter da = null; //função de leitura do sql e transferi-lo para coluna/tabela ou o que se deseja
            DataTable dt = new DataTable();//local para onde serão transferidas as informações a partir do dataadapter

            try
            {
                var vcon = DataConnection();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "DELETE FROM Users WHERE N_ID_USER=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon); //tenta chamar os dados contidos na tabela users, senão gera uma excessão
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Fim das funções para F_Gestao_Users
        //Rotinas Gerais
        public static bool UserExist(User u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = DataConnection();
            var cmd =vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM Users WHERE T_USERNAME = '" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                res = true;
            }else
            {
                res = false;
            }

            vcon.Close();
            return res;
        }
        
    }
}
