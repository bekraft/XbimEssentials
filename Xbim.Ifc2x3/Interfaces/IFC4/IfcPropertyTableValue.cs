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
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyTableValue : IIfcPropertyTableValue
	{

		[CrossSchemaAttribute(typeof(IIfcPropertyTableValue), 3)]
		IItemSet<IIfcValue> IIfcPropertyTableValue.DefiningValues 
		{ 
			get
			{
			
				return _definingValuesIfc4 ?? (_definingValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    DefiningValues, 
                    new ItemSet<IIfcValue>(this, 0, -3), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc2x3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _definingValuesIfc4;

		[CrossSchemaAttribute(typeof(IIfcPropertyTableValue), 4)]
		IItemSet<IIfcValue> IIfcPropertyTableValue.DefinedValues 
		{ 
			get
			{
			
				return _definedValuesIfc4 ?? (_definedValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    DefinedValues, 
                    new ItemSet<IIfcValue>(this, 0, -4), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc2x3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _definedValuesIfc4;

		[CrossSchemaAttribute(typeof(IIfcPropertyTableValue), 5)]
		Ifc4.MeasureResource.IfcText? IIfcPropertyTableValue.Expression 
		{ 
			get
			{
				if (!Expression.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Expression.Value);
			} 
			set
			{
				Expression = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPropertyTableValue), 6)]
		IIfcUnit IIfcPropertyTableValue.DefiningUnit 
		{ 
			get
			{
				if (DefiningUnit == null) return null;
				var ifcderivedunit = DefiningUnit as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
					return ifcderivedunit;
				var ifcnamedunit = DefiningUnit as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
					return ifcnamedunit;
				var ifcmonetaryunit = DefiningUnit as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
					return ifcmonetaryunit;
				return null;
			} 
			set
			{
				if (value == null)
				{
					DefiningUnit = null;
					return;
				}	
				var ifcderivedunit = value as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
				{
					DefiningUnit = ifcderivedunit;
					return;
				}
				var ifcmonetaryunit = value as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
				{
					DefiningUnit = ifcmonetaryunit;
					return;
				}
				var ifcnamedunit = value as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
				{
					DefiningUnit = ifcnamedunit;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPropertyTableValue), 7)]
		IIfcUnit IIfcPropertyTableValue.DefinedUnit 
		{ 
			get
			{
				if (DefinedUnit == null) return null;
				var ifcderivedunit = DefinedUnit as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
					return ifcderivedunit;
				var ifcnamedunit = DefinedUnit as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
					return ifcnamedunit;
				var ifcmonetaryunit = DefinedUnit as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
					return ifcmonetaryunit;
				return null;
			} 
			set
			{
				if (value == null)
				{
					DefinedUnit = null;
					return;
				}	
				var ifcderivedunit = value as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
				{
					DefinedUnit = ifcderivedunit;
					return;
				}
				var ifcmonetaryunit = value as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
				{
					DefinedUnit = ifcmonetaryunit;
					return;
				}
				var ifcnamedunit = value as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
				{
					DefinedUnit = ifcnamedunit;
					return;
				}
				
			}
		}

		private  Ifc4.Interfaces.IfcCurveInterpolationEnum? _curveInterpolation;


		[CrossSchemaAttribute(typeof(IIfcPropertyTableValue), 8)]
		Ifc4.Interfaces.IfcCurveInterpolationEnum? IIfcPropertyTableValue.CurveInterpolation 
		{ 
			get
			{
				return _curveInterpolation;
			} 
			set
			{
				SetValue(v => _curveInterpolation = v, _curveInterpolation, value, "CurveInterpolation", -8);
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
	//## Custom code
	//##
	}
}