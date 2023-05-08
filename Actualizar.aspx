<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualizar.aspx.cs" Inherits="Laboratorio__11.Actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Actualizar Datos</h2>
<p>Buscar universidad&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
</p>
<p>Nuevo nombre de universidad&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Enabled="False" OnClick="Button2_Click" Text="Actualizar" />
</p>
</asp:Content>
