// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.StructuralElementsDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcingMeshType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcingMeshType : IIfcReinforcingElementType
	{
		IfcReinforcingMeshTypeEnum @PredefinedType { get;  set; }
		IfcPositiveLengthMeasure? @MeshLength { get;  set; }
		IfcPositiveLengthMeasure? @MeshWidth { get;  set; }
		IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter { get;  set; }
		IfcPositiveLengthMeasure? @TransverseBarNominalDiameter { get;  set; }
		IfcAreaMeasure? @LongitudinalBarCrossSectionArea { get;  set; }
		IfcAreaMeasure? @TransverseBarCrossSectionArea { get;  set; }
		IfcPositiveLengthMeasure? @LongitudinalBarSpacing { get;  set; }
		IfcPositiveLengthMeasure? @TransverseBarSpacing { get;  set; }
		IfcLabel? @BendingShapeCode { get;  set; }
		IItemSet<IIfcBendingParameterSelect> @BendingParameters { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcReinforcingMeshType", 1247)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingMeshType : IfcReinforcingElementType, IInstantiableEntity, IIfcReinforcingMeshType, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcReinforcingMeshType>
	{
		#region IIfcReinforcingMeshType explicit implementation
		IfcReinforcingMeshTypeEnum IIfcReinforcingMeshType.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.MeshLength { 
 
			get { return @MeshLength; } 
			set { MeshLength = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.MeshWidth { 
 
			get { return @MeshWidth; } 
			set { MeshWidth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.LongitudinalBarNominalDiameter { 
 
			get { return @LongitudinalBarNominalDiameter; } 
			set { LongitudinalBarNominalDiameter = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.TransverseBarNominalDiameter { 
 
			get { return @TransverseBarNominalDiameter; } 
			set { TransverseBarNominalDiameter = value;}
		}	
		IfcAreaMeasure? IIfcReinforcingMeshType.LongitudinalBarCrossSectionArea { 
 
			get { return @LongitudinalBarCrossSectionArea; } 
			set { LongitudinalBarCrossSectionArea = value;}
		}	
		IfcAreaMeasure? IIfcReinforcingMeshType.TransverseBarCrossSectionArea { 
 
			get { return @TransverseBarCrossSectionArea; } 
			set { TransverseBarCrossSectionArea = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.LongitudinalBarSpacing { 
 
			get { return @LongitudinalBarSpacing; } 
			set { LongitudinalBarSpacing = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.TransverseBarSpacing { 
 
			get { return @TransverseBarSpacing; } 
			set { TransverseBarSpacing = value;}
		}	
		IfcLabel? IIfcReinforcingMeshType.BendingShapeCode { 
 
			get { return @BendingShapeCode; } 
			set { BendingShapeCode = value;}
		}	
		IItemSet<IIfcBendingParameterSelect> IIfcReinforcingMeshType.BendingParameters { 
			get { return new Common.Collections.ProxyItemSet<IfcBendingParameterSelect, IIfcBendingParameterSelect>( @BendingParameters); } 
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingMeshType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this, 0,  20);
		}

		#region Explicit attribute fields
		private IfcReinforcingMeshTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _meshLength;
		private IfcPositiveLengthMeasure? _meshWidth;
		private IfcPositiveLengthMeasure? _longitudinalBarNominalDiameter;
		private IfcPositiveLengthMeasure? _transverseBarNominalDiameter;
		private IfcAreaMeasure? _longitudinalBarCrossSectionArea;
		private IfcAreaMeasure? _transverseBarCrossSectionArea;
		private IfcPositiveLengthMeasure? _longitudinalBarSpacing;
		private IfcPositiveLengthMeasure? _transverseBarSpacing;
		private IfcLabel? _bendingShapeCode;
		private readonly OptionalItemSet<IfcBendingParameterSelect> _bendingParameters;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 19)]
		public IfcReinforcingMeshTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
		public IfcPositiveLengthMeasure? @MeshLength 
		{ 
			get 
			{
				if(_activated) return _meshLength;
				Activate();
				return _meshLength;
			} 
			set
			{
				SetValue( v =>  _meshLength = v, _meshLength, value,  "MeshLength", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcPositiveLengthMeasure? @MeshWidth 
		{ 
			get 
			{
				if(_activated) return _meshWidth;
				Activate();
				return _meshWidth;
			} 
			set
			{
				SetValue( v =>  _meshWidth = v, _meshWidth, value,  "MeshWidth", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 22)]
		public IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter 
		{ 
			get 
			{
				if(_activated) return _longitudinalBarNominalDiameter;
				Activate();
				return _longitudinalBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarNominalDiameter = v, _longitudinalBarNominalDiameter, value,  "LongitudinalBarNominalDiameter", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 23)]
		public IfcPositiveLengthMeasure? @TransverseBarNominalDiameter 
		{ 
			get 
			{
				if(_activated) return _transverseBarNominalDiameter;
				Activate();
				return _transverseBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _transverseBarNominalDiameter = v, _transverseBarNominalDiameter, value,  "TransverseBarNominalDiameter", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 24)]
		public IfcAreaMeasure? @LongitudinalBarCrossSectionArea 
		{ 
			get 
			{
				if(_activated) return _longitudinalBarCrossSectionArea;
				Activate();
				return _longitudinalBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarCrossSectionArea = v, _longitudinalBarCrossSectionArea, value,  "LongitudinalBarCrossSectionArea", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 25)]
		public IfcAreaMeasure? @TransverseBarCrossSectionArea 
		{ 
			get 
			{
				if(_activated) return _transverseBarCrossSectionArea;
				Activate();
				return _transverseBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _transverseBarCrossSectionArea = v, _transverseBarCrossSectionArea, value,  "TransverseBarCrossSectionArea", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 26)]
		public IfcPositiveLengthMeasure? @LongitudinalBarSpacing 
		{ 
			get 
			{
				if(_activated) return _longitudinalBarSpacing;
				Activate();
				return _longitudinalBarSpacing;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarSpacing = v, _longitudinalBarSpacing, value,  "LongitudinalBarSpacing", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public IfcPositiveLengthMeasure? @TransverseBarSpacing 
		{ 
			get 
			{
				if(_activated) return _transverseBarSpacing;
				Activate();
				return _transverseBarSpacing;
			} 
			set
			{
				SetValue( v =>  _transverseBarSpacing = v, _transverseBarSpacing, value,  "TransverseBarSpacing", 18);
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 28)]
		public IfcLabel? @BendingShapeCode 
		{ 
			get 
			{
				if(_activated) return _bendingShapeCode;
				Activate();
				return _bendingShapeCode;
			} 
			set
			{
				SetValue( v =>  _bendingShapeCode = v, _bendingShapeCode, value,  "BendingShapeCode", 19);
			} 
		}	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 29)]
		public IOptionalItemSet<IfcBendingParameterSelect> @BendingParameters 
		{ 
			get 
			{
				if(_activated) return _bendingParameters;
				Activate();
				return _bendingParameters;
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcReinforcingMeshTypeEnum) System.Enum.Parse(typeof (IfcReinforcingMeshTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_meshLength = value.RealVal;
					return;
				case 11: 
					_meshWidth = value.RealVal;
					return;
				case 12: 
					_longitudinalBarNominalDiameter = value.RealVal;
					return;
				case 13: 
					_transverseBarNominalDiameter = value.RealVal;
					return;
				case 14: 
					_longitudinalBarCrossSectionArea = value.RealVal;
					return;
				case 15: 
					_transverseBarCrossSectionArea = value.RealVal;
					return;
				case 16: 
					_longitudinalBarSpacing = value.RealVal;
					return;
				case 17: 
					_transverseBarSpacing = value.RealVal;
					return;
				case 18: 
					_bendingShapeCode = value.StringVal;
					return;
				case 19: 
					_bendingParameters.InternalAdd((IfcBendingParameterSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingMeshType other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @HasPropertySets)
					yield return entity;
				foreach(var entity in @RepresentationMaps)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
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