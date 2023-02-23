using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["db_con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {


                SqlConnection db_con = new SqlConnection(con);
                if (db_con.State == ConnectionState.Closed)
                {
                    db_con.Open();
                }

                SqlCommand cdd = new SqlCommand("select * from user_details where user_name = '" + TextBox1.Text.Trim() + " ' AND password ='" + TextBox2.Text.Trim() + " '", db_con); ; ;
                SqlDataAdapter da = new SqlDataAdapter(cdd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    Response.Redirect("main.aspx");
                }

                else
                {
                    Response.Write("<script>alert('Wrong details or Member not registered');</script>");
                }

            }

            catch (Exception ex)
            {
                Response.Write("<sript>alert('" + ex.Message + "');</script>");

            }

        }
    }
}