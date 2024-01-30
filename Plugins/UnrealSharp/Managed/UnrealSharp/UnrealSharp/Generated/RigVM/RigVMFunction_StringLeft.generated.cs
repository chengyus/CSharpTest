using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_StringLeft
{
    // IntProperty /Script/RigVM.RigVMFunction_StringLeft:Count
    static readonly int Count_Offset;
    public int Count;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_StringLeft()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_StringLeft");
        
        Count_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Count");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_StringLeft(IntPtr InNativeStruct)
    {
        unsafe
        {
            Count = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Count_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Count_Offset), 0, null, Count);
        }
    }
}

public static class RigVMFunction_StringLeftMarshaler
{
    public static RigVMFunction_StringLeft FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_StringLeft(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_StringLeft obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_StringLeft.NativeDataSize;
    }
}