using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_StringPadInteger
{
    // IntProperty /Script/RigVM.RigVMFunction_StringPadInteger:Value
    static readonly int Value_Offset;
    public int Value;
    
    // IntProperty /Script/RigVM.RigVMFunction_StringPadInteger:Digits
    static readonly int Digits_Offset;
    public int Digits;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_StringPadInteger()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_StringPadInteger");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Digits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Digits");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_StringPadInteger(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Digits = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Digits_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Digits_Offset), 0, null, Digits);
        }
    }
}

public static class RigVMFunction_StringPadIntegerMarshaler
{
    public static RigVMFunction_StringPadInteger FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_StringPadInteger(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_StringPadInteger obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_StringPadInteger.NativeDataSize;
    }
}