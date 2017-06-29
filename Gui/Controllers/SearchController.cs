﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SD.HnD.BL;
using SD.HnD.DALAdapter.TypedListClasses;
using SD.HnD.Gui.Models;
using SD.Tools.BCLExtensions.CollectionsRelated;

namespace SD.HnD.Gui.Controllers
{
	public class SearchController : Controller
	{
		/// <summary>
		/// Get method for the advanced search UI
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public ActionResult AdvancedSearch()
		{
			var allAccessibleForumIDs = LoggedInUserAdapter.GetForumsWithActionRight(ActionRights.AccessForum).ToHashSet();
			var viewData = new AdvancedSearchUIData()
						   {
							   NumberOfMessages = MessageGuiHelper.GetTotalNumberOfMessages(),
							   AllAccessibleForumsWithSectionName = ForumGuiHelper.GetAllForumsWithSectionNames().Where(r => allAccessibleForumIDs.Contains(r.ForumID)).ToList()
						   };
			return View(viewData);
		}


		/// <summary>
		/// post method for the advanced search. It's called 'SearchAdvanced' as the other search methods are called Search<i>method</i>.
		/// </summary>
		/// <param name="searchData"></param>
		/// <returns></returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SearchAdvanced([Bind(Include = "SearchParameters, SearchTarget, TargetForums, FirstSortClause, SecondSortClause")] AdvancedSearchModel searchData)
		{
			if(string.IsNullOrWhiteSpace(searchData.SearchParameters))
			{
				return RedirectToAction("Index", "Home");
			}
			var forumsToSearch = new List<int>();
			if(searchData.TargetForums == null || searchData.TargetForums.Count <= 0)
			{
				forumsToSearch = ForumGuiHelper.GetAllForumIds();
			}
			else
			{
				forumsToSearch.AddRange(searchData.TargetForums);
			}

			var firstSortClause = SearchResultsOrderSetting.ForumAscending;
			if(!Enum.TryParse(searchData.FirstSortClause, out firstSortClause))
			{
				firstSortClause = SearchResultsOrderSetting.ForumAscending;
			}
			var secondSortClause = SearchResultsOrderSetting.LastPostDateAscending;
			if(!Enum.TryParse(searchData.SecondSortClause, out secondSortClause))
			{
				secondSortClause = SearchResultsOrderSetting.LastPostDateAscending;
			}
			var searchTarget = SearchTarget.MessageText;
			if(!Enum.TryParse(searchData.SearchTarget, out searchTarget))
			{
				searchTarget = SearchTarget.MessageText;
			}
			PerformSearch(searchData.SearchParameters, forumsToSearch, firstSortClause, secondSortClause, searchTarget);
			return RedirectToAction("Results", "Search", new { pageNo = 1 });
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SearchAll([Bind] string searchParameters="")
		{
			if(string.IsNullOrWhiteSpace(searchParameters))
			{
				return RedirectToAction("Index", "Home");
			}
			PerformSearch(searchParameters, ForumGuiHelper.GetAllForumIds(), SearchResultsOrderSetting.LastPostDateDescending, SearchResultsOrderSetting.ForumAscending, 
						  SearchTarget.MessageTextAndThreadSubject);

			return RedirectToAction("Results", "Search", new { pageNo = 1 });
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SearchForum(int forumId = 0, string searchParameters="")
		{
			if(string.IsNullOrWhiteSpace(searchParameters))
			{
				return RedirectToAction("Index", "Home");
			}
			var forum = CacheManager.GetForum(forumId);
			if(forum == null)
			{
				return RedirectToAction("Index", "Home");
			}
			PerformSearch(searchParameters, new List<int>() { forumId}, SearchResultsOrderSetting.LastPostDateDescending, SearchResultsOrderSetting.ThreadSubjectAscending, 
						  SearchTarget.MessageTextAndThreadSubject);
			return RedirectToAction("Results", "Search", new { pageNo = 1 });
		}


		[HttpGet]
		public ActionResult Results(int pageNo = 0)
		{
			if(pageNo < 1)
			{
				return RedirectToAction("Index", "Home");
			}

			var results = SessionAdapter.GetSearchResults();
			if(results == null)
			{
				return RedirectToAction("Index", "Home");
			}
			var pageSize = CacheManager.GetSystemData().PageSizeSearchResults;
			if(pageSize <= 0)
			{
				pageSize = 50;
			}
			int numberOfPages = (results.Count / pageSize);
			if(numberOfPages * pageSize < results.Count)
			{
				numberOfPages++;
			}
			var rowsToShow = new List<SearchResultRow>();
			for(int i = 0; (i < pageSize) && ((((pageNo - 1) * pageSize) + i) < results.Count); i++)
			{
				rowsToShow.Add(results[((pageNo-1)*pageSize) + i]);
			}
			var viewData = new SearchResultsData()
						   {
							   NumberOfPages = numberOfPages,
							   PageNo = pageNo,
							   PageRows = rowsToShow,
							   NumberOfResultRows = results.Count,
							   SearchParameters = SessionAdapter.GetSearchTerms()
						   };
			return View(viewData);
		}


		private void PerformSearch(string searchParameters, List<int> forumIDs, SearchResultsOrderSetting orderFirstElement, SearchResultsOrderSetting orderSecondElement, 
								   SearchTarget targetToSearch)
		{
			var searchTerms = searchParameters.Length > 1024 ? searchParameters.Substring(0, 1024) : searchParameters;
			var results = Searcher.DoSearch(searchTerms, forumIDs, orderFirstElement, orderSecondElement,
										    LoggedInUserAdapter.GetForumsWithActionRight(ActionRights.ViewNormalThreadsStartedByOthers), LoggedInUserAdapter.GetUserID(), targetToSearch);
			SessionAdapter.AddSearchTermsAndResults(searchTerms, results);
		}
	}
}