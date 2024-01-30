// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class ScaleBox : UnrealSharp.UMG.ContentWidget
{
    
    static ScaleBox()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ScaleBox");
        
        Stretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Stretch");
        StretchDirection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchDirection");
        UserSpecifiedScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserSpecifiedScale");
        IgnoreInheritedScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IgnoreInheritedScale");
        
        SetUserSpecifiedScale_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetUserSpecifiedScale");
        SetUserSpecifiedScale_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetUserSpecifiedScale_NativeFunction);
        SetUserSpecifiedScale_InUserSpecifiedScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetUserSpecifiedScale_NativeFunction, "InUserSpecifiedScale");
        SetStretchDirection_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetStretchDirection");
        SetStretchDirection_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetStretchDirection_NativeFunction);
        SetStretchDirection_InStretchDirection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStretchDirection_NativeFunction, "InStretchDirection");
        SetStretch_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetStretch");
        SetStretch_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetStretch_NativeFunction);
        SetStretch_InStretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStretch_NativeFunction, "InStretch");
        SetIgnoreInheritedScale_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetIgnoreInheritedScale");
        SetIgnoreInheritedScale_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetIgnoreInheritedScale_NativeFunction);
        SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetIgnoreInheritedScale_NativeFunction, "bInIgnoreInheritedScale");
        
        
    }
    
    protected ScaleBox(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ByteProperty /Script/UMG.ScaleBox:Stretch
    static readonly int Stretch_Offset;
    
    public UnrealSharp.Slate.EStretch Stretch
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Slate.EStretch>.FromNative(IntPtr.Add(NativeObject, Stretch_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Slate.EStretch>.ToNative(IntPtr.Add(NativeObject, Stretch_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/UMG.ScaleBox:StretchDirection
    static readonly int StretchDirection_Offset;
    
    public UnrealSharp.Slate.EStretchDirection StretchDirection
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Slate.EStretchDirection>.FromNative(IntPtr.Add(NativeObject, StretchDirection_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Slate.EStretchDirection>.ToNative(IntPtr.Add(NativeObject, StretchDirection_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.ScaleBox:UserSpecifiedScale
    static readonly int UserSpecifiedScale_Offset;
    
    public float UserSpecifiedScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, UserSpecifiedScale_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, UserSpecifiedScale_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.ScaleBox:IgnoreInheritedScale
    static readonly int IgnoreInheritedScale_Offset;
    
    public bool IgnoreInheritedScale
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, IgnoreInheritedScale_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, IgnoreInheritedScale_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.ScaleBox:SetUserSpecifiedScale
    static readonly IntPtr SetUserSpecifiedScale_NativeFunction;
    static readonly int SetUserSpecifiedScale_ParamsSize;
    static readonly int SetUserSpecifiedScale_InUserSpecifiedScale_Offset;
    
    public void SetUserSpecifiedScale(float inUserSpecifiedScale)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetUserSpecifiedScale_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetUserSpecifiedScale_InUserSpecifiedScale_Offset), 0, null, inUserSpecifiedScale);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetUserSpecifiedScale_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.ScaleBox:SetStretchDirection
    static readonly IntPtr SetStretchDirection_NativeFunction;
    static readonly int SetStretchDirection_ParamsSize;
    static readonly int SetStretchDirection_InStretchDirection_Offset;
    
    public void SetStretchDirection(UnrealSharp.Slate.EStretchDirection inStretchDirection)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetStretchDirection_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Slate.EStretchDirection>.ToNative(IntPtr.Add(ParamsBuffer, SetStretchDirection_InStretchDirection_Offset), 0, null, inStretchDirection);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetStretchDirection_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.ScaleBox:SetStretch
    static readonly IntPtr SetStretch_NativeFunction;
    static readonly int SetStretch_ParamsSize;
    static readonly int SetStretch_InStretch_Offset;
    
    public void SetStretch(UnrealSharp.Slate.EStretch inStretch)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetStretch_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Slate.EStretch>.ToNative(IntPtr.Add(ParamsBuffer, SetStretch_InStretch_Offset), 0, null, inStretch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetStretch_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.ScaleBox:SetIgnoreInheritedScale
    static readonly IntPtr SetIgnoreInheritedScale_NativeFunction;
    static readonly int SetIgnoreInheritedScale_ParamsSize;
    static readonly int SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset;
    
    public void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetIgnoreInheritedScale_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset), 0, null, bInIgnoreInheritedScale);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetIgnoreInheritedScale_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}