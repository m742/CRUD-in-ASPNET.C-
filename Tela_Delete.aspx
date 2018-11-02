<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tela_Delete.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="ControleMessageBox" namespace="ControleMessageBox" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    


        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Informe o nome do usuario"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 17px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </asp:Panel>
    


    </div>
        <cc1:MessageBox ID="MessageBox1" runat="server" />
    </form>
</body>
</html>
