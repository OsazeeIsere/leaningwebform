<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DPExample.aspx.cs" Inherits="leaningwebform.DataPersistentTechniquesDemos.DPExample" %>

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
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Write into View State" />
                    </td>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Read from view state" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Write to Session" />
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Read from Session" />
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Read Session Data in Another Page" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Sign Out" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Write to Cookie" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Read from Cookie" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>
</body>
</html>
