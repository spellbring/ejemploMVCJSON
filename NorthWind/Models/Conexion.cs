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
        //private static volatile Conexion instance;
        //private static object syncRoot = new Object();



        public Conexion()
        {
            try
            {
                // this.D_cn = new SqlConnection("Data Source=localhost; Initial Catalog=Financiero ; User ID=sa; Password=123");


                // --------------------------------------------------------------------------------
                // JOVM - 29/09/2015
                // Se modifica modo de conexión y se obtiene cadena desde Web.Config la variable
                // ConnectionString llamada "FinancieroConnectionString"
                // --------------------------------------------------------------------------------
                //System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/Senainfo2015");
                
                //if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                //{
                //stringConexion = ConfigurationManager.ConnectionStrings["FinancieroConnectionString"].ToString();
                D_cn = new SqlConnection("Data Source=\\SQLEXPRESS; Initial Catalog=NORTHWND ; User ID=sa; Password=123");
                // }
                // --------------------------------------------------------------------------------
                if (this.D_cn.State != ConnectionState.Open)
                    this.D_cn.Open();

                this.status = "Conexion exitosa";
            }
            catch (Exception ex)
            {
                this.status = "Error: " + ex.ToString();
            }
        }
        //public static Conexion Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (syncRoot)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new Conexion();

        //                }

        //            }

        //        }
        //        return instance;
        //    }

        //}

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