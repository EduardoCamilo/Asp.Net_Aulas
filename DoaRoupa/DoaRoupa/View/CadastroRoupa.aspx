<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroRoupa.aspx.cs" Inherits="DoaRoupa.View.CadastroRoupa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cadastro de Roupa</h1>

    <asp:Label ID="lblnomeDoardor" runat="server" Text="Nome do Doador"></asp:Label>
    <asp:TextBox ID="txtnomeDoador" runat="server"></asp:TextBox>
    <br /><br />

    
    <asp:RadioButtonList ID="rdbTipo" runat="server">
        <asp:ListItem Value="frio" Text="Roupa de frio" runat="server"/>
        <asp:ListItem Value="calor" Text="Roupa de calor" runat="server"/>
    </asp:RadioButtonList>
    <br /><br />

    <asp:Label ID="lblRoupa" runat="server" Text="Descrição da Roupa"></asp:Label>
    <asp:TextBox ID="txtRoupa" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br /><br />

    <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button CssClass="btn btn-warning" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
