<%@ Page Title="Verify Cache" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="redis01.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <p></p> <p></p> 
        <h5>Cache: <label id="lblHit" runat="server" ></label></h5>
        <h5>Prodcuct Price: $<label id="lblPrice" runat="server" ></label></h5>
        

        <asp:Button runat="server" id="btnModifyCache" OnClick="btnModifyCache_Click" class="btn btn-primary btn-md" Text="Add $100 on product" />
    </main>
</asp:Content>
