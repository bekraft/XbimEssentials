// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFace
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFace : IIfcTopologicalRepresentationItem
	{
		IItemSet<IIfcFaceBound> @Bounds { get; }
		IEnumerable<IIfcTextureMap> @HasTextureMaps {  get; }
	
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IfcFace", 83)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFace : IfcTopologicalRepresentationItem, IInstantiableEntity, IIfcFace, IContainsEntityReferences, IEquatable<@IfcFace>
	{
		#region IIfcFace explicit implementation
		IItemSet<IIfcFaceBound> IIfcFace.Bounds { 
			get { return new Common.Collections.ProxyItemSet<IfcFaceBound, IIfcFaceBound>( @Bounds); } 
		}	
		IEnumerable<IIfcTextureMap> IIfcFace.HasTextureMaps {  get { return @HasTextureMaps; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFace(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_bounds = new ItemSet<IfcFaceBound>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcFaceBound> _bounds;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcFaceBound> @Bounds 
		{ 
			get 
			{
				if(_activated) return _bounds;
				Activate();
				return _bounds;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MappedTo")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 4)]
		public IEnumerable<IfcTextureMap> @HasTextureMaps 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureMap>(e => Equals(e.MappedTo), "MappedTo", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_bounds.InternalAdd((IfcFaceBound)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFace other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Bounds)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}