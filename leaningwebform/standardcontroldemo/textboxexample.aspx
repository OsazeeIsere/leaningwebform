<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="textboxexample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.textboxexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 5px solid #FF0000;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 129px;
        }
        .auto-style3 {
            width: 129px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            width: 129px;
            height: 27px;
        }
        .auto-style6 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtemployeenamme" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Salary"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtsalary" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="HRA"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txthra" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblta" runat="server" Text="TA"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtta" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="MA"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtma" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Net Salary"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnetsalary" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Profile"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Height="125px" TextMode="MultiLine" Width="239px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Access Code"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtaccessscode" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btncalculate" runat="server" OnClick="btncalculate_Click" Text="Calculate" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btncancel" runat="server" OnClick="Button2_Click" Text="Cancel" />
                </td>
            </tr>
        </table>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
