using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;

namespace NorthWind.Models
{
    public class CategoriasDAL
    {
        public List<Categorias> GetCategorias()
        {
            var categorias = new List<Categorias>();

            var con = new Conexion();
            var cmd = new SqlCommand("SELECT CATEGORYID,CATEGORYNAME FROM NORTHWIND.DBO.CATEGORIES", con.getConex());
            var dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int categoryid = int.Parse(dr["CATEGORYID"].ToString());
                    string categoryname = dr["CATEGORYNAME"].ToString();

                    categorias.Add(new Categorias
                    {
                        CategoryID = categoryid,
                        CategoryName = categoryname
                    });
                }
            }
            con.Close();
            return categorias;



        }
    }
}