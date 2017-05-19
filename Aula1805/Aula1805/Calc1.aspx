<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc1.aspx.cs" Inherits="Aula1805.Calc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">

      

        <div class="col-md-4">
            <asp:Label ID="lblValor1" runat="server" Text="Primeiro Valor"></asp:Label>
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblValor2" runat="server" Text="Segundo Valor"></asp:Label>
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-3">
            <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btnMais" CssClass="btn btn-primary" runat="server" Text="+" OnClick="btnMais_Click" />
            <asp:Button ID="btnIgual" CssClass="btn btn-primary" runat="server" Text="=" OnClick="btnIgual_Click" />
        </div>
    </div>
        
    



</asp:Content>
