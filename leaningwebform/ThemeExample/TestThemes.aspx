<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestThemes.aspx.cs" Theme="Season" Inherits="leaningwebform.ThemeExample.TestThemes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" SkinID="skinDemo"></asp:TextBox>
            <br />
            <br />
                       
            </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" Width="142px" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Button" Width="142px" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
