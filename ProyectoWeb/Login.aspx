<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        width: 285px;
    }
    .style2
    {
        width: 183px;
    }
</style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 96%; height: 155px;" id="tblLogin">
    <tr>
        <td class="style2">
            Username</td>
        <td class="style1">
            <asp:TextBox ID="txtUserLogin" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlUserLogin" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Contraseña</td>
        <td class="style1">
            <asp:TextBox runat="server" ID="txtPassLogin"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlPassLogin" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Button ID="btnAseptarLogin" runat="server" Text="Aseptar" 
                onclick="Button1_Click" class="boton" />
        </td>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
