<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewer.aspx.cs" Inherits="DexTest.Viewer" %>

<%@ Register Assembly="DevExpress.Dashboard.v14.1.Web, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" DashboardId="" DashboardSource="~/DashBoards/dashTest.xml" DashboardXmlFile="~/DashBoards/dashTest.xml" FullscreenMode="True" Height="100%" OnConfigureDataConnection="ConfigureDataConnection" OnDataLoading="ASPxDashboardViewer1_DataLoading" Width="100%"></dx:ASPxDashboardViewer>
        </div>
    </form>
</body>
</html>
