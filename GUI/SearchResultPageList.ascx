<%@ Control Language="c#" AutoEventWireup="false" Inherits="SD.HnD.GUI.SearchResultPageList" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="SearchResultPageList.ascx.cs" %>
<asp:repeater id="rptPageList" runat="server">
	<headertemplate>Pages: </headertemplate>
	<separatortemplate> </separatortemplate>
	<itemtemplate>
		<asp:label id="lblMessagesPage" runat="server" visible="False"><%# (int)(Container.DataItem)%></asp:label>
		<asp:hyperlink navigateurl="SearchResults.aspx?Page=" id="lnkResultPage" visible="False" runat="server"><%# (int)(Container.DataItem)%></asp:hyperlink>
	</itemtemplate>
</asp:repeater>
