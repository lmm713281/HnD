<%@ Control Language="c#" AutoEventWireup="false" CodeFile="Footer.ascx.cs" Inherits="SD.HnD.GUI.Footer" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Import namespace="SD.HnD.BL" %>
<table width="760" align="center" border="0" cellpadding="1" cellspacing="1">
<tr>
	<td class="SmallFontSmallest" align="middle">
		<hr class="FooterHR" style="text-align:center;" width="40%" size="1">
		Powered by <a href="https://github.com/SolutionsDesign/HnD" target="_blank">HnD</a> &copy;2002-<%=DateTime.Now.Year %> <a href="https://www.sd.nl/" target="_blank">Solutions Design bv</a><br>
		<a href="https://github.com/SolutionsDesign/HnD" target="_blank">HnD</a> uses <a href="https://www.llblgen.com" target="_blank">LLBLGen Pro</a><br />
		<br>
		Version: <%=Globals.Version%>.<%=Globals.Build%> <%=Globals.ReleaseType%>.
		<br><br>
	</td>
</tr>
</table>
