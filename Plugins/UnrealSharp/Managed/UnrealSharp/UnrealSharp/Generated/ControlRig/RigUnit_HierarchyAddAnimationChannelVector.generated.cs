using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddAnimationChannelVector
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector:InitialValue
    static readonly int InitialValue_Offset;
    public System.DoubleNumerics.Vector3 InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector:MinimumValue
    static readonly int MinimumValue_Offset;
    public System.DoubleNumerics.Vector3 MinimumValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector:MaximumValue
    static readonly int MaximumValue_Offset;
    public System.DoubleNumerics.Vector3 MaximumValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddAnimationChannelVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddAnimationChannelVector");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddAnimationChannelVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            MinimumValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
        }
    }
}

public static class RigUnit_HierarchyAddAnimationChannelVectorMarshaler
{
    public static RigUnit_HierarchyAddAnimationChannelVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddAnimationChannelVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddAnimationChannelVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddAnimationChannelVector.NativeDataSize;
    }
}