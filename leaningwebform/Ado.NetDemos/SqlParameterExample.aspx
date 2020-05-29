<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlParameterExample.aspx.cs" Inherits="leaningwebform.Ado.NetDemos.SqlParameterExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 34%;
            border-left-style: solid;
            border-left-width: 4px;
            border-right: 4px solid #C0C0C0;
            border-top-style: solid;
            border-top-width: 4px;
            border-bottom: 4px solid #C0C0C0;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 115px;
        }
        .auto-style3 {
            width: 246px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="a"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txta" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="b"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="c"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="d"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="e"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txte" runat="server" style="height: 22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="f"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtf" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" Width="159px" />
    </form>
</body>
</html>
