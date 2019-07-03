﻿using System;
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
using System.Drawing;


namespace Randevu_Sistemi
{
    public partial class Randevular : System.Web.UI.Page
    { SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
     SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
     protected void Page_Load(object sender, EventArgs e)
     {
            lblAd.Visible = false;
            lblSoy.Visible = false;
            lblBol.Visible = false;
            lblZaman.Visible = false;
            lblSaat.Visible = false;
           
            if (!IsPostBack)
         {
             baglan.Open();
             string query2 = "Select  Bolum from  Bolumler";
             SqlDataAdapter da2 = new SqlDataAdapter(query2, baglan);
             da2.SelectCommand.ExecuteNonQuery();
             DataSet ds2 = new DataSet();
             da2.Fill(ds2);
             DropDownList1.DataSource = ds2;
             DropDownList1.DataValueField = "Bolum";
             DropDownList1.DataTextField = "Bolum";
             DropDownList1.DataBind();
             baglan.Close();
    
             baglan.Open();

    
         }
    
    
         }


        protected void S_8_Click(object sender, EventArgs e)
        {
            Label2.Text = "08:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S_8.BackColor = Color.Red;


            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "08.00";
                S_8.BackColor = Color.Green;
                S_9.BackColor = Color.Empty;
                S_10.BackColor = Color.Empty;
                S11.BackColor = Color.Empty;
                S12.BackColor = Color.Empty;
                S13.BackColor = Color.Empty;
                S14.BackColor = Color.Empty;
                S15.BackColor = Color.Empty;
                S16.BackColor = Color.Empty;
            }

        }



        protected void S_9_Click(object sender, EventArgs e)
        {
            Label2.Text = "09:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S_9.BackColor = Color.Red;
                
                

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "09.00";
                S_9.BackColor = Color.Green;
                S_8.BackColor = Color.Empty;
                S_10.BackColor = Color.Empty;
                S11.BackColor = Color.Empty;
                S12.BackColor = Color.Empty;
                S13.BackColor = Color.Empty;
                S14.BackColor = Color.Empty;
                S15.BackColor = Color.Empty;
                S16.BackColor = Color.Empty;
            }

        }

        

  protected void S_10_Click(object sender, EventArgs e)
        {
            Label2.Text = "10:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S_10.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "10.00";
                S_10.BackColor = Color.Green;
                S_8.BackColor = Color.Empty;
                S_9.BackColor = Color.Empty;
                S11.BackColor = Color.Empty;
                S12.BackColor = Color.Empty;
                S13.BackColor = Color.Empty;
                S14.BackColor = Color.Empty;
                S15.BackColor = Color.Empty;
                S16.BackColor = Color.Empty;
            }



        }

        protected void S11_Click(object sender, EventArgs e)
        {
            Label2.Text = "11:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S11.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "11.00";
                S11.BackColor = Color.Green;
                S_8.BackColor = Color.Empty;
                S_10.BackColor = Color.Empty;
                S_9.BackColor = Color.Empty;
                S12.BackColor = Color.Empty;
                S13.BackColor = Color.Empty;
                S14.BackColor = Color.Empty;
                S15.BackColor = Color.Empty;
                S16.BackColor = Color.Empty;
            }


        }
        protected void S12_Click(object sender, EventArgs e)
        {
            Label2.Text = "12:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S12.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "12.00";
                S12.BackColor = Color.Green;
                S_8.BackColor = Color.Empty;
                S_10.BackColor = Color.Empty;
                S11.BackColor = Color.Empty;
                S_9.BackColor = Color.Empty;
                S13.BackColor = Color.Empty;
                S14.BackColor = Color.Empty;
                S15.BackColor = Color.Empty;
                S16.BackColor = Color.Empty;
            }

        }


        protected void S13_Click(object sender, EventArgs e)
        {
            Label2.Text = "13:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S13.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "13.00";
                S13.BackColor = Color.Green;
            }
        }

        protected void S14_Click(object sender, EventArgs e)
        {
            Label2.Text = "14:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S14.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "14.00";
                S14.BackColor = Color.Green;
            }
        }

        protected void S15_Click(object sender, EventArgs e)
        {
            Label2.Text = "15:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S15.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "15.00";
                S15.BackColor = Color.Green;
            }
        }

        protected void S16_Click(object sender, EventArgs e)
        {
            Label2.Text = "16:00:00";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA2 = new SqlCommand("Select * from Randevular where  Tarih='" + TxtRTarih.Text + "' and Saat='" + Label2.Text + "'", baglanti);
            SqlDataReader dr = gonderA2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Dolu Saat";
                S16.BackColor = Color.Red;

            }
            else
            {
                Label1.Text = "Saatiniz : ";
                Label2.Text = "16.00";
                S16.BackColor = Color.Green;
            }
        }


        protected void BtnKKayıt_Click(object sender, EventArgs e)
        {
            SqlConnection bag1 = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            bag1.Open();
            SqlCommand gonderA1 = new SqlCommand("Select * from Randevular where  TC='" + TxtRTC.Text + "' and Ad='" + TxtRAd + "'", bag1);
            SqlDataReader dr1 = gonderA1.ExecuteReader();
            if (dr1.Read())
            {
                Label11.Visible = true;
                Label11.Text = "Randevu Alamazsınız";


            }
            else
            { }

                SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            bag.Open();
            SqlCommand gonderA = new SqlCommand("Select * from Randevular where  TC='" + TxtRTC.Text + "' and Bolum='" + DropDownList1.SelectedItem.Text + "'", bag);
            SqlDataReader dr = gonderA.ExecuteReader();
            if (dr.Read())
            {
                Label11.Visible = true;
                Label11.Text = "Randevu Alamazsınız";
               

            }
            else
            {

                baglanti.Open();
                SqlCommand gond = new SqlCommand("insert into Randevular(Bolum,TC,Ad,Soyad,Tarih,Saat)values('" + DropDownList1.SelectedItem.Text + "','" + TxtRTC.Text + "','" + TxtRAd.Text + "','" + TxtRSoy.Text + "','" + TxtRTarih.Text + "','" + Label2.Text + "' )", baglanti);

                gond.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
                
            TxtRAd.Text = "";



            Label11.Visible = true;
            Label11.Text = "Kaydınız Gerçekleşti";

        }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string ad = "";
            string soy = "";
            string bolum = "";
            string tarih = "";
            string saat = "";

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA = new SqlCommand("Select * from Randevular where TC='" + TextBox1.Text +"' and Tarih = '" + TextBox2.Text +"'", baglanti);
            SqlDataReader dr = gonderA.ExecuteReader();
            if (dr.Read())

            { 
           

                lblAd.Visible = true;
                ad = dr["Ad"].ToString();
                lblAd.Text = ad;
                lblSoy.Visible = true;
                soy = dr["SoyAd"].ToString();
                lblSoy.Text = soy;
                lblBol.Visible = true;
                bolum = dr["Bolum"].ToString();
                lblBol.Text = bolum;
                lblZaman.Visible = true;
                tarih = dr["Tarih"].ToString();
                lblZaman.Text = tarih;
                lblSaat.Visible = true;
                saat = dr["Saat"].ToString();
                lblSaat.Text = saat;
                Label12.Text = "Böyle bir randevu yok";
                Label12.Visible = false;

            }
            else
            {
               Label12.Visible = true;
                    Label12.Text = "Böyle bir randevu yok";
                


            }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T62RT0H\SQLEXPRESS;Initial Catalog=Randevu; Integrated Security=True");
            baglanti.Open();
            SqlCommand gonderA = new SqlCommand("DELETE FROM Randevular WHERE TC='" + TextBox1.Text + "'", baglanti);
            gonderA.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();

            Label12.Visible = true;
                Label12.Text = "Silindi";


            
           

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Güncelle.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }
    }
    }
    

    
        
    