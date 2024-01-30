using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_StringLength
{
    // IntProperty /Script/RigVM.RigVMFunction_StringLength:Length
    static readonly int Length_Offset;
    public int Length;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_StringLength()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_StringLength");
        
        Length_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Length");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_StringLength(IntPtr InNativeStruct)
    {
        unsafe
        {
            Length = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Length_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Length_Offset), 0, null, Length);
        }
    }
}

public static class RigVMFunction_StringLengthMarshaler
{
    public static RigVMFunction_StringLength FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_StringLength(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_StringLength obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_StringLength.NativeDataSize;
    }
}