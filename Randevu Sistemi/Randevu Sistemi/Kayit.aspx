<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="Randevu_Sistemi.Kayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #FFFFFF; padding-left: 100px; padding: 20px; margin: 10px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.3); width:400px; height:480px; margin-top: 40px; top:100px; border-top-left-radius: 25px;
   border-top-right-radius: 25px;
   border-bottom-left-radius: 25px;
   border-bottom-right-radius: 25px; margin-left:565px;"> <center><h2>KAYIT</h2></center>
       <center><asp:TextBox ID="TxtKTC" AutoCompleteType="Disabled" runat="server"  maxlength="11" value="T.C.  Kimlik numaranızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='T.C.  Kimlik numaranızı giriniz' }" onchange="this.beenchanged = true;" Width="350px" Height="30px"></asp:TextBox> <br />
       <br /> <asp:TextBox ID="TxtKAd" AutoCompleteType="Disabled" runat="server" value="Adınızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Adınızı giriniz' }" onchange="this.beenchanged = true;" Width="350px" Height="30px"></asp:TextBox> <br />
       <br /> <asp:TextBox ID="TxtKSoy" AutoCompleteType="Disabled" runat="server" value="Soyadınızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Soyadınızı giriniz' }" onchange="this.beenchanged = true;" Width="350px" Height="30px"></asp:TextBox> <br />
        <br /><asp:TextBox ID="TxtKYas" AutoCompleteType="Disabled" MaxLength="3" runat="server" Visible="True" TextMode="SingleLine" value="Yaşınızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Yaşınızı giriniz' }" onchange="this.beenchanged = true;" Width="350px" Height="30px"></asp:TextBox> <br />
        <br /><asp:TextBox ID="TxtKTel" AutoCompleteType="Disabled" MaxLength="11" runat="server" TextMode="Phone"  value="05__" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Telefon numarasını giriniz' }" onchange="this.beenchanged = true;" Width="350px" Height="30px"></asp:TextBox> <br /> </center>
      <div style="margin-left:20px;">  <br /> <asp:TextBox ID="TxtKSifre" AutoCompleteType="Disabled" MaxLength="6" runat="server"  value="Şifre giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Şifre giriniz' }" onchange="this.beenchanged = true;" Width="170px" Height="30px"></asp:TextBox> <br />
       <br /></div>

           <div style="position:absolute; margin-left:240px; margin-top:-50px;"><asp:Button ID="BtnKKayıt" runat="server" Text="KAYIT" Width="120px" Height="95px" OnClick="BtnKKayıt_Click"></asp:Button></div>
      
       &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Button1" runat="server" Height="30px" Text="&lt;&lt;&lt; Geri" Width="117px" OnClick="Button1_Click" />
     
       <br />
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
      
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
   </div>
</asp:Content>
