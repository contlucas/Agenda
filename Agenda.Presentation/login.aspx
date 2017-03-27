<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/base.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Agenda.Presentation.login" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="content" runat="server">
    <div class="panel panel-default">
        <div class="panel-body">
            <div class="form-group row">
                <label class="control-label col-sm-3" for="txtUsuario">Nombre de usuario</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtUsuario" runat="server" MaxLength="10"
                        CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="control-label col-sm-3" for="txtPassword">Contraseña</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtPassword" runat="server" MaxLength="20" TextMode="Password"
                        CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-3"></div>
                <div class="col-sm-9">
                    <asp:CheckBox ID="chkRemberMe" runat="server" Text="Recordarme"
                        CssClass="checkbox-inline" />
                </div>
            </div>
        </div>
        <div class="panel-footer">
            <div class="row">
                <div class="col-sm-6">
                    <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
                <div class="col-sm-6 text-right">
                    <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" OnClick="btnLogin_Click"
                        CssClass="btn btn-default" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
