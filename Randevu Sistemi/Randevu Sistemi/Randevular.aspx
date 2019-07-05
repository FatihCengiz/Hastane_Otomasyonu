<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"  MaintainScrollPositionOnPostBack="true" AutoEventWireup="true" CodeBehind="Randevular.aspx.cs" Inherits="Randevu_Sistemi.Randevular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="background-color: #FFFFFF; float:left; padding-left: 100px; padding: 20px; margin: 10px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.3); width:400px; height:700px; margin-top: 120px; top:100px; border-top-left-radius: 25px;
   border-top-right-radius: 25px;
   border-bottom-left-radius: 25px;
   border-bottom-right-radius: 25px; margin-left:50px;"> <center><h2>RANDEVU AL</h2>
            <br /> 
      
        <br />  <asp:DropDownList ID="DropDownList1" runat="server" Width="300px" Height="30px" ></asp:DropDownList> <br>
        <br /><asp:TextBox ID="TxtRTC" AutoCompleteType="Disabled" runat="server"  maxlength="11" value="T.C.  Kimlik numaranızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='T.C.  Kimlik numaranızı giriniz' }" onchange="this.beenchanged = true;" Width="300px" Height="30px"></asp:TextBox> <br />
        <br /> <asp:TextBox ID="TxtRAd" AutoCompleteType="Disabled" runat="server" value="Adınızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Adınızı giriniz' }" onchange="this.beenchanged = true;" Width="300px" Height="30px"></asp:TextBox> <br />
        <br /> <asp:TextBox ID="TxtRSoy" AutoCompleteType="Disabled" runat="server" value="Soyadınızı giriniz" onfocus="if(this.beenchanged!=true){ this.value = ''}" onblur="if(this.beenchanged!=true) { this.value='Soyadınızı giriniz' }" onchange="this.beenchanged = true;" Width="300px" Height="30px"></asp:TextBox> <br />
        <br /><asp:TextBox ID="TxtRTarih" AutoCompleteType="Disabled" runat="server" TextMode="Date" Width="300px" Height="30px"></asp:TextBox> <br />
        </center>
       <center><br /><div style="display:block; padding:10px; ">
           
                
                    <asp:Button ID="S_8" runat="server" Text="08:00" Width="60px" OnClick="S_8_Click"  />
                &nbsp; &nbsp;
                    <asp:Button ID="S_9" runat="server" Text="09:00" Width="60px " OnClick="S_9_Click" />
                &nbsp; &nbsp;
                    <asp:Button ID="S_10" runat="server" Text="10:00" Width="60px" OnClick="S_10_Click" />
                </div>
       <div style="display:block; padding:10px;">
                    <asp:Button ID="S11" runat="server" Text="11:00" Width="60px" OnClick="S11_Click"  />
                 &nbsp; &nbsp;
                    <asp:Button ID="S12" runat="server" Text="12:00" Width="60px" OnClick="S12_Click"  />
                 &nbsp; &nbsp;
                    <asp:Button ID="S13" runat="server" Text="13:00" Width="60px" OnClick="S13_Click"  />
                </div>
             <div style="display:block; padding:10px;">
                    <asp:Button ID="S14" runat="server" Text="14:00" Width="60px" OnClick="S14_Click" />
            &nbsp; &nbsp;
                
                    <asp:Button ID="S15" runat="server" Text="15:00" Width="60px" OnClick="S15_Click"  />
                 &nbsp; &nbsp;
                    <asp:Button ID="S16" runat="server" Text="16:00" Width="60px" OnClick="S16_Click" style="height: 26px" />
                

            </div></center>
           <div style="position:absolute; margin-left:119px; margin-top:20px; top: 798px; left: 75px;"><asp:Button ID="BtnKKayıt" runat="server" Text="KAYIT" Width="150px" Height="70px" OnClick="BtnKKayıt_Click"></asp:Button></div>
      
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Durum"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="00:00"></asp:Label>
        <br />
        <asp:Label ID="lbT" runat="server" Text="deneme"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Text="Label" Visible="False" Width="120px"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              
   </div>
        <div style="background-color: #FFFFFF; float:left; padding-left: 700px; padding: 20px; margin: 10px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.3); width:700px; height:680px; margin-top: 120px; top:100px; border-top-left-radius: 25px;
   border-top-right-radius: 25px;
   border-bottom-left-radius: 25px;
   border-bottom-right-radius: 25px; margin-left:50px;"> <center><h2>RANDEVULARIM</h2>
                <h2>&nbsp;</h2>
                <h2>
                    <asp:Label ID="Label3" runat="server" Text="T.C No :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" AutoCompleteType="Disabled" runat="server" Height="20px" Width="216px" MaxLength="11"></asp:TextBox>
                </h2>
                <h2>
                    <asp:Label ID="Label10" runat="server" Text="Bolum : "></asp:Label>
                    <asp:TextBox ID="TextBox2" AutoCompleteType="Disabled" runat="server" Height="19px" Width="216px" TextMode="Date"></asp:TextBox>
                </h2>
                <p>&nbsp;</p>
                <h2>
                    <asp:Label ID="lblAd" runat="server" Text="Label" Visible="False"></asp:Label>
                </h2>
                <h2>
                    <asp:Label ID="lblSoy" runat="server" Text="Label" Visible="False"></asp:Label>
                </h2>
                <h2>
                    <asp:Label ID="lblBol" runat="server" Text="Label" Visible="False"></asp:Label>
                </h2>
                <h2>
                    <asp:Label ID="lblZaman"  runat="server" Text="Label" Visible="False"></asp:Label>
                </h2>
                <h2>
                    <asp:Label ID="lblSaat" runat="server" Text="Label" Visible="False"></asp:Label>
                </h2>
                <h2>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="44px" Text="Sorgula" Width="88px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="46px" Text="Randevu Sil" Width="83px" OnClick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Height="117px" OnClick="Button3_Click" Text="Kişi Bilgilerini Güncelle" Width="163px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </h2>
                <h2>
                    <asp:Label ID="Label12" runat="server" Text="Label" Visible="False"></asp:Label>
                </h2>
                <p>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Exit" Width="153px" />
                </p>
            </center>
            </div>


</asp:Content>
