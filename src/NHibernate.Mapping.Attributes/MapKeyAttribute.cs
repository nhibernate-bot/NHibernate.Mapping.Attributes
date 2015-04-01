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
	public class MapKeyAttribute : BaseAttribute
	{
		
		private string _formula = null;
		
		private string _node = null;
		
		private string _type = null;
		
		private string _column = null;
		
		private int _length = -1;
		
		/// <summary> Default constructor (position=0) </summary>
		public MapKeyAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public MapKeyAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Column
		{
			get
			{
				return this._column;
			}
			set
			{
				this._column = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Formula
		{
			get
			{
				return this._formula;
			}
			set
			{
				this._formula = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		
		/// <summary> </summary>
		public virtual int Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Node
		{
			get
			{
				return this._node;
			}
			set
			{
				this._node = value;
			}
		}
	}
}
