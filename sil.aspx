<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sil.aspx.cs" Inherits="sil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Not Sil</h2>
    Öğrenci No: <asp:TextBox ID="TxtOgrenciNo" runat="server"></asp:TextBox><br /><br />
    Ders: 
    <asp:DropDownList ID="DropDers" runat="server">
        <asp:ListItem Value="Programlama II">Programlama II</asp:ListItem>
        <asp:ListItem Value="Web Programlama I">Web Programlama I</asp:ListItem>
        <asp:ListItem Value="Veri Tabanı I">Veri Tabanı I</asp:ListItem>
    </asp:DropDownList><br /><br />
    <asp:Button ID="BtnSil" runat="server" Text="Sil" OnClick="BtnSil_Click" /><br /><br />
    <asp:Label ID="BilgiGoster" runat="server" Text=""></asp:Label>
</asp:Content>