using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetControlFloat
{
    // NameProperty /Script/ControlRig.RigUnit_GetControlFloat:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // FloatProperty /Script/ControlRig.RigUnit_GetControlFloat:FloatValue
    static readonly int FloatValue_Offset;
    public float FloatValue;
    
    // FloatProperty /Script/ControlRig.RigUnit_GetControlFloat:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_GetControlFloat:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetControlFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetControlFloat");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        FloatValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FloatValue");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetControlFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            FloatValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FloatValue_Offset), 0, null);
            Minimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FloatValue_Offset), 0, null, FloatValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
        }
    }
}

public static class RigUnit_GetControlFloatMarshaler
{
    public static RigUnit_GetControlFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetControlFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetControlFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetControlFloat.NativeDataSize;
    }
}