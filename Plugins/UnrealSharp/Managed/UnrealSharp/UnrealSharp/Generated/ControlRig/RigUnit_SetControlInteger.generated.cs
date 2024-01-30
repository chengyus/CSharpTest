using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetControlInteger
{
    // NameProperty /Script/ControlRig.RigUnit_SetControlInteger:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // IntProperty /Script/ControlRig.RigUnit_SetControlInteger:Weight
    static readonly int Weight_Offset;
    public int Weight;
    
    // IntProperty /Script/ControlRig.RigUnit_SetControlInteger:IntegerValue
    static readonly int IntegerValue_Offset;
    public int IntegerValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetControlInteger()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetControlInteger");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        IntegerValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IntegerValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetControlInteger(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Weight = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            IntegerValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, IntegerValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, IntegerValue_Offset), 0, null, IntegerValue);
        }
    }
}

public static class RigUnit_SetControlIntegerMarshaler
{
    public static RigUnit_SetControlInteger FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetControlInteger(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetControlInteger obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetControlInteger.NativeDataSize;
    }
}