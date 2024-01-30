using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_NameReplace
{
    // NameProperty /Script/RigVM.RigVMFunction_NameReplace:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // NameProperty /Script/RigVM.RigVMFunction_NameReplace:Old
    static readonly int Old_Offset;
    public Name Old;
    
    // NameProperty /Script/RigVM.RigVMFunction_NameReplace:New
    static readonly int New_Offset;
    public Name New;
    
    // NameProperty /Script/RigVM.RigVMFunction_NameReplace:Result
    static readonly int Result_Offset;
    public Name Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_NameReplace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_NameReplace");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Old_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Old");
        New_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "New");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_NameReplace(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Old = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Old_Offset), 0, null);
            New = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, New_Offset), 0, null);
            Result = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Old_Offset), 0, null, Old);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, New_Offset), 0, null, New);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_NameReplaceMarshaler
{
    public static RigVMFunction_NameReplace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_NameReplace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_NameReplace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_NameReplace.NativeDataSize;
    }
}