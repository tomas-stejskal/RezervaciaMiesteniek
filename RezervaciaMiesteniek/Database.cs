using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/********************************************************
*
* Klasa ktora sa stara o vsetko co suvisi s sql databazou
*
*********************************************************/

namespace RezervaciaMiesteniek
{
    class Database
    {
        private MySqlConnection connect;
        private string connectStr = @"SERVER=localhost;DATABASE=trains2;UID=root;PASSWORD=1234;"; //nech si to kazdy zmenia podla sovojej potreby;

        public Database()
        {
            connect = new MySqlConnection(connectStr);
        }
        
        public void openConnection() //otvorenie priopojenia
        {
            try
            {
                connect.Open();
                System.Console.WriteLine("connection succesful");
            }
            catch (MySqlException ex)
            {
                System.Console.WriteLine("can not connect to database");
            }
        }

        public void closeConnection() //uzavretie pripojenia, STALE POUZIVAT!!!
        {
            try
            {
                connect.Close();
                System.Console.WriteLine("close connection succesful");
            }
            catch(MySqlException ex)
            {
                System.Console.WriteLine("can not close to database");
            }
        }
    }
}
