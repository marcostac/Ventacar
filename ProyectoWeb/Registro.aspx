<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyectoWeb.Registro" %>
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
    .style3
    {
        width: 93px;
    }
</style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 139px;">
    <tr>
        <td class="style2">
            Nmbre paterno</td>
        <td class="style1">
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlNombre" runat="server"></asp:Label>
        </td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            Rut</td>
        <td class="style1">
            <asp:TextBox ID="TxtRut" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlRut" runat="server"></asp:Label>
        </td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            Username</td>
        <td class="style1">
            <asp:TextBox ID="txtUserRegistro" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="controlUser" runat="server"></asp:Label>
            <asp:Label ID="ControlUser2" runat="server"></asp:Label>
        </td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            Sexo</td>
        <td class="style1">
            <asp:RadioButton ID="M" runat="server" Checked="True" 
                oncheckedchanged="M_CheckedChanged" Text="Masculino" />
            <asp:RadioButton ID="F" runat="server" oncheckedchanged="F_CheckedChanged" 
                Text="Femenino" />
        </td>
        <td>
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            E-mail</td>
        <td class="style1">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlEmail" runat="server"></asp:Label>
            <asp:Label ID="ControlEmail2" runat="server"></asp:Label>
        </td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            Contraseña</td>
        <td class="style1">
            <asp:TextBox ID="txtPass1" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlPass1" runat="server"></asp:Label>
        </td>
        <td rowspan="2" class="style3">
            <asp:Label ID="ControlPass3" runat="server"></asp:Label>
        </td>
    </tr>
    <tr >
        <td  class="style2">
            Conf.Contraseña</td>
        <td class="style1">
            <asp:TextBox ID="txtpass2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="ControlPass2" runat="server"></asp:Label>
        </td>
      
    </tr>
    <tr>
        <td class="style2">
            <asp:Button ID="Button1" runat="server" Text="Guardar" 
                onclick="Button1_Click" CssClass="boton" />
        </td>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
    </tr>
</table>

</asp:Content>
