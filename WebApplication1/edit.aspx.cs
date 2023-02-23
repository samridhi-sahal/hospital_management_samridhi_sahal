using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection db_con = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog =hospital; Integrated Security=true");

                db_con.Open();
                SqlCommand cdd = new SqlCommand("UPDATE  patient_list SET patient_name = '"+TextBox2.Text.Trim()+ "', date_registered = '" + TextBox3.Text.Trim() + "', doc_registered = '" + TextBox4.Text.Trim() + "' where patient_id='" + TextBox1.Text.Trim() + "';", db_con);
                cdd.ExecuteNonQuery();
                Response.Redirect("main.aspx");
                db_con.Close();


            }
           catch(Exception ex)
            { Response.Write("<sript>alert('" + ex.Message + "');</script>"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try {
                SqlConnection db_con = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog =hospital; Integrated Security=true");

                db_con.Open();
                SqlCommand cdd = new SqlCommand("DELETE from patient_list where patient_id='" + TextBox1.Text.Trim() + "';", db_con);
                cdd.ExecuteNonQuery();
                Response.Redirect("main.aspx");
                db_con.Close();
            }
            catch (Exception ex)
            { Response.Write("<sript>alert('" + ex.Message + "');</script>"); }
        }
    }
}