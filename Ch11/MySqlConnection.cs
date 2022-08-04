using MySql.Data.MySqlClient;

namespace Ch11
{
    internal class MySqlConnection
    {
        private string strConn;

        public MySqlConnection(string strConn)
        {
            this.strConn = strConn;
        }

        internal MySqlCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}