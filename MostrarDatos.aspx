<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarDatos.aspx.cs" Inherits="Laboratorio__11.MostrarDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Eliminar universidad</h2>
    <p>
        Universidad a buscar&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Eliminar" Enabled="False" OnClick="Button2_Click" />
    </p>
</asp:Content>
