using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddAnimationChannelFloat
{
    // FloatProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelFloat:InitialValue
    static readonly int InitialValue_Offset;
    public float InitialValue;
    
    // FloatProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelFloat:MinimumValue
    static readonly int MinimumValue_Offset;
    public float MinimumValue;
    
    // FloatProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelFloat:MaximumValue
    static readonly int MaximumValue_Offset;
    public float MaximumValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddAnimationChannelFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddAnimationChannelFloat");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddAnimationChannelFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            MinimumValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
        }
    }
}

public static class RigUnit_HierarchyAddAnimationChannelFloatMarshaler
{
    public static RigUnit_HierarchyAddAnimationChannelFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddAnimationChannelFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddAnimationChannelFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddAnimationChannelFloat.NativeDataSize;
    }
}