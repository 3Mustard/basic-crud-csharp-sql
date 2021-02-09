using System;
using System.Data;
using System.Data.SqlClient;//1

namespace CRUDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This example uses a database that contains the following table: { Id: PrimaryKey int, Username: varchar(50), Password: varchar(50) }

            //CREATE
            //SqlConnection cn = new SqlConnection(@"PUT DATA CONNECTION STRING HERE");
            //cn.Open();

            //string Username, Password, Id;
            //Console.WriteLine("Enter The id and the new username/password of the new user: ");
            //Id = Console.ReadLine();
            //Username = Console.ReadLine();
            //Password = Console.ReadLine();

            //SqlCommand cmd = new SqlCommand("INSERT INTO CrudAppUsers VALUES (@Id, @Username, @Password)", cn);
            //cmd.Parameters.AddWithValue("@Id", int.Parse(Id));
            //cmd.Parameters.AddWithValue("@Username", Username);
            //cmd.Parameters.AddWithValue("@Password", Password);
            //cmd.ExecuteNonQuery();
            //cn.Close();
            //Console.WriteLine("Success!");

            //UPDATE
            //SqlConnection cn = new SqlConnection(@"PUT DATA CONNECTION STRING HERE");
            //cn.Open();
            //string Username, Password, Id;
            //Console.WriteLine("Enter The id of the user to update and the new username/password: ");
            //Id = Console.ReadLine();
            //Username = Console.ReadLine();
            //Password = Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("UPDATE CrudAppUsers SET Username=@Username, Password=@Password WHERE Id = @Id", cn);
            //cmd.Parameters.AddWithValue("@Id", int.Parse(Id));
            //cmd.Parameters.AddWithValue("@Username", Username);
            //cmd.Parameters.AddWithValue("@Password", Password);
            //cmd.ExecuteNonQuery();
            //cn.Close();
            //Console.WriteLine("Success!");

            //Delete
            //SqlConnection cn = new SqlConnection(@"PUT DATA CONNECTION STRING HERE");
            //cn.Open();
            //string Id;
            //Console.WriteLine("Enter The id of the user you wish to delete: ");
            //Id = Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("DELETE CrudAppUsers WHERE Id=@Id", cn);
            //cmd.Parameters.AddWithValue("@Id", int.Parse(Id));
            //cmd.ExecuteNonQuery();
            //cn.Close();
            //Console.WriteLine("Success!");

            //SELECT ALL
            //SqlConnection cn = new SqlConnection(@"PUT DATA CONNECTION STRING HERE");
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM CrudAppUsers", cn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    string Id = row["Id"].ToString();
            //    string Username = row["Username"].ToString();
            //    string Password = row["Password"].ToString();
            //    Console.WriteLine($"ID: {Id}, Username: {Username}, Password: {Password}");
            //    Console.WriteLine("-------------------------------------------------------");
            //}
            //cn.Close();
            //Console.WriteLine("Success!");

            //SELECT BY ID
            //SqlConnection cn = new SqlConnection(@"PUT DATA CONNECTION STRING HERE");
            //cn.Open();
            //string Id;
            //Console.WriteLine("Enter The id of the user you wish to select: ");
            //Id = Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM CrudAppUsers WHERE Id=@Id", cn);
            //cmd.Parameters.AddWithValue("Id", int.Parse(Id));
            //SqlDataAdapter da = new SqlDataAdapter(cmd); // pass select statement to the data adapter
            //DataTable dt = new DataTable();
            //da.Fill(dt); // use the data adapter to fill the empty data table
            //string Username = dt.Rows[0]["Username"].ToString();
            //string Password = dt.Rows[0]["Password"].ToString();
            //Console.WriteLine($"ID: {Id}, Username: {Username}, Password: {Password}");
            //cn.Close();
            //Console.WriteLine("Success!");
        }
    }
}
