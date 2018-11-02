<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<%@ Register Assembly="ControleMessageBox" Namespace="ControleMessageBox" TagPrefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Style.css" rel="stylesheet" />


</head>

<body>
    

    <form id="form1" runat="server" class="form-horizontal">
        <div class="bg-success">


        <img src="Imagens/Prefeitura.png" /> 


    </div>
        <div class="form-group">
            &nbsp;&nbsp;
        <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BackColor="" GroupingText="">
                <div class="form-group">
                    <div class="col-6 cols1">
                        <asp:Label ID="Label1" runat="server" Text="Usuario" class="col-md-4 control-label" Width="312px"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" Height="32px" Style="margin-left: 0px" Width="310px" CssClass="form-control input-md"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="* Campo Obrigatorio"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Senha" class="col-md-4 control-label" CssClass="col-md-4 control-label" Width="312px"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" Style="margin-left: 0px" Width="311px" Height="34px" CssClass="form-control input-md"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="* Campo Obrigatorio"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" CssClass="btn btn-success mr-4 mt-3 px-4" />
                        <br />
                        <br />
                          </div>
                          </div>
            </asp:Panel>
            <br />
            <br />
      
        </div>
        <cc1:MessageBox ID="MessageBox1" runat="server" />
    </form>
    
</body>
</html>
