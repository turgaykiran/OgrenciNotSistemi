<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Not Ekle</h2>
    Öğrenci No: <asp:TextBox ID="TxtOgrenciNo" runat="server"></asp:TextBox><br /><br />
    Adı Soyadı: <asp:TextBox ID="TxtAdSoyad" runat="server"></asp:TextBox><br /><br />
    Ders: 
    <asp:DropDownList ID="DropDers" runat="server">
        <asp:ListItem Value="Programlama II">Programlama II</asp:ListItem>
        <asp:ListItem Value="Web Programlama I">Web Programlama I</asp:ListItem>
        <asp:ListItem Value="Veri Tabanı I">Veri Tabanı I</asp:ListItem>
    </asp:DropDownList><br /><br />
    Vize Notu: <asp:TextBox ID="TxtVizeNotu" runat="server"></asp:TextBox><br /><br />
    Final Notu: <asp:TextBox ID="TxtFinalNotu" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet" OnClick="BtnKaydet_Click" /><br /><br />
    <asp:Label ID="BilgiGoster" runat="server" Text=""></asp:Label>
</asp:Content>