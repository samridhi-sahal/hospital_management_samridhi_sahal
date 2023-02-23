using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
               {
                    SqlConnection db_con = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog =hospital; Integrated Security=true");

                    db_con.Open();
                    SqlCommand com = new SqlCommand("Select * from doctor_list", db_con);
                    // SqlDataAdapter adpt = new SqlDataAdapter(com);
                    // DataTable dt = new DataTable();
                    // adpt.Fill(dt);

                    // DropDownList1.DataSource = dt;
                    DropDownList1.DataSource = com.ExecuteReader();
                    DropDownList1.DataTextField = "doctor_name";
                    // DropDownList1.DataValueField = "doctor_id";
                    DropDownList1.DataBind();
                    db_con.Close();

                }

            }
            catch (Exception ex)
            {
                Response.Write("<sript>alert('" + ex.Message + "');</script>");
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_doc.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_pat.aspx");
        }










        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db_con = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog =hospital; Integrated Security=true");

                db_con.Open();
                SqlCommand cmd = new SqlCommand("select patient_name,patient_id,date_registered from patient_list where doc_registered ='" + DropDownList1.Text + "'", db_con);
                SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label1.Text = "record found";
                db_con.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<sript>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("edit.aspx");
            }
            catch(Exception ex)
            {
                Response.Write("<sript>alert('" + ex.Message + "');</script>");
            }
        }
    }

       
 }
