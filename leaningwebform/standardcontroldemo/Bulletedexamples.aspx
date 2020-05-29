<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bulletedexamples.aspx.cs" Inherits="leaningwebform.standardcontroldemo.Bulletedexamples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 2px solid #808000;
            background-color: #00FF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Numbered" DisplayMode="LinkButton" OnClick="BulletedList1_Click">
                            <asp:ListItem>Nigeria</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                        </asp:BulletedList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:BulletedList ID="BulletedList2" runat="server">
                        </asp:BulletedList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="177px" Width="607px">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
