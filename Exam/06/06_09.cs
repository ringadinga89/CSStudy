using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _06_09
    {
        static void Main(string[] args)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            Console.WriteLine("******************************");
            Console.WriteLine("데이터 매니저 프로그램 v1.0");
            Console.WriteLine("******************************");

            while (true)
            {
                string strConn = $"server={server};";
                       strConn = $"port={port};";
                       strConn = $"username={username};";
                       strConn = $"password={password};";
                       strConn = $"database={database};";

                MySqlConnection conn = new MySqlConnection(strConn);

                Console.WriteLine("종료:0, 입력:1, 전체조회:2");
                Console.Write("선택 : ");

                int answer = int.Parse(Console.ReadLine());

                if (answer == 0)
                {
                    Console.WriteLine
                }
            }
        }
    }
}
