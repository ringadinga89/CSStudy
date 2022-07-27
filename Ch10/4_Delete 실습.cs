﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _4_Delete_실습
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
                cmd.CommandText = "DELETE FROM `sample21` WHERE `no`='1'";
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
