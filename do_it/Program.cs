using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace do_it
{
    static class Program
    {
        
        public static int get_userID()
        {
            string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection();
            SqlCommand comd = new SqlCommand();

            string id = "";
            cn = new SqlConnection(cs);
            cn.Open();
            string r = "select ID_USER from users where FULL_NAME  = '" + Program.activeUser + "' or login = '" + Program.activeUser +"'" ;
            comd = new SqlCommand(r, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                id = dr[0].ToString();
            }


            cn.Close();
            cn = null;
            r = null;
            comd = null;
            dr = null;
            return int.Parse(id);
        }
        public static string activeUser;
        public static bool goToTask = false;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingForm());
        }
    }
}
