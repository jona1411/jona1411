//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>AnimalCollection</summary>
	[PublishedContentModel("animalCollection")]
	public partial class AnimalCollection : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "animalCollection";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AnimalCollection(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AnimalCollection, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// CategoryIds
		///</summary>
		[ImplementPropertyType("categoryIds")]
		public IEnumerable<IPublishedContent> CategoryIds
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("categoryIds"); }
		}

		///<summary>
		/// CollectionName
		///</summary>
		[ImplementPropertyType("collectionName")]
		public string CollectionName
		{
			get { return this.GetPropertyValue<string>("collectionName"); }
		}
	}
}
