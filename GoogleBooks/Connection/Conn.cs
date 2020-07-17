using System;
using System.Data.SQLite;
using System.IO;

namespace GoogleBooks.Connection
{
    public class Conn
    {
        private static SQLiteConnection sqlC;
        public Conn(){}
        protected static SQLiteConnection dbConn() 
        {
            sqlC = new SQLiteConnection("Data Source=c:\\GoogleBooks\\base.sqlite; Version=3;");
            sqlC.Open();
            return sqlC;
        }
        public static void initDb()
        {
            try
            {
                if (!Directory.Exists("c:\\GoogleBooks\\")) 
                {
                    Directory.CreateDirectory("c:\\GoogleBooks\\");
                }
                if (!File.Exists("c:\\GoogleBooks\\base.sqlite"))
                {
                    SQLiteConnection.CreateFile(@"c:\\GoogleBooks\\base.sqlite");
                }

                createTable(Querys.TABLE_FAVORITOS);
            }
            catch
            {
                throw;
            }
        }
        public static void createTable(string createQuery)
        {
            try
            {
                using (var cmd = dbConn().CreateCommand())
                {
                    cmd.CommandText = createQuery;
                    cmd.ExecuteNonQuery();
                }
                dbConn().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
