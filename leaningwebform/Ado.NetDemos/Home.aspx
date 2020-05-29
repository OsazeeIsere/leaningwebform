<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="leaningwebform.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Change Password</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Change Profile</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Unsubscribe</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="List All Users" />
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">SignOut</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
