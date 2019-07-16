<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bolumler.aspx.cs" Inherits="Randevu_Sistemi.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><div style="height:auto; width:500px; background-color:greenyellow;">


            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Forecolor="White" >
            </asp:GridView>
            <br />
            <asp:Label ID="lblmsj" runat="server" Text="Label"></asp:Label>


            </div></center>
</asp:Content>
