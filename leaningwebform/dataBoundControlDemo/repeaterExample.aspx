<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repeaterExample.aspx.cs" Inherits="leaningwebform.dataBoundControlDemo.repeatedExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
      <!-- in this control, the developer does the coding -->
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource2">
              
                <HeaderTemplate>
                    <table border ="5" bgColor="aqua">
                        <tr >
                            <td>User Name </td>
                            <td >Password</td>
                            <td>Email</td>
                            <td>Country</td>
                        </tr>
                    
                </HeaderTemplate>
                 <ItemTemplate>

               <tr>
                   <td><%#Eval("userName")%></td>
                   <td><%#Eval("Password")%></td>
                   <td><%#Eval("Email")%></td>
                   <td><%#Eval("Country")%></td>
               </tr>
               
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr bgColor="grey">
                   <td><%#Eval("userName")%></td>
                   <td><%#Eval("Password")%></td>
                   <td><%#Eval("Email")%></td>
                   <td><%#Eval("Country")%></td>
               </tr>
                </AlternatingItemTemplate>
                 <FooterTemplate>
                      </table>
                </FooterTemplate>
               
            </asp:Repeater>
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ASPtrainingConnectionString %>" SelectCommand="SELECT * FROM [userDetails]"></asp:SqlDataSource>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
