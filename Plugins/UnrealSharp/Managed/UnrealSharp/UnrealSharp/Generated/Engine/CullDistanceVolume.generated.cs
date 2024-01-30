// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class CullDistanceVolume : UnrealSharp.Engine.Volume
{
    
    static CullDistanceVolume()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CullDistanceVolume");
        
        CullDistances_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CullDistances");
        CullDistances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CullDistances");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        
        
        
    }
    
    protected CullDistanceVolume(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ArrayProperty /Script/Engine.CullDistanceVolume:CullDistances
    static readonly int CullDistances_Offset;
    static readonly IntPtr CullDistances_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.CullDistanceSizePair> CullDistances_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Engine.CullDistanceSizePair> CullDistances
    {
        get
        {
            if(CullDistances_Wrapper == null)
            {
                CullDistances_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.CullDistanceSizePair>(1, CullDistances_NativeProperty, BlittableMarshaller<UnrealSharp.Engine.CullDistanceSizePair>.ToNative, BlittableMarshaller<UnrealSharp.Engine.CullDistanceSizePair>.FromNative);
            }
            
            return CullDistances_Wrapper.FromNative(IntPtr.Add(NativeObject,CullDistances_Offset),0,this);
        }
    }
    
    // BoolProperty /Script/Engine.CullDistanceVolume:bEnabled
    static readonly int bEnabled_Offset;
    static readonly IntPtr bEnabled_NativeProperty;
    
    public bool bEnabled
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEnabled_NativeProperty, bEnabled_Offset);
        }
    }
    
    
}