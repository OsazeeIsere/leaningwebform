<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detailViewExample.aspx.cs" Inherits="leaningwebform.dataBoundControlDemo.detailViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="userName" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" Height="50px" Width="125px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <Fields>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            </asp:DetailsView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPtrainingConnectionString %>" DeleteCommand="DELETE FROM userDetails WHERE (userName = @userName)" InsertCommand="INSERT INTO userDetails(userName, password, email, country) VALUES (@userName, @password, @email, @country)" SelectCommand="SELECT * FROM [userDetails]" UpdateCommand="UPDATE userDetails SET password = @password, email = @email, country = @country WHERE (userName = @userName)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="userName" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="userName" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="country" PropertyName="SelectedValue" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="country" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="userName" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
