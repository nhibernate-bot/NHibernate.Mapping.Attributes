// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.x
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	public enum CacheMode
	{
		
		/// <summary>Default value (don't use it)</summary>
		Unspecified,
		
		/// <summary>get</summary>
		[System.Xml.Serialization.XmlEnumAttribute("get")]
		Get,
		
		/// <summary>ignore</summary>
		[System.Xml.Serialization.XmlEnumAttribute("ignore")]
		Ignore,
		
		/// <summary>normal</summary>
		[System.Xml.Serialization.XmlEnumAttribute("normal")]
		Normal,
		
		/// <summary>put</summary>
		[System.Xml.Serialization.XmlEnumAttribute("put")]
		Put,
		
		/// <summary>refresh</summary>
		[System.Xml.Serialization.XmlEnumAttribute("refresh")]
		Refresh,
	}
}
