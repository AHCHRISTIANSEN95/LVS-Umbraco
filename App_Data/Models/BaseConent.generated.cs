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
	// Mixin content Type 1215 with alias "baseConent"
	/// <summary>BaseConent</summary>
	public partial interface IBaseConent : IPublishedContent
	{
		/// <summary>Content sub text</summary>
		string ContentSubText { get; }

		/// <summary>Content text</summary>
		IHtmlString ContentText { get; }

		/// <summary>Page Title</summary>
		string PageTitle { get; }
	}

	/// <summary>BaseConent</summary>
	[PublishedContentModel("baseConent")]
	public partial class BaseConent : PublishedContentModel, IBaseConent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "baseConent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BaseConent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BaseConent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content sub text
		///</summary>
		[ImplementPropertyType("contentSubText")]
		public string ContentSubText
		{
			get { return GetContentSubText(this); }
		}

		/// <summary>Static getter for Content sub text</summary>
		public static string GetContentSubText(IBaseConent that) { return that.GetPropertyValue<string>("contentSubText"); }

		///<summary>
		/// Content text
		///</summary>
		[ImplementPropertyType("contentText")]
		public IHtmlString ContentText
		{
			get { return GetContentText(this); }
		}

		/// <summary>Static getter for Content text</summary>
		public static IHtmlString GetContentText(IBaseConent that) { return that.GetPropertyValue<IHtmlString>("contentText"); }

		///<summary>
		/// Page Title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return GetPageTitle(this); }
		}

		/// <summary>Static getter for Page Title</summary>
		public static string GetPageTitle(IBaseConent that) { return that.GetPropertyValue<string>("pageTitle"); }
	}
}
