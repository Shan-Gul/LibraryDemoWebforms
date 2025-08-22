<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowBooks.aspx.cs" Inherits="LibraryDemoWebforms.UI.ShowBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center">📚 Book List with Author</h2>
    <hr />

    <!-- Book List -->
    <asp:Repeater ID="rptBooks" runat="server" OnItemCommand="rptBooks_ItemCommand">
        <ItemTemplate>
            <div style="margin:10px; padding:10px; border:1px solid #ccc; border-radius:8px;">
                <asp:LinkButton 
                    ID="lnkBook" 
                    runat="server" 
                    CommandName="SelectBook" 
                    CommandArgument='<%# Eval("BookId") %>' 
                    CssClass="btn btn-link">
                    <%# Eval("Title") %>
                </asp:LinkButton>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <hr />
    <!-- Selected Book Details -->
    <asp:Panel ID="pnlBookDetails" runat="server" Visible="false" CssClass="alert alert-info">
        <h4><asp:Label ID="lblTitle" runat="server" /></h4>
        <p><strong>Description:</strong> <asp:Label ID="lblDesc" runat="server" /></p>
        <p><strong>Author:</strong> <asp:Label ID="lblAuthor" runat="server" /></p>
    </asp:Panel>
</asp:Content>
