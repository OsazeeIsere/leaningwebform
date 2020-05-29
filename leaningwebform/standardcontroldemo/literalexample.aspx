<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="literalexample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.literalexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="&lt;h1&gt;Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server" Text="literal"></asp:Literal>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label2" runat="server" Text="&lt;img src=&quot;~/Image/OZ.LOGO3.png&quot;&gt;&lt;/img&gt;"></asp:Label>
    </form>
</body>
</html>
