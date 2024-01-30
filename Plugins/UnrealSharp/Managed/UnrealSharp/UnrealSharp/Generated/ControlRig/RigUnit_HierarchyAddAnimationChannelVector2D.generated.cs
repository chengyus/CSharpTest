using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddAnimationChannelVector2D
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector2D:InitialValue
    static readonly int InitialValue_Offset;
    public System.DoubleNumerics.Vector2 InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector2D:MinimumValue
    static readonly int MinimumValue_Offset;
    public System.DoubleNumerics.Vector2 MinimumValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector2D:MaximumValue
    static readonly int MaximumValue_Offset;
    public System.DoubleNumerics.Vector2 MaximumValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddAnimationChannelVector2D()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddAnimationChannelVector2D");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddAnimationChannelVector2D(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            MinimumValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
        }
    }
}

public static class RigUnit_HierarchyAddAnimationChannelVector2DMarshaler
{
    public static RigUnit_HierarchyAddAnimationChannelVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddAnimationChannelVector2D(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddAnimationChannelVector2D obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddAnimationChannelVector2D.NativeDataSize;
    }
}