using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Eclerx.AshutoshRana.Question3
{
    public partial class AddProduct : System.Web.UI.Page
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Eclerx"].ConnectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Category", con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DdlCategories.DataSource = dt;
                        DdlCategories.DataValueField = "Id";
                        DdlCategories.DataTextField = "CategoryName";
                        DdlCategories.DataBind();
                    }
                }

            }
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Eclerx"].ConnectionString))
                {
                    using (cmd = new SqlCommand("usp_addItem", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryName", DdlCategories.SelectedValue);
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@TotalQuantity", txtQuantity.Text);
                        cmd.Parameters.AddWithValue("@AddedDate", DateTime.Today);

                        this.reset();

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();

                    }
                }
            }
        }
        public void reset()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        protected void BtnGoto_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayProductByDate.aspx");
        }
    }
}