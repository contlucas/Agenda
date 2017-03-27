<%@ Page Title="" Language="C#" MasterPageFile="~/base.Master" AutoEventWireup="true" CodeBehind="error-page.aspx.cs" Inherits="Agenda.Presentation.errors.error_page" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="content" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3><%= this.statusCode + " " + this.encabezadoPage %></h3>
        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col-sm-5">
                    <asp:Image runat="server" ImageUrl="~/Content/img/one-punch-man.png" />
                </div>
                <div class="col-sm-7">
                    <%= this.mensajePage %>
                </div>
            </div>
        </div>
        <div class="panel-footer text-right">
            <asp:HyperLink runat="server" NavigateUrl="~/default.aspx">Volver</asp:HyperLink>
        </div>
    </div>
</asp:Content>
