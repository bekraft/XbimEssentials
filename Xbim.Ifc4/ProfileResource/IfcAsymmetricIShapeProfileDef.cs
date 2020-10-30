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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAsymmetricIShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAsymmetricIShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @BottomFlangeWidth { get;  set; }
		IfcPositiveLengthMeasure @OverallDepth { get;  set; }
		IfcPositiveLengthMeasure @WebThickness { get;  set; }
		IfcPositiveLengthMeasure @BottomFlangeThickness { get;  set; }
		IfcNonNegativeLengthMeasure? @BottomFlangeFilletRadius { get;  set; }
		IfcPositiveLengthMeasure @TopFlangeWidth { get;  set; }
		IfcPositiveLengthMeasure? @TopFlangeThickness { get;  set; }
		IfcNonNegativeLengthMeasure? @TopFlangeFilletRadius { get;  set; }
		IfcNonNegativeLengthMeasure? @BottomFlangeEdgeRadius { get;  set; }
		IfcPlaneAngleMeasure? @BottomFlangeSlope { get;  set; }
		IfcNonNegativeLengthMeasure? @TopFlangeEdgeRadius { get;  set; }
		IfcPlaneAngleMeasure? @TopFlangeSlope { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IfcAsymmetricIShapeProfileDef", 672)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcAsymmetricIShapeProfileDef, IContainsEntityReferences, IEquatable<@IfcAsymmetricIShapeProfileDef>
	{
		#region IIfcAsymmetricIShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.BottomFlangeWidth { 
 
			get { return @BottomFlangeWidth; } 
			set { BottomFlangeWidth = value;}
		}	
		IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.OverallDepth { 
 
			get { return @OverallDepth; } 
			set { OverallDepth = value;}
		}	
		IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.WebThickness { 
 
			get { return @WebThickness; } 
			set { WebThickness = value;}
		}	
		IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.BottomFlangeThickness { 
 
			get { return @BottomFlangeThickness; } 
			set { BottomFlangeThickness = value;}
		}	
		IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.BottomFlangeFilletRadius { 
 
			get { return @BottomFlangeFilletRadius; } 
			set { BottomFlangeFilletRadius = value;}
		}	
		IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.TopFlangeWidth { 
 
			get { return @TopFlangeWidth; } 
			set { TopFlangeWidth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeThickness { 
 
			get { return @TopFlangeThickness; } 
			set { TopFlangeThickness = value;}
		}	
		IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeFilletRadius { 
 
			get { return @TopFlangeFilletRadius; } 
			set { TopFlangeFilletRadius = value;}
		}	
		IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.BottomFlangeEdgeRadius { 
 
			get { return @BottomFlangeEdgeRadius; } 
			set { BottomFlangeEdgeRadius = value;}
		}	
		IfcPlaneAngleMeasure? IIfcAsymmetricIShapeProfileDef.BottomFlangeSlope { 
 
			get { return @BottomFlangeSlope; } 
			set { BottomFlangeSlope = value;}
		}	
		IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeEdgeRadius { 
 
			get { return @TopFlangeEdgeRadius; } 
			set { TopFlangeEdgeRadius = value;}
		}	
		IfcPlaneAngleMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeSlope { 
 
			get { return @TopFlangeSlope; } 
			set { TopFlangeSlope = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsymmetricIShapeProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _bottomFlangeWidth;
		private IfcPositiveLengthMeasure _overallDepth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _bottomFlangeThickness;
		private IfcNonNegativeLengthMeasure? _bottomFlangeFilletRadius;
		private IfcPositiveLengthMeasure _topFlangeWidth;
		private IfcPositiveLengthMeasure? _topFlangeThickness;
		private IfcNonNegativeLengthMeasure? _topFlangeFilletRadius;
		private IfcNonNegativeLengthMeasure? _bottomFlangeEdgeRadius;
		private IfcPlaneAngleMeasure? _bottomFlangeSlope;
		private IfcNonNegativeLengthMeasure? _topFlangeEdgeRadius;
		private IfcPlaneAngleMeasure? _topFlangeSlope;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure @BottomFlangeWidth 
		{ 
			get 
			{
				if(_activated) return _bottomFlangeWidth;
				Activate();
				return _bottomFlangeWidth;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeWidth = v, _bottomFlangeWidth, value,  "BottomFlangeWidth", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPositiveLengthMeasure @OverallDepth 
		{ 
			get 
			{
				if(_activated) return _overallDepth;
				Activate();
				return _overallDepth;
			} 
			set
			{
				SetValue( v =>  _overallDepth = v, _overallDepth, value,  "OverallDepth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(_activated) return _webThickness;
				Activate();
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcPositiveLengthMeasure @BottomFlangeThickness 
		{ 
			get 
			{
				if(_activated) return _bottomFlangeThickness;
				Activate();
				return _bottomFlangeThickness;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeThickness = v, _bottomFlangeThickness, value,  "BottomFlangeThickness", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcNonNegativeLengthMeasure? @BottomFlangeFilletRadius 
		{ 
			get 
			{
				if(_activated) return _bottomFlangeFilletRadius;
				Activate();
				return _bottomFlangeFilletRadius;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeFilletRadius = v, _bottomFlangeFilletRadius, value,  "BottomFlangeFilletRadius", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcPositiveLengthMeasure @TopFlangeWidth 
		{ 
			get 
			{
				if(_activated) return _topFlangeWidth;
				Activate();
				return _topFlangeWidth;
			} 
			set
			{
				SetValue( v =>  _topFlangeWidth = v, _topFlangeWidth, value,  "TopFlangeWidth", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcPositiveLengthMeasure? @TopFlangeThickness 
		{ 
			get 
			{
				if(_activated) return _topFlangeThickness;
				Activate();
				return _topFlangeThickness;
			} 
			set
			{
				SetValue( v =>  _topFlangeThickness = v, _topFlangeThickness, value,  "TopFlangeThickness", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcNonNegativeLengthMeasure? @TopFlangeFilletRadius 
		{ 
			get 
			{
				if(_activated) return _topFlangeFilletRadius;
				Activate();
				return _topFlangeFilletRadius;
			} 
			set
			{
				SetValue( v =>  _topFlangeFilletRadius = v, _topFlangeFilletRadius, value,  "TopFlangeFilletRadius", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcNonNegativeLengthMeasure? @BottomFlangeEdgeRadius 
		{ 
			get 
			{
				if(_activated) return _bottomFlangeEdgeRadius;
				Activate();
				return _bottomFlangeEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeEdgeRadius = v, _bottomFlangeEdgeRadius, value,  "BottomFlangeEdgeRadius", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 15)]
		public IfcPlaneAngleMeasure? @BottomFlangeSlope 
		{ 
			get 
			{
				if(_activated) return _bottomFlangeSlope;
				Activate();
				return _bottomFlangeSlope;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeSlope = v, _bottomFlangeSlope, value,  "BottomFlangeSlope", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 16)]
		public IfcNonNegativeLengthMeasure? @TopFlangeEdgeRadius 
		{ 
			get 
			{
				if(_activated) return _topFlangeEdgeRadius;
				Activate();
				return _topFlangeEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _topFlangeEdgeRadius = v, _topFlangeEdgeRadius, value,  "TopFlangeEdgeRadius", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 17)]
		public IfcPlaneAngleMeasure? @TopFlangeSlope 
		{ 
			get 
			{
				if(_activated) return _topFlangeSlope;
				Activate();
				return _topFlangeSlope;
			} 
			set
			{
				SetValue( v =>  _topFlangeSlope = v, _topFlangeSlope, value,  "TopFlangeSlope", 15);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_bottomFlangeWidth = value.RealVal;
					return;
				case 4: 
					_overallDepth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_bottomFlangeThickness = value.RealVal;
					return;
				case 7: 
					_bottomFlangeFilletRadius = value.RealVal;
					return;
				case 8: 
					_topFlangeWidth = value.RealVal;
					return;
				case 9: 
					_topFlangeThickness = value.RealVal;
					return;
				case 10: 
					_topFlangeFilletRadius = value.RealVal;
					return;
				case 11: 
					_bottomFlangeEdgeRadius = value.RealVal;
					return;
				case 12: 
					_bottomFlangeSlope = value.RealVal;
					return;
				case 13: 
					_topFlangeEdgeRadius = value.RealVal;
					return;
				case 14: 
					_topFlangeSlope = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAsymmetricIShapeProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}