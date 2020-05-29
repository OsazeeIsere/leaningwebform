<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radiobuttonexample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.radiobuttonexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
            background-color: #808000;
        }
        .auto-style2 {
            width: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Allowances"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="Allowances" OnCheckedChanged="RadioButton1_CheckedChanged" Text="HRA" />
                        <br />
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Allowances" OnCheckedChanged="RadioButton2_CheckedChanged" Text="CA" />
                        <br />
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Allowances" OnCheckedChanged="RadioButton3_CheckedChanged" Text="MA" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Net Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
