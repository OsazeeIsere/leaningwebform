<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageOutputCaching.aspx.cs" Inherits="leaningwebform.Ado.NetDemos.PageOutputCaching" %>
<%--<%@ OutputCache Duration="600" VaryByParam="None"%>--%>
<%@ OutputCache CacheProfile="myCacheProfile" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
<%--           Go to Web.config page to prepare the duation of the output cache by typing
    system.web
            <caching>
       <outputCacheSettings>
         <outputCacheProfiles>
           <add name="myCacheProfile" duration="600" varyByParam="Nome" location="Server"/>
         </outputCacheProfiles>
       </outputCacheSettings>
     </caching>
    --%>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
