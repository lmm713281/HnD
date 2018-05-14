<%@ Control Language="c#" AutoEventWireup="false" Inherits="SD.HnD.GUI.MyThreadsPageList" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="MyThreadsPageList.ascx.cs" %>
<asp:repeater id="rptPageList" runat="server">
	<headertemplate>Pages: </headertemplate>
	<separatortemplate> </separatortemplate>
	<itemtemplate>
		<asp:label id="lblMessagesPage" runat="server" visible="False"><%# (int)(Container.DataItem)%></asp:label>
		<asp:hyperlink navigateurl="MyThreads.aspx?Page=" id="lnkResultPage" visible="False" runat="server"><%# (int)(Container.DataItem)%></asp:hyperlink>
	</itemtemplate>
</asp:repeater>
