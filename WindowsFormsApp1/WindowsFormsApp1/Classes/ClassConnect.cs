using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace WindowsFormsApp1.Classes
{
    class ClassConnect
    {
        static public string connectStr = "Database = shop; datasource = localhost; user = root; password = qwerty; charset = utf8;";

        static public MySqlConnection myConnect;
        static public MySqlCommand myCommand;
        static public MySqlDataAdapter myDataAdapter;

        static public bool DBConnect()
        {
            try
            {
                myConnect = new MySqlConnection(connectStr);
                myConnect.Open();
                myCommand = new MySqlCommand();
                myCommand.Connection = myConnect;
                myDataAdapter = new MySqlDataAdapter(myCommand);
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
        }
        static public void DBConnectClose()
        {
            myConnect.Close();
            
        }
    }
}
