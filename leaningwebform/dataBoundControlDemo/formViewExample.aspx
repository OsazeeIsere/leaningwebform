<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formViewExample.aspx.cs" Inherits="leaningwebform.dataBoundControlDemo.formViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ASPtrainingConnectionString %>" SelectCommand="SELECT * FROM [userDetails]"></asp:SqlDataSource>
        </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="userName" DataSourceID="SqlDataSource2" ForeColor="Black">
            <EditItemTemplate>
                userName:
                <asp:Label ID="userNameLabel1" runat="server" Text='<%# Eval("userName") %>' />
                <br />
                password:
                <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                <br />
                email:
                <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                <br />
                country:
                <asp:TextBox ID="countryTextBox" runat="server" Text='<%# Bind("country") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <InsertItemTemplate>
                userName:
                <asp:TextBox ID="userNameTextBox" runat="server" Text='<%# Bind("userName") %>' />
                <br />
                password:
                <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                <br />
                email:
                <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                <br />
                country:
                <asp:TextBox ID="countryTextBox" runat="server" Text='<%# Bind("country") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Dear
                <asp:Label ID="userNameLabel" runat="server" Text='<%# Eval("userName") %>' />
                <br />
                As per your request, a new password has been created i.e&nbsp;<asp:Label ID="passwordLabel" runat="server" Text='<%# Bind("password") %>' />
                <br />
                And it has already been emailed to the email id i.e
                <asp:Label ID="emailLabel" runat="server" Text='<%# Bind("email") %>' />
                <br />
                <br />
                No Regards<br /> Someone<br />

            </ItemTemplate>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        </asp:FormView>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
