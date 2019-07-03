using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;
using System.Configuration;


namespace Randevu_Sistemi
{
    public partial class Güncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKKayıt_Click(object sender, EventArgs e)
        {
           


                SqlConnection baglan = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
                baglan.Open();
                SqlCommand gonderc = new SqlCommand("Update Kayit SET Tc='" + TxtKTC.Text + "'  , Ad='" + TxtKAd.Text + "' , Soyad='" + TxtKSoy.Text + "' , Yas='" + TxtKYas.Text + "' , Telefon='" + TxtKTel.Text + "'   where Sifre='" + TxtKSifre.Text + "'", baglan);
                gonderc.ExecuteNonQuery();
                baglan.Dispose();
                baglan.Close();
          

                Label1.Visible = true;
                Label1.Text = "İslemiz Gerçekleşti";
            
            

           // and Ad = '" + TxtKAd.Text + "' and Soyad = '" + TxtKSoy.Text + "' and Yas = '" + TxtKYas.Text + "' and Telefon = '" + TxtKTel.Text + "'


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Randevular.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglan.Open();
            SqlCommand gonderc = new SqlCommand("Update Kayit SET Sifre='" + TextBox1.Text + "' where Sifre='" + TextBox2.Text + "' ", baglan);
            gonderc.ExecuteNonQuery();
            SqlDataReader dr = gonderc.ExecuteReader();
            if (dr.Read())
            {

                Label4.Visible = true;
                Label4.Text = "Şirfeniz Değiştirlemedi!";



            }
            else
            {
               
                Label4.Visible = true;
                Label4.Text = "Şirfeniz Değiştirdi";
            }
            baglan.Dispose();
            baglan.Close();

        }

    }
}