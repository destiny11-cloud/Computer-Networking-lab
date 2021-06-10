using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
//using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace MusicPlayer
{
    class database
    {
        public static database dbcon = new database();//声明静态实例
        SQLiteConnection conn = null;
        public database()
        {
            createConnection();

        }
        private void createConnection()
        {
            string connection = "data source = music_player.db";//暂定
            conn = new SQLiteConnection(connection);
            //conn.Open();
        }
        public SQLiteConnection getConnection()
        {
            return conn;
        }

    }
}
