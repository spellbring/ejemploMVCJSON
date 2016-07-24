using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace NorthWind.Models
{


    public class Conexion
    {
        private SqlConnection D_cn;
        private SqlCommand D_cmd;
        private String status;
        private String stringConexion;



        public Conexion()
        {
            try
            {                
                D_cn = new SqlConnection("Data Source=LAPTOP-1S4842QV\\SQLEXPRESS; Initial Catalog=NORTHWIND ; User ID=sa; Password=123dnd123");
                
                if (this.D_cn.State != ConnectionState.Open)
                    this.D_cn.Open();

                this.status = "Conexion exitosa";
            }
            catch (Exception ex)
            {
                this.status = "Error: " + ex.ToString();
            }
        }
       

        public void consulta(String query)
        {
            this.D_cmd = new SqlCommand(query, this.D_cn);
            this.D_cmd.ExecuteNonQuery();
        }

        public SqlConnection getConex()
        {
            return this.D_cn;
        }

        public String getStatus()
        {
            return this.status;
        }
        public void Close()
        {
            this.D_cn.Close();
        }




    }
}