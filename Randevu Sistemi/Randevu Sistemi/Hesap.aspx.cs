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
    public partial class Hesap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sifre = "";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");

            baglanti.Open();
            SqlCommand gonderA = new SqlCommand("Select * from Kayit where Tc='" + TextBox1.Text + "'", baglanti);
            SqlDataReader dr = gonderA.ExecuteReader();
            if (dr.Read())
            {
                Label1.Visible = true;
                Label2.Visible = true;
                sifre = dr["Sifre"].ToString();
                Label1.Text = "Şifreniz : ";
                Label2.Text = sifre;
            }
            else if(TextBox1.Text=="")
            {
                Label1.Visible = true;
                Label1.Text = "TC kimlik numarınız girilmedi";
                Label2.Text = "";
            }
            else {
                Label1.Visible = true;
                Label1.Text = "Kayıt bulunamadı";
                Label2.Text = "";
            }
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }
    }
    }
