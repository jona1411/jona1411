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
	// Mixin content Type 1068 with alias "banner"
	/// <summary>Banner</summary>
	public partial interface IBanner : IPublishedContent
	{
		/// <summary>Animal Banner</summary>
		IPublishedContent BannerImage { get; }
	}

	/// <summary>Banner</summary>
	[PublishedContentModel("banner")]
	public partial class Banner : PublishedContentModel, IBanner
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "banner";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Banner(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Banner, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Animal Banner: Select an image to be shown on the animal cards on the animals list
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return GetBannerImage(this); }
		}

		/// <summary>Static getter for Animal Banner</summary>
		public static IPublishedContent GetBannerImage(IBanner that) { return that.GetPropertyValue<IPublishedContent>("bannerImage"); }
	}
}
