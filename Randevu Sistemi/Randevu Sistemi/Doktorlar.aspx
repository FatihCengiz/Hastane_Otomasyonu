<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doktorlar.aspx.cs" Inherits="Randevu_Sistemi.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <center><div style="width:700px; height:419px;" >


           <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="ID" Width="350px" DataSourceID="SqlDataSource1" ForeColor="#333333" style="margin-left: 0px" RepeatColumns="1">
               <AlternatingItemStyle BackColor="White" />
               <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
               <ItemStyle BackColor="#E3EAEB" />
               <ItemTemplate>
                   <table>
                       <tr>
                <td>    
                   <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Resim") %>' Width="150px" > </asp:Image>
                   <br />
                    </td>
                           <td>
                  
                   Ad:
                   <asp:Label ID="AdLabel" runat="server" Text='<%# Eval("Ad") %>' />
                   <br />
                   Soyad:
                   <asp:Label ID="SoyadLabel" runat="server" Text='<%# Eval("Soyad") %>' />
                   <br />
                   Bolum:
                   <asp:Label ID="BolumLabel" runat="server" Text='<%# Eval("Bolum") %>' />
                   <br />
                   Unvan:
                   <asp:Label ID="UnvanLabel" runat="server" Text='<%# Eval("Unvan") %>' />
                   <br />
                  
<br /></td></tr></table>
               </ItemTemplate>
               <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
           </asp:DataList>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RandevuConnectionString %>" SelectCommand="SELECT * FROM [Doktolar]"></asp:SqlDataSource>


           <br />
           <br />


           </div></center>
</asp:Content>
