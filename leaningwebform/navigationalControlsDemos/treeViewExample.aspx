<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="treeViewExample.aspx.cs" Inherits="leaningwebform.navigationalControlsDemos.treeViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList4" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="Standard Control" Value="Standard Control">
                        <asp:TreeNode NavigateUrl="~/standardcontroldemo/textboxexample.aspx" Text="Text Box" Value="Text Box"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/standardcontroldemo/checkboxexample.aspx" Text="Check Box" Value="Check Box"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/standardcontroldemo/radiobuttonexample.aspx" Text="Radio Button" Value="Radio Button"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Data Bound Controls" Value="Data Bound Controls">
                        <asp:TreeNode NavigateUrl="~/dataBoundControlDemo/gridViewExample.aspx" Text="Grid View" Value="Grid View"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/dataBoundControlDemo/detailViewExample.aspx" Text="Detail View" Value="Detail View"></asp:TreeNode>
                        <asp:TreeNode Text="Form View" Value="Form View"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
        <asp:TreeView ID="TreeView2" runat="server" DataSourceID="XmlDataSource1" ImageSet="BulletedList4" ShowLines="True">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="ControlType" TextField="Name" />
                <asp:TreeNodeBinding DataMember="Control" NavigateUrlField="Url" TextField="Name" />
            </DataBindings>
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/myMenu.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
