using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetControlFloat
{
    // NameProperty /Script/ControlRig.RigUnit_SetControlFloat:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // FloatProperty /Script/ControlRig.RigUnit_SetControlFloat:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // FloatProperty /Script/ControlRig.RigUnit_SetControlFloat:FloatValue
    static readonly int FloatValue_Offset;
    public float FloatValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetControlFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetControlFloat");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        FloatValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FloatValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetControlFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            FloatValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FloatValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FloatValue_Offset), 0, null, FloatValue);
        }
    }
}

public static class RigUnit_SetControlFloatMarshaler
{
    public static RigUnit_SetControlFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetControlFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetControlFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetControlFloat.NativeDataSize;
    }
}