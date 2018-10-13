<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="StateManagement._Default" %>


<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    <hr />
    <dx:ASPxButton ID="ASPxButton1" runat="server" OnClick="btnSubmit_Click1" Text="Load UserControl 1"></dx:ASPxButton>
    <dx:ASPxButton ID="ASPxButton2" runat="server" OnClick="btnSubmit_Click2" Text="Load UserControl 2"></dx:ASPxButton>
    <dx:ASPxButton ID="ASPxButton3" runat="server" OnClick="btnSubmit_Click3" Text="Load UserControl 3"></dx:ASPxButton>

    <asp:PlaceHolder ID="Placeholder1" runat="server"></asp:PlaceHolder>


</asp:Content>
