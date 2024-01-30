using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddAnimationChannelRotator
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelRotator:InitialValue
    static readonly int InitialValue_Offset;
    public UnrealSharp.Rotator InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelRotator:MinimumValue
    static readonly int MinimumValue_Offset;
    public UnrealSharp.Rotator MinimumValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelRotator:MaximumValue
    static readonly int MaximumValue_Offset;
    public UnrealSharp.Rotator MaximumValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddAnimationChannelRotator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddAnimationChannelRotator");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddAnimationChannelRotator(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            MinimumValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
        }
    }
}

public static class RigUnit_HierarchyAddAnimationChannelRotatorMarshaler
{
    public static RigUnit_HierarchyAddAnimationChannelRotator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddAnimationChannelRotator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddAnimationChannelRotator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddAnimationChannelRotator.NativeDataSize;
    }
}