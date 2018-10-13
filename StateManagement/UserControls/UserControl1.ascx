<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl1.ascx.cs" Inherits="StateManagement.UserControls.UserControl1" %>
<h3>This is UserControl 1</h3>

<table>
    <tr>
        <td><asp:Label ID="label1" runat="server" Text="First Name" ></asp:Label></td>
        <td> <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
    </tr>
     <tr>
        <td><asp:Label ID="label2" runat="server" Text="Last Name" ></asp:Label></td>
        <td> <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <dx:ASPxButton ID="ASPxButton1" runat="server" Text="UserControl1 Button" OnClick="ASPxButton1_Click"></dx:ASPxButton>
        </td>
    </tr>

</table>


