<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="delete-modal.ascx.cs" Inherits="Agenda.Presentation.UserControl.delete_modal" %>
<input type="hidden" id="hdmValue" runat="server" />
<div id="<%= this.ModalID %>" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title"><%= this.ModalTitulo %></h4>
            </div>
            <div class="modal-body">
                <p>
                    <%= this.ModalContenido %>
                </p>
            </div>
            <div class="modal-footer">
                <button type="button" data-dismiss="modal" class="btn btn-default">No</button>
                <asp:Button ID="btnAccion" runat="server" class="btn btn-default" Text="Si"
                    OnClick="btnAccion_Click" />
            </div>
        </div>
    </div>
</div>


