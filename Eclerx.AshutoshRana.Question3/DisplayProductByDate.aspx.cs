using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Eclerx.AshutoshRana.Question3
{
    public partial class DisplayProductByDate : System.Web.UI.Page
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Eclerx"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Product where AddedDate between @FromAddedDate and @ToAddedDate", con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@FromAddedDate", TxtFromdate.Text);
                    adapter.SelectCommand.Parameters.AddWithValue("@ToAddedDate", TxtToDate.Text);

                    ds = new DataSet();
                    adapter.Fill(ds, "Product");

                    GridProduct.DataSource = ds.Tables["Product"];
                    GridProduct.DataBind();
                }
            }
        }
    }
}