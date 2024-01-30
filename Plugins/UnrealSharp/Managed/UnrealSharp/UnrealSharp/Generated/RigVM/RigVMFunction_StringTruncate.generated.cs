using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_StringTruncate
{
    // IntProperty /Script/RigVM.RigVMFunction_StringTruncate:Count
    static readonly int Count_Offset;
    public int Count;
    
    // BoolProperty /Script/RigVM.RigVMFunction_StringTruncate:FromEnd
    static readonly int FromEnd_Offset;
    public bool FromEnd;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_StringTruncate()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_StringTruncate");
        
        Count_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Count");
        FromEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FromEnd");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_StringTruncate(IntPtr InNativeStruct)
    {
        unsafe
        {
            Count = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Count_Offset), 0, null);
            FromEnd = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, FromEnd_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Count_Offset), 0, null, Count);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, FromEnd_Offset), 0, null, FromEnd);
        }
    }
}

public static class RigVMFunction_StringTruncateMarshaler
{
    public static RigVMFunction_StringTruncate FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_StringTruncate(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_StringTruncate obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_StringTruncate.NativeDataSize;
    }
}