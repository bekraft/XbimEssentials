// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPoint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPoint : IIfcGeometricRepresentationItem, IfcGeometricSetSelect, IfcPointOrVertexPoint
	{
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcPoint", 66)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPoint : IfcGeometricRepresentationItem, IIfcPoint, IEquatable<@IfcPoint>
	{
		#region IIfcPoint explicit implementation
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPoint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}





		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPoint other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
        /// <summary>
        /// This is always overriden in specific non-abstract classes
        /// </summary>
        IfcDimensionCount IfcGeometricSetSelect.Dim { get { return 0; } }
        //##
		#endregion
	}
}