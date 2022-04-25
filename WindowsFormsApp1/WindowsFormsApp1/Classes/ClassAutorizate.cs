using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1.Classes
{
    class ClassAutorizate
    {
        static public string fio = "";
        static public void Auth(string login, string pass)
        {
            try
            {
                ClassConnect.myCommand.CommandText = $@"select FI_menejer 
                                                        from menejer 
                                                        where login_menejer = '{login}' and password_menejer = '{pass}'";
                object rezult = ClassConnect.myCommand.ExecuteScalar();
                if(rezult!=null)
                {
                    fio = rezult.ToString();
                }
                else
                {
                    fio = null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                throw;
            }
        }
    }
}
