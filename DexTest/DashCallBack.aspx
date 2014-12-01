<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashCallBack.aspx.cs" Inherits="DexTest.DashCallBack" %>

<%@ Register Assembly="DevExpress.Dashboard.v14.1.Web, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxCallbackPanel" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dxp" Namespace="DevExpress.Web.ASPxPanel" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxEditors" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxHiddenField" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="ComboArea" runat="server">
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DropDownStyle="DropDownList" SelectedIndex="1">
            <ClientSideEvents 
                SelectedIndexChanged="function(s, e) {
	                  var item = ASPxComboBox1.GetSelectedItem();  
                      CallbackPanel.PerformCallback(item.value);  
            }" />
            <Items>
                <dx:ListEditItem Text="24小时" Value="0" />
                <dx:ListEditItem Text="48小时" Value="1" />
            </Items>
        </dx:ASPxComboBox>
    </div>
    
    <div>    
        <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" OnCallback="ASPxCallbackPanel1_Callback" 
            Width="200px" ShowLoadingPanelImage="False" ClientInstanceName="CallbackPanel"  >
            <PanelCollection>
                 <dxp:PanelContent ID="PanelContent1" runat="server">  
                     <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server"  DashboardSource="DexTest.DashBoards.DashboardRegisterTendency" OnDataLoading="ASPxDashboardViewer1_DataLoading" DashboardId="" Width="800px" Height="600px"></dx:ASPxDashboardViewer>
                     <dx:ASPxHiddenField ID="ListBoxHiddenField" runat="server" ClientIDMode="AutoID"></dx:ASPxHiddenField>
                 </dxp:PanelContent>  
            </PanelCollection>
        </dx:ASPxCallbackPanel>
    </div>
    </form>
</body>
</html>
