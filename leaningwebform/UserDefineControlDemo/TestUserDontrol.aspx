<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestUserDontrol.aspx.cs" Inherits="leaningwebform.UserDefineControlDemo.TestUserDontrol" %>

<%@ Register src="Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<%@ Register src="UserList.ascx" tagname="UserList" tagprefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <uc1:Header ID="Header1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc3:UserList ID="UserList1" runat="server" Country="USA" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc2:Footer ID="Footer1" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
