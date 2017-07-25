using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.SqlClient;
using SampleWebBlog.Models;

namespace SampleWebBlog.DAL
{
    public class CategoryDAL
    {
        private string connStr;
        public CategoryDAL()
        {
            connStr = 
                ConfigurationManager
                .ConnectionStrings["BootcampDbConnectionString"].ConnectionString;
        }

        public List<Category> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                List<Category> lstCat = new List<Category>();
                string strSql = @"select * from Categories order by CategoryName asc";
                SqlCommand cmd = new SqlCommand(strSql,conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lstCat.Add(
                            new Category
                            {
                                CategoryId = Convert.ToInt32(dr["CategoryId"]),
                                CategoryName = dr["CategoryName"].ToString()
                            });
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();

                return lstCat;
            }
        }

        public void Insert(Category category)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"insert into Categories(CategoryName) 
                                  values(@CategoryName)";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception(sqlEx.Message);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }
    }
}