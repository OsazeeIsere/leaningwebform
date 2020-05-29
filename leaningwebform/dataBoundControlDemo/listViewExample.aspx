<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listViewExample.aspx.cs" Inherits="leaningwebform.dataBoundControlDemo.listViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="userName" DataSourceID="SqlDataSource1" GroupItemCount="3" InsertItemPosition="LastItem">
                <AlternatingItemTemplate>
                    <td runat="server" style="background-color:#FFF8DC;">userName:
                        <asp:Label ID="userNameLabel" runat="server" Text='<%# Eval("userName") %>' />
                        <br />password:
                        <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                        <br />email:
                        <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                        <br />country:
                        <asp:Label ID="countryLabel" runat="server" Text='<%# Eval("country") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br /></td>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">userName:
                        <asp:Label ID="userNameLabel1" runat="server" Text='<%# Eval("userName") %>' />
                        <br />password:
                        <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                        <br />email:
                        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                        <br />country:
                        <asp:TextBox ID="countryTextBox" runat="server" Text='<%# Bind("country") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        <br /></td>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
<td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <InsertItemTemplate>
                    <td runat="server" style="">userName:
                        <asp:TextBox ID="userNameTextBox" runat="server" Text='<%# Bind("userName") %>' />
                        <br />password:
                        <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                        <br />email:
                        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                        <br />country:
                        <asp:TextBox ID="countryTextBox" runat="server" Text='<%# Bind("country") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        <br /></td>
                </InsertItemTemplate>
                <ItemTemplate>
                    <td runat="server" style="background-color:#DCDCDC;color: #000000;">userName:
                        <asp:Label ID="userNameLabel" runat="server" Text='<%# Eval("userName") %>' />
                        <br />password:
                        <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                        <br />email:
                        <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                        <br />country:
                        <asp:Label ID="countryLabel" runat="server" Text='<%# Eval("country") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br /></td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">userName:
                        <asp:Label ID="userNameLabel" runat="server" Text='<%# Eval("userName") %>' />
                        <br />password:
                        <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                        <br />email:
                        <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                        <br />country:
                        <asp:Label ID="countryLabel" runat="server" Text='<%# Eval("country") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br /></td>
                </SelectedItemTemplate>
            </asp:ListView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPtrainingConnectionString %>" DeleteCommand="DELETE FROM userDetails WHERE (userName = @userName)" InsertCommand="INSERT INTO userDetails(userName, password, email, country) VALUES (@userName, @password, @email, @country)" SelectCommand="SELECT * FROM [userDetails]" UpdateCommand="UPDATE userDetails SET password = @password, email = @email, country = @country WHERE (userName = @userName)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="ListView1" Name="userName" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="ListView1" Name="userName" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="ListView1" Name="password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="ListView1" Name="email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="ListView1" Name="country" PropertyName="SelectedValue" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="ListView1" Name="password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="ListView1" Name="email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="ListView1" Name="country" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="ListView1" Name="userName" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DataPager ID="DataPager2" runat="server" PagedControlID="ListView1" PageSize="2">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
        <p>
            <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
                <CurrentNodeStyle ForeColor="#333333" />
                <NodeStyle Font-Bold="True" ForeColor="#990000" />
                <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
                <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
            </asp:SiteMapPath>
        </p>
    </form>
</body>
</html>
