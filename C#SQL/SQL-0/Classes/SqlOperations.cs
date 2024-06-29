using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SQL_0.Classes
{
    public class SqlOperations
    {
    
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=SchoolDB;Integrated Security=True");
// public başka bir sınıfdan çağırıyor static  iççin nesne oluşturmamız için
        public static void CheckConnection(SqlConnection tempConnection)
        {
            //connection.Open();
            if(tempConnection.State==ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {
                
            }





            //connection.Close();
        }
    

        }
}
