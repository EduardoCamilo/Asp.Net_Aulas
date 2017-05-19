<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc2.aspx.cs" Inherits="Aula1805.Calc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Resultados</h1>

    <br />
    <%--"cabeçalho"--%>
    <div class="row">

        <div class="col-md-4">
            <b><asp:Label ID="lblValor1" runat="server" Text="Primeiro Valor"></asp:Label></b>
        </div>
        <div class="col-md-4">
            <b><asp:Label ID="lblValor2" runat="server" Text="Segundo Valor"></asp:Label></b>
        </div>
        <div class="col-md-4">
            <b><asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label></b>
        </div>
    </div>
    <br />
    <%--Linha de Adição--%>
    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtValor1Mais" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblMais" runat="server" Text="+"></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtValor2Mais" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblResultMais" runat="server" Text="="></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtResultadoMais" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <%--Linha de Subtração--%>
    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtValor1Menos" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblMenos" runat="server" Text="-"></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtValor2Menos" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblResultMenos" runat="server" Text="="></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtResultadoMenos" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <%--Linha de Multiplicação--%>
    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtValor1Mult" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblMult" runat="server" Text="*"></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtValor2Mult" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblResultMult" runat="server" Text="="></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtResultadoMult" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <%--Linha de Divisão--%>
    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtValor1Div" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblDiv" runat="server" Text="/"></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtValor2Div" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2" align="center">
            <b><asp:Label ID="lblResultDiv" runat="server" Text="="></asp:Label></b>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtResultadoDiv" runat="server"></asp:TextBox>
        </div>
    </div>


</asp:Content>
