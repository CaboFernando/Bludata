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
    }
}
