<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="Aula2505.Views.Categorias.CadastroCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro de Categorias</h1>
    <br />
    
        <asp:Label ID="Nome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Label ID="Descrição" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
        <asp:CheckBox ID="ckbAtivo" runat="server" />
        <br /><br />

        <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <asp:Button CssClass="btn btn-primary" ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button CssClass="btn btn-danger" ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
        <asp:Button CssClass="btn btn-info" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

        

</asp:Content>
