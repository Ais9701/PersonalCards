using System.Data.SqlClient;

namespace Personal_cardsApp1.InfoPersonalCards
{
    internal class SqlDataTimeAdapter
    {
        private string querySave;
        private SqlConnection connection;

        public SqlDataTimeAdapter(string querySave, SqlConnection connection)
        {
            this.querySave = querySave;
            this.connection = connection;
        }
    }
}