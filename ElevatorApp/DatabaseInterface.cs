using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;

namespace ElevatorApp
{
    class DatabaseInterface
    {
        private String connectionString;
        private OleDbConnection connection;
        public DatabaseInterface()
        {
            this.connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\..\..\database.mdb";
            
            this.connection = new OleDbConnection(connectionString);
            
        }
        public ArrayList GetLogs()
        {
            String query = "SELECT * FROM elevator_logs";
            OleDbCommand command = new OleDbCommand(query, connection);
            ArrayList list = new ArrayList();
            try
            {
                // Open connecton  
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    list.Add(
                        "Date and Time"
                        + ("                  ")
                        + ("          ")
                        + "Floor"
                        + ("                  ")
                        + "Event" + "\r\n"
                    );
                    String line;
                    while (reader.Read())
                    {
                        line = reader["Time"].ToString() 
                            + ("                  ")
                            + reader["Floor"].ToString() 
                            + ("                  ") 
                            + reader["Event"].ToString() + "\r\n";
                        list.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return list;
        }
        public void AddEntry(String lvl, String evnt)
        {
            String query = $"INSERT INTO elevator_logs(Floor, Event) VALUES('{lvl}', '{evnt}')";
            OleDbCommand command = new OleDbCommand(query, connection);
            ArrayList list = new ArrayList();
            try
            {
                // Open connecton  
                connection.Open();
                command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
