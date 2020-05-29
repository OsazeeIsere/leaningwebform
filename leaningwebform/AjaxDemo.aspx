<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxDemo.aspx.cs" Inherits="leaningwebform.AjaxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="MyTitle" runat="server" ></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Enter The First Number"></asp:Label>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Enter The Second Number</td>
                            <td class="auto-style3" colspan="3">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                            </td>
                            <td class="auto-style2">
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Subtract" />
                            </td>
                            <td class="auto-style2">
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiply" />
                            </td>
                            <td class="auto-style2">
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="height: 26px" Text="Divide" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                <asp:Label ID="Label4" runat="server" Text="Calculation is in progress! please Wait"></asp:Label>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                </asp:Timer>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" ForeColor="#FF3300"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
