using Ch11;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2

{
    internal class DBAccess : DBAccessBase
    {
        // DB 정보

        string server = "127.0.0.1";
        string port = "3306";
        string username = "root";
        string password = "1234";
        string database = "userdb";

        internal object SelectUsers()
        {
            throw new NotImplementedException();
        }

        string table = "user3";

        // 싱글톤
        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        public MySqlConnection Connect()
        {
            // DB 접속 커넥션 생성

            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }


        public void InsertUser(string uid, string name, string hp, string age)
        {
            MySqlConnection conn = Connect();
        }
        
        
    public void SelectUser() { }

        public void UpdateUser() { }
            public void DeleteUser() { }



        }
    }

}