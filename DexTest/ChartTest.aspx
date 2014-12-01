<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartTest.aspx.cs" Inherits="DexTest.ChartTest" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxCallbackPanel" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>
<%@ Register TagPrefix="dxp" Namespace="DevExpress.Web.ASPxPanel" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <dx:ASPxButton  ID="ASPxButton1" runat="server" Text="ASPxButton" AutoPostBack="False" >
                            <ClientSideEvents Click="function(s, e) {
	                    {<% =panelId%>.PerformCallBack(1);}
                        }"></ClientSideEvents>
  </dx:ASPxButton>
        <div id="Button" runat="server">heheheh</div>
        <div><% =ASPxCallbackPanel1.ClientID %>------<% =ASPxCallbackPanel1.IsEnabled() %></div>
    </div>
        <dx:ASPxListBox ID="ASPxListBoxSelect" runat="server" ClientInstanceName="ListBox" Height="83px">  
        <Items>  
            <dx:ListEditItem Text="雷语1" Value="0" />  
            <dx:ListEditItem Text="雷语2" Value="1" />  
            <dx:ListEditItem Text="雷语3" Value="2" />  
        </Items>  
     <ClientSideEvents SelectedIndexChanged="function(s, e) {  
              var item = ListBox.GetSelectedItem();  
              ASPxCallbackPanel1.PerformCallback(item.value);    
          }" Init="function(s, e) {  
              ListBox.SetSelectedIndex(0);  
              ASPxCallbackPanel1.PerformCallback(0);  
          }"   
      />                 
</dx:ASPxListBox>  
        <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" OnCallback="ASPxCallbackPanel1_Callback" 
            Width="200px"   >
            <PanelCollection>
                 <dxp:PanelContent ID="PanelContent1" runat="server">  
                           <asp:MultiView ID="MultiView01" runat="server">  
                               <asp:View ID="View01" runat="server">  
                                   <table>  
                                       <tr>  
                                           <td valign="top">  
                                               <dx:ASPxLabel ID="ASPxLabel01" runat="server" Text="001"  
                                                   Font-Bold="True">   
                                               </dx:ASPxLabel>  
                                           </td>  
                                       </tr>  
                                   </table>  
                               </asp:View>  
                               <asp:View ID="View02" runat="server">  
                                   <table>  
                                       <tr>  
                                           <td valign="top">  
                                               <dx:ASPxLabel ID="ASPxLabel03" runat="server" Text="002"  
                                                   Font-Bold="True">  
                                               </dx:ASPxLabel>  
                                           </td>  
                                       </tr>  
                                   </table>  
                               </asp:View>  
                               <asp:View ID="View03" runat="server">  
                                   <table>  
                                       <tr>  
                                           <td valign="top">  
                                               <dx:ASPxLabel ID="ASPxLabel05" runat="server" Text="003"  
                                                   Font-Bold="True">  
                                               </dx:ASPxLabel>  
                                           </td>  
                                       </tr>  
                                   </table>  
                               </asp:View>  
                           </asp:MultiView>

                 </dxp:PanelContent>  
                </PanelCollection>
            
        </dx:ASPxCallbackPanel>
        
    </form>
</body>
</html>
