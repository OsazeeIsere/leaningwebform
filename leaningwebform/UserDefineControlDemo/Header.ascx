<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="leaningwebform.UserDefineControlDemo.Header" %>
<%@ Register assembly="MYCCD1" namespace="MYCCD1" tagprefix="cc1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        border-style: solid;
        border-width: 3px;
        background-color: #00FFFF;
    }
</style>

<cc1:NewGreetings ID="NewGreetings1" runat="server">
</cc1:NewGreetings>
<cc1:ListAllUsers ID="ListAllUsers1" runat="server">
</cc1:ListAllUsers>

<table class="auto-style1">
    <tr>
        <td>
            <asp:Image ID="Image1" runat="server" Height="38px" ImageUrl="~/Image/NOZEME_LOGOS.jpg2.jpg" />
        </td>
    </tr>
</table>

