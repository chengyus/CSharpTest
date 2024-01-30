using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_StringMiddle
{
    // IntProperty /Script/RigVM.RigVMFunction_StringMiddle:Start
    static readonly int Start_Offset;
    public int Start;
    
    // IntProperty /Script/RigVM.RigVMFunction_StringMiddle:Count
    static readonly int Count_Offset;
    public int Count;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_StringMiddle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_StringMiddle");
        
        Start_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Start");
        Count_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Count");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_StringMiddle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Start = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Start_Offset), 0, null);
            Count = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Count_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Start_Offset), 0, null, Start);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Count_Offset), 0, null, Count);
        }
    }
}

public static class RigVMFunction_StringMiddleMarshaler
{
    public static RigVMFunction_StringMiddle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_StringMiddle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_StringMiddle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_StringMiddle.NativeDataSize;
    }
}