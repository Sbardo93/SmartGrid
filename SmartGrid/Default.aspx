<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartGridWebSite.Default" %>

<%@ Register Src="~/ucSmartGrid.ascx" TagName="ucSmartGrid" TagPrefix="ucSmartGrid" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <title>SmartGrid</title>
</head>
<body>
    <ucSmartGrid:ucSmartGrid ID="ucSmartGrid" runat="server"></ucSmartGrid:ucSmartGrid>
</body>
</html>
