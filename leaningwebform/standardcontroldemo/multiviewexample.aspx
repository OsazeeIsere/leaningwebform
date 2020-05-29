<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiviewexample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.multiviewexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #00FF00;
        }
        .auto-style2 {
            width: 100%;
            background-color: #FF0000;
        }
        .auto-style3 {
            width: 100%;
            background-color: #FF00FF;
        }
        .auto-style4 {
            width: 658px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View2" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Button" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <table class="auto-style2">
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td class="auto-style4">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td class="auto-style4">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                            </td>
                            <td class="auto-style4">&nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View4" runat="server">
                </asp:View>
                <asp:View ID="View1" runat="server">
                </asp:View>
            </asp:MultiView>
        </div>
        <table class="auto-style3">
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="First" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="&gt;" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="AQ">Academy Qualification</asp:ListItem>
            <asp:ListItem Value="TQ">Technical Qualification</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>
