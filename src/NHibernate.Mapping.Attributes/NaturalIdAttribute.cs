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
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class NaturalIdAttribute : BaseAttribute
	{
		
		private bool _mutable = false;
		
		private bool _mutablespecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public NaturalIdAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public NaturalIdAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual bool Mutable
		{
			get
			{
				return this._mutable;
			}
			set
			{
				this._mutable = value;
				_mutablespecified = true;
			}
		}
		
		/// <summary> Tells if Mutable has been specified. </summary>
		public virtual bool MutableSpecified
		{
			get
			{
				return this._mutablespecified;
			}
		}
	}
}
