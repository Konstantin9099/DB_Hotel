﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_Hotel
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";  // Имя хоста.
            int port = 3306;  // Имя пользователя.
            string database = "hotels"; // Вводим название базы данных, имеющейся в программе MySQL.
            string user = "root"; // Логин в MySQL.
            string password = "root"; // Пароль в MySQL.
            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
