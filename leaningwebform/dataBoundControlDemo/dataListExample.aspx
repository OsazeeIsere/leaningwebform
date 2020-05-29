<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataListExample.aspx.cs" Inherits="leaningwebform.dataBoundControlDemo.dataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPtrainingConnectionString %>" SelectCommand="SELECT * FROM [userDetails]"></asp:SqlDataSource>
        </div>
        <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyField="userName" DataSourceID="SqlDataSource1" ForeColor="Black" RepeatColumns="2">
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <AlternatingItemTemplate>
                <strong>
                <asp:Label ID="userNameLabel" runat="server" Text='<%# Eval("userName") %>' />
                </strong>
                <br />
                <strong>
                <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                </strong>
                <br />
                <strong>
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                </strong>
                <br />
                <strong>
                <asp:Label ID="countryLabel" runat="server" Text='<%# Eval("country") %>' />
                </strong>
            </AlternatingItemTemplate>
            <FooterStyle BackColor="Tan" />
            <FooterTemplate>
                End Of List Of Users
            </FooterTemplate>
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <HeaderTemplate>
                List Of Users
            </HeaderTemplate>
            <ItemTemplate>
                &nbsp;<asp:Label ID="userNameLabel" runat="server" Text='<%# Eval("userName") %>' />
                <br />
                <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                <br />
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                <br />
                <asp:Label ID="countryLabel" runat="server" Text='<%# Eval("country") %>' />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataList>
    </form>
</body>
</html>
