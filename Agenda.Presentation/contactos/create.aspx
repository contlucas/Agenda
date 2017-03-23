<%@ Page Title="Crear un nuevo contacto" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="Agenda.Presentation.contactos.create" %>

<asp:Content ContentPlaceHolderID="head" runat="server" ClientIDMode="Static">
</asp:Content>
<asp:Content ContentPlaceHolderID="content" runat="server" ClientIDMode="Static">
    <div class="panel panel-default">
        <div class="panel-body">
            <div class="form-group row">
                <label class="control-label col-sm-2" for="txtNombre">Nombre</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtNombre" runat="server" MaxLength="50"
                        CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="control-label col-sm-2" for="txtApellido">Apellido</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtApellido" runat="server" MaxLength="50"
                        CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="control-label col-sm-2" for="txtEdad">Edad</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtEdad" runat="server" MaxLength="50"
                        CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="panel-footer text-right">
            <asp:HyperLink runat="server" CssClass="btn btn-default" role="button"
                NavigateUrl="~/contactos/contactos.aspx">Cancelar</asp:HyperLink>
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-success"
                Text="Guardar" 
                OnClientClick="return confirm('¿Desea guardar los cambios?'"
                OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
