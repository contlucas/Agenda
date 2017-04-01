<%@ Page Title="Contactos" Language="C#" MasterPageFile="~/child.master" AutoEventWireup="true" CodeBehind="contactos.aspx.cs" Inherits="Agenda.Presentation.contactos.contactos" %>

<%@ Register Src="~/UserControl/delete-modal.ascx" TagPrefix="modal" TagName="delete" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function deleteContacto(id) { $("#hdmValue").val(id); }
    </script>
</asp:Content>
<asp:Content ContentPlaceHolderID="content" runat="server">
    <modal:delete runat="server"
        ModalID="modalContactos"
        ModalTitulo="Contactos"
        ModalContenido="¿Desea eliminar el contacto?" />
    <div class="text-right">
        <asp:HyperLink runat="server" NavigateUrl="~/contactos/create.aspx?editmode=false">Crear contacto</asp:HyperLink>
    </div>
    <div class="panel panel-default">
        <div class="panel-heading">
            <h4>Listado de contactos</h4>
        </div>
        <div class="panel-body">
            <asp:Repeater ID="repeater" runat="server" ItemType="Agenda.Model.Contacto">
                <HeaderTemplate>
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>
                                    <label>Nombre</label></th>
                                <th>
                                    <label>Apellido</label></th>
                                <th>
                                    <label>Edad</label></th>
                                <th></th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label></td>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Apellido") %>'></asp:Label></td>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Edad") %>'></asp:Label></td>
                        <td align="right">
                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# Eval("ID", "~/contactos/create.aspx?id={0}&editmode=true") %>'
                                CssClass="btn btn-default" role="button">Editar</asp:HyperLink>

                            <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#modalContactos"
                                onclick='<%# Eval("ID", "deleteContacto({0})") %>'>
                                Eliminar</button>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
