<%@ Page Title="PickACar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto.UI.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <link rel="stylesheet" href="Content/Inicio.css" />
    </head>
    <body>
        <div class="Titulo">
            <h1>Bienvenido a PickACar</h1>
        </div>
        <div id="Busqueda">
            <h3>¿Cómo desea buscar su carro?</h3>
            <div>
                <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#MarcaModelo">Marca y Modelo</a></li>
                    <li><a data-toggle="tab" href="#Precio">Precio</a></li>
                </ul>
                <div class="tab-content">
                    <div id="MarcaModelo" class="tab-pane fade in active">
                        <asp:Label ID="Label1" runat="server" Text="Marca"></asp:Label>
                        <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:Label ID="Label2" runat="server" Text="Modelo"></asp:Label>
                        <asp:DropDownList ID="ddlModelo" runat="server" CssClass="form-control"></asp:DropDownList>
                        <br />
                        <asp:Button ID="btnBuscarMM" runat="server" Text="Buscar" CssClass="btn btn-default" OnClick="btnBuscarMM_Click"/>
                    </div>
                    <div id="Precio" class="tab-pane fade">
                        <asp:Label ID="Label3" runat="server" Text="Precio Mínimo"></asp:Label>
                        <asp:TextBox ID="tbMinimo" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Label ID="L" runat="server" Text="Precio Máximo"></asp:Label>
                        <asp:TextBox ID="tbMaximo" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnBuscarP" runat="server" Text="Buscar" CssClass="btn btn-default" OnClick="btnBuscarP_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </body>
</asp:Content>
