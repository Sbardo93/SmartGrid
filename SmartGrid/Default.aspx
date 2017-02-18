<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartGridWebSite.Default" %>

<%@ Register Src="~/ucSmartGrid.ascx" TagName="ucSmartGrid" TagPrefix="ucSmartGrid" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=11">
    <title>SmartGrid</title>
</head>
<body>
    <form id="form1" runat="server">
        <ucSmartGrid:ucSmartGrid ID="ucSmartGrid" runat="server"></ucSmartGrid:ucSmartGrid>
    </form>
</body>
</html>
