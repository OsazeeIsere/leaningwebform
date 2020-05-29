<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="leaningwebform.MembershipDemo.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Site
            <asp:LoginName ID="LoginName1" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/MembershipDemo/Login.aspx" />
            <br />
            <br />
        </div>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <asp:Label ID="Label1" runat="server" Text="You are Guest User"></asp:Label>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" ContinueDestinationPageUrl="~/MembershipDemo/Login.aspx" Font-Names="Verdana" Font-Size="10pt">
                    <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
                </asp:ChangePassword>
            </LoggedInTemplate>
        </asp:LoginView>
    </form>
</body>
</html>
