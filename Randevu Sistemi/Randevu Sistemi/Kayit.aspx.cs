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
    public partial class Kayit : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKKayıt_Click(object sender, EventArgs e)
        {
           
                SqlConnection bag1 = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            bag1.Open();
            SqlCommand gonderA1 = new SqlCommand("Select * from Kayit where  Tc='" + TxtKTC.Text + "'", bag1);
            SqlDataReader dr1 = gonderA1.ExecuteReader();
            if (dr1.Read())
            {
                Label1.Text=("Doğru Tc Giriniz");


            }
            else {


                SqlConnection bag2 = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
                bag2.Open();
                SqlCommand gonderA2 = new SqlCommand("Select * from Kayit where  Tc='" + TxtKTC.Text + "'", bag2);
                SqlDataReader dr2 = gonderA2.ExecuteReader();
                if (dr2.Read())
                {
                    Label1.Text = ("Doğru Tc Giriniz");


                }
                else
                {
                }



                baglanti.Open();
            SqlCommand gonder = new SqlCommand("insert into Kayit(Tc,Ad,Soyad,Yas,Telefon,Sifre)values('" + TxtKTC.Text + "','" + TxtKAd.Text + "','" + TxtKSoy.Text + "','" + TxtKYas.Text + "','" + TxtKTel.Text + "','" + TxtKSifre.Text + "' )", baglanti);

            gonder.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
            TxtKTC.Text = "";
            TxtKAd.Text = "";
            TxtKSoy.Text = "";
            TxtKYas.Text = "";
            TxtKTel.Text = "";
            TxtKSifre.Text = "";
            Label1.Visible = true;
            Label1.Text = "İslemiz Gerçekleşti";

                 

        } }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");

        }
    }
}