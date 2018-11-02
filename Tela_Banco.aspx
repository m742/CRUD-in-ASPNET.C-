<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tela_Banco.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="ControleMessageBox" Namespace="ControleMessageBox" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    


</head>
        <link href="Style.css" rel="stylesheet" />
        <script src="Scripts/jquery-3.0.0.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
<body>
    <div class="bg-success">
        <img src="Imagens/Prefeitura.png" />

    </div>
    <form id="form1" runat="server">
        &nbsp;<br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server" EnableTheming="True">
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="USUA_CODIGO" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" ShowFooter="True" >
                    <Columns>
                        <asp:BoundField DataField="USUA_CODIGO" HeaderText="CODIGO" />
                        <asp:BoundField DataField="USUA_NOME" HeaderText="NOME" />
                        <asp:BoundField DataField="USUA_LOGIN" HeaderText="LOGIN" />
                        <asp:BoundField DataField="USUA_STATUS" HeaderText="STATUS" />
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Editar" />
                    </Columns>
                    <PagerSettings Mode="NumericFirstLast" />
                </asp:GridView>
              
                <br />
                <asp:Button ID="ButtonNovo" runat="server" OnClick="ButtonNovo_Click" Text="Novo" CssClass="btn btn-success mr-4 mt-3 px-4" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Label ID="labellogin" runat="server" Text="Login" CssClass="col-md-4 control-label"></asp:Label>
                <br />
                <asp:TextBox ID="txtlogin" runat="server" MaxLength="45" CssClass="form-control input-md" Width="240px"></asp:TextBox>
                &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtlogin" ErrorMessage="* Campo Obrigatorio"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="labelnome" runat="server" Text="Nome" CssClass="col-md-4 control-label"></asp:Label>
                <br />
                <asp:TextBox ID="txtnome" runat="server" MaxLength="100" Height="26px" Width="356px" Style="margin-right: 0px" CssClass="form-control input-md"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnome" ErrorMessage="* Campo Obrigatorio"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="labelstatus" runat="server" Text="Status" CssClass="col-md-4 control-label"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="130px">
                    <asp:ListItem Value="1">ATIVO</asp:ListItem>
                    <asp:ListItem Value="0">INATIVO</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<br />
                <br />
                <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Salvar" CssClass="btn btn-success mr-4 mt-3 px-4" />
                <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="Button1_Click" Text="Voltar" CssClass="btn btn-success mr-4 mt-3 px-4" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Excluir" CssClass="btn btn-success mr-4 mt-3 px-4" />
                <br />
                <br />
                <cc1:MessageBox ID="MessageBox2" runat="server" />
                <br />
                <br />
            </asp:View>


        </asp:MultiView>
        <br />




        <br />
        <br />


        
    </form>
</body>
</html>
