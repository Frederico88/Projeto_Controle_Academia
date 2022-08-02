using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Project
{
    internal class Globais
    {
        public static string version = "1.0";
        public static Boolean log = false;
        public static int level = 0; // 1=Basico 2=Gerente 3=Admin ou Master
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_project.db";
        public static string caminhoBanco = caminho + @"\Banco\";
        public static string caminhoFotos = caminho + @"\Fotos\";
        /* 
         datatable User
         N_ID_USER
         T_NAME_USER
         T_PASSWORD
         T_USER_STATE
         N_USER_LEVEL
         T_USERNAME
         */
    }
}
