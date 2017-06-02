<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarRoupa.aspx.cs" Inherits="DoaRoupa.View.ListarRoupa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Lista de Doação</h1>

    <asp:GridView ID="gvRoupas" runat="server" OnRowCommand="gvRoupas_RowCommand">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
</asp:Content>
