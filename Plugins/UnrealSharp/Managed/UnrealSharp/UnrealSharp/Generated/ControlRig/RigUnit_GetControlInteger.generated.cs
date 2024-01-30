using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetControlInteger
{
    // NameProperty /Script/ControlRig.RigUnit_GetControlInteger:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // IntProperty /Script/ControlRig.RigUnit_GetControlInteger:IntegerValue
    static readonly int IntegerValue_Offset;
    public int IntegerValue;
    
    // IntProperty /Script/ControlRig.RigUnit_GetControlInteger:Minimum
    static readonly int Minimum_Offset;
    public int Minimum;
    
    // IntProperty /Script/ControlRig.RigUnit_GetControlInteger:Maximum
    static readonly int Maximum_Offset;
    public int Maximum;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetControlInteger()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetControlInteger");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        IntegerValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IntegerValue");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetControlInteger(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            IntegerValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, IntegerValue_Offset), 0, null);
            Minimum = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, IntegerValue_Offset), 0, null, IntegerValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
        }
    }
}

public static class RigUnit_GetControlIntegerMarshaler
{
    public static RigUnit_GetControlInteger FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetControlInteger(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetControlInteger obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetControlInteger.NativeDataSize;
    }
}