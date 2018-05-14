<%@ Page language="c#" AutoEventWireup="false" Inherits="SD.HnD.GUI.Admin.ManageUsersInRole" 
	MasterPageFile="~/Admin/AdminMaster.master" Title="HnD::Administrate::Manage users in role" Codebehind="ManageUsersInRole.aspx.cs" %>

<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="700" align="center" class="ExplanationBox" cellpadding="2" cellspacing="0">
<tr>
	<td>
		<h3>Manage users in role.</h3>
		Below you'll find all existing roles in the system. Select the role which users you want to administrate. When your system has a lot of users,
		the administration pages for roles with a lot of users can be huge and therefor somewhat slow. 
	</td>
</tr>
</table>
<br clear="all"><br>
<table width="700" align="center" border="0" cellpadding="0" cellspacing="0">
<tr>
	<td class="TableHeaderTwoLine">
		<span class="TableName">Existing roles</span>
		<br>
		<span class="TableDescription">The list of existing roles in the forum system.</span>
	</td>
</tr>
<tr>
	<td class="TableContent">
		<table width="698" align="center" border="0" cellpadding="2" cellspacing="0">
		<tr>
			<td class="TableColumnHeader"><b>Role description</b></td>
			<td class="TableColumnHeader"><b># Users</b></td>
			<td class="TableColumnHeader"><b>Action</b></td>
		</tr>
		<asp:repeater ID="rpRoles" Runat="server" EnableViewState="True">
			<itemtemplate>
			<tr>
				<td class="TableRow LightBackground">
					<%#Eval("RoleDescription")%><br>
					<asp:label CssClass="SmallFontSmallest" ID="lblIsAnonymousRole" Runat="server" Visible='<%# (bool)Eval("IsAnonymousRole") %>'>This role is used for anonymous users.</asp:label>
					<asp:label CssClass="SmallFontSmallest" ID="lblIsDefaultNewUserRole" Runat="server" Visible='<%# (bool)Eval("IsDefaultNewUserRole") %>'>This role is assigned to new users.</asp:label>
				</td>
				<td class="TableRow LightBackground" align="center" width="60">
					<asp:label ID="lblAmountUsersInRole" Runat="server" Text='<%# Eval("AmountUsersInRole") %>' />
				</td>
				<td width="275" class="TableRow LightBackground">
					<asp:button CssClass="FormButtons" ID="btnAddUsers" CommandName="AddUsersToRole" Text="Add user(s)" runat="server" CommandArgument='<%# Eval("RoleID") %>'/>&nbsp;&nbsp;
					<asp:button CssClass="FormButtons" ID="btnRemoveUsersFromRole" CommandName="RemoveUsersFromRole" Text="Remove user(s)" runat="server" CommandArgument='<%# Eval("RoleID") %>'/>
				</td>
			</tr>
			</itemtemplate>
			
			<alternatingitemtemplate>
			<tr>
				<td class="TableRow DarkBackground">
					<%#Eval("RoleDescription")%><br>
					<asp:label CssClass="SmallFontSmallest" ID="lblIsAnonymousRole" Runat="server" Visible='<%# (bool)Eval("IsAnonymousRole") %>'>This role is used for anonymous users.</asp:label>
					<asp:label CssClass="SmallFontSmallest" ID="lblIsDefaultNewUserRole" Runat="server" Visible='<%# (bool)Eval("IsDefaultNewUserRole") %>'>This role is assigned to new users.</asp:label>
				</td>
				<td class="TableRow DarkBackground" align="center" width="60">
					<asp:label ID="lblAmountUsersInRole" Runat="server" Text='<%# Eval("AmountUsersInRole") %>' />
				</td>
				<td width="275" class="TableRow DarkBackground">
					<asp:button CssClass="FormButtons" ID="btnAddUsers" CommandName="AddUsersToRole" Text="Add user(s)" runat="server" CommandArgument='<%# Eval("RoleID") %>'/>&nbsp;&nbsp;
					<asp:button CssClass="FormButtons" ID="btnRemoveUsersFromRole" CommandName="RemoveUsersFromRole" Text="Remove user(s)" runat="server" CommandArgument='<%# Eval("RoleID") %>'/>
				</td>
			</tr>
			</alternatingitemtemplate>
		</asp:repeater>
		</table>
	</td>
</tr>
<tr><td class="EmptyRowBottom">&nbsp;</td></tr>
</table>
</asp:Content>