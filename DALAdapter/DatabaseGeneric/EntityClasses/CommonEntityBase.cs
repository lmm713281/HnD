﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.HnD.DAL.HelperClasses;
using SD.HnD.DAL.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Runtime.Serialization;

namespace SD.HnD.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Common base class which is the base class for all generated entities which aren't a subtype of another entity.</summary>
	[Serializable]
	public abstract partial class CommonEntityBase : EntityBase2
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		/// <summary>CTor</summary>
		protected CommonEntityBase() {}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CommonEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates the entity collection and stores it in destination if destination is null</summary>
		/// <typeparam name="T">type of the element to store in the collection</typeparam>
		/// <typeparam name="TFactory">The type of the factory to pass to the entitycollection ctor.</typeparam>
		/// <param name="navigatorName">Name of the property this collection is for.</param>
		/// <param name="setContainingEntityInfo">if set to <see langword="true"/> the collection is for an 1:n relationship, and the containing entity info has to be set</param>
		/// <param name="forMN">if set to <see langword="true"/> the collection is for an m:n relationship, otherwise for an 1:n relationship</param>
		/// <param name="destination">The destination member variable.</param>
		/// <returns>the collection referred to by destination if destination isn't null, otherwise the newly created collection (which is then stored in destination</returns>
		protected EntityCollection<T> GetOrCreateEntityCollection<T, TFactory>(string navigatorName, bool setContainingEntityInfo, bool forMN, ref EntityCollection<T> destination)
			where T:EntityBase2, IEntity2
		{
			if(destination==null)
			{
				destination = new EntityCollection<T>(EntityFactoryCache2.GetEntityFactory(typeof(TFactory)));
				if(forMN)
				{
					((IEntityCollectionCore)destination).IsForMN = true;
				}
				else
				{
					if(setContainingEntityInfo)
					{
						destination.SetContainingEntityInfo(this, navigatorName);
					}
				}
				destination.ActiveContext = this.ActiveContext;
			}
			return destination;
		}
		
		/// <inheritdoc/>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider() { return ModelInfoProviderSingleton.GetInstance(); }
		
		/// <inheritdoc/>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider() {	return new TypeDefaultValue(); }
				
		/// <inheritdoc/>
		protected override IEntityCollection2 CreateEntityCollectionForType<T>() { return CommonEntityBase.CreateEntityCollection<T>();	}
		
		/// <summary>Creates the entity collection for the types specified</summary>
		/// <typeparam name="T">type of the element to store in the collection</typeparam>
		protected static EntityCollection<T> CreateEntityCollection<T>()
			where T:EntityBase2, IEntity2
		{
			return new EntityCollection<T>(EntityFactoryFactory.GetFactory(typeof(T)));
		}
		
		/// <inheritdoc/>
		protected override Type LLBLGenProEntityTypeEnumType
		{
			get { return typeof(SD.HnD.DAL.EntityType); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}
