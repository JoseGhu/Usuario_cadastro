<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Usuario_cadastro.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-color:orangered;
            font-family Arial, Helvetica, sans-serif;
            font-size: 20px;
        }
        h1{
            color:white;
        }
       

    </style>
        
</head>

<body>

    <h1>
        Cadastro de Usuario Ultilizando Asp.net e C#!
    </h1>

    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Id:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Nome:
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Telefone:
                    </td>
                    <td>
                        <asp:TextBox ID="TxtTelefone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        CPF:
                    </td>
                    <td>
                        <asp:TextBox ID="TxtCpf" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="BtnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click" />
                        <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
                        <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </form>
</body>
</html>
