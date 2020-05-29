<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panelexamples.aspx.cs" Inherits="leaningwebform.standardcontroldemo.panelexamples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 3px;
            background-color: #00FF00;
        }
        .auto-style2 {
            width: 100%;
            margin-bottom: 0px;
            background-color: #FF0000;
        }
        .auto-style3 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #C0C0C0;
        }
        .auto-style4 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #FF00FF;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 299px;
        }
        .auto-style7 {
            height: 26px;
            width: 299px;
        }
        .auto-style8 {
            height: 94px;
        }
        .auto-style9 {
            height: 30px;
        }
        .auto-style10 {
            width: 301px;
        }
        .auto-style11 {
            height: 88px;
        }
        .auto-style12 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11">
                        <asp:Panel ID="Panel1" runat="server" GroupingText="Academic Qualification">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style10">
                                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style10">
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style10">
                                        <asp:Button ID="Button1" runat="server" Text="Button" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Panel ID="Panel2" runat="server" GroupingText="Technical Qualification" Visible="False">
                            <table class="auto-style3">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <asp:Button ID="Button2" runat="server" Text="Button" />
                                    </td>
                                    <td class="auto-style9"></td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Panel ID="Panel3" runat="server" GroupingText="Work Experience" Visible="False">
                            <table class="auto-style4">
                                <tr>
                                    <td class="auto-style6">
                                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">
                                        <asp:Button ID="Button3" runat="server" Text="Button" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem Value="AQ">Academic Qualification</asp:ListItem>
                            <asp:ListItem Value="TQ">Technical Qualification</asp:ListItem>
                            <asp:ListItem Value="WE">Work Experience</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
