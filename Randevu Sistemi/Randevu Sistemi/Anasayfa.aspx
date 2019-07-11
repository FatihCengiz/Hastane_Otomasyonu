<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="Randevu_Sistemi.Anasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="position:absolute; margin-left:560px; margin-top:50px;"><asp:Image src="images/Logo.png" ID="Image2" runat="server" Width="60px" /><h3 style="margin-left:90px; margin-top:-40px;">Hastane Randevu Merkezi</h3></div>
    <div style="background-color: #FFFFFF;  padding-left: 100px; padding: 20px; margin: 10px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.3); width:400px; height:245px; margin-top: 130px; top:100px; border-top-left-radius: 25px;
   border-top-right-radius: 25px;
   border-bottom-left-radius: 25px;
   border-bottom-right-radius: 25px; margin-left:460px;">&nbsp;
    <center>  <asp:TextBox  ID="TxtTC" AutoCompleteType="Disabled" runat="server" TextMode="SingleLine" maxlength="11" value="T.C.  Kimlik numaranızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='T.C.  Kimlik numaranızı giriniz' }" onchange="this.beenchanged = true;" Width="350px" Height="30px" Visible="True"  ></asp:TextBox>
</center>
   <div style="margin-top:20px; margin-left:23px;"> <asp:TextBox ID="TxtSifre" AutoCompleteType="Disabled" runat="server"  value="Şifreniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Şifreniz' }" onchange="this.beenchanged = true;" Width="170px" Height="30px" Visible="True" TextMode="SingleLine"></asp:TextBox>
   
        &nbsp;
   
       <asp:Button ID="BtnSH" runat="server" Text="Hatırlamıyorum" Width="170px" Height="37px" OnClick="BtnSH_Click" />

        </div>
   <center>    <div style="margin:15px;">
            <asp:Button ID="BtnGiris" runat="server" Text="Giriş" Width="355px" Height="40px" OnClick="BtnGiris_Click" />
        </div>
        <div style="margin:15px;">
            <asp:Button ID="BtnKayit" runat="server" Text="Kayıt" Width="355px" Height="40px" OnClick="BtnKayit_Click" />  <br />   <br /> 

            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

     <br /> 
       <br />  
     <br />   
           
            <br />

        </div></center> 
    </div>
 

</asp:Content>