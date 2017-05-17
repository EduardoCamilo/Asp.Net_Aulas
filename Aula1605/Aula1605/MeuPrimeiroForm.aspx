<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeuPrimeiroForm.aspx.cs" Inherits="Aula1605.MeuPrimeiroForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Meu Primeiro Form </h1>


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <asp:Label ID="lblnome" runat="server" Text="Nome:"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Campo Nome é Obrigatório"></asp:RequiredFieldValidator>
            </div>
            <div class="row">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
                <asp:CheckBox ID="chkAtivo" runat="server" />
            </div>
            
            <br />
            <div class="row">
                <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                <asp:Button CssClass="btn btn-danger" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="false" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
