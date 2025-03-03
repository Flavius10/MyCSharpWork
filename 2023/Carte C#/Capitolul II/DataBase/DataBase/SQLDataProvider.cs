using System;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class SQLDataProvider
    {
        static void Main(string[] args)
        {
            string connString = @"server= .\sqlexpress;
                                Database=Scoala.mdf;
                                trusted_connection=True;
                                AttachDbFileName =
                        C:\DatabaseExample\DatabaseExample\bin\Debug\Scoala.mdf";

            string sql1 = @"SELECT * FROM Elevi";
            string sgl2 = @"INSERT INTO Elevi
                            (Nume, Prenume, Varsta)
                          VALUES
                            ('Axente', 'Mihai', 20)";

            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql1, conn);
                reader = cmd.ExecuteReader();

                reader.Close();

                cmd = new SqlCommand(sgl2, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

                cmd = new SqlCommand(sql1, conn);
                reader = cmd.ExecuteReader();

                Console.WriteLine("Baza de date" +
                    conn.Database + " se interogheaza cu" + cmd.CommandText);

                while (reader.Read())
                    Console.WriteLine("{0}  {1}  {2}",
                        reader[1], reader["Prenume"],
                        reader[3]);

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex);
            }

            finally
            {
                reader.Close();
                conn.Close();
                conn.Dispose();
            }
        }
    }
}