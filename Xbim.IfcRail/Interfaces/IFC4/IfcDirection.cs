// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.IfcRail.GeometryResource
{
	public partial class @IfcDirection : IIfcDirection
	{

		[CrossSchemaAttribute(typeof(IIfcDirection), 1)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcReal> IIfcDirection.DirectionRatios 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcReal, Ifc4.MeasureResource.IfcReal>(DirectionRatios, 
					s => new Ifc4.MeasureResource.IfcReal(s), 
					t => new MeasureResource.IfcReal(t));
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcDirection.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}