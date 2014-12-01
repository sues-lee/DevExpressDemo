<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemSelectorControl.ascx.cs" Inherits="DexTest.UserControls.ItemSelectorControl" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxEditors" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web.ASPxHiddenField" Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<div>
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DropDownStyle="DropDownList" SelectedIndex="1">
            <ClientSideEvents 
                SelectedIndexChanged="function(s, e) {
	                  var item = ASPxComboBox1.GetSelectedItem();  
                      <% = CallbackPanelId%>.PerformCallback(item.value);  
            }" />
            <Items>
                <dx:ListEditItem Text="24小时" Value="0" />
                <dx:ListEditItem Text="48小时" Value="1" />
            </Items>
        </dx:ASPxComboBox>
    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton"></dx:ASPxButton>
</div>
<dx:ASPxHiddenField ID="ListBoxHiddenField" runat="server" ClientIDMode="AutoID"></dx:ASPxHiddenField>