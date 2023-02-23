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
    public partial class register : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db_con = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog =hospital; Integrated Security=true");
               
                    db_con.Open();

                if(TextBox1.Text.Trim() == ""|| TextBox2.Text.Trim() == ""|| TextBox3.Text.Trim() == "")
                {
                    Response.Write("<script>alert('Empty field');</script>");
                }

                 SqlCommand cdd = new SqlCommand("SELECT * from user_details where email='" + TextBox1.Text.Trim() + "';", db_con);
                  SqlDataAdapter da = new SqlDataAdapter(cdd);
                  DataTable dt = new DataTable();
                   da.Fill(dt);

                   if (dt.Rows.Count >= 1)
                  {
                       Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");
                   }
                   else {

                
                SqlCommand cmd = new SqlCommand("insert into user_details(user_name,password,email) values(@user_name,@password,@email)", db_con);
                cmd.Parameters.AddWithValue("@email", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@user_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox3.Text.Trim());
                    cmd.ExecuteNonQuery();
                    db_con.Close();
                    Response.Write("<script>alert('Member Registered');</script>");
                    Response.Redirect("main.aspx");
                    
               }

            }
            catch(Exception ex)
            {
                Response.Write("<sript>alert('" + ex.Message + "');</script>");

            }

        }
    }
}