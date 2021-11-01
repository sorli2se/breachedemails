using Dapper;
using IO.Swagger.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Repository
{
    public class BreachedeMailRepository : IBreachedeMailRepository
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;DataBase=breachedemails;User Id=sa;password=test";

        public Breachedemail GetByEmail(string name)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var command = new SqlCommand("BreachedeMailsFunc", conn)
                {
                    CommandType = CommandType.StoredProcedure

                })
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Mode", "GETBYEMAIL"));
                    command.Parameters.Add(new SqlParameter("@Email", name));
                    using (SqlDataReader rdr = command.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        if (rdr.Read())
                        {
                            Console.WriteLine("Email: {0}", rdr["Name"]);
                            var b = new Breachedemail();
                            b.Name = rdr["Name"].ToString();
                            return b;
                        }
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HashSet<string> GetAll()
        {
            try
            {
                HashSet<string> hss = new HashSet<string>();
                using (var conn = new SqlConnection(connectionString))
                using (var command = new SqlCommand("BreachedeMailsFunc", conn)
                {
                    CommandType = CommandType.StoredProcedure

                })
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Mode", "GETALL"));
                    using (SqlDataReader rdr = command.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        while (rdr.Read())
                        {
                            Console.WriteLine("RetVal: {0}", rdr["Name"]);
                            hss.Add(rdr["Name"].ToString());
                        }
                    }
                    return hss;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Add(Breachedemail contactMaster)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var command = new SqlCommand("BreachedeMailsFunc", conn)
                {
                    CommandType = CommandType.StoredProcedure

                })
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Mode", "EDIT"));
                    command.Parameters.Add(new SqlParameter("@Email", contactMaster.Name));
                    using (SqlDataReader rdr = command.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        if (rdr.Read())
                        {
                            Console.WriteLine("RetVal: {0}", rdr["RetVal"]);
                            if (rdr["RetVal"].Equals("ok"))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string name)
        {
            try
            {
                using (var conn = new SqlConnection("Server=DESKTOP-4NB1HM7\\SQLEXPRESS;DataBase=breachedemails;User Id=sa;password=test"))
                using (var command = new SqlCommand("BreachedeMailsFunc", conn)
                {
                    CommandType = CommandType.StoredProcedure

                })
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@Mode", "DELETE"));
                    command.Parameters.Add(new SqlParameter("@Email", name));
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
