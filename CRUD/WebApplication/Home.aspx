<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-3.0.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Avaliação de Conhecimentos – Programador C#</h1>

            Selecione a operação desejada:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" text="- Escolha uma opção -" />
                <asp:ListItem Value="1" text="Cadastrar Empresa" />
                <asp:ListItem Value="2" text="Consultar Empresa" />
            </asp:DropDownList>
            <asp:Button ID="btnMenu" runat="server" text="Acessar" CssClass="btn btn-primary btn-lg"/>
            <p>
                <asp:Label ID="lblMensagem" runat="server"/>
            </p>
        </div>
    </form>
</body>
</html>
