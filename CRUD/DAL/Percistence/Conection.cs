using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DAL.Percistence
{
    public class Conection
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void OpenConection()
        {
            try
            {
                Con = new SqlConnection("Data Source=DESKTOP-JDK2GPD;Initial Catalog=bludata;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        protected void CloseConection()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
