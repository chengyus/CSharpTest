using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_StringFind
{
    // BoolProperty /Script/RigVM.RigVMFunction_StringFind:Found
    static readonly int Found_Offset;
    public bool Found;
    
    // IntProperty /Script/RigVM.RigVMFunction_StringFind:Index
    static readonly int Index_Offset;
    public int Index;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_StringFind()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_StringFind");
        
        Found_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Found");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_StringFind(IntPtr InNativeStruct)
    {
        unsafe
        {
            Found = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Found_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Found_Offset), 0, null, Found);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
        }
    }
}

public static class RigVMFunction_StringFindMarshaler
{
    public static RigVMFunction_StringFind FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_StringFind(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_StringFind obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_StringFind.NativeDataSize;
    }
}