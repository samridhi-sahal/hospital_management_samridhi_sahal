using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long i = 1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            TextBox2.Text = number;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try

            {
                SqlConnection db_con = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog =hospital; Integrated Security=true");

                db_con.Open();
                SqlCommand cmd = new SqlCommand("insert into doctor_list(doctor_name,doctor_id) values(@doctor_name,@doctor_id)", db_con);
                cmd.Parameters.AddWithValue("@doctor_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@doctor_id", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                db_con.Close();
                Response.Redirect("main.aspx");

            }
            catch (Exception ex)
            {

                Response.Write("<sript>alert('" + ex.Message + "');</script>");
            }
        }
    }
}