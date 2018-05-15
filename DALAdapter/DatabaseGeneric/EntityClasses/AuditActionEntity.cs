﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using SD.HnD.DAL.HelperClasses;
using SD.HnD.DAL.FactoryClasses;
using SD.HnD.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.HnD.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'AuditAction'.<br/><br/></summary>
	[Serializable]
	public partial class AuditActionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<AuditDataCoreEntity> _auditDataCore;
		private EntityCollection<RoleAuditActionEntity> _roleAuditActions;
		private EntityCollection<RoleEntity> _rolesWithAuditAction;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AuditActionEntityStaticMetaData _staticMetaData = new AuditActionEntityStaticMetaData();
		private static AuditActionRelations _relationsFactory = new AuditActionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditDataCore</summary>
			public static readonly string AuditDataCore = "AuditDataCore";
			/// <summary>Member name RoleAuditActions</summary>
			public static readonly string RoleAuditActions = "RoleAuditActions";
			/// <summary>Member name RolesWithAuditAction</summary>
			public static readonly string RolesWithAuditAction = "RolesWithAuditAction";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AuditActionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AuditActionEntityStaticMetaData()
			{
				SetEntityCoreInfo("AuditActionEntity", InheritanceHierarchyType.None, false, (int)SD.HnD.DAL.EntityType.AuditActionEntity, typeof(AuditActionEntity), typeof(AuditActionEntityFactory), false);
				AddNavigatorMetaData<AuditActionEntity, EntityCollection<AuditDataCoreEntity>>("AuditDataCore", a => a._auditDataCore, (a, b) => a._auditDataCore = b, a => a.AuditDataCore, () => new AuditActionRelations().AuditDataCoreEntityUsingAuditActionID, typeof(AuditDataCoreEntity), (int)SD.HnD.DAL.EntityType.AuditDataCoreEntity);
				AddNavigatorMetaData<AuditActionEntity, EntityCollection<RoleAuditActionEntity>>("RoleAuditActions", a => a._roleAuditActions, (a, b) => a._roleAuditActions = b, a => a.RoleAuditActions, () => new AuditActionRelations().RoleAuditActionEntityUsingAuditActionID, typeof(RoleAuditActionEntity), (int)SD.HnD.DAL.EntityType.RoleAuditActionEntity);
				AddNavigatorMetaData<AuditActionEntity, EntityCollection<RoleEntity>>("RolesWithAuditAction", a => a._rolesWithAuditAction, (a, b) => a._rolesWithAuditAction = b, a => a.RolesWithAuditAction, () => new AuditActionRelations().RoleAuditActionEntityUsingAuditActionID, () => new RoleAuditActionRelations().RoleEntityUsingRoleID, "AuditActionEntity__", "RoleAuditAction_", typeof(RoleEntity), (int)SD.HnD.DAL.EntityType.RoleEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static AuditActionEntity()
		{
		}

		/// <summary> CTor</summary>
		public AuditActionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AuditActionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AuditActionEntity</param>
		public AuditActionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="auditActionID">PK value for AuditAction which data should be fetched into this AuditAction object</param>
		public AuditActionEntity(System.Int32 auditActionID) : this(auditActionID, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="auditActionID">PK value for AuditAction which data should be fetched into this AuditAction object</param>
		/// <param name="validator">The custom validator object for this AuditActionEntity</param>
		public AuditActionEntity(System.Int32 auditActionID, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.AuditActionID = auditActionID;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AuditActionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AuditDataCore' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAuditDataCore() { return CreateRelationInfoForNavigator("AuditDataCore"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RoleAuditAction' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRoleAuditActions() { return CreateRelationInfoForNavigator("RoleAuditActions"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Role' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRolesWithAuditAction() { return CreateRelationInfoForNavigator("RolesWithAuditAction"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AuditActionEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static AuditActionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AuditDataCore' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAuditDataCore { get { return _staticMetaData.GetPrefetchPathElement("AuditDataCore", CommonEntityBase.CreateEntityCollection<AuditDataCoreEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RoleAuditAction' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRoleAuditActions { get { return _staticMetaData.GetPrefetchPathElement("RoleAuditActions", CommonEntityBase.CreateEntityCollection<RoleAuditActionEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Role' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRolesWithAuditAction { get { return _staticMetaData.GetPrefetchPathElement("RolesWithAuditAction", CommonEntityBase.CreateEntityCollection<RoleEntity>()); } }

		/// <summary>The AuditActionID property of the Entity AuditAction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditAction"."AuditActionID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AuditActionID
		{
			get { return (System.Int32)GetValue((int)AuditActionFieldIndex.AuditActionID, true); }
			set	{ SetValue((int)AuditActionFieldIndex.AuditActionID, value); }
		}

		/// <summary>The AuditActionDescription property of the Entity AuditAction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditAction"."AuditActionDescription".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AuditActionDescription
		{
			get { return (System.String)GetValue((int)AuditActionFieldIndex.AuditActionDescription, true); }
			set	{ SetValue((int)AuditActionFieldIndex.AuditActionDescription, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'AuditDataCoreEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AuditDataCoreEntity))]
		public virtual EntityCollection<AuditDataCoreEntity> AuditDataCore { get { return GetOrCreateEntityCollection<AuditDataCoreEntity, AuditDataCoreEntityFactory>("AuditAction", true, false, ref _auditDataCore); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RoleAuditActionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RoleAuditActionEntity))]
		public virtual EntityCollection<RoleAuditActionEntity> RoleAuditActions { get { return GetOrCreateEntityCollection<RoleAuditActionEntity, RoleAuditActionEntityFactory>("AuditAction", true, false, ref _roleAuditActions); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RoleEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RoleEntity))]
		public virtual EntityCollection<RoleEntity> RolesWithAuditAction { get { return GetOrCreateEntityCollection<RoleEntity, RoleEntityFactory>("AssignedAuditActions", false, true, ref _rolesWithAuditAction); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace SD.HnD.DAL
{
	public enum AuditActionFieldIndex
	{
		///<summary>AuditActionID. </summary>
		AuditActionID,
		///<summary>AuditActionDescription. </summary>
		AuditActionDescription,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace SD.HnD.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AuditAction. </summary>
	public partial class AuditActionRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between AuditActionEntity and AuditDataCoreEntity over the 1:n relation they have, using the relation between the fields: AuditAction.AuditActionID - AuditDataCore.AuditActionID</summary>
		public virtual IEntityRelation AuditDataCoreEntityUsingAuditActionID
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "AuditDataCore", true, new[] { AuditActionFields.AuditActionID, AuditDataCoreFields.AuditActionID }); }
		}

		/// <summary>Returns a new IEntityRelation object, between AuditActionEntity and RoleAuditActionEntity over the 1:n relation they have, using the relation between the fields: AuditAction.AuditActionID - RoleAuditAction.AuditActionID</summary>
		public virtual IEntityRelation RoleAuditActionEntityUsingAuditActionID
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "RoleAuditActions", true, new[] { AuditActionFields.AuditActionID, RoleAuditActionFields.AuditActionID }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAuditActionRelations
	{
		internal static readonly IEntityRelation AuditDataCoreEntityUsingAuditActionIDStatic = new AuditActionRelations().AuditDataCoreEntityUsingAuditActionID;
		internal static readonly IEntityRelation RoleAuditActionEntityUsingAuditActionIDStatic = new AuditActionRelations().RoleAuditActionEntityUsingAuditActionID;

		/// <summary>CTor</summary>
		static StaticAuditActionRelations() { }
	}
}
