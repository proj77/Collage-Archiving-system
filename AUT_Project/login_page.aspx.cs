using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AUT_Project
{
    public partial class login_page : System.Web.UI.Page
    {
       // SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|//AUT_DB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand comm = new SqlCommand();

            comm.CommandText = "'select * from Login where Username='" + TextBoxUserName.Text + "' and Password='" + TextBoxPassword.Text + "'";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                Response.Write("success");
                Response.Redirect("Web2.aspx");
            }
            else
            {
                Response.Write("Error");
            }
            conn.Close();
        }
    }
}