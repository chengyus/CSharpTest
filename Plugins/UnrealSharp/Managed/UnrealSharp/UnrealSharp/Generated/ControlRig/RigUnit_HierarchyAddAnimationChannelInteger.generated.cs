using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddAnimationChannelInteger
{
    // IntProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelInteger:InitialValue
    static readonly int InitialValue_Offset;
    public int InitialValue;
    
    // IntProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelInteger:MinimumValue
    static readonly int MinimumValue_Offset;
    public int MinimumValue;
    
    // IntProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelInteger:MaximumValue
    static readonly int MaximumValue_Offset;
    public int MaximumValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddAnimationChannelInteger()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddAnimationChannelInteger");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddAnimationChannelInteger(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            MinimumValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
        }
    }
}

public static class RigUnit_HierarchyAddAnimationChannelIntegerMarshaler
{
    public static RigUnit_HierarchyAddAnimationChannelInteger FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddAnimationChannelInteger(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddAnimationChannelInteger obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddAnimationChannelInteger.NativeDataSize;
    }
}