using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_NameTruncate
{
    // NameProperty /Script/RigVM.RigVMFunction_NameTruncate:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // IntProperty /Script/RigVM.RigVMFunction_NameTruncate:Count
    static readonly int Count_Offset;
    public int Count;
    
    // BoolProperty /Script/RigVM.RigVMFunction_NameTruncate:FromEnd
    static readonly int FromEnd_Offset;
    public bool FromEnd;
    
    // NameProperty /Script/RigVM.RigVMFunction_NameTruncate:Remainder
    static readonly int Remainder_Offset;
    public Name Remainder;
    
    // NameProperty /Script/RigVM.RigVMFunction_NameTruncate:Chopped
    static readonly int Chopped_Offset;
    public Name Chopped;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_NameTruncate()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_NameTruncate");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Count_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Count");
        FromEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FromEnd");
        Remainder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Remainder");
        Chopped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Chopped");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_NameTruncate(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Count = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Count_Offset), 0, null);
            FromEnd = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, FromEnd_Offset), 0, null);
            Remainder = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Remainder_Offset), 0, null);
            Chopped = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Chopped_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Count_Offset), 0, null, Count);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, FromEnd_Offset), 0, null, FromEnd);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Remainder_Offset), 0, null, Remainder);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Chopped_Offset), 0, null, Chopped);
        }
    }
}

public static class RigVMFunction_NameTruncateMarshaler
{
    public static RigVMFunction_NameTruncate FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_NameTruncate(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_NameTruncate obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_NameTruncate.NativeDataSize;
    }
}