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
	public class SqlInsertAttribute : BaseAttribute
	{
		
		private bool _callablespecified;
		
		private string _content = null;
		
		private bool _callable = false;
		
		private CustomSqlCheck _check = CustomSqlCheck.Unspecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public SqlInsertAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public SqlInsertAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual bool Callable
		{
			get
			{
				return this._callable;
			}
			set
			{
				this._callable = value;
				_callablespecified = true;
			}
		}
		
		/// <summary> Tells if Callable has been specified. </summary>
		public virtual bool CallableSpecified
		{
			get
			{
				return this._callablespecified;
			}
		}
		
		/// <summary> </summary>
		public virtual CustomSqlCheck Check
		{
			get
			{
				return this._check;
			}
			set
			{
				this._check = value;
			}
		}
		
		/// <summary> Gets or sets the content of this element </summary>
		public virtual string Content
		{
			get
			{
				return this._content;
			}
			set
			{
				this._content = value;
			}
		}
	}
}
