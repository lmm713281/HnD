﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using SD.HnD.DALAdapter.EntityClasses;
using SD.HnD.DALAdapter.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace SD.HnD.DALAdapter.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField2(fieldName, targetAlias, typeof(TValue));
		}
		
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the ActionRight entity</summary>
		public EntityQuery<ActionRightEntity> ActionRight
		{
			get { return Create<ActionRightEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Attachment entity</summary>
		public EntityQuery<AttachmentEntity> Attachment
		{
			get { return Create<AttachmentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditAction entity</summary>
		public EntityQuery<AuditActionEntity> AuditAction
		{
			get { return Create<AuditActionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditDataCore entity</summary>
		public EntityQuery<AuditDataCoreEntity> AuditDataCore
		{
			get { return Create<AuditDataCoreEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditDataMessageRelated entity</summary>
		public EntityQuery<AuditDataMessageRelatedEntity> AuditDataMessageRelated
		{
			get { return Create<AuditDataMessageRelatedEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditDataThreadRelated entity</summary>
		public EntityQuery<AuditDataThreadRelatedEntity> AuditDataThreadRelated
		{
			get { return Create<AuditDataThreadRelatedEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Bookmark entity</summary>
		public EntityQuery<BookmarkEntity> Bookmark
		{
			get { return Create<BookmarkEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Forum entity</summary>
		public EntityQuery<ForumEntity> Forum
		{
			get { return Create<ForumEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ForumRoleForumActionRight entity</summary>
		public EntityQuery<ForumRoleForumActionRightEntity> ForumRoleForumActionRight
		{
			get { return Create<ForumRoleForumActionRightEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the IPBan entity</summary>
		public EntityQuery<IPBanEntity> IPBan
		{
			get { return Create<IPBanEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Message entity</summary>
		public EntityQuery<MessageEntity> Message
		{
			get { return Create<MessageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Role entity</summary>
		public EntityQuery<RoleEntity> Role
		{
			get { return Create<RoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RoleAuditAction entity</summary>
		public EntityQuery<RoleAuditActionEntity> RoleAuditAction
		{
			get { return Create<RoleAuditActionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RoleSystemActionRight entity</summary>
		public EntityQuery<RoleSystemActionRightEntity> RoleSystemActionRight
		{
			get { return Create<RoleSystemActionRightEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RoleUser entity</summary>
		public EntityQuery<RoleUserEntity> RoleUser
		{
			get { return Create<RoleUserEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Section entity</summary>
		public EntityQuery<SectionEntity> Section
		{
			get { return Create<SectionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SupportQueue entity</summary>
		public EntityQuery<SupportQueueEntity> SupportQueue
		{
			get { return Create<SupportQueueEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SupportQueueThread entity</summary>
		public EntityQuery<SupportQueueThreadEntity> SupportQueueThread
		{
			get { return Create<SupportQueueThreadEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SystemData entity</summary>
		public EntityQuery<SystemDataEntity> SystemData
		{
			get { return Create<SystemDataEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Thread entity</summary>
		public EntityQuery<ThreadEntity> Thread
		{
			get { return Create<ThreadEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ThreadSubscription entity</summary>
		public EntityQuery<ThreadSubscriptionEntity> ThreadSubscription
		{
			get { return Create<ThreadSubscriptionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User
		{
			get { return Create<UserEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserTitle entity</summary>
		public EntityQuery<UserTitleEntity> UserTitle
		{
			get { return Create<UserTitleEntity>(); }
		}


 
		/// <summary>Gets the query to fetch the typed list ForumMessages</summary>
		/// <returns>Dynamic Query which fetches <see cref="SD.HnD.DALAdapter.TypedListClasses.ForumMessagesRow"/> instances </returns>
		public DynamicQuery<SD.HnD.DALAdapter.TypedListClasses.ForumMessagesRow> GetForumMessagesTypedList()
		{
			return this.Create()
						.Select(() => new SD.HnD.DALAdapter.TypedListClasses.ForumMessagesRow()
								{
									MessageID = MessageFields.MessageID.ToValue<System.Int32>(),
									PostingDate = MessageFields.PostingDate.ToValue<System.DateTime>(),
									MessageTextAsHTML = MessageFields.MessageTextAsHTML.ToValue<System.String>(),
									ThreadID = MessageFields.ThreadID.ToValue<System.Int32>(),
									Subject = ThreadFields.Subject.ToValue<System.String>(),
									EmailAddress = UserFields.EmailAddress.ToValue<System.String>(),
									EmailAddressIsPublic = UserFields.EmailAddressIsPublic.ToValue<Nullable<System.Boolean>>(),
									NickName = UserFields.NickName.ToValue<System.String>(),
									MessageText = MessageFields.MessageText.ToValue<System.String>()
								})
						.From(this.Message
								.InnerJoin(this.Thread).On(MessageFields.ThreadID.Equal(ThreadFields.ThreadID))
								.InnerJoin(this.User).On(MessageFields.PostedByUserID.Equal(UserFields.UserID))
								.InnerJoin(this.Forum).On(ThreadFields.ForumID.Equal(ForumFields.ForumID)));
		}

		/// <summary>Gets the query to fetch the typed list ForumsWithSectionName</summary>
		/// <returns>Dynamic Query which fetches <see cref="SD.HnD.DALAdapter.TypedListClasses.ForumsWithSectionNameRow"/> instances </returns>
		public DynamicQuery<SD.HnD.DALAdapter.TypedListClasses.ForumsWithSectionNameRow> GetForumsWithSectionNameTypedList()
		{
			return this.Create()
						.Select(() => new SD.HnD.DALAdapter.TypedListClasses.ForumsWithSectionNameRow()
								{
									ForumID = ForumFields.ForumID.ToValue<System.Int32>(),
									ForumName = ForumFields.ForumName.ToValue<System.String>(),
									SectionName = SectionFields.SectionName.ToValue<System.String>(),
									ForumDescription = ForumFields.ForumDescription.ToValue<System.String>(),
									SectionID = SectionFields.SectionID.ToValue<System.Int32>(),
									ForumOrderNo = ForumFields.OrderNo.As("ForumOrderNo").ToValue<System.Int16>()
								})
						.From(this.Forum
								.InnerJoin(this.Section).On(ForumFields.SectionID.Equal(SectionFields.SectionID)));
		}

		/// <summary>Gets the query to fetch the typed list MessagesInThread</summary>
		/// <returns>Dynamic Query which fetches <see cref="SD.HnD.DALAdapter.TypedListClasses.MessagesInThreadRow"/> instances </returns>
		public DynamicQuery<SD.HnD.DALAdapter.TypedListClasses.MessagesInThreadRow> GetMessagesInThreadTypedList()
		{
			return this.Create()
						.Select(() => new SD.HnD.DALAdapter.TypedListClasses.MessagesInThreadRow()
								{
									MessageID = MessageFields.MessageID.ToValue<System.Int32>(),
									PostingDate = MessageFields.PostingDate.ToValue<System.DateTime>(),
									MessageTextAsHTML = MessageFields.MessageTextAsHTML.ToValue<System.String>(),
									ThreadID = MessageFields.ThreadID.ToValue<System.Int32>(),
									PostedFromIP = MessageFields.PostedFromIP.ToValue<System.String>(),
									UserID = UserFields.UserID.ToValue<Nullable<System.Int32>>(),
									NickName = UserFields.NickName.ToValue<System.String>(),
									SignatureAsHTML = UserFields.SignatureAsHTML.ToValue<System.String>(),
									IconURL = UserFields.IconURL.ToValue<System.String>(),
									Location = UserFields.Location.ToValue<System.String>(),
									JoinDate = UserFields.JoinDate.ToValue<Nullable<System.DateTime>>(),
									AmountOfPostings = UserFields.AmountOfPostings.ToValue<Nullable<System.Int32>>(),
									UserTitleDescription = UserTitleFields.UserTitleDescription.ToValue<System.String>()
								})
						.From(this.Message
						   		.LeftJoin(this.User).On(MessageFields.PostedByUserID.Equal(UserFields.UserID))
								.InnerJoin(this.UserTitle).On(UserFields.UserTitleID.Equal(UserTitleFields.UserTitleID)));
		}

		/// <summary>Gets the query to fetch the typed list SearchResult</summary>
		/// <returns>Dynamic Query which fetches <see cref="SD.HnD.DALAdapter.TypedListClasses.SearchResultRow"/> instances </returns>
		public DynamicQuery<SD.HnD.DALAdapter.TypedListClasses.SearchResultRow> GetSearchResultTypedList()
		{
			return this.Create()
						.Select(() => new SD.HnD.DALAdapter.TypedListClasses.SearchResultRow()
								{
									ThreadID = ThreadFields.ThreadID.ToValue<System.Int32>(),
									Subject = ThreadFields.Subject.ToValue<System.String>(),
									ForumName = ForumFields.ForumName.ToValue<System.String>(),
									SectionName = SectionFields.SectionName.ToValue<System.String>(),
									ThreadLastPostingDate = ThreadFields.ThreadLastPostingDate.ToValue<Nullable<System.DateTime>>()
								})
						.From(this.Message
								.InnerJoin(this.Thread).On(MessageFields.ThreadID.Equal(ThreadFields.ThreadID))
								.InnerJoin(this.Forum).On(ThreadFields.ForumID.Equal(ForumFields.ForumID))
								.InnerJoin(this.Section).On(ForumFields.SectionID.Equal(SectionFields.SectionID)));
		}

	}
}