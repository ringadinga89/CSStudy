using MySql.Data.MySqlClient;

namespace Project2
{
    internal class DBAccessBase
    {


        public List<User> SelectUsers()
        {
            // 그리드뷰 데이터 공급을 위한 리스트
            List<User> userList = new List<User>();

            MySqlConnection conn = Connect();

            try
            {

                // DB 정보
                string server = "127.0.0.1";
                string port = "3306";
                string username = "root";
                string password = "1234";
                string database = "userdb";
                string table = "user3";

                // DB 접속 커넥션 생성
                string strConn = $"server={server};port={port};username={username};password={password};database={database};";
                MySqlConnection conn = new Ch11.MySqlConnection(strConn);

                // DB 접속
                conn.Open();

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {table}";
                MySqlDataReader reader = cmd.ExecuteReader();



                // 결과처리
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    userList.Add(user);
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                // DB 종료
                conn.Close();
            };

            return userList;
        }
    }
}