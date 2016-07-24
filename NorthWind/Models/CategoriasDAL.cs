using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;

namespace NorthWind.Models
{
    public class CategoriasDAL:Conexion
    {
        
        public List<Categorias> Obtener(int id)
        {
            var categorias = new List<Categorias>();
            var cmd = new SqlCommand("SELECT CATEGORYID,CATEGORYNAME FROM DBO.CATEGORIES", this.getConex());
            using (cmd)
            {
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    categorias.Add(new Categorias
                    {
                        CategoryID = int.Parse(row[0].ToString()),
                        CategoryName = row[1].ToString()
                    });
                }
            }
            return categorias; 
        }
        public string Insert(string name, string description)
        {
            var mensaje = "";
            try
            {
                var sql = "INSERT INTO NORTHWIND.DBO.CATEGORIES(CATEGORIENAME,DESCRIPTION, PICTURE)" +
                          "VALUES(@CATEGORIENAME, @DESCRIPTION) ";
                var cmd = new SqlCommand(sql, this.getConex());
                    cmd.Parameters.AddWithValue("@CATEGORIENAME", name);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                    cmd.Parameters.AddWithValue("@PICTURE", description);
                   
                var filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    mensaje = "OK";
                }

            }
            catch (SqlException ex)
            {

                mensaje = ex.Message;
            }
         
            


            return "";
        }
        public SqlCommand ExecuteQuery(string sql)
        {
            var cmd = new SqlCommand(sql, this.getConex());
            return cmd;
        }


        
    }
    
}