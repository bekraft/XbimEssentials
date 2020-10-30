// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRepresentationContext
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRepresentationContext : IPersistEntity
	{
		IfcLabel? @ContextIdentifier { get;  set; }
		IfcLabel? @ContextType { get;  set; }
		IEnumerable<IIfcRepresentation> @RepresentationsInContext {  get; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IfcRepresentationContext", 378)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRepresentationContext : PersistEntity, IIfcRepresentationContext, IEquatable<@IfcRepresentationContext>
	{
		#region IIfcRepresentationContext explicit implementation
		IfcLabel? IIfcRepresentationContext.ContextIdentifier { 
 
			get { return @ContextIdentifier; } 
			set { ContextIdentifier = value;}
		}	
		IfcLabel? IIfcRepresentationContext.ContextType { 
 
			get { return @ContextType; } 
			set { ContextType = value;}
		}	
		IEnumerable<IIfcRepresentation> IIfcRepresentationContext.RepresentationsInContext {  get { return @RepresentationsInContext; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRepresentationContext(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _contextIdentifier;
		private IfcLabel? _contextType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @ContextIdentifier 
		{ 
			get 
			{
				if(_activated) return _contextIdentifier;
				Activate();
				return _contextIdentifier;
			} 
			set
			{
				SetValue( v =>  _contextIdentifier = v, _contextIdentifier, value,  "ContextIdentifier", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel? @ContextType 
		{ 
			get 
			{
				if(_activated) return _contextType;
				Activate();
				return _contextType;
			} 
			set
			{
				SetValue( v =>  _contextType = v, _contextType, value,  "ContextType", 2);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ContextOfItems")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 3)]
		public IEnumerable<IfcRepresentation> @RepresentationsInContext 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRepresentation>(e => Equals(e.ContextOfItems), "ContextOfItems", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_contextIdentifier = value.StringVal;
					return;
				case 1: 
					_contextType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRepresentationContext other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}