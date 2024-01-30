// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialBillboardComponent : UnrealSharp.Engine.PrimitiveComponent
{
    
    static MaterialBillboardComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialBillboardComponent");
        
        Elements_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Elements");
        Elements_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Elements");
        
        SetElements_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetElements");
        SetElements_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetElements_NativeFunction);
        SetElements_NewElements_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetElements_NativeFunction, "NewElements");
        SetElements_NewElements_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetElements_NativeFunction, "NewElements");
        AddElement_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddElement");
        AddElement_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddElement_NativeFunction);
        AddElement_Material_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddElement_NativeFunction, "Material");
        AddElement_DistanceToOpacityCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddElement_NativeFunction, "DistanceToOpacityCurve");
        AddElement_bSizeIsInScreenSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddElement_NativeFunction, "bSizeIsInScreenSpace");
        AddElement_BaseSizeX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddElement_NativeFunction, "BaseSizeX");
        AddElement_BaseSizeY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddElement_NativeFunction, "BaseSizeY");
        AddElement_DistanceToSizeCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddElement_NativeFunction, "DistanceToSizeCurve");
        
        
    }
    
    protected MaterialBillboardComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ArrayProperty /Script/Engine.MaterialBillboardComponent:Elements
    static readonly int Elements_Offset;
    static readonly IntPtr Elements_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.MaterialSpriteElement> Elements_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Engine.MaterialSpriteElement> Elements
    {
        get
        {
            if(Elements_Wrapper == null)
            {
                Elements_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.MaterialSpriteElement>(1, Elements_NativeProperty, UnrealSharp.Engine.MaterialSpriteElementMarshaler.ToNative, UnrealSharp.Engine.MaterialSpriteElementMarshaler.FromNative);
            }
            
            return Elements_Wrapper.FromNative(IntPtr.Add(NativeObject,Elements_Offset),0,this);
        }
    }
    
    // Function /Script/Engine.MaterialBillboardComponent:SetElements
    static readonly IntPtr SetElements_NativeFunction;
    static readonly int SetElements_ParamsSize;
    static readonly int SetElements_NewElements_Offset;
    static readonly int SetElements_NewElements_ElementSize;
    
    public void SetElements(System.Collections.Generic.IList<UnrealSharp.Engine.MaterialSpriteElement> newElements)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetElements_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NewElements_NativeBuffer = IntPtr.Add(ParamsBuffer, SetElements_NewElements_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialSpriteElement> NewElements_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialSpriteElement>(1, UnrealSharp.Engine.MaterialSpriteElementMarshaler.ToNative, UnrealSharp.Engine.MaterialSpriteElementMarshaler.FromNative, SetElements_NewElements_ElementSize);
            NewElements_Marshaler.ToNative(NewElements_NativeBuffer, 0, null, newElements);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetElements_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.MaterialBillboardComponent:AddElement
    static readonly IntPtr AddElement_NativeFunction;
    static readonly int AddElement_ParamsSize;
    static readonly int AddElement_Material_Offset;
    static readonly int AddElement_DistanceToOpacityCurve_Offset;
    static readonly int AddElement_bSizeIsInScreenSpace_Offset;
    static readonly int AddElement_BaseSizeX_Offset;
    static readonly int AddElement_BaseSizeY_Offset;
    static readonly int AddElement_DistanceToSizeCurve_Offset;
    
    public void AddElement(UnrealSharp.Engine.MaterialInterface material, UnrealSharp.Engine.CurveFloat distanceToOpacityCurve, bool bSizeIsInScreenSpace, float baseSizeX, float baseSizeY, UnrealSharp.Engine.CurveFloat distanceToSizeCurve)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddElement_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(ParamsBuffer, AddElement_Material_Offset), 0, null, material);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(ParamsBuffer, AddElement_DistanceToOpacityCurve_Offset), 0, null, distanceToOpacityCurve);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddElement_bSizeIsInScreenSpace_Offset), 0, null, bSizeIsInScreenSpace);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddElement_BaseSizeX_Offset), 0, null, baseSizeX);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddElement_BaseSizeY_Offset), 0, null, baseSizeY);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(ParamsBuffer, AddElement_DistanceToSizeCurve_Offset), 0, null, distanceToSizeCurve);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddElement_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}