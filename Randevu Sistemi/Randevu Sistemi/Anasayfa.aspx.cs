using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Randevu_Sistemi
{
    public partial class Anasayfa : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKayit_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Kayit.aspx");
       
        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
       
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA = new SqlCommand("Select * from Kayit where Tc='" + TxtTC.Text + "' and Sifre='" + TxtSifre.Text + "'", baglanti);
            SqlDataReader dr = gonderA.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Randevular.aspx");
            }
            else {
                Label1.Visible = true;
                Label1.Text=("Hatalı Giriş Yaptınız"); }
        }

        protected void BtnSH_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hesap.aspx");
        }

      
    }
}