using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySql_Test
{
    class shortcut_table
    {
        string query;

        public shortcut_table()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=shortcut;Uid=root;Pwd=938002"))
            {
                query = "select *from notion;";
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", table["FUNC"], table["CTRL"], table["ALT"], table["SHIFT"], table["HOTKEY"]);
                    }
                    table.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }
                    /*if (command.ExecuteNonQuery() == 1)
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
                }*/
            };

        }

        static void Main()
        {
            shortcut_table shortcut_Table = new shortcut_table();
        }
    }
}
