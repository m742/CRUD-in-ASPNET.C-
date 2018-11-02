<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alterações Banco.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="ControleMessageBox" namespace="ControleMessageBox" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <img src="Imagens/Prefeitura.png" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text3 {
            margin-left: 21px;
        }
        #Text4 {
            height: 17px;
            margin-left: 10px;
        }
        #Text1 {
            margin-left: 12px;
        }
        #Text2 {
            margin-left: 8px;
        }
        #Login1 {
            margin-left: 23px;
        }
        #Nome1 {
            margin-left: 47px;
        }
        #Senha1 {
            margin-left: 41px;
        }
        #Status1 {
            margin-left: 9px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderColor="White" GroupingText="Painel 1">
            <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
            &nbsp;<asp:TextBox ID="Login" runat="server" style="margin-left: 5px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="SENHA"></asp:Label>
            &nbsp;<asp:TextBox ID="Senha" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="NOME"></asp:Label>
            &nbsp;<asp:TextBox ID="Nome" runat="server" style="margin-left: 7px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Cancelar" Width="64px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Salvar" Width="60px" />
            <asp:Button ID="Button2" runat="server" Height="22px" style="margin-top: 0px; margin-left: 2px;" Text="Excluir" Width="62px" OnClick="Button2_Click" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="* Para Exclusão de usuario, escrever apenas login"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="* Para inclusão de usuário, informar todos os campos"></asp:Label>
            <br />
        </asp:Panel>
        <br />
        <br />
        <cc1:MessageBox ID="MessageBox1" runat="server" />
        <br />
        <br />
        <br />
        &nbsp;
        <br />
        <br />
&nbsp;<br />
        <br />

        <br />

        <br />
        <br />
        <br />
        <br />
    

        
       

       </div>
    </form>
</body>
</html>
