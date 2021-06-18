using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Shortcut
{
    class shortcut_db
    {
        string query;

        public shortcut_db()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=shortcut;Uid=root;Pwd=938002"))
            {
                query = "select *from notion";
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine(command.CommandText);
                    }
                    else
                    {
                        Console.WriteLine("Fail");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }
            };
            
        }

        static void main()
        {
            shortcut_db shortcut_Table = new shortcut_db();
        }
    }
}
