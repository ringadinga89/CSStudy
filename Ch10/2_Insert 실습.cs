using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/27
 * 이름 : 조경은
 * 내용 : 데이터베이스 프로그래밍 실습
 * 
 */


namespace Ch10
{
    internal class _2_Insert_실습
    {
        static void Main4(string[] args)
        {
            // 데이터 베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";


            // 데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);

            // 데이터베이스 접속
            try
            {
                conn.Open();
                Console.WriteLine("접속성공!");

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `sample21` VALUES (1, '박준용', '1976-10-18', '대구광역시 수성구')";
                cmd.ExecuteNonQuery();


                Console.WriteLine("SQL 완료...");

            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);

            }
            finally
            {

                // 접속종료
                conn.Close();
                Console.WriteLine("접속 종료...");
            }
        }
    }
}
