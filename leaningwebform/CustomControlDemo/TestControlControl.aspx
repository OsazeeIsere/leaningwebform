<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestControlControl.aspx.cs" Inherits="leaningwebform.CustomControlDemo.TestControlControl" %>

<%@ Register assembly="MYCCD1" namespace="MYCCD1" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <cc1:NewGreetings ID="NewGreetings1" runat="server" Counter="5" Message="This Is my First User Control">
            </cc1:NewGreetings>

        </div>
        <cc1:NewGreetings ID="NewGreetings2" runat="server" Counter="5" Message="Another Greetings">
        </cc1:NewGreetings>
        <cc1:ListAllUsers ID="ListAllUsers1" runat="server">
        </cc1:ListAllUsers>
    </form>
</body>
</html>
