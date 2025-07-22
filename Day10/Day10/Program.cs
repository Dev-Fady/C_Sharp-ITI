using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JR16FNI;
                                                             Initial Catalog=course_enrollment_system;
                                                             Integrated Security=True");


            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT enrollment_id , user_id FROM enrollments";

            command.CommandText = "update  courses set price = price + 1000 where course_id = 1";


            #region Connected Mode

            //sqlConnection.Open();

            //SqlDataReader dataReader = command.ExecuteReader();

            //while (await dataReader.ReadAsync())
            //{
            //    int enrollment_id = (int)dataReader["enrollment_id"];
            //    int user_id = (int)dataReader["user_id"];
            //    Console.WriteLine($"enrollment_id : {enrollment_id} , user_id : {user_id}");

            //}

            //sqlConnection.Close();

            #endregion

            #region DisConnected Mode

            //DataTable dataTable = new DataTable();

            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    int enrollment_id = (int)row["enrollment_id"];
            //    int user_id = (int)row["user_id"];
            //    Console.WriteLine($"enrollment_id : {enrollment_id} , user_id : {user_id}");
            //}

            #endregion

            #region  update command 
            sqlConnection.Open();

            command.ExecuteNonQuery();// This will execute the update command 

            sqlConnection.Close(); 
            #endregion

        }
    }
}
