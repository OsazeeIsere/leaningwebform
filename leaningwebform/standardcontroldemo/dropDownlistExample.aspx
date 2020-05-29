<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropDownlistExample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.dropDownlistExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Nigeria</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>London</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" Width="137px"></asp:TextBox>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete All" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete " />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Insert" />
                    </td>
                    <td colspan="2">
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Select" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList4" runat="server">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <br />
                        <asp:ListBox ID="ListBox1" runat="server" Height="162px" Width="230px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList5" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="DropDownList6" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
