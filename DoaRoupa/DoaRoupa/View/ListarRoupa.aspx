<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarRoupa.aspx.cs" Inherits="DoaRoupa.View.ListarRoupa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <h1>Lista de Doação</h1>

    <asp:GridView ID="gvRoupas" runat="server" OnRowCommand="gvRoupas_RowCommand" AutoGenerateColumns="False">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
            <asp:BoundField HeaderText="Código" DataField="Id" />
            <asp:BoundField HeaderText="Nome do Doador" DataField="Doador.Nome" />
            <asp:BoundField HeaderText="Descrição da Roupa" DataField="TipoRoupa" />
            <asp:BoundField HeaderText="Tipo da Roupa" DataField="DescricaoRoupa" />
        </Columns>
    </asp:GridView>

    <hr />
    <hr />

    <asp:Label ID="lblID1" runat="server" Text="ID:"></asp:Label>
    <asp:Label ID="lblID2" runat="server" Text=""></asp:Label>
    <br /><br />


    <asp:Label ID="lblnomeDoardor" runat="server" Text="CPF do Doador"></asp:Label>
    <asp:TextBox ID="txtnomeDoadorEdt" runat="server"></asp:TextBox>
    <br /><br />

    
    <asp:RadioButtonList ID="rdbTipoEdt" runat="server">
        <asp:ListItem Value="Frio" Text="Roupa de frio" runat="server"/>
        <asp:ListItem Value="Calor" Text="Roupa de calor" runat="server"/>
    </asp:RadioButtonList>
    <br /><br />

    <asp:Label ID="lblRoupa" runat="server" Text="Descrição da Roupa"></asp:Label>
    <asp:TextBox ID="txtRoupaEdt" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br /><br />

    <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button CssClass="btn btn-warning" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
