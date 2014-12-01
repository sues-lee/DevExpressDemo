<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CallBackDashBoard.ascx.cs" Inherits="DexTest.UserControls.CallBackDashBoard" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxCallbackPanel" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dxp" Namespace="DevExpress.Web.ASPxPanel" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.DashboardWeb" Assembly="DevExpress.Dashboard.v14.1.Web, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxHiddenField" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<script type="text/javascript" >
    function indexChanged(s, e) {
       
        var item = <%=ASPxComboBox1.ClientID%>.GetSelectedItem();
        <% = ASPxCallbackPanel1.ClientID%>.PerformCallback(item.value);
    }
</script>
<div><% =Text %></div>
<div class="comboBox" runat="server" ClientIDMode="AutoID">
    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ClientIDMode="AutoID">
        <ClientSideEvents SelectedIndexChanged="indexChanged"></ClientSideEvents>
    </dx:ASPxComboBox>
</div>

<dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" OnCallback="ASPxCallbackPanel1_Callback" 
             ShowLoadingPanelImage="False"  ClientIDMode="AutoID" >
            <PanelCollection>
                 <dxp:PanelContent ID="PanelContent1" runat="server">
                     <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server"  OnDataLoading="ASPxDashboardViewer1_DataLoading" DashboardId="" Width="100%" Height="500px">
                     </dx:ASPxDashboardViewer>
                     <dx:ASPxHiddenField ID="ASPxHiddenField1" runat="server" ClientIDMode="AutoID"></dx:ASPxHiddenField>
                 </dxp:PanelContent>
            </PanelCollection>
</dx:ASPxCallbackPanel>