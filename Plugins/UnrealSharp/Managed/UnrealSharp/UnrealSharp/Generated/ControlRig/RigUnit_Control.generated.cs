using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Control
{
    // StructProperty /Script/ControlRig.RigUnit_Control:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.AnimationCore.EulerTransform Transform;
    
    // StructProperty /Script/ControlRig.RigUnit_Control:Base
    static readonly int Base_Offset;
    public UnrealSharp.Transform Base;
    
    // StructProperty /Script/ControlRig.RigUnit_Control:InitTransform
    static readonly int InitTransform_Offset;
    public UnrealSharp.Transform InitTransform;
    
    // StructProperty /Script/ControlRig.RigUnit_Control:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    // StructProperty /Script/ControlRig.RigUnit_Control:Filter
    static readonly int Filter_Offset;
    public UnrealSharp.AnimationCore.TransformFilter Filter;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_Control()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Control");
        
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Base_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Base");
        InitTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitTransform");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        Filter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Filter");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Control(IntPtr InNativeStruct)
    {
        unsafe
        {
            Transform = BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Base = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Base_Offset), 0, null);
            InitTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InitTransform_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            Filter = UnrealSharp.AnimationCore.TransformFilterMarshaler.FromNative(IntPtr.Add(InNativeStruct, Filter_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Base_Offset), 0, null, Base);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InitTransform_Offset), 0, null, InitTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            UnrealSharp.AnimationCore.TransformFilterMarshaler.ToNative(IntPtr.Add(Buffer, Filter_Offset), 0, null, Filter);
        }
    }
}

public static class RigUnit_ControlMarshaler
{
    public static RigUnit_Control FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Control(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Control obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Control.NativeDataSize;
    }
}