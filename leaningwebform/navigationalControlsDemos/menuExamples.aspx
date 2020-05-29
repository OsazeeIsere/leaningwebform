<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuExamples.aspx.cs" Inherits="leaningwebform.navigationalControlsDemos.menuExamples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/myMenu.xml"></asp:XmlDataSource>
            <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem Text="Standard Controls" Value="Standard Controls">
                        <asp:MenuItem NavigateUrl="~/standardcontroldemo/textboxexample.aspx" Text="Text Box" Value="Text Box"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/standardcontroldemo/checkboxexample.aspx" Text="Check Box" Value="Check Box"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/standardcontroldemo/radiobuttonexample.aspx" Text="Radio Button" Value="Radio Button"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Data Bound Controls" Value="Data Bound Controls">
                        <asp:MenuItem NavigateUrl="~/dataBoundControlDemo/gridViewExample.aspx" Text="Grid View" Value="Grid View"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/dataBoundControlDemo/detailViewExample.aspx" Text="Detail View" Value="Detail View"></asp:MenuItem>
                        <asp:MenuItem Text="Form View" Value="Form View"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />
            </asp:Menu>
        </div>
        <asp:Menu ID="Menu2" runat="server" BackColor="#E3EAEB" DataSourceID="XmlDataSource1" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px">
            <DataBindings>
                <asp:MenuItemBinding DataMember="ControlType" TextField="Name" />
                <asp:MenuItemBinding DataMember="Control" NavigateUrlField="Url" TextField="Name" />
            </DataBindings>
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#E3EAEB" />
            <DynamicSelectedStyle BackColor="#1C5E55" />
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#1C5E55" />
        </asp:Menu>
    </form>
</body>
</html>
