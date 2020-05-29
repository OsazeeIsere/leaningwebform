<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="navigationalcontrolexample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.navigationalcontrolexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 106px;
            background-color: #008080;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" NavigateUrl="~/standardcontroldemo/textboxexample.aspx">Goto TBE</asp:HyperLink>
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/OZ.LOGO3.png" Height="100px" OnClick="ImageButton1_Click1" Width="400px" />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="White" OnClick="LinkButton1_Click">Goto TBE</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
