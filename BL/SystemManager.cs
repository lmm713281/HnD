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
using SD.HnD.DAL.DatabaseSpecific;
using SD.HnD.DAL.EntityClasses;

namespace SD.HnD.BL
{
	/// <summary>
	/// General System Settings Manager
	/// </summary>
	public static class SystemManager
	{
		/// <summary>
		/// Will overwrite the system settings stored in SystemData. As there's just one record and that record is already there, it's just overwriting the
		/// existing entity.
		/// </summary>
		/// <param name="id">The id.</param>
		/// <param name="newDefaultUserRoleNewUsers">The new default user role for new users.</param>
		/// <param name="newAnonymousRole">The new anonymous role.</param>
		/// <param name="newUserTitleNewUsers">The new user title for new users.</param>
		/// <param name="hoursThresholdForActiveThreads">The hours threshold for active threads.</param>
		/// <param name="pageSizeSearchResults">The page size search results.</param>
		/// <param name="minimalNumberOfThreadsToFetch">The minimal number of threads to fetch.</param>
		/// <param name="minimalNumberOfNonStickyVisibleThreads">The minimal number of non sticky visible threads.</param>
		/// <param name="sendReplyNotifications">The setting to send notification emails or not. If set to false the system won't send
		/// notification emails and users can't subscribe / unsubscribe to threads.</param>
		/// <returns>
		/// true if save was succeeded, false otherwise
		/// </returns>
		public static bool StoreNewSystemSettings(int id, int newDefaultUserRoleNewUsers, int newAnonymousRole, int newUserTitleNewUsers, short hoursThresholdForActiveThreads, 
												  short pageSizeSearchResults, short minimalNumberOfThreadsToFetch, short minimalNumberOfNonStickyVisibleThreads, bool sendReplyNotifications)
		{
			using(var adapter = new DataAccessAdapter())
			{
				// fetch the existing system data entity. 
				var systemData = new SystemDataEntity(id);
				if(!adapter.FetchEntity(systemData))
				{
					throw new InvalidOperationException("No system settings object found!");
				}

				// update its parameters. 
				systemData.DefaultRoleNewUser = newDefaultUserRoleNewUsers;
				systemData.AnonymousRole = newAnonymousRole;
				systemData.DefaultUserTitleNewUser = newUserTitleNewUsers;
				systemData.HoursThresholdForActiveThreads = hoursThresholdForActiveThreads;
				systemData.PageSizeSearchResults = pageSizeSearchResults;
				systemData.MinNumberOfNonStickyVisibleThreads = minimalNumberOfNonStickyVisibleThreads;
				systemData.MinNumberOfThreadsToFetch = minimalNumberOfThreadsToFetch;
				systemData.SendReplyNotifications = sendReplyNotifications;
				return adapter.SaveEntity(systemData);
			}
		}
	}
}
