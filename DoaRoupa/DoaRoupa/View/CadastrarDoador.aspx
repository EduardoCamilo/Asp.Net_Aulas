<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarDoador.aspx.cs" Inherits="DoaRoupa.View.CadastrarDoador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cadastro do Doador</h1>

    <asp:Label ID="lblCPFDoador" runat="server" Text="CPF: "></asp:Label>
    <asp:TextBox ID="txtCPFDoador" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblNomeDoador" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="txtNomeDoador" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblTelefone" runat="server" Text="Telefone:"></asp:Label>
    <asp:TextBox ID="txtTelefoneDoador" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button CssClass="btn btn-warning" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
