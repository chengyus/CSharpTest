using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ItemEquals
{
    // StructProperty /Script/ControlRig.RigUnit_ItemEquals:A
    static readonly int A_Offset;
    public UnrealSharp.ControlRig.RigElementKey A;
    
    // StructProperty /Script/ControlRig.RigUnit_ItemEquals:B
    static readonly int B_Offset;
    public UnrealSharp.ControlRig.RigElementKey B;
    
    // BoolProperty /Script/ControlRig.RigUnit_ItemEquals:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ItemEquals()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ItemEquals");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ItemEquals(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_ItemEqualsMarshaler
{
    public static RigUnit_ItemEquals FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ItemEquals(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ItemEquals obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ItemEquals.NativeDataSize;
    }
}