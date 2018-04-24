/*
	This file is part of HnD.
	HnD is (c) 2002-2007 Solutions Design.
    http://www.llblgen.com
	http://www.sd.nl

	HnD is free software; you can redistribute it and/or modify
	it under the terms of version 2 of the GNU General Public License as published by
	the Free Software Foundation.

	HnD is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with HnD, please see the LICENSE.txt file; if not, write to the Free Software
	Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/
using System;

using SD.HnD.BL;
using SD.HnD.DAL.EntityClasses;
using System.Collections.Generic;
using SD.HnD.Utility;

namespace SD.HnD.GUI.Admin
{
	/// <summary>
	/// Code behind for the form which allows an administrator to modify a role's properties
	/// </summary>
	public partial class ModifyRole : System.Web.UI.Page
	{
		private int _roleID;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// If the user doesn't have any access rights to management stuff, the user should
			// be redirected to the default of the global system. 
            if (!SessionAdapter.HasSystemActionRights())
            {
				// doesn't have system rights. redirect.
				Response.Redirect("../Default.aspx",true);
			}
			
			// Check if the user has the right systemright
			if(!SessionAdapter.HasSystemActionRight(ActionRights.SecurityManagement))
			{
				// no, redirect to admin default page, since the user HAS access to the admin menu.
				Response.Redirect("Default.aspx",true);
			}

			_roleID = HnDGeneralUtils.TryConvertToInt(Request.QueryString["RoleID"]);

			if(!Page.IsPostBack)
			{
				// get the role and show the description
				RoleEntity role = SecurityGuiHelper.GetRole(_roleID);
				if(role!=null)
				{
					tbxRoleDescription.Text = role.RoleDescription;
				}

				// get the system rights
				var systemActionRights = SecurityGuiHelper.GetAllSystemActionRights();

				cblSystemRights.DataSource = systemActionRights;
				cblSystemRights.DataTextField = "ActionRightDescription";
				cblSystemRights.DataValueField = "ActionRightID";
				cblSystemRights.DataBind();

				// get the action rights set for this role
				var systemActionRightRoleCombinations = SecurityGuiHelper.GetSystemActionRightRolesForRole(_roleID);

				// check the checkboxes in the cblSystemRights list if the value matches a row in the datatable
				foreach(RoleSystemActionRightEntity currentEntity in systemActionRightRoleCombinations)
				{
					cblSystemRights.Items.FindByValue(currentEntity.ActionRightID.ToString()).Selected=true;
				}
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnSave.ServerClick += new System.EventHandler(this.btnSave_ServerClick);
			this.btnCancel.ServerClick += new System.EventHandler(this.btnCancel_ServerClick);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


		private void btnCancel_ServerClick(object sender, System.EventArgs e)
		{
			// do nothing.
			Response.Redirect("ModifyDeleteRole.aspx", true);
		}

		private void btnSave_ServerClick(object sender, System.EventArgs e)
		{
			if(Page.IsValid)
			{
				// read checked action rights
				List<int> checkedActionRightIDs = new List<int>();

				for(int i=0;i<cblSystemRights.Items.Count;i++)
				{
					if(cblSystemRights.Items[i].Selected)
					{
						checkedActionRightIDs.Add(Convert.ToInt32(cblSystemRights.Items[i].Value));
					}
				}

				// modify the role
				if(SecurityManager.ModifyRole(checkedActionRightIDs, _roleID, tbxRoleDescription.Text))
				{
					// succeeded
					Response.Redirect("ModifyDeleteRole.aspx", true);
				}
				else
				{
					// same description error
					lblDuplicateRoleDescription.Visible=true;
				}
			}
		}
	}
}

