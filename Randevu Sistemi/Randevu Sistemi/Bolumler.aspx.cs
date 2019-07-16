using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



namespace Randevu_Sistemi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsj.Visible = false;
            if (!Page.IsPostBack)

            {

                BindData();

            }

        }

        public void BindData()

        {

            try

            {

                baglanti.Open();



                SqlDataAdapter da = new SqlDataAdapter("select Bolum from Bolumler", baglanti);

                DataTable ds = new DataTable();

                da.Fill(ds);

                GridView1.DataSource = ds;

                GridView1.DataBind();

            }

            catch (Exception ex)

            {
         
                lblmsj.Text = ex.Message.ToString();

            }

            finally

            {

                baglanti.Close();

            }

        }
    }
}